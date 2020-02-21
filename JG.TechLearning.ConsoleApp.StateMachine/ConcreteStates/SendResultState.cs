using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class SendResultState : VirtualState
    {
        public SendResultState(IStateMachine stateMachine) : base(StateName.SendResultState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }
    }
}
