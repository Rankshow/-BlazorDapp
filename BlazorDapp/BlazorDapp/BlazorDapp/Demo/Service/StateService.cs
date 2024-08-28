namespace BlazorDapp.Demo.Service;

    public class StateService
    {
        private List<string> messages = new();
        public event Action OnChange;
        public IEnumerable<string> GetMessages() => messages;
        public void AddMessage(string message)
        {
            messages.Add(message);
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
