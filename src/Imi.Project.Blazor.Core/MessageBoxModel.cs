namespace Imi.Project.Blazor.Core
{
    public class MessageBoxModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Button1Active { get; set; }
        public bool Button2Active { get; set; }
        public string Button1Content { get; set; }
        public string Button2Content { get; set; }
        public bool IsShown { get; set; } = false;

        public MessageBoxModel()
        {
        }

        public static MessageBoxModel Show(string title, string message, bool button1Active = false, string button1Content = null, bool button2Active = false,
            string button2Content = null)
        {
            MessageBoxModel model = new();
            
            model.Title = title;
            model.Message = message;
            model.Button1Active = button1Active;
            model.Button1Content = button1Content;
            model.Button2Active = button2Active;
            model.Button2Content = button2Content;
            model.IsShown = true;
            return model;
        }
    }
}
