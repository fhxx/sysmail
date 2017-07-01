namespace Dobug.SysMail
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Email = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_ResetEmail = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.statusNotify = new System.Windows.Forms.StatusStrip();
            this.tssl_dqjsr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_dqfsr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbp_NowPrograss = new System.Windows.Forms.ToolStripProgressBar();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_sjr = new System.Windows.Forms.Button();
            this.lb_sjr = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_fj = new System.Windows.Forms.Button();
            this.txt_fsf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_Body = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lb_fj = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tp_UserInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_UserInfo = new System.Windows.Forms.DataGridView();
            this.TableKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_UserInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_UserInfoDel = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cz = new System.Windows.Forms.Button();
            this.btn_ImportUserInfo = new System.Windows.Forms.Button();
            this.btn_SaveUserInfo = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_Rec = new System.Windows.Forms.TabPage();
            this.dgv_AddresseeInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_AddresseeRefresh = new System.Windows.Forms.Button();
            this.btn_AddresseeDel = new System.Windows.Forms.Button();
            this.tp_SendState = new System.Windows.Forms.TabPage();
            this.dgv_SentState = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_ClearHistory = new System.Windows.Forms.Button();
            this.tp_EmailFilter = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_EmailFilterImport = new System.Windows.Forms.Button();
            this.btn_EmailFilterClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_EmailFilterTrue = new System.Windows.Forms.GroupBox();
            this.gb_EmailFilterFlase = new System.Windows.Forms.GroupBox();
            this.rtb_EmailFilterTrue = new System.Windows.Forms.RichTextBox();
            this.rtb_EmailFilterFlase = new System.Windows.Forms.RichTextBox();
            this.htmlEditor1 = new Dobug.SysMail.HtmlEditor();
            this.tabControl1.SuspendLayout();
            this.tp_Email.SuspendLayout();
            this.statusNotify.SuspendLayout();
            this.tp_UserInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserInfo)).BeginInit();
            this.cms_UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tp_Rec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddresseeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tp_SendState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SentState)).BeginInit();
            this.panel4.SuspendLayout();
            this.tp_EmailFilter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gb_EmailFilterTrue.SuspendLayout();
            this.gb_EmailFilterFlase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Email);
            this.tabControl1.Controls.Add(this.tp_UserInfo);
            this.tabControl1.Controls.Add(this.tp_Rec);
            this.tabControl1.Controls.Add(this.tp_SendState);
            this.tabControl1.Controls.Add(this.tp_EmailFilter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 498);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tp_Email
            // 
            this.tp_Email.Controls.Add(this.comboBox1);
            this.tp_Email.Controls.Add(this.htmlEditor1);
            this.tp_Email.Controls.Add(this.btn_ResetEmail);
            this.tp_Email.Controls.Add(this.label8);
            this.tp_Email.Controls.Add(this.statusNotify);
            this.tp_Email.Controls.Add(this.btn_Cancel);
            this.tp_Email.Controls.Add(this.btn_sjr);
            this.tp_Email.Controls.Add(this.lb_sjr);
            this.tp_Email.Controls.Add(this.label7);
            this.tp_Email.Controls.Add(this.btn_Send);
            this.tp_Email.Controls.Add(this.btn_fj);
            this.tp_Email.Controls.Add(this.txt_fsf);
            this.tp_Email.Controls.Add(this.label6);
            this.tp_Email.Controls.Add(this.rtb_Body);
            this.tp_Email.Controls.Add(this.label5);
            this.tp_Email.Controls.Add(this.txt_Subject);
            this.tp_Email.Controls.Add(this.lb_fj);
            this.tp_Email.Controls.Add(this.label4);
            this.tp_Email.Controls.Add(this.label3);
            this.tp_Email.Location = new System.Drawing.Point(4, 22);
            this.tp_Email.Name = "tp_Email";
            this.tp_Email.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Email.Size = new System.Drawing.Size(677, 472);
            this.tp_Email.TabIndex = 0;
            this.tp_Email.Text = "邮件发送";
            this.tp_Email.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 76;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(64, 420);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 20);
            this.comboBox1.TabIndex = 151;
            // 
            // btn_ResetEmail
            // 
            this.btn_ResetEmail.Location = new System.Drawing.Point(403, 418);
            this.btn_ResetEmail.Name = "btn_ResetEmail";
            this.btn_ResetEmail.Size = new System.Drawing.Size(75, 23);
            this.btn_ResetEmail.TabIndex = 18;
            this.btn_ResetEmail.Text = "重   置";
            this.btn_ResetEmail.UseVisualStyleBackColor = true;
            this.btn_ResetEmail.Click += new System.EventHandler(this.btn_ResetEmail_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "间隔：";
            // 
            // statusNotify
            // 
            this.statusNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_dqjsr,
            this.tssl_dqfsr,
            this.toolStripStatusLabel1,
            this.tsbp_NowPrograss});
            this.statusNotify.Location = new System.Drawing.Point(3, 447);
            this.statusNotify.Name = "statusNotify";
            this.statusNotify.Size = new System.Drawing.Size(671, 22);
            this.statusNotify.TabIndex = 14;
            this.statusNotify.Text = "statusStrip1";
            // 
            // tssl_dqjsr
            // 
            this.tssl_dqjsr.Name = "tssl_dqjsr";
            this.tssl_dqjsr.Size = new System.Drawing.Size(71, 17);
            this.tssl_dqjsr.Text = "当前接收人:";
            // 
            // tssl_dqfsr
            // 
            this.tssl_dqfsr.Name = "tssl_dqfsr";
            this.tssl_dqfsr.Size = new System.Drawing.Size(71, 17);
            this.tssl_dqfsr.Text = "当前发送人:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "发送进度:";
            // 
            // tsbp_NowPrograss
            // 
            this.tsbp_NowPrograss.Name = "tsbp_NowPrograss";
            this.tsbp_NowPrograss.Size = new System.Drawing.Size(100, 16);
            this.tsbp_NowPrograss.Step = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(496, 418);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "取   消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_sjr
            // 
            this.btn_sjr.Location = new System.Drawing.Point(603, 11);
            this.btn_sjr.Name = "btn_sjr";
            this.btn_sjr.Size = new System.Drawing.Size(61, 52);
            this.btn_sjr.TabIndex = 12;
            this.btn_sjr.Text = "收件人";
            this.btn_sjr.UseVisualStyleBackColor = true;
            this.btn_sjr.Click += new System.EventHandler(this.btn_sjr_Click);
            // 
            // lb_sjr
            // 
            this.lb_sjr.FormattingEnabled = true;
            this.lb_sjr.ItemHeight = 12;
            this.lb_sjr.Location = new System.Drawing.Point(64, 11);
            this.lb_sjr.Name = "lb_sjr";
            this.lb_sjr.Size = new System.Drawing.Size(532, 52);
            this.lb_sjr.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "收件人：";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(589, 418);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 18;
            this.btn_Send.Text = "发   送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_fj
            // 
            this.btn_fj.Location = new System.Drawing.Point(603, 124);
            this.btn_fj.Name = "btn_fj";
            this.btn_fj.Size = new System.Drawing.Size(61, 52);
            this.btn_fj.TabIndex = 19;
            this.btn_fj.Text = "附 件";
            this.btn_fj.UseVisualStyleBackColor = true;
            this.btn_fj.Click += new System.EventHandler(this.btn_fj_Click);
            // 
            // txt_fsf
            // 
            this.txt_fsf.Location = new System.Drawing.Point(64, 96);
            this.txt_fsf.Name = "txt_fsf";
            this.txt_fsf.Size = new System.Drawing.Size(600, 21);
            this.txt_fsf.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 130;
            this.label6.Text = "昵称：";
            // 
            // rtb_Body
            // 
            this.rtb_Body.Location = new System.Drawing.Point(64, 184);
            this.rtb_Body.Name = "rtb_Body";
            this.rtb_Body.Size = new System.Drawing.Size(600, 227);
            this.rtb_Body.TabIndex = 5;
            this.rtb_Body.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 150;
            this.label5.Text = "内容：";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(64, 69);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(600, 21);
            this.txt_Subject.TabIndex = 1;
            // 
            // lb_fj
            // 
            this.lb_fj.FormattingEnabled = true;
            this.lb_fj.ItemHeight = 12;
            this.lb_fj.Location = new System.Drawing.Point(64, 124);
            this.lb_fj.Name = "lb_fj";
            this.lb_fj.Size = new System.Drawing.Size(532, 52);
            this.lb_fj.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 140;
            this.label4.Text = "附件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 120;
            this.label3.Text = "主题：";
            // 
            // tp_UserInfo
            // 
            this.tp_UserInfo.Controls.Add(this.panel2);
            this.tp_UserInfo.Controls.Add(this.panel1);
            this.tp_UserInfo.Location = new System.Drawing.Point(4, 22);
            this.tp_UserInfo.Name = "tp_UserInfo";
            this.tp_UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_UserInfo.Size = new System.Drawing.Size(677, 472);
            this.tp_UserInfo.TabIndex = 1;
            this.tp_UserInfo.Text = "发件用户管理";
            this.tp_UserInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_UserInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 417);
            this.panel2.TabIndex = 1;
            // 
            // dgv_UserInfo
            // 
            this.dgv_UserInfo.AllowUserToAddRows = false;
            this.dgv_UserInfo.AllowUserToDeleteRows = false;
            this.dgv_UserInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableKey,
            this.UserName,
            this.PassWord});
            this.dgv_UserInfo.ContextMenuStrip = this.cms_UserInfo;
            this.dgv_UserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UserInfo.Location = new System.Drawing.Point(0, 0);
            this.dgv_UserInfo.Name = "dgv_UserInfo";
            this.dgv_UserInfo.ReadOnly = true;
            this.dgv_UserInfo.RowTemplate.Height = 23;
            this.dgv_UserInfo.Size = new System.Drawing.Size(671, 417);
            this.dgv_UserInfo.TabIndex = 0;
            this.dgv_UserInfo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserInfo_RowEnter);
            // 
            // TableKey
            // 
            this.TableKey.DataPropertyName = "TableKey";
            this.TableKey.HeaderText = "序号";
            this.TableKey.Name = "TableKey";
            this.TableKey.ReadOnly = true;
            this.TableKey.Width = 60;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "密码";
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            this.PassWord.Width = 150;
            // 
            // cms_UserInfo
            // 
            this.cms_UserInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_UserInfoDel});
            this.cms_UserInfo.Name = "cms_UserInfo";
            this.cms_UserInfo.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmi_UserInfoDel
            // 
            this.tsmi_UserInfoDel.Name = "tsmi_UserInfoDel";
            this.tsmi_UserInfoDel.Size = new System.Drawing.Size(124, 22);
            this.tsmi_UserInfoDel.Text = "删除用户";
            this.tsmi_UserInfoDel.Click += new System.EventHandler(this.tsmi_UserInfoDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cz);
            this.panel1.Controls.Add(this.btn_ImportUserInfo);
            this.panel1.Controls.Add(this.btn_SaveUserInfo);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_UserInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 49);
            this.panel1.TabIndex = 0;
            // 
            // btn_cz
            // 
            this.btn_cz.Location = new System.Drawing.Point(433, 13);
            this.btn_cz.Name = "btn_cz";
            this.btn_cz.Size = new System.Drawing.Size(75, 23);
            this.btn_cz.TabIndex = 6;
            this.btn_cz.Text = "重   置";
            this.btn_cz.UseVisualStyleBackColor = true;
            this.btn_cz.Click += new System.EventHandler(this.btn_cz_Click);
            // 
            // btn_ImportUserInfo
            // 
            this.btn_ImportUserInfo.Location = new System.Drawing.Point(591, 13);
            this.btn_ImportUserInfo.Name = "btn_ImportUserInfo";
            this.btn_ImportUserInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportUserInfo.TabIndex = 5;
            this.btn_ImportUserInfo.Text = "导   入";
            this.btn_ImportUserInfo.UseVisualStyleBackColor = true;
            this.btn_ImportUserInfo.Click += new System.EventHandler(this.btn_ImportUserInfo_Click);
            // 
            // btn_SaveUserInfo
            // 
            this.btn_SaveUserInfo.Location = new System.Drawing.Point(514, 13);
            this.btn_SaveUserInfo.Name = "btn_SaveUserInfo";
            this.btn_SaveUserInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveUserInfo.TabIndex = 4;
            this.btn_SaveUserInfo.Text = "保   存";
            this.btn_SaveUserInfo.UseVisualStyleBackColor = true;
            this.btn_SaveUserInfo.Click += new System.EventHandler(this.btn_SaveUserInfo_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(300, 15);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(127, 21);
            this.txt_Password.TabIndex = 3;
            // 
            // txt_UserInfo
            // 
            this.txt_UserInfo.Location = new System.Drawing.Point(63, 15);
            this.txt_UserInfo.Name = "txt_UserInfo";
            this.txt_UserInfo.Size = new System.Drawing.Size(190, 21);
            this.txt_UserInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密 码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // tp_Rec
            // 
            this.tp_Rec.Controls.Add(this.dgv_AddresseeInfo);
            this.tp_Rec.Controls.Add(this.dataGridView1);
            this.tp_Rec.Controls.Add(this.panel3);
            this.tp_Rec.Location = new System.Drawing.Point(4, 22);
            this.tp_Rec.Name = "tp_Rec";
            this.tp_Rec.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Rec.Size = new System.Drawing.Size(677, 472);
            this.tp_Rec.TabIndex = 2;
            this.tp_Rec.Text = "收件用户信息";
            this.tp_Rec.UseVisualStyleBackColor = true;
            // 
            // dgv_AddresseeInfo
            // 
            this.dgv_AddresseeInfo.AllowUserToAddRows = false;
            this.dgv_AddresseeInfo.AllowUserToDeleteRows = false;
            this.dgv_AddresseeInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_AddresseeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AddresseeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_AddresseeInfo.ContextMenuStrip = this.cms_UserInfo;
            this.dgv_AddresseeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AddresseeInfo.Location = new System.Drawing.Point(3, 3);
            this.dgv_AddresseeInfo.Name = "dgv_AddresseeInfo";
            this.dgv_AddresseeInfo.ReadOnly = true;
            this.dgv_AddresseeInfo.RowTemplate.Height = 23;
            this.dgv_AddresseeInfo.Size = new System.Drawing.Size(671, 417);
            this.dgv_AddresseeInfo.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TableKey";
            this.dataGridViewTextBoxColumn1.HeaderText = "TableKey";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Addressee";
            this.dataGridViewTextBoxColumn2.HeaderText = "接邮箱";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReceiveCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "接收次数";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(671, 417);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_AddresseeRefresh);
            this.panel3.Controls.Add(this.btn_AddresseeDel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 49);
            this.panel3.TabIndex = 0;
            // 
            // btn_AddresseeRefresh
            // 
            this.btn_AddresseeRefresh.Location = new System.Drawing.Point(514, 13);
            this.btn_AddresseeRefresh.Name = "btn_AddresseeRefresh";
            this.btn_AddresseeRefresh.Size = new System.Drawing.Size(75, 23);
            this.btn_AddresseeRefresh.TabIndex = 3;
            this.btn_AddresseeRefresh.Text = "刷新记录";
            this.btn_AddresseeRefresh.UseVisualStyleBackColor = true;
            this.btn_AddresseeRefresh.Click += new System.EventHandler(this.btn_AddresseeRefresh_Click);
            // 
            // btn_AddresseeDel
            // 
            this.btn_AddresseeDel.Location = new System.Drawing.Point(591, 13);
            this.btn_AddresseeDel.Name = "btn_AddresseeDel";
            this.btn_AddresseeDel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddresseeDel.TabIndex = 2;
            this.btn_AddresseeDel.Text = "清除记录";
            this.btn_AddresseeDel.UseVisualStyleBackColor = true;
            this.btn_AddresseeDel.Click += new System.EventHandler(this.btn_AddresseeDel_Click);
            // 
            // tp_SendState
            // 
            this.tp_SendState.Controls.Add(this.dgv_SentState);
            this.tp_SendState.Controls.Add(this.panel4);
            this.tp_SendState.Location = new System.Drawing.Point(4, 22);
            this.tp_SendState.Name = "tp_SendState";
            this.tp_SendState.Padding = new System.Windows.Forms.Padding(3);
            this.tp_SendState.Size = new System.Drawing.Size(677, 472);
            this.tp_SendState.TabIndex = 3;
            this.tp_SendState.Text = "发件记录";
            this.tp_SendState.UseVisualStyleBackColor = true;
            // 
            // dgv_SentState
            // 
            this.dgv_SentState.AllowUserToAddRows = false;
            this.dgv_SentState.AllowUserToDeleteRows = false;
            this.dgv_SentState.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_SentState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SentState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgv_SentState.ContextMenuStrip = this.cms_UserInfo;
            this.dgv_SentState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SentState.Location = new System.Drawing.Point(3, 3);
            this.dgv_SentState.Name = "dgv_SentState";
            this.dgv_SentState.ReadOnly = true;
            this.dgv_SentState.RowTemplate.Height = 23;
            this.dgv_SentState.Size = new System.Drawing.Size(671, 417);
            this.dgv_SentState.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TableKey";
            this.dataGridViewTextBoxColumn4.HeaderText = "序号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sender";
            this.dataGridViewTextBoxColumn5.HeaderText = "发件人";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Addressee";
            this.dataGridViewTextBoxColumn6.HeaderText = "收件人";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SentTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "发件时间";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DeliveryStatus";
            this.dataGridViewTextBoxColumn8.HeaderText = "投送状态";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Refresh);
            this.panel4.Controls.Add(this.btn_ClearHistory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 420);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 49);
            this.panel4.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(514, 13);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "刷新记录";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_ClearHistory
            // 
            this.btn_ClearHistory.Location = new System.Drawing.Point(591, 13);
            this.btn_ClearHistory.Name = "btn_ClearHistory";
            this.btn_ClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearHistory.TabIndex = 0;
            this.btn_ClearHistory.Text = "清除记录";
            this.btn_ClearHistory.UseVisualStyleBackColor = true;
            this.btn_ClearHistory.Click += new System.EventHandler(this.btn_ClearHistory_Click);
            // 
            // tp_EmailFilter
            // 
            this.tp_EmailFilter.Controls.Add(this.gb_EmailFilterFlase);
            this.tp_EmailFilter.Controls.Add(this.gb_EmailFilterTrue);
            this.tp_EmailFilter.Controls.Add(this.panel5);
            this.tp_EmailFilter.Location = new System.Drawing.Point(4, 22);
            this.tp_EmailFilter.Name = "tp_EmailFilter";
            this.tp_EmailFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tp_EmailFilter.Size = new System.Drawing.Size(677, 472);
            this.tp_EmailFilter.TabIndex = 4;
            this.tp_EmailFilter.Text = "邮箱筛选";
            this.tp_EmailFilter.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_EmailFilterImport);
            this.panel5.Controls.Add(this.btn_EmailFilterClear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(671, 49);
            this.panel5.TabIndex = 1;
            // 
            // btn_EmailFilterImport
            // 
            this.btn_EmailFilterImport.Location = new System.Drawing.Point(591, 13);
            this.btn_EmailFilterImport.Name = "btn_EmailFilterImport";
            this.btn_EmailFilterImport.Size = new System.Drawing.Size(75, 23);
            this.btn_EmailFilterImport.TabIndex = 6;
            this.btn_EmailFilterImport.Text = "导   入";
            this.btn_EmailFilterImport.UseVisualStyleBackColor = true;
            this.btn_EmailFilterImport.Click += new System.EventHandler(this.btn_EmailFilterImport_Click);
            // 
            // btn_EmailFilterClear
            // 
            this.btn_EmailFilterClear.Location = new System.Drawing.Point(514, 13);
            this.btn_EmailFilterClear.Name = "btn_EmailFilterClear";
            this.btn_EmailFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btn_EmailFilterClear.TabIndex = 0;
            this.btn_EmailFilterClear.Text = "清除记录";
            this.btn_EmailFilterClear.UseVisualStyleBackColor = true;
            this.btn_EmailFilterClear.Click += new System.EventHandler(this.btn_EmailFilterClear_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gb_EmailFilterTrue
            // 
            this.gb_EmailFilterTrue.Controls.Add(this.rtb_EmailFilterTrue);
            this.gb_EmailFilterTrue.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_EmailFilterTrue.Location = new System.Drawing.Point(3, 3);
            this.gb_EmailFilterTrue.Name = "gb_EmailFilterTrue";
            this.gb_EmailFilterTrue.Size = new System.Drawing.Size(334, 417);
            this.gb_EmailFilterTrue.TabIndex = 2;
            this.gb_EmailFilterTrue.TabStop = false;
            this.gb_EmailFilterTrue.Text = "正确邮箱地址";
            // 
            // gb_EmailFilterFlase
            // 
            this.gb_EmailFilterFlase.Controls.Add(this.rtb_EmailFilterFlase);
            this.gb_EmailFilterFlase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_EmailFilterFlase.Location = new System.Drawing.Point(337, 3);
            this.gb_EmailFilterFlase.Name = "gb_EmailFilterFlase";
            this.gb_EmailFilterFlase.Size = new System.Drawing.Size(337, 417);
            this.gb_EmailFilterFlase.TabIndex = 3;
            this.gb_EmailFilterFlase.TabStop = false;
            this.gb_EmailFilterFlase.Text = "错误邮箱地址";
            // 
            // rtb_EmailFilterTrue
            // 
            this.rtb_EmailFilterTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_EmailFilterTrue.Location = new System.Drawing.Point(3, 17);
            this.rtb_EmailFilterTrue.Name = "rtb_EmailFilterTrue";
            this.rtb_EmailFilterTrue.Size = new System.Drawing.Size(328, 397);
            this.rtb_EmailFilterTrue.TabIndex = 0;
            this.rtb_EmailFilterTrue.Text = "";
            // 
            // rtb_EmailFilterFlase
            // 
            this.rtb_EmailFilterFlase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_EmailFilterFlase.Location = new System.Drawing.Point(3, 17);
            this.rtb_EmailFilterFlase.Name = "rtb_EmailFilterFlase";
            this.rtb_EmailFilterFlase.Size = new System.Drawing.Size(331, 397);
            this.rtb_EmailFilterFlase.TabIndex = 0;
            this.rtb_EmailFilterFlase.Text = "";
            // 
            // htmlEditor1
            // 
            this.htmlEditor1.Location = new System.Drawing.Point(64, 184);
            this.htmlEditor1.Name = "htmlEditor1";
            this.htmlEditor1.Size = new System.Drawing.Size(600, 227);
            this.htmlEditor1.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 498);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 536);
            this.MinimumSize = new System.Drawing.Size(701, 536);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_Email.ResumeLayout(false);
            this.tp_Email.PerformLayout();
            this.statusNotify.ResumeLayout(false);
            this.statusNotify.PerformLayout();
            this.tp_UserInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserInfo)).EndInit();
            this.cms_UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tp_Rec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddresseeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tp_SendState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SentState)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tp_EmailFilter.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gb_EmailFilterTrue.ResumeLayout(false);
            this.gb_EmailFilterFlase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Email;
        private System.Windows.Forms.ListBox lb_fj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tp_UserInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_UserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ImportUserInfo;
        private System.Windows.Forms.Button btn_SaveUserInfo;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Body;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cms_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_UserInfoDel;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_fj;
        private System.Windows.Forms.TextBox txt_fsf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_sjr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.ListBox lb_sjr;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.StatusStrip statusNotify;
        private System.Windows.Forms.ToolStripStatusLabel tssl_dqjsr;
        private System.Windows.Forms.ToolStripStatusLabel tssl_dqfsr;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tsbp_NowPrograss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ResetEmail;
        private System.Windows.Forms.Button btn_cz;
        private System.Windows.Forms.TabPage tp_Rec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private HtmlEditor htmlEditor1;
        private System.Windows.Forms.DataGridView dgv_AddresseeInfo;
        private System.Windows.Forms.TabPage tp_SendState;
        private System.Windows.Forms.DataGridView dgv_SentState;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ClearHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tp_EmailFilter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_EmailFilterClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_AddresseeRefresh;
        private System.Windows.Forms.Button btn_AddresseeDel;
        private System.Windows.Forms.Button btn_EmailFilterImport;
        private System.Windows.Forms.GroupBox gb_EmailFilterFlase;
        private System.Windows.Forms.RichTextBox rtb_EmailFilterFlase;
        private System.Windows.Forms.GroupBox gb_EmailFilterTrue;
        private System.Windows.Forms.RichTextBox rtb_EmailFilterTrue;
    }
}