Simple basic authentication with one line of code for HttpClient().

```C#
using (var client = new HttpClient())
{
	httpClient.BaseAddress = new Uri("http://www.example.com/");
	httpClient.DefaultRequestHeaders.Authorization = BasicAuthentication.Create("username", "password");
	var result = httpClient.PostAsync("/api/users", new StringContent(json)).Result;

	// etc...
}
```