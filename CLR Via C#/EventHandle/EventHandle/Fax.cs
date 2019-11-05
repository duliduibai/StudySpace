using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandle
{
    public class Fax
    {
        public MailManager mailManager;
        public Fax(MailManager mailManager)
        {
            this.mailManager = mailManager;
            this.mailManager.NewEmail += FaxMsg;
        }

        public void FaxMsg(object sender, NewMailEventArgs e)
        {
            Console.WriteLine($"In Fax: from:{e.From}, to:{e.To}, subject:{e.Subject}");
        }
    }
}
