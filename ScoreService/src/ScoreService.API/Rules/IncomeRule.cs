
using System;

namespace ScoreService.API{

    public class IncomeRule : IRule
    {
        public bool Validate(ApplicantRequest applicationRequest)
        {
            return applicationRequest.Income > 15000;
        }
    }
}