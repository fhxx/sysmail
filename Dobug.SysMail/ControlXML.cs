using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Dobug.SysMail
{
    /// <summary>
    /// XML操作类
    /// </summary>
    public class ControlXML
    {
        #region 属性

        /// <summary>
        /// 用户名
        /// </summary>
        public string[] nodeUserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string[] nodePassword { get; set; }

        /// <summary>
        /// 用户信息的文件路径
        /// </summary>
        private string XMLPath = Application.StartupPath + @"\UserInfo.xml";
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
            XElement xe = (XElement)XEle.FirstNode;
            if (XEle.Nodes().Count() == 1 && xe.Attribute("TableKey").Value == "")
            {
                File.Delete(XMLPath);
                CreateXML();
            }
            else {
                xe = (XElement)XEle.LastNode;
                int count = int.Parse(xe.Attribute("TableKey").Value) + 1;
                for (int i = 0; i < nodeUserName.Length; i++)
                {
                    XEle.Add(
                        new XElement("UserInfo",
                            new XAttribute("TableKey", (i + count).ToString()),
                            new XAttribute("UserName", nodeUserName[i].ToString()),
                            new XAttribute("PassWord", nodePassword[i].ToString())
                        )
                    );
                }
                XEle.Save(XMLPath);
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="tableKey"></param>
        public bool DelXML(string tableKey)
        {
            try
            {
                XElement XEle = XElement.Load(XMLPath);
                IEnumerable<XElement> IXEle = from e in XEle.Elements("UserInfo")
                                              where e.Attribute("TableKey").Value == tableKey
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
                XEle.Save(XMLPath);
                return true;
            }
            catch {
                return false;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="tableKey"></param>
        public void DelALLXML() {
            if (File.Exists(XMLPath))
            {
                File.Delete(XMLPath);
            }
        }

        /// <summary>
        /// 更新节点
        /// </summary>
        /// <param name="tableKey"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UpdateXML(string tableKey, string userName, string password)
        {
            try
            {
                XElement XEle = XElement.Load(XMLPath);
                IEnumerable<XElement> IXEle = from e in XEle.Elements("UserInfo")
                                              where e.Attribute("TableKey").Value == tableKey
                                              select e;
                XElement xe = IXEle.First();
                xe.SetAttributeValue("UserName", userName);
                xe.SetAttributeValue("PassWord", password);
                XEle.Save(XMLPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public DataTable getUserInfo()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(XMLPath);
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 创建新的XML文件
        /// </summary>
        private void CreateXML()
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
            XEle.Save(XMLPath);
        }
        #endregion
    }
}