using System;

namespace Domain
{
    public class Scheduling
    {
        public string ScheduledDate { get; set; }
        public string SuggestedDateOne { get; set; }
        public string SuggestedDateTwo { get; set; }
        public bool IsConfirmed { get; set; }
        public string Tenant { get; set; }

        public Scheduling(string scheduledDate, string suggestedDateOne, string suggestedDayTwo, bool isConfirmed, string tenant)
        {
            ScheduledDate = scheduledDate;
            SuggestedDateOne = suggestedDateOne;
            SuggestedDateTwo = SuggestedDateTwo;
            IsConfirmed = isConfirmed;
            Tenant = tenant;
        }
    }
}
