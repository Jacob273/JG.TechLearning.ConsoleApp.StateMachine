using System;

namespace JG.TechLearning.ConsoleApp.StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 transitions


            //1# >>>>>Idle state
            StateMachine sm = new StateMachine();
            Console.WriteLine(sm.GetCurrentState());


            //2# >>>>>Idle GOING Initialized
            sm.Initialize();
            Console.WriteLine(sm.GetCurrentState());



            //3# Starting the machine cause: >>>>>Initial state GOING ElementPlacement state
            sm.Start();
            Console.WriteLine(sm.GetCurrentState());



            //4# Ready has been clicked cause: >>>>>ElementPlacement GOING Welding
            sm.Ready();
            Console.WriteLine(sm.GetCurrentState());
        }
    }
}
