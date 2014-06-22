namespace CrossViewModelCommunication.Message
{
    public class ChangeBackgroundMessage
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
