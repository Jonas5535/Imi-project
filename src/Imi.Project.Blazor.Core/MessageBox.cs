namespace Imi.Project.Blazor.Core
{
    public class MessageBox
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Button1Content { get; set; }
        public bool Button2Active { get; set; }
        public string Button2Content { get; set; }
        public bool IsShown { get; set; } = false;

        public MessageBox()
        {
        }

        public static MessageBox Show(string title, string message, string button1Content, bool button2Active = false, string button2Content = null)
        {
            MessageBox model = new();

            model.Title = title;
            model.Message = message;
            model.Button1Content = button1Content;
            model.Button2Active = button2Active;
            model.Button2Content = button2Content;
            model.IsShown = true;
            return model;
        }
    }
}
