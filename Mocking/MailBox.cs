using System;
using System.Collections.Generic;

namespace Mocking
{
    public class MailBox
    {
        public List<Mail> mailList = new List<Mail>();
        int numReceivedMessages;
        public MailBox()
        {
        }
        
        public int NumReceivedMessages
        {
            get {return numReceivedMessages;}
            set {numReceivedMessages = value;}
        }
        internal void Add(Mail mail)
        {
            mailList.Add(mail);
            numReceivedMessages++;
        }

        internal string GetLatestMessageText()
        {
            return mailList[numReceivedMessages - 1].Content;
        }
    }
}