using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System.Diagnostics;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class IdleState : VirtualState
    {
        public IdleState(IStateMachine stateMachine) : base(StateName.IdleState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }


        public override void OnInitialize()
        {
            //state setting
            stateMachine.SetState(StateName.InitializeState);

            //logic execution
            Debug.WriteLine("Initialization has been finished....");
        }
    }
}
