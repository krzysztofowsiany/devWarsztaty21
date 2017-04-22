using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ScoreService.API
{
    public class ScoresModule
    {
        public Task GetScore(HttpContext httpContext){
             return httpContext.Response.WriteAsync("po zmiana dddanie scoremodules ");
        }
    }
}