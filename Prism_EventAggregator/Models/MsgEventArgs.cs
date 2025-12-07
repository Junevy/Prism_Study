using Prism.Events;

namespace Prism_EventAggregator.Models
{
    public class MsgEventArgs : PubSubEvent
    {
        public string Message { get; set; }
    }
}
