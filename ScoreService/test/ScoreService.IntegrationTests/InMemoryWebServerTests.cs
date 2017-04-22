using System;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using ScoreService.API;
using Xunit;

public class InMemoryWebServerTests : IDisposable
{
    private readonly IWebHost httpServer;
    public InMemoryWebServerTests()
    {

        httpServer = new WebHostBuilder()
         .UseKestrel()
                     .UseIISIntegration()
                    .UseStartup<Startup>()
                    .UseUrls("http://localhost:9889").Build();
        httpServer.Start();
    }


    public void Dispose() { httpServer.Dispose(); }

    [Fact]
    public async void post_scores_with_correct_body_return_OK()
    {            // arrange          
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:9889");

        var applicantRequest = new ApplicantRequest
        {
            Name = "Test",
            LastName = "Kowalski",
            Country = "Poland",
            Income = 30000,
            Mortgage = false
        };
        var json = JsonConvert.SerializeObject(applicantRequest);
        var requestBody = new StringContent(json);
        requestBody.Headers.Remove("Content-Type");
        requestBody.Headers.Add("Content-Type", "application/json");
        //act        
        var result = await httpClient.PostAsync("/scores", requestBody);
        var resultObject = await result.Content.ReadAsStringAsync();
        // assert            
        Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        Assert.NotEmpty(resultObject);
    }
}