using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine
{
    public class StateMachine : IStateMachine
    {

        private IState currentState;
        private IState previousState;
        private StateInstanceHolder stateHolder;

        public StateMachine()
        {
            stateHolder = new StateInstanceHolder(this);
            currentState = stateHolder.GetStateInstance(StateName.IdleState);
            previousState = null;
        }

        public StateName GetCurrentState()
        {
            return currentState.Name;
        }

        public StateName GetPreviousState()
        {
            return previousState.Name;
        }

        public void SetState(StateName stateName)
        {
            Debug.WriteLine("CurrentState: {0} changes to: {1} ", currentState.Name, stateName.ToString());
            previousState = currentState;
            currentState = stateHolder.GetStateInstance(stateName);
        }

        public void Initialize()
        {
            currentState.OnInitialize();
        }

        public void Start()
        {
            currentState.OnStart();
        }

        public void Reset()
        {
            currentState.OnReset();
        }

        public void Ready()
        {
            currentState.OnReady();
        }

        public void Run()
        {
            currentState.OnRun();
        }

        public void RunTest()
        {
            currentState.OnRunTest();
        }

        public void Send()
        {
            currentState.OnSend();
        }

        public void Passed()
        {
            currentState.OnPassed();
        }

        public void Error()
        {
            currentState.OnError();
        }

        public void Complete()
        {
            currentState.OnComplete();
        }
    }
}
