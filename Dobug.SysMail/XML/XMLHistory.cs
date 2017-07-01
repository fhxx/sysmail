using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Dobug.SysMail.XML
{
    /// <summary>
    /// 邮件发送历史记录
    /// </summary>
    public class XMLHistory:XML
    {
        #region 属性
        /// <summary>
        /// 节点需要
        /// </summary>
        public string TableKey { get; set; }

        /// <summary>
        /// XML文件路径
        /// </summary>
        public string XMLFilePath { get; set; }

        /// <summary>
        /// 发件人
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public string Addressee { get; set; }

        /// <summary>
        /// 投送状态
        /// </summary>
        public string DeliveryStatus { get; set; }
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public XMLHistory()
        {
            XMLFilePath = Application.StartupPath + @"\History.xml";
        }

        #region 方法
        /// <summary>
        /// 增加新的节点，在以后的基础上增加
        /// </summary>
        /// <returns></returns>
        public override bool AddNewNode()
        {
            if (File.Exists(XMLFilePath))
            {
                XElement XEle = XElement.Load(XMLFilePath);
                XElement xe = (XElement)XEle.LastNode;
                XEle.Add(
                    new XElement("State",
                        new XAttribute("TableKey", int.Parse(xe.Attribute("TableKey").Value) + 1),
                        new XAttribute("Sender", Sender),
                        new XAttribute("Addressee", Addressee),
                        new XAttribute("SentTime", DateTime.Now.ToString()),
                        new XAttribute("DeliveryStatus", DeliveryStatus)
                    )
                );
                XEle.Save(XMLFilePath);
            }
            else
            {
                CreateXMLFile();
            }
            return true; 
        }

        /// <summary>
        /// 更新指定节点值
        /// </summary>
        public override bool UpdateNode() { return true; }

        /// <summary>
        /// 删除指定节点
        /// </summary>
        public override bool DelNode() { return true; }

        /// <summary>
        /// 删除整个XML文件
        /// </summary>
        public override void DelXMLFile()
        {
            if (File.Exists(XMLFilePath))
            {
                File.Delete(XMLFilePath);
            }
        }

        /// <summary>
        /// 获取XML数据到DataTable，如果不存在则返回null
        /// </summary>
        /// <returns></returns>
        public override DataTable GetXMLData()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(XMLFilePath);
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 当XML文件不存在时创建新的XML文件
        /// </summary>
        public override void CreateXMLFile()
        {
            XElement XEle = new XElement("States",
                    new XElement("State",
                        new XAttribute("TableKey", "1"),
                        new XAttribute("Sender", Sender),
                        new XAttribute("Addressee", Addressee),
                        new XAttribute("SentTime", DateTime.Now.ToString()),
                        new XAttribute("DeliveryStatus", DeliveryStatus)
                    )
                );
            XEle.Save(XMLFilePath);
        }
        #endregion
    }
}