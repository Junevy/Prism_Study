using Prism.Events;

namespace Prism_EventAggregator.Models
{
    public class ValidateEventArgs : PubSubEvent<bool>
    {
        public bool IsValid { get; set; }
    }
}
