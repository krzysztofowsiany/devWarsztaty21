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
            var result = DeserializeAsync<ApplicantRequest>(httpContext);

            return httpContext.Response.WriteAsync($" {result.Name} po zmiana dddanie scoremodules ");
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

    public class ApplicantRequest
    {


        public string Name { get; set; }

        public string LastName { get; set; }
        public string Country { get; set; }


        public int Income { get; set; }
        public bool Mortgage { get; set; }

    }
}