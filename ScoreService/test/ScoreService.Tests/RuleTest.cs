using System;
using Xunit;
using ScoreService.API;

namespace ScoreService.Tests
{
    public class RuleTest
    {
        [Fact]
        public void given_validate_when_income_less_than_15000()
        {
            //arragne
            var incomeRule = new IncomeRule();

            var applicantRequest = new ApplicantRequest() {
                Income = 9000
            };

            //act
           var result  = incomeRule.Validate(applicantRequest);

            //assert
           Assert.False(result);
        }
    }
}
