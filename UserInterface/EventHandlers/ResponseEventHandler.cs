namespace Gestin.UI.EventHandlers
{
    public class ResponseEventHandler : EventArgs //Handling returns between Forms
    {
        public bool status { get; set; }

        public ResponseEventHandler() { }

        public ResponseEventHandler(bool @checked)
        {
            status = @checked;
        }
    }
}
