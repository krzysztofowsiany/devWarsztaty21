
using System;

namespace ScoreService.API{

    public class CountryRule : IRule
    {
        public bool Validate(ApplicantRequest applicationRequest)
        {
            if (String.IsNullOrEmpty(applicationRequest.Country))
                return false;
            return applicationRequest.Country.Equals("Poland");
        }
    }
}