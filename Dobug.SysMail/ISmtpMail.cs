
namespace Dobug.SysMail
{
    #region 邮件收发代码接口

    /// <summary>
    /// 邮件发送代码接口
    /// </summary>
    public interface ISmtpMail
    {
        /// <summary>
        /// 端口
        /// </summary>
        int MailDomainPort { set; }

        /// <summary>
        /// 发件人的邮箱地址
        /// </summary>
        string From { get; set; }

        /// <summary>
        /// 发件人姓名
        /// </summary>
        string FromName { get; set; }

        /// <summary>
        /// 是否支持HTML代码
        /// </summary>
        bool IsHtml { get; set; }

        /// <summary>
        /// 邮件标题
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        string Body { get; set; }

        /// <summary>
        /// 邮件的服务器地址
        /// </summary>
        string MailDomain { set; }

        /// <summary>
        /// 用户名
        /// </summary>
        string MailServerUserName { set; }

        /// <summary>
        /// 口令
        /// </summary>
        string MailServerPassWord { set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        string RecipientName { get; set; }

        /// <summary>
        /// 收件人的邮箱地址
        /// </summary>
        string Recipient { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        string[] mailAttachments { get; set; }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <returns>发送成功则返回true，否则返回false</returns>
        bool Send();
    }

    #endregion
}