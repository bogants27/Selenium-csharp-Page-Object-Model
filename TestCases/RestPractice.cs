
using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ApiAutomation;

[TestFixture]
public class PostsApiTests
{
    private HttpClient _client = null!;

    [SetUp]
    public void SetUp()
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri(
                "https://jsonplaceholder.typicode.com/")
        };
    }

    [TearDown]
    public void TearDown()
    {
        _client.Dispose();
    }

    [Test]
    public async Task GetPost_ShouldReturnExpectedData()
    {
        // Act
        HttpResponseMessage response =
            await _client.GetAsync("posts/1");

        string json =
            await response.Content.ReadAsStringAsync();

        JObject post = JObject.Parse(json);

        // Assert
        Assert.That(
            response.StatusCode,
            Is.EqualTo(HttpStatusCode.OK));

        Assert.That((int?)post["id"], Is.EqualTo(1));
        Assert.That((string?)post["title"],
            Is.Not.Null.And.Not.Empty);
    }
}
