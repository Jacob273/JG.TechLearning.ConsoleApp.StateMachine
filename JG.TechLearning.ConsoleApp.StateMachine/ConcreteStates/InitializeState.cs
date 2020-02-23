using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System.Diagnostics;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class InitializeState : VirtualState
    {
        public InitializeState(IStateMachine stateMachine) : base(StateName.InitializeState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }


        public override void OnStart()
        {
            //state setting
            stateMachine.SetState(StateName.ElementPlacementState);

            //logic execution
            Debug.WriteLine("Placing the element...");
        }
    }

}
