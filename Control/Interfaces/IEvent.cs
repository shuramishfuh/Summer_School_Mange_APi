using System;

namespace Control.Interfaces
{
    interface IEvent
    {
        short EventId { get; set; }
        string EventName { get; set; }
        string Url { get; set; }
        string Description { get; set; }
        DateTime EventDate { get; set; }
    }
}
