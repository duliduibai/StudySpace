using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandle
{
    public class NewMailEventArgs : EventArgs
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public NewMailEventArgs(string from, string to, string subject)
        {
            From = from;
            To = to;
            Subject = subject;
        }
    }
}
