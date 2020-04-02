using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    
        public class CallCenter
        {
            private int _counter = 0;
            public Queue<IncomingCalls> Calls { get; private set; }

            public CallCenter()
            {
                Calls = new Queue<IncomingCalls>();
            }

            public int Call(int clientId)
            {
                IncomingCalls call = new IncomingCalls()
                {
                    Id = ++_counter,
                    ClientId = clientId,
                    CallTime = DateTime.Now
                };
                Calls.Enqueue(call);
            return Calls.Count; 
            }

            public IncomingCalls Answer(string consultant)
            {
                if (Calls.Count > 0)
                {
                    IncomingCalls call = Calls.Dequeue();
                    call.Consultant = consultant;
                    call.StartTime = DateTime.Now;
                    return call;
                }
                return null;
            }

            public void End(IncomingCalls call)
            {
                call.EndTime = DateTime.Now;
            }

            public bool AreWaitingCalls()
            {
                return Calls.Count > 0;
            }
        }
}
