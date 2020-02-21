using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class OrderIntepretationState : VirtualState
    {
        public OrderIntepretationState(IStateMachine stateMachine) : base(StateName.OrderInterpretationState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }
    }
}
