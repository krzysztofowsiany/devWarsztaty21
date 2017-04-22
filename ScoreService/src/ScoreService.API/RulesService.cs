using System.Collections.Generic;
using System.Linq;

namespace ScoreService.API{
    public class RulesService{
        private readonly List<IRule> rules;
        public RulesService()
        {
            rules = new List<IRule>();
            rules.Add(new IncomeRule());
            rules.Add(new CountryRule());
            rules.Add(new MortgageRule());
            rules.Add(new AgeRule());
        }


        public bool ValidateAll(ApplicantRequest applicantnRequest){
            return rules.All(x => x.Validate(applicantnRequest));
        }
    }
}