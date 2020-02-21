using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine
{
    public interface IStateMachine
    {
        StateName GetCurrentState();
        StateName GetPreviousState();
        void SetState(StateName stateName);

        void Initialize();
        void Start();
        void Reset();
        void Ready();
        void Run();
        void RunTest();
        void Send();
        void Passed();
        void Error();
        void Complete();
    }
}
