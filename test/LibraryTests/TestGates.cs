using NUnit.Framework;
using System.Collections.Generic;
using Library;

namespace Tests
{
    public class TestGates
    {
        [Test]
        public void AndTest()
        {
            LogicInput input1 = new LogicInput(true);
            LogicInput input2 = new LogicInput(false);
            AndGate and = new AndGate("And");
            and.Inputs.Add(input1);
            and.Inputs.Add(input2);
            var expected = false;
            var actual = and.Calculate();
            Assert.AreEqual(expected, actual);
            try
            {
                and.AddInput(input1);
                and.AddInput(input2);
                and.Calculate();
                Assert.Fail();

            }
            catch (GateExceptions )
            {
                Assert.Pass();
            }
           
        }
        [Test]
        public void OrTest()
        {
            LogicInput input1 = new LogicInput(true);
            LogicInput input2 = new LogicInput(false);
            OrGate or = new OrGate("Or");
            or.Inputs.Add(input1);
            or.Inputs.Add(input2);
            var expected = true;
            var actual = or.Calculate();
            Assert.AreEqual(expected, actual);
            try 
            {
                or.AddInput(input1);
                or.Calculate();
                Assert.Fail();
            }
            catch (GateExceptions)
            {
                Assert.Pass();
            }
        }
        [Test]
        public void NotTest()
        {
            LogicInput input = new LogicInput(true);
            NotGate not = new NotGate("Not");
            not.Inputs.Add(input);
            var expected = false;
            var actual = not.Calculate();
            Assert.AreEqual(expected, actual);
            try
            {
                not.AddInput(input);
                not.Calculate();
                Assert.Fail();
            }
            catch (GateExceptions)
            {
                Assert.Pass();
            }
        }
        
        
    }//assert.fail para las excepciones
}