using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_Event
{
    public delegate void NotifyWarmUpCompleted(string foodName);
    internal class Microwave
    {
        public event NotifyWarmUpCompleted WarmUpCompleted;
        public void WarmUp(string foodName)
        {
            Console.WriteLine($"I warm up {foodName}");
            WarmUpCreated(foodName);
        }
        protected virtual void WarmUpCreated(string foodName)
        {
            if(WarmUpCompleted != null)
            {
                WarmUpCompleted.Invoke(foodName);
            }
        }
    }
}
