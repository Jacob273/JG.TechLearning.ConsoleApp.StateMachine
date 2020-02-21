using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine
{
    public interface IState
    {
        StateName Name { get; }
        void OnInitialize();

        void OnStart();
        void OnReset();
        void OnReady();
        void OnRun();
        void OnRunTest();
        void OnSend();
        void OnPassed();
        void OnError();
        void OnComplete();
    }
}
