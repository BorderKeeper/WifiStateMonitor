namespace WiFiStateMonitor.ViewModels.Entities
{
    public class WifiEventRow
    {
        public WifiEventRow(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}