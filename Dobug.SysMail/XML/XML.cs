using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dobug.SysMail.XML
{
    /// <summary>
    /// XML操作抽象类
    /// </summary>
    public abstract class XML
    {
        #region 属性
        /// <summary>
        /// 节点需要
        /// </summary>
        string TableKey { get; set; }

        /// <summary>
        /// XML文件路径
        /// </summary>
        string XMLFilePath { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 增加新的节点，在以后的基础上增加
        /// </summary>
        /// <returns></returns>
        public abstract bool AddNewNode();

        /// <summary>
        /// 更新指定节点值
        /// </summary>
        public abstract bool UpdateNode();

        /// <summary>
        /// 删除指定节点
        /// </summary>
        public abstract bool DelNode();

        /// <summary>
        /// 删除整个XML文件
        /// </summary>
        public abstract void DelXMLFile();

        /// <summary>
        /// 获取XML数据到DataTable，如果不存在则返回null
        /// </summary>
        /// <returns></returns>
        public abstract DataTable GetXMLData();

        /// <summary>
        /// 当XML文件不存在时创建新的XML文件
        /// </summary>
        public abstract void CreateXMLFile();
        #endregion
    }
}