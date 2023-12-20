using Microsoft.AspNetCore.Components;

namespace ZeroToHero.Client.Pages.Counter
{
    public class CounterBase : ComponentBase
    {
        public int currentCount { get; set; } = 8;
        public void IncrementCount()
        {
            currentCount++;
        }

    }
}
