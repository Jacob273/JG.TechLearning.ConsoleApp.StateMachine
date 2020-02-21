using System;
using System.Collections.Generic;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine.Enums
{
    public enum StateName
    {
        InitializeState,
        IdleState,
        ErrorState,
        OrderInterpretationState,
        ElementPlacementState,
        WeldingState,
        PerformTestState,
        SendResultState,
    }
}
