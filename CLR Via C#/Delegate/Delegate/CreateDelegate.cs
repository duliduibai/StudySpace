using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStudy
{
    public class CreateDelegate
    {
        internal delegate void Feedback(int value);
        public void ChainDelegateDemo(CreateDelegate del)
        {
            Feedback fb1 = new Feedback(FeebackToConsole);
            Feedback fb2 = new Feedback(FeedbackToConsoleWithYes);
            Feedback fb3 = new Feedback(FeebackToFile);

            Feedback fbChain = null;
            fbChain = (Feedback)Delegate.Combine(fbChain, fb1);
            fbChain = (Feedback)Delegate.Combine(fbChain, fb2);
            fbChain = (Feedback)Delegate.Combine(fbChain, fb3);
            Counter(1, 2, fbChain);

            Console.WriteLine();

            fbChain = (Feedback)Delegate.Remove(fbChain, new Feedback(FeebackToConsole));
            fbChain = (Feedback)Delegate.Remove(fbChain, new Feedback(FeebackToFile));
            Counter(1, 2, fbChain);
        }

        private void FeebackToConsole(int value)
        {
            Console.WriteLine("Item = " + value);
        }

        private void FeedbackToConsoleWithYes(int value)
        {
            Console.WriteLine("Yes, the item = " + value);
        }

        private void FeebackToFile(int value)
        {
            using (StreamWriter writer = new StreamWriter("Status.txt", true))
            {
                writer.WriteLine("Item = " + value);
            }
        }

        private void Counter(int from, int to, Feedback fb)
        {
            for (int i = from; i <= to; i++)
            {
                if (fb != null)
                {
                    fb(i);
                }
            }
        }
    }
}
