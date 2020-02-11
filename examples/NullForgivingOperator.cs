using System;

namespace DotNetLightningTalks
{
    class Message
    {
        public string Contents { get; set; }
        public DateTime CreatedOn { get; }

        public Message(string messageContents)
        {
            this.Contents = messageContents;
            this.DateTime = DateTime.Now;
        }
    }

    class MessageReader
    {
        void ReadMessage(Message? message)
        {
            if(IsValid(message)) 
            {
                Console.WriteLine($"{message!.CreatedOn.ToString} - {message!.Contents}");           
            }

            if(IsValidAnnotated(message))
            {
                Console.WriteLine($"{message.CreatedOn.ToString} - {message.Contents}");  
            }
        }

        bool IsValid(Message? message) => message != null && !string.IsNullOrEmpty(message.Contents);

        bool IsValidAnnotated([NotNullWhen(true)] Message? message) 
        {
            return message != null && !string.IsNullOrEmpty(message.Contents);
        }
    }
}