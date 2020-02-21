using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;

namespace JG.TechLearning.ConsoleApp.StateMachine
{
    public abstract class VirtualState : IState
    {
        protected StateName stateName;
        protected IStateMachine stateMachine;

        public StateName Name => stateName;

        public VirtualState(StateName stateName, IStateMachine stateMachine)
        {
            this.stateName = stateName;
            this.stateMachine = stateMachine;
        }

        public virtual void OnInitialize()
        {
            throw new NotImplementedException();
        }

        public virtual void OnStart()
        {
            throw new NotImplementedException();
        }

        public virtual void OnReset()
        {
            throw new NotImplementedException();
        }

        public virtual void OnReady()
        {
            throw new NotImplementedException();
        }

        public virtual void OnRun()
        {
            throw new NotImplementedException();
        }

        public virtual void OnRunTest()
        {
            throw new NotImplementedException();
        }

        public virtual void OnSend()
        {
            throw new NotImplementedException();
        }

        public virtual void OnPassed()
        {
            throw new NotImplementedException();
        }

        public virtual void OnError()
        {
            throw new NotImplementedException();
        }

        public virtual void OnComplete()
        {
            throw new NotImplementedException();
        }
    }
}
