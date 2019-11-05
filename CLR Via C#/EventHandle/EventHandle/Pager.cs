using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandle
{
    public class Pager
    {
        public MailManager mailManager;
        public Pager(MailManager mailManager)
        {
            this.mailManager = mailManager;
            this.mailManager.NewEmail += FaxMsg;
        }

        public void FaxMsg(object sender, NewMailEventArgs e)
        {
            MailManager tmep = sender as MailManager;
            int x = tmep.test;
            Console.WriteLine($"In Pager: from:{e.From}, to:{e.To}, subject:{e.Subject}");
        }
    }
}
