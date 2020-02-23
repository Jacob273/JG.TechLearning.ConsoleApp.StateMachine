using JG.TechLearning.ConsoleApp.StateMachine;
using JG.TechLearning.ConsoleApp.StateMachine.Enums;
using NUnit.Framework;

namespace JG.TechLearning.ConsoleApp.UnitTests
{
    public class Tests
    {
        IStateMachine _sm;

        [SetUp]
        public void Setup()
        {
            _sm = new StateMachine.StateMachine();
        }

        [Test]
        public void IdlingOnStartupStateTest()
        {
            Assert.AreEqual(StateName.IdleState, _sm.GetCurrentState());
        }


        [Test]
        public void GoingInitializedStateTest()
        {
            IdlingOnStartupStateTest();

            _sm.Initialize();
            Assert.AreEqual(StateName.InitializeState, _sm.GetCurrentState());
        }

        [Test]
        public void ElementPlacementStateTest()
        {
            GoingInitializedStateTest();

            _sm.Start();
            Assert.AreEqual(StateName.ElementPlacementState, _sm.GetCurrentState());
        }

        [Test]
        public void WeldingElementStateTest()
        {
            ElementPlacementStateTest();

            _sm.Run();
            Assert.AreEqual(StateName.WeldingState, _sm.GetCurrentState());
        }

        [Test]
        public void WeldingFinishedStateTest()
        {
            WeldingElementStateTest();

            _sm.Complete();
            Assert.AreEqual(StateName.IdleState, _sm.GetCurrentState());
        }
    }
}