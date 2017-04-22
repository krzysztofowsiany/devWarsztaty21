
using System;

namespace ScoreService.API{

    public class AgeRule : IRule
    {
        public bool Validate(ApplicantRequest applicationRequest)
        {
            return ! (applicationRequest.Age < 21);
        }
    }
}