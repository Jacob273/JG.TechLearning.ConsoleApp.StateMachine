using JG.TechLearning.ConsoleApp.StateMachine.Enums;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class PerformTestState : VirtualState
    {
        public PerformTestState(IStateMachine stateMachine) : base(StateName.PerformTestState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }
    }
}
