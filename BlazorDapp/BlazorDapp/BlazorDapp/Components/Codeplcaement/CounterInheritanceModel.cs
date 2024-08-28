using Microsoft.AspNetCore.Components;

namespace BlazorDapp.Components.Codeplcaement
{
    public class CounterInheritanceModel:ComponentBase
    {
        protected int currentCount = 0;
        protected void IncremengtCount()
        {
            currentCount++;
        }
    }
}
