using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Dobug.SysMail.XML
{
    /// <summary>
    /// 邮件发送者信息
    /// </summary>
    public class XMLSender:XML
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
        /// 用户名数组，批量导入使用到
        /// </summary>
        public string[] nodeUserName { get; set; }

        /// <summary>
        /// 用户密码数组，批量导入使用到
        /// </summary>
        public string[] nodePassword { get; set; }

        /// <summary>
        /// 单一邮箱地址，用户更新
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 单一邮箱密码，用户更新
        /// </summary>
        public string password { get; set; }
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public XMLSender() {
            XMLFilePath = Application.StartupPath +@"\SenderInfo.xml";
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
                XElement xe = (XElement)XEle.FirstNode;
                if (XEle.Nodes().Count() == 1 && xe.Attribute("TableKey").Value == "")
                {
                    File.Delete(XMLFilePath);
                    CreateXMLFile();
                }
                else
                {
                    xe = (XElement)XEle.LastNode;
                    int tk = int.Parse(xe.Attribute("TableKey").Value) + 1;
                    for (int i = 0; i < nodeUserName.Length; i++)
                    {
                        XEle.Add(
                            new XElement("UserInfo",
                                new XAttribute("TableKey", (i + tk).ToString()),
                                new XAttribute("UserName", nodeUserName[i].ToString()),
                                new XAttribute("PassWord", nodePassword[i].ToString())
                            )
                        );
                    }
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
            try
            {
                XElement XEle = XElement.Load(XMLFilePath);
                IEnumerable<XElement> IXEle = from e in XEle.Elements("UserInfo")
                                              where e.Attribute("TableKey").Value == TableKey
                                              select e;
                XElement xe = IXEle.First();
                xe.SetAttributeValue("UserName", userName);
                xe.SetAttributeValue("PassWord", password);
                XEle.Save(XMLFilePath);
                return true;
            }
            catch { return true; }
        }

        /// <summary>
        /// 删除指定节点
        /// </summary>
        public override bool DelNode()
        {
            try
            {
                XElement XEle = XElement.Load(XMLFilePath);
                IEnumerable<XElement> IXEle = from e in XEle.Elements("UserInfo")
                                              where e.Attribute("TableKey").Value == TableKey
                                              select e;
                XElement xe = IXEle.First();
                if (XEle.Nodes().Count() > 1)
                {
                    xe.Remove();
                }
                else
                {
                    xe.SetAttributeValue("TableKey", "");
                    xe.SetAttributeValue("UserName", "");
                    xe.SetAttributeValue("PassWord", "");
                }
                XEle.Save(XMLFilePath);
                return true;
            }
            catch { return false; }
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
            XElement XEle = new XElement("UserInfos");
            for (int i = 0; i < nodeUserName.Length; i++)
            {
                XEle.Add(
                    new XElement("UserInfo",
                        new XAttribute("TableKey", (i + 1).ToString()),
                        new XAttribute("UserName", nodeUserName[i].ToString()),
                        new XAttribute("PassWord", nodePassword[i].ToString())
                    )
                );
            }
            XEle.Save(XMLFilePath);
        }
        #endregion
    }
}