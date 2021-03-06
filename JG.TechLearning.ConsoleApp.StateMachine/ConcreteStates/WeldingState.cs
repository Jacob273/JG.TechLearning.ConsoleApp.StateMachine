﻿using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace JG.TechLearning.ConsoleApp.StateMachine.ConcreteStates
{
    public class WeldingState : VirtualState
    {
        public WeldingState(IStateMachine stateMachine) : base(StateName.WeldingState, stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public override void OnComplete()
        {
            //state setting
            stateMachine.SetState(StateName.IdleState);

            //logic execution
            Debug.WriteLine("Going idle...");
        }
    }
}
