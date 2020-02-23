using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class ElementPlacementState : VirtualState
    {
        public ElementPlacementState(IStateMachine stateMachine) : base(StateName.ElementPlacementState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public override void OnReady()
        {
            //state setting
            stateMachine.SetState(StateName.WeldingState);

            //logic execution
            Debug.WriteLine("Welding...");
        }
    }
}
