Simple basic authentication with one line of code for HttpClient.

```c#
using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("http://www.example.com/");
    client.DefaultRequestHeaders.Authorization = BasicAuthentication.Create("username", "password");
    var result = client.PostAsync("/api/users", new StringContent(json)).Result;

    // etc...
}
```
