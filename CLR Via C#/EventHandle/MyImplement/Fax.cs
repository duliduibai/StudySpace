using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImplement
{
    public class Fax
    {
        public MailManager mailManager;
        public Fax(MailManager mailManager)
        {
            this.mailManager = mailManager;
            mailManager.NewEmail += WriteEmail;
        }

        public void WriteEmail(string from, string to, string subject)
        {
            Console.WriteLine($"In Fax: from:{from}, to:{to}, subject:{subject}");
        }
    }
}
