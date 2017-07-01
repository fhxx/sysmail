using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Dobug.SysMail
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 属性
        /// <summary>
        /// 发件用户的信息
        /// </summary>
        public DataTable dt { get; set; }

        /// <summary>
        /// 用户管理选项卡中当前选中的TableKey
        /// </summary>
        public string tableKey { get; set; }

        /// <summary>
        /// 用户管理选项卡中当前选中的用户名
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 用户管理选项卡中当前选中的用户密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 附件列表
        /// </summary>
        public string[] mailAttachments{get;set;}

        /// <summary>
        /// 当前发送方的邮箱账号
        /// </summary>
        public string ServerUserName { get; set; }

        /// <summary>
        /// 当前发送方的邮箱密码
        /// </summary>
        public string ServerPassWord { get; set; }

        /// <summary>
        /// 当前收件人的邮箱
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// 当前接收邮件列表的行下标
        /// </summary>
        public int rowIndex_Addressee = 0;

        /// <summary>
        /// 当前发送邮件列表的行下标
        /// </summary>
        public int rowIndex_Sender = 0;

        /// <summary>
        /// 当前发送邮件列表的循环次数
        /// </summary>
        public int sendCount = 1;

        /// <summary>
        /// 发送邮件的总进度
        /// 根据发件人X5与收件人对比，存放小的。
        /// </summary>
        public int totalPrograssCount = 0;

        #endregion

        #region 邮件发送选项卡
        /// <summary>
        /// 添加附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "选择附件";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    this.lb_fj.Items.Add(fileName);
                }
            }
        }

        /// <summary>
        /// 导入收件人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sjr_Click(object sender, EventArgs e)
        {
            this.lb_sjr.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择邮件接收人";
            openFileDialog.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string email = string.Empty;
                    while ((email = reader.ReadLine()) != null)
                    {
                        if (email != "")
                            this.lb_sjr.Items.Add(email);
                    }
                }
            }
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Send_Click(object sender, EventArgs e)
        {

            if (dt != null)
            {
                GetUserInfo();
                if (dt != null)
                {
                    //获取发件人列表的第一个发件用户信息
                    ServerUserName = dt.Rows[rowIndex_Sender]["UserName"].ToString();
                    ServerPassWord = dt.Rows[rowIndex_Sender]["PassWord"].ToString();
                }
                else
                {
                    MessageBox.Show("请先导入发件人的邮箱信息", "系统提示");
                }
            }

            this.btn_Send.Enabled = false;
            this.btn_ResetEmail.Enabled = false;

            if (dt == null)
            {
                MessageBox.Show("没有找到邮件发送方的账号信息，请核实", "系统提示");
                return;
            }
            if (this.lb_sjr.Items.Count == 0)
            {
                MessageBox.Show("请导入邮件接收方的账号", "系统提示");
                return;
            }
            if (this.txt_Subject.Text.Trim() == "")
            {
                MessageBox.Show("请填写邮件主题", "系统提示");
                return;
            }
            if (this.htmlEditor1.Text.Trim() == "")
            {
                MessageBox.Show("请填写邮件内容", "系统提示");
                return;
            }

            //获取附件信息
            mailAttachments = new string[this.lb_fj.Items.Count];
            for (int i = 0; i < this.lb_fj.Items.Count; i++)
			{
                mailAttachments[i] = this.lb_fj.Items[i].ToString();
			}

            if (dt.Rows.Count * 5 > this.lb_sjr.Items.Count)
            {
                this.totalPrograssCount = this.lb_sjr.Items.Count;
            }
            else
            {
                this.totalPrograssCount = dt.Rows.Count * 5;
            }

            this.timer1.Interval = int.Parse(this.comboBox1.SelectedItem.ToString()) * 60 * 1000;
            this.timer1.Enabled = true;
        }

        /// <summary>
        /// 加载当前发件用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetUserInfo();
            this.comboBox1.SelectedIndex = 0;
            if (dt != null)
            {
                //获取发件人列表的第一个发件用户信息
                ServerUserName = dt.Rows[rowIndex_Sender]["UserName"].ToString();
                ServerPassWord = dt.Rows[rowIndex_Sender]["PassWord"].ToString();
            }
            else
            {
                MessageBox.Show("请先导入发件人的邮箱信息", "系统提示");
            }
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             * 先判断是否该继续发送邮件
             * 1.当发送方的邮箱都循环了5次就停止邮件发送,此时不管接收方还有多少邮件未完成发送
             * 2.当接收方的邮件都发送过一次后停止邮件发送，不管发送邮件列表的邮箱是否完成5次循环
             */

            if (sendCount > 5 || rowIndex_Addressee > this.lb_sjr.Items.Count - 1)
            //if (rowIndex_Addressee > this.lb_sjr.Items.Count - 1)
            {
                this.timer1.Enabled = false;
                this.btn_Send.Enabled = true;
                this.btn_ResetEmail.Enabled = true;
                MessageBox.Show("邮件发送完成", "系统提示");
                return;
            }

            //获取当前邮件接收方的邮箱号码
            Recipient = this.lb_sjr.Items[rowIndex_Addressee++].ToString();

            if (rowIndex_Sender == this.dt.Rows.Count - 1)
            {
                rowIndex_Sender = 0;
                sendCount++;
            }
            else
            {
                rowIndex_Sender++;
            }

            //提示状态
            this.statusNotify.Invoke(new Action(delegate
            {
                this.tssl_dqfsr.Text = "当前发送人:" + ServerUserName;
                this.tssl_dqjsr.Text = "当前接收人:" + Recipient;
                this.tsbp_NowPrograss.Maximum = totalPrograssCount;
                this.tsbp_NowPrograss.PerformStep();
            }));

            ISmtpMail em = new sysMailMessage();
            //getSMTPInfo(em, ServerUserName);
            em.Recipient = Recipient;
            em.MailDomainPort = 25;
            em.From = ServerUserName;
            em.FromName = this.txt_fsf.Text.Trim();
            em.mailAttachments = mailAttachments;
            em.IsHtml = true;
            em.Subject = this.txt_Subject.Text.Trim();
            em.Body = this.htmlEditor1.Text;
            em.MailDomain = "smtp.qq.com";
            em.MailServerUserName = ServerUserName;
            em.MailServerPassWord = ServerPassWord;

            //发件状态统计
            XML.XMLHistory history = new XML.XMLHistory();
            if (em.Send())
            {
                history.DeliveryStatus = "成功";
            }
            else
            {
                history.DeliveryStatus = "失败";
            }
            history.Sender = ServerUserName;
            history.Addressee = Recipient;
            history.AddNewNode();

            //接收邮件用户信息统计
            XML.XMLAddressee addressee = new XML.XMLAddressee();
            addressee.Addressee = Recipient;
            addressee.AddNewNode();

            //获取新的发送方的用户名
            ServerUserName = dt.Rows[rowIndex_Sender]["UserName"].ToString();
            ServerPassWord = dt.Rows[rowIndex_Sender]["PassWord"].ToString();
        }

        /// <summary>
        /// 更加当前发送的邮箱获取相应的SMTP
        /// </summary>
        /// <param name="em"></param>
        private void getSMTPInfo(ISmtpMail em,string sender) {
            string s = sender.Substring(sender.IndexOf('@') - 1);
        }

        /// <summary>
        /// 取消发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.btn_Send.Enabled = true;
            this.btn_ResetEmail.Enabled = true;
        }

        /// <summary>
        /// 重置当前邮件的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ResetEmail_Click(object sender, EventArgs e)
        {
            this.lb_fj.Items.Clear();
            this.lb_sjr.Items.Clear();
            this.txt_Subject.Text = "";
            this.txt_fsf.Text = "";
        }
        #endregion

        #region 发件用户管理选项卡
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveUserInfo_Click(object sender, EventArgs e)
        {
            XML.XMLSender xml = new XML.XMLSender() { 
                TableKey=tableKey,
                userName=this.txt_UserInfo.Text.Trim(),
                password=this.txt_Password.Text.Trim()
            };
            if (xml.UpdateNode())
            {
                MessageBox.Show("编辑成功", "系统提示");
                GetUserInfo();
            }
            else
                MessageBox.Show("编辑失败", "系统提示");
        }

        /// <summary>
        /// 导入用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ImportUserInfo_Click(object sender, EventArgs e)
        {
            //发件用户的邮箱
            string userName = string.Empty;
            //发件用户的邮箱秘密
            string password = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择导入用户新文件";
            openFileDialog.Filter = "文本文件(*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string userInfo = string.Empty;
                    while ((userInfo = reader.ReadLine()) != null)
                    {
                        if (userInfo != "")
                        {
                            userName += userInfo.Split('-')[0].ToString() + ",";
                            password += userInfo.Split('-')[1].ToString() + ",";
                        }
                    }
                }
            }

            XML.XMLSender xml = new XML.XMLSender();
            xml.nodeUserName = userName.Substring(0, userName.Length - 1).Split(',');
            xml.nodePassword = password.Substring(0, password.Length - 1).Split(',');
            xml.AddNewNode();
            MessageBox.Show("导入新的用户名成功", "系统提示");
            GetUserInfo();
        }

        /// <summary>
        /// 删除发件人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定重置发件人信息，重置后将无法恢复", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XML.XMLSender xml = new XML.XMLSender();
                xml.DelXMLFile();
                this.txt_UserInfo.Text = "";
                this.txt_Password.Text = "";
                GetUserInfo();
            }
        }

        /// <summary>
        /// 用户信息
        /// </summary>
        public void GetUserInfo()
        {
            XML.XMLSender xml = new XML.XMLSender();
            this.dgv_UserInfo.DataSource = dt = xml.GetXMLData();
        }

        /// <summary>
        /// 选中发件用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_UserInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tableKey = this.dgv_UserInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txt_UserInfo.Text = userName = this.dgv_UserInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txt_Password.Text = password = this.dgv_UserInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_UserInfoDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除后无法恢复，您确定要删除该用户?", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XML.XMLSender xml = new XML.XMLSender();
                xml.TableKey = tableKey;
                if (xml.DelNode())
                {
                    MessageBox.Show("删除成功", "系统提示");
                    GetUserInfo();
                }
                else
                    MessageBox.Show("删除失败", "系统提示");
            }
        }
        #endregion

        #region 发送状态选项卡
        /// <summary>
        /// 清楚发送状态历史记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClearHistory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除发件记录，重置后将无法恢复", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XML.XMLHistory xml = new XML.XMLHistory();
                xml.DelXMLFile();
                getSentState();
            }
        }

        /// <summary>
        /// 只有选中发件历史的选项卡才加载历史记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取发件记录
            if (this.tabControl1.SelectedIndex == 3)
            {
                getSentState();
            }

            //获取发件用户信息
            if (this.tabControl1.SelectedIndex == 2)
            {
                getAddresseeInfo();
            }
        }

        /// <summary>
        /// 获取发件状态
        /// </summary>
        private void getSentState()
        {
            XML.XMLHistory xml = new XML.XMLHistory();
            this.dgv_SentState.DataSource = xml.GetXMLData();
        }

        /// <summary>
        /// 刷新纪录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getSentState();
        }
        #endregion

        #region 收件用户信息选项卡
        /// <summary>
        /// 获取收件用户统计信息
        /// </summary>
        public void getAddresseeInfo() {
            XML.XMLAddressee xml = new XML.XMLAddressee();
            this.dgv_AddresseeInfo.DataSource = xml.GetXMLData();
        }

        /// <summary>
        /// 刷新收件用户统计信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddresseeRefresh_Click(object sender, EventArgs e)
        {
            getSentState();
        }

        /// <summary>
        /// 删除收件用户统计信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddresseeDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除收件用户统计信息，重置后将无法恢复", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XML.XMLAddressee xml = new XML.XMLAddressee();
                xml.DelXMLFile();
                getAddresseeInfo();
            }
        }
        #endregion

        #region 邮箱筛选
        /// <summary>
        /// 清楚筛选结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EmailFilterClear_Click(object sender, EventArgs e)
        {
            this.rtb_EmailFilterTrue.Clear();
            this.rtb_EmailFilterFlase.Clear();
        }

        /// <summary>
        /// 导入筛选数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EmailFilterImport_Click(object sender, EventArgs e)
        {
            int EmailFilterTrue =0, EmailFilterFlase = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择需要筛选的邮箱数据";
            openFileDialog.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string email = string.Empty;
                    while ((email = reader.ReadLine()) != null)
                    {
                        if (email != "")
                        {
                            if (Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                            {
                                if (!this.rtb_EmailFilterTrue.Text.Contains(email))
                                {
                                    this.rtb_EmailFilterTrue.AppendText(email + "\n");
                                    EmailFilterTrue++;
                                }
                            }
                            else
                            {
                                if (!this.rtb_EmailFilterFlase.Text.Contains(email))
                                {
                                    this.rtb_EmailFilterFlase.AppendText(email + "\n");
                                    EmailFilterFlase++;
                                }
                            }
                        }
                    }
                }
            }
            this.gb_EmailFilterTrue.Text = "正确邮箱地址" + EmailFilterTrue;
            this.gb_EmailFilterFlase.Text = "错误邮箱地址" + EmailFilterFlase;

            this.rtb_EmailFilterTrue.SaveFile(Application.StartupPath + @"\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "True.txt", RichTextBoxStreamType.PlainText);
            this.rtb_EmailFilterFlase.SaveFile(Application.StartupPath + @"\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "Flase.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("筛选后的邮箱信息已保存到程序的根目录", "系统提示");
        }
        #endregion
    }
}