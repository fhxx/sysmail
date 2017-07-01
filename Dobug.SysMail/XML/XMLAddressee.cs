using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace Dobug.SysMail.XML
{
    /// <summary>
    /// 邮件接收者信息
    /// </summary>
    public class XMLAddressee:XML
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
        /// 收件人
        /// </summary>
        public string Addressee { get; set; }
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public XMLAddressee()
        {
            XMLFilePath = Application.StartupPath + @"\AddresseeInfo.xml";
        }

        #region 方法
        /// <summary>
        /// 增加新的节点，在以后的基础上增加
        /// </summary>
        /// <returns></returns>
        public override bool AddNewNode() {
            if (File.Exists(XMLFilePath))
            {
                XElement XEle = XElement.Load(XMLFilePath);
                IEnumerable<XElement> IXEle = from e in XEle.Elements("AddresseeInfo")
                                              where e.Attribute("Addressee").Value == Addressee
                                              select e;
                if (IXEle.Count() > 0) {
                    XElement xe = IXEle.First();
                    xe.SetAttributeValue("ReceiveCount", int.Parse(xe.Attribute("ReceiveCount").Value) + 1);
                    XEle.Save(XMLFilePath);
                }
                else {
                    XElement xe = (XElement)XEle.LastNode;
                    XEle.Add(
                        new XElement("AddresseeInfo",
                            new XAttribute("TableKey", int.Parse(xe.Attribute("TableKey").Value) + 1),
                            new XAttribute("Addressee", Addressee),
                            new XAttribute("ReceiveCount", "1")
                        )
                    );
                    XEle.Save(XMLFilePath);
                }
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
        /// <returns></returns>
        public override bool UpdateNode()
        {
            return true;
        }

        /// <summary>
        /// 删除指定节点
        /// </summary>
        public override bool DelNode()
        {
            return true;
        }

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
            var xDoc = new XDocument(
                new XElement("AddresseeInfos", 
                    new XElement("AddresseeInfo",
                        new XAttribute("TableKey","1"),
                        new XAttribute("Addressee",Addressee),
                        new XAttribute("ReceiveCount", "1")
                    )
                )
            );
            xDoc.Save(XMLFilePath);
        }
        #endregion
    }
}
