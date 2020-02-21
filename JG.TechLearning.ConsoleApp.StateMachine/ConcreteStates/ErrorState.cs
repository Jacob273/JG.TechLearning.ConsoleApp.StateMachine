using JG.TechLearning.ConsoleApp.StateMachine.Enums;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class ErrorState : VirtualState
    {
        public ErrorState(IStateMachine stateMachine) : base(StateName.ErrorState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }
    }
}
