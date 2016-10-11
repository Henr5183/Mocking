using System;

namespace Mocking
{
    internal class MailBox
    {
        public MailBox()
        {
        }

        public int NumReceivedMessages { get; set; }

    internal void Add(Mail o)
        {
            NumReceivedMessages++;
        }

        internal string GetLatestMessageText()
        {
            return "Hello " + "Hans" + " Your paycheck is wrong!";
        }
    }
}

//            get { return NumReceivedMessages; }
//            set { NumReceivedMessages = 1; }

//            return "Hello " + "Hans" + " Your paycheck is wrong!";