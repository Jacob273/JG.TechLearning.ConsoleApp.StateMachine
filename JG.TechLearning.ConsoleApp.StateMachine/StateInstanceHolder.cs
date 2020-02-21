using JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates;
using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System.Collections.Generic;
using System.Linq;

namespace JG.TechLearning.ConsoleApp.StateMachine
{
    public class StateInstanceHolder
    {
        private readonly List<IState> possibleStates;
        private readonly bool isInitialized;

        public StateInstanceHolder(IStateMachine stateMachine)
        {
            if (isInitialized)
            {
                return;
            }

            possibleStates = new List<IState>
            {
                new IdleState(stateMachine),
                     new WeldingState(stateMachine),
                          new ElementPlacementState(stateMachine),
                                new InitializeState(stateMachine)
            };

            isInitialized = true;
        }

        public IState GetStateInstance(StateName stateName)
        {
            return possibleStates.First(x => x.Name == stateName);
        }
    }
}
