using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandle
{
    public class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewEmail;
        public int test = 1;
        public MailManager()
        {
        }
        public void ReceiveEmail(string from, string to, string subject)
        {
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            OnNewEmail(e);
        }

        public void OnNewEmail(NewMailEventArgs e)
        {
            //EventHandler<NewMailEventArgs> temp = Volatile.Read(ref NewEmail);
            //if (temp != null)
            //{
            //    temp(this, e);
            //}
            //简单写法
            Volatile.Read(ref NewEmail)?.Invoke(this, e);
        }
    }
}
