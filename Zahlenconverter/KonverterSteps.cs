using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Zahlenconverter
{
    [Binding]
    public class KonverterSteps
    {

        string x;
        int Integer;
        [Given(@"the srtig is (.*)")]
        public void GivenTheSrtigIs(string p0)
        {
            x = p0;
        }
        
        [When(@"the the string gets converted with base sixteen")]
        public void WhenTheTheStringGetsConvertedWithBaseSixteen()
        {
            Integer = System.Convert.ToInt32(x, 16);
        }
        
        [When(@"the the string gets converted with base eight")]
        public void WhenTheTheStringGetsConvertedWithBaseEight()
        {
            Integer = System.Convert.ToInt32(x, 8);
        }
        
        [When(@"the the string gets converted with base two")]
        public void WhenTheTheStringGetsConvertedWithBaseTwo()
        {
            Integer = System.Convert.ToInt32(x, 2);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, Integer);
        }
    }
}
