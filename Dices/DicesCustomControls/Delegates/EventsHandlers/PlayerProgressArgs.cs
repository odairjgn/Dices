using System;
using DicesCustomControls.Enums;

namespace DicesCustomControls.Delegates.EventsHandlers
{
    public class PlayerProgressArgs : EventArgs
    {
        public string Description { get; }
        public PlayerStatus Status { get; }
        public TimeSpan Current { get; }
        public TimeSpan Total { get; }
        public float Percentage { get; }

        public PlayerProgressArgs(string description, PlayerStatus status, TimeSpan current, TimeSpan Total, float percentage)
        {
            Description = description;
            Status = status;
            Current = current;
            this.Total = Total;
            Percentage = percentage;
        }
    }
}
