using Domain;
using System;

namespace Rules
{
    public class TenantSchedulingRule : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            Scheduling scheduling = null; 
            When().Match(() => scheduling, sc => sc.Tenant.Equals("WPH"));

            Then().Do(ctx => FillScheduleOptions(scheduling));
        }

        private static void FillScheduleOptions(Scheduling scheduling)
        {
            scheduling.SuggestedDateOne = "Viernes";
            scheduling.SuggestedDateTwo = "Sabado";
        }
    }
}
