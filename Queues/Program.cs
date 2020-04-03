using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {




            // Many Consultant
            //CallCenter centerMany = new CallCenter();
            //Parallel.Invoke(
            //    () => CallersAction(centerMany),
            //    () => ConsultantAction(centerMany, "Marcin", ConsoleColor.Red),
            //    () => ConsultantAction(centerMany, "James", ConsoleColor.Yellow),
            //    () => ConsultantAction(centerMany, "Olivia", ConsoleColor.Green));




            // One Consultant 

            //Random random = new Random();

            //CallCenter center = new CallCenter();
            //center.Call(1234);
            //center.Call(5678);
            //center.Call(1468);
            //center.Call(9641);

            //while (center.AreWaitingCalls())
            //{
            //    IncomingCalls call = center.Answer("Marcin");
            //    Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}.");
            //    Thread.Sleep(random.Next(1000, 10000));
            //    center.End(call);
            //    Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}.");





            // Priority Queue
            Random random = new Random();

            CallCenterPriority center = new CallCenterPriority();
            center.Call(1234);
            center.Call(5678, true);
            center.Call(1468);
            center.Call(9641, true);

            while (center.AreWaitingCalls())
            {
                IncomingCallsPriority call = center.Answer("Marcin");
                Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant} / Mode: {(call.IsPriority ? "priority" : "normal")}.");
                Thread.Sleep(random.Next(1000, 10000));
                center.End(call);
                Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}.");
            }
            }



        public static void CallersAction(CallCenter center)
        {
            Random random = new Random();
            while (true)
            {
                int clientId = random.Next(1, 10000);
                int waitingCount = center.Call(clientId);
                Log($"Incoming call from {clientId}, waiting in the queue: {waitingCount}");
                Thread.Sleep(random.Next(1000, 5000));
            }
        }

        private static void ConsultantAction(CallCenter center, string name, ConsoleColor color)
        {
            Random random = new Random();
            while (true)
            {
                IncomingCalls call = center.Answer(name);
                if (call != null)
                {
                    Console.ForegroundColor = color;
                    Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}.");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Thread.Sleep(random.Next(1000, 10000));
                    center.End(call);

                    Console.ForegroundColor = color;
                    Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}.");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Thread.Sleep(random.Next(500, 1000));
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private static void Log(string text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
        }
    }
}


      