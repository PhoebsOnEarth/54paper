using System;
namespace _2dstringarray
{
    public class Message
    {
        private string text = String.Empty;
        private string time = String.Empty;

        public Message(string text, string time = "NA")
        {
            Text = text;
            Time = time;
        }

        public string Text
        {
            get => text;
            set => text = value;
        }

        public string Time
        {
            get => time;
            set => time = value;
        }

        public override string ToString()
        => $"Text: {Text}, Time: {Time}";
    }

    public class Email : Message
    {
        private string sender = String.Empty;
        private string receiver = String.Empty;
        private string subject = String.Empty;

        public Email(string text, string time,string sender
            ,string receiver,string subject)
            : base(text, time)
        {
            Sender = sender;
            Receiver = receiver;
            Subject = subject;
        }

        public string Sender
        {
            get => sender;
            set => sender = value;
        }

        public string Receiver
        {
            get => receiver;
            set => receiver = value;
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }

        public override string ToString()
        => String.Format("Sender: {0}, Receiver: {1}, Subject: {2}, {3}",Sender,Receiver,Subject,base.ToString());
    }

    public class SMS : Message
    {
        private string recipientContactNo;


        public SMS(string text, string time, string r) : base(text, time)
        {
            RecipientContactNo = r;
        }


        public string RecipientContactNo
        {
            get => recipientContactNo;
            set => recipientContactNo = value;
        }

   
        public override string ToString()
        => $"Recipient:{RecipientContactNo}, {base.ToString()}";


    }
}

