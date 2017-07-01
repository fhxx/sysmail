using System.Text;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Net.Mime;

namespace Dobug.SysMail
{
    /// <summary>
    /// .net邮件发送程序
    /// </summary>
    public class sysMailMessage:ISmtpMail
    {
        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 发件人地址
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// 发件人姓名
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// 邮箱域,即SMTP地址
        /// </summary>
        public string MailDomain { get; set; }

        /// <summary>
        /// 邮件服务器端口号
        /// </summary>
        public int MailDomainPort { get; set; }

        /// <summary>
        /// SMTP认证时使用的用户名--发件人邮箱
        /// </summary>
        public string MailServerUserName { get; set; }

        /// <summary>
        /// SMTP认证时使用的密码--发件人邮箱的密码
        /// </summary>
        public string MailServerPassWord { get; set; }

        /// <summary>
        /// 是否Html邮件
        /// </summary>
        public bool IsHtml { get; set; }

        /// <summary>
        /// 收件人的邮箱地址
        /// </summary>
        public string Recipient{get;set;}

        /// <summary>
        /// 附件地址
        /// </summary>
        public string[] mailAttachments { get; set; }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <returns>发送成功则返回true，否则返回false</returns>
        public bool Send()
        {
            MailMessage myEmail = new MailMessage();
            Encoding eEcode = Encoding.GetEncoding("utf-8");
            myEmail.From = new MailAddress(this.From, this.FromName, eEcode);
            myEmail.To.Add(this.Recipient);
            myEmail.Subject = this.Subject;
            myEmail.SubjectEncoding = eEcode;
            myEmail.Body = this.Body;
            myEmail.BodyEncoding = eEcode;
            myEmail.IsBodyHtml = true;
            
            myEmail.Priority = MailPriority.Normal;

            //附件列表
            Attachment attachment = null;
            foreach (var fileNamePath in mailAttachments)
            {
                string extName = Path.GetExtension(fileNamePath).ToLower();
                if (extName == ".rar" || extName == ".zip")
                {
                    attachment = new System.Net.Mail.Attachment(fileNamePath, MediaTypeNames.Application.Zip);
                }
                else
                {
                    attachment = new System.Net.Mail.Attachment(fileNamePath, MediaTypeNames.Application.Octet);
                }

                ContentDisposition cd = attachment.ContentDisposition;
                cd.CreationDate = File.GetCreationTime(fileNamePath);
                cd.ModificationDate = File.GetLastWriteTime(fileNamePath);
                cd.ReadDate = File.GetLastAccessTime(fileNamePath);
                // 把附件对象加入到邮件附件集合中
                myEmail.Attachments.Add(attachment);
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Host = this.MailDomain;
            smtp.Port = this.MailDomainPort;
            smtp.Credentials =new NetworkCredential(this.MailServerUserName, this.MailServerPassWord);

            //当不是25端口(gmail:587)
            if (this.MailDomainPort != 25)
            {
                smtp.EnableSsl = true;
            }

            try
            {
                smtp.Send(myEmail);
            }
            catch(SmtpException ex) {
                string result = ex.Message;
                return false;
            }

            return true;
        }
    }
}