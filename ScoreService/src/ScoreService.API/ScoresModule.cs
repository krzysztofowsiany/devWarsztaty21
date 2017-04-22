using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ScoreService.API
{
    public class ScoresModule
    {
        public Task GetScore(HttpContext httpContext)
        {
            var applicantRequest = DeserializeAsync<ApplicantRequest>(httpContext);
            
            var ruleService = new RulesService();
           
            if (ruleService.ValidateAll(applicantRequest)){
                return httpContext.Response.WriteAsync("You are allowed");
            }

            return httpContext.Response.WriteAsync("Not allowed");
        }

        public T DeserializeAsync<T>(HttpContext context) where T : class
        {
            if (context.Request.Body.CanRead)
            {
                using (var sr = new StreamReader(context.Request.Body))
                using (var jr = new JsonTextReader(sr))
                {
                    return new JsonSerializer().Deserialize<T>(jr);
                }
            }
            else
            {
                return null;
            }
        }
    }
}