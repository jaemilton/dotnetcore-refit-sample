// See https://aka.ms/new-console-template for more information
using HttpClientExample.integrations;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Text.Json;

//var myIpApi = RestService.For<IMyIpApi>("https://api.my-ip.io");
//var myIp = await myIpApi.GetMyIpAsync();
//Console.WriteLine(JsonSerializer.Serialize(myIp));

//var objectRestfulApiDevApi = RestService.For<IReqResUsersApi>("https://reqres.in");
const string reqResUsersApiApiKey = "reqres-free-v1";
var serices = new ServiceCollection();
serices.AddRefitClient<IMyIpApi>();
serices.AddRefitClient<IReqResUsersApi>()
    //.AddHttpMessageHandler(() => new ApiKeyHeaderHandler("reqres-free-v1"))
    .ConfigureHttpClient(x => 
        x.BaseAddress = new Uri("https://reqres.in"));

var provider = serices.BuildServiceProvider();
var objectRestfulApiDevApi = provider.GetRequiredService<IReqResUsersApi>();


var responseGetAll = await objectRestfulApiDevApi.GetAllAsync();
Console.WriteLine(JsonSerializer.Serialize(responseGetAll));

var responseGetById = await objectRestfulApiDevApi.GetByIdAsync(4, reqResUsersApiApiKey);
Console.WriteLine(JsonSerializer.Serialize(responseGetById));

try
{
    responseGetById = await objectRestfulApiDevApi.GetByIdAsync(5000, reqResUsersApiApiKey);
    Console.WriteLine(JsonSerializer.Serialize(responseGetById));
}
catch (ApiException ex)
{
    // Translate the ApiException into an HttpResponseMessage
    var errorMessage = ex.HasContent ? ex.Content : $"API error: {ex.Message}";
    //return new HttpResponseMessage(ex.StatusCode)
    //{
    //    Content = new StringContent(errorMessage)
    //};

}

//var newUser = new UserDataRequest
//{
//    Email = "teste@yahoo.com",
//    First_Name = "Teste",
//    Last_Name = "Silva",
//    Avatar = "https://teste.com/avatar.jpg"
//};
//var responsePost = await objectRestfulApiDevApi.PostAsync(newUser, reqResUsersApiApiKey);
//Console.WriteLine(JsonSerializer.Serialize(responsePost));


