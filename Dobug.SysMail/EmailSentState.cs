using System.Windows.Forms;
using System.IO;
using System.Data;
using System;
using System.Xml.Linq;

namespace Dobug.SysMail
{
    /// <summary>
    /// 管理邮箱发送状态的XML操作类
    /// </summary>
    public class EmailSentState
    {
        #region 属性

        /// <summary>
        /// 发件人
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public string Addressee { get; set; }

        /// <summary>
        /// 投送状态-T代成功，F代表失败
        /// </summary>
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 用户信息的文件路径
        /// </summary>
        private string XMLPath = Application.StartupPath + @"\SentState.xml";
        #endregion

        #region 方法
        public void writeToXML()
        {
            if (File.Exists(XMLPath))
            {
                AddNode();
            }
            else
            {
                CreateXML();
            }
        }

        /// <summary>
        /// 导入新的数据
        /// </summary>
        private void AddNode()
        {
            XElement XEle = XElement.Load(XMLPath);
            XElement xe = (XElement)XEle.LastNode;
            int count = int.Parse(xe.Attribute("TableKey").Value) + 1;
            XEle.Add(
                new XElement("State", 
                    new XAttribute("TableKey",count),
                    new XAttribute("Sender",Sender),
                    new XAttribute("Addressee",Addressee),
                    new XAttribute("SentTime",DateTime.Now.ToString()),
                    new XAttribute("DeliveryStatus",DeliveryStatus)
                )
            );
            XEle.Save(XMLPath);
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="tableKey"></param>
        public void DelALLXML()
        {
            if (File.Exists(XMLPath))
            {
                File.Delete(XMLPath);
            }
        }

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public DataTable getSentState()
        {
            using (DataSet ds = new DataSet())
            {
                try
                {
                    ds.ReadXml(XMLPath);
                    return ds.Tables[0];
                }
                catch
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 创建新的XML文件
        /// </summary>
        private void CreateXML()
        {
            XElement XEle = new XElement("States",
                new XElement("State", 
                    new XAttribute("TableKey","1"),
                    new XAttribute("Sender",Sender),
                    new XAttribute("Addressee",Addressee),
                    new XAttribute("SentTime",DateTime.Now.ToString()),
                    new XAttribute("DeliveryStatus",DeliveryStatus)
                )
            );
            XEle.Save(XMLPath);
        }
        #endregion
    }
}