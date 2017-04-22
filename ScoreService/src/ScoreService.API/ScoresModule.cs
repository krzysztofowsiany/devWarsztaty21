using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ScoreService.API
{
    public class ScoresModule
    {
        public Task GetScore(HttpContext httpContext)
        {
            return httpContext.Response.WriteAsync("po zmiana dddanie scoremodules ");
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