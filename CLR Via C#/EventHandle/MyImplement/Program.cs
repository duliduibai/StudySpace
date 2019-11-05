using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mailManager = new MailManager();
            Fax fax = new Fax(mailManager);
            Pager pager = new Pager(mailManager);
            mailManager.ReceiveEmail("boone", "james", "吃饭了吗？");
            Console.ReadLine();
        }
    }
}
