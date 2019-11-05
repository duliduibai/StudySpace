using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImplement
{
    public class MailManager
    {
        public event Action<string, string, string> NewEmail;
        public MailManager()
        {
            NewEmail += OnNewEmail;
        }
        public void ReceiveEmail(string from, string to, string subject)
        {
            NewEmail(from, to, subject);
        }

        public void OnNewEmail(string from, string to, string subject)
        {
            Console.WriteLine("TEST");
        }
    }
}
