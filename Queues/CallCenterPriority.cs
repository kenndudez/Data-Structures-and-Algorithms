using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class CallCenterPriority
    {

        private int _counter = 0;
        public SimplePriorityQueue<IncomingCallsPriority> Calls { get; private set; }

        public CallCenterPriority()
        {
            Calls = new SimplePriorityQueue<IncomingCallsPriority>();
        }

        public void Call(int clientId, bool isPriority = false)
        {
            IncomingCallsPriority call = new IncomingCallsPriority()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now,
                IsPriority = isPriority
            };
            Calls.Enqueue(call, isPriority ? 0 : 1);
        }

        public IncomingCallsPriority Answer(string consultant)
        {
            if (Calls.Count > 0)
            {
                IncomingCallsPriority call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;
                return call;
            }
            return null;
        }

        public void End(IncomingCallsPriority call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }
}
