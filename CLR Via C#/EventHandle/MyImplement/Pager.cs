using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImplement
{
    public class Pager
    {
        public MailManager mailManager;
        public Pager(MailManager mailManager)
        {
            this.mailManager = mailManager;
            mailManager.NewEmail += WriteEmail;
        }

        public void WriteEmail(string from, string to, string subject)
        {
            Console.WriteLine($"In Pager: from:{from}, to:{to}, subject:{subject}");
        }
    }
}
