namespace Imi.Project.Blazor.Core
{
    public class MessageBox
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Button1Active { get; set; }
        public bool Button2Active { get; set; }
        public string Button1Content { get; set; }
        public string Button2Content { get; set; }

        public MessageBox(string title, string message, bool button1Active = false, bool button2Active = false, string button1Content = null,
            string button2Content = null)
        {
            Title = title;
            Message = message;
            Button1Active = button1Active;
            Button2Active = button2Active;
            Button1Content = button1Content;
            Button2Content = button2Content;
        }
    }
}
