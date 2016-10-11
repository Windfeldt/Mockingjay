namespace Mocking
{
    public class MailBox
    {
        public<Mail> mailList = new List<Mail>();
        int numReceivedMessages;
        public MailBox()
        {
        }
        
        public void Add(Mail mail)
        {
            mailList.Add(mail);
            numReceivedMessages++;
        }
        public int NumReceivedMessages
        {
            get {return numReceivedMessages;}
            set {numReceivedMessages = value;}
        }
    }
}