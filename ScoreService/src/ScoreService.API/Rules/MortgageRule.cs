
using System;

namespace ScoreService.API{

    public class MortgageRule : IRule
    {
        public bool Validate(ApplicantRequest applicationRequest)
        {
            return !applicationRequest.Mortgage;
        }
    }
}