using GalaSoft.MvvmLight.Messaging;

namespace CrossViewModelCommunication.Message
{
    public class ChangeBackgroundMessage : MessageBase
    {
        public ChangeBackgroundMessage()
        {}

        public ChangeBackgroundMessage(string hex)
        {
            Hex = hex;
        }

        public string Hex { get; set; }
    }
}
