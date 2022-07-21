<Query Kind="Program">
  <NuGetReference>Castle.Core</NuGetReference>
  <NuGetReference>Refit</NuGetReference>
  <Namespace>Refit</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>Castle.DynamicProxy</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <DisableMyExtensions>true</DisableMyExtensions>
</Query>

/// <summary>
/// 	As a companion to the "Mini ASP.NET Core WebAPI" query, this query demonstrates using something like Refit to easily prototpye a REST API client.
/// 
/// 	As of July 2022, Refit does not seem to function within LINQPad. The ProxyRestService class is used as a polyfill.
/// </summary>

async Task Main()
{
	var client = ProxyRestService.For<IMiniWebApiClient>("http://localhost:5000");
	var randomNumber = await client.GetRandomNumberAsync();
	randomNumber.Dump();
	
	await client.SetLimitsAsync(new Limits(200, 250));
	randomNumber = await client.GetRandomNumberAsync();
	randomNumber.Dump();
	
	await client.ResetLimitsAsync();
}

public record Limits(int lower, int upper);

public interface IMiniWebApiClient 
{
	[Get("/")]
	Task<int> GetRandomNumberAsync();
	
	[Post("/")]
	Task SetLimitsAsync([Body(BodySerializationMethod.UrlEncoded)]Limits limits);
	
	[Delete("/")]
	Task ResetLimitsAsync();
}


/// <summary>
/// Necessary class for using Refit within LINQPad. Retrieved from: https://gist.github.com/bennor/c73870e810f8245b2b1d
/// </summary>
public class ProxyRestService
{
	static readonly ProxyGenerator Generator = new ProxyGenerator();

	public static T For<T>(HttpClient client, RefitSettings settings)
		where T : class
	{
		if (!typeof(T).IsInterface)
		{
			throw new InvalidOperationException("T must be an interface.");
		}

		var interceptor = new RestMethodInterceptor<T>(client, settings);
		return Generator.CreateInterfaceProxyWithoutTarget<T>(interceptor);
	}

	public static T For<T>(string hostUrl, RefitSettings settings)
		where T : class
	{
		var client = new HttpClient() { BaseAddress = new Uri(hostUrl) };
		return For<T>(client, settings);
	}

	public static T For<T>(string hostUrl)
		where T : class
	{
		var client = new HttpClient() { BaseAddress = new Uri(hostUrl) };
		return For<T>(client, null);
	}

	class RestMethodInterceptor<T> : IInterceptor
	{
		readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;
		readonly HttpClient client;
		readonly RefitSettings settings;

		public RestMethodInterceptor(HttpClient client, RefitSettings settings)
		{
			this.client = client;
			this.settings = settings;

			this.methodImpls = typeof(T).GetMethods().Select(m => m.Name).ToDictionary(k => k, v => RequestBuilder.ForType<T>(settings).BuildRestResultFuncForMethod(v));
		}

		public void Intercept(IInvocation invocation)
		{
			if (!methodImpls.ContainsKey(invocation.Method.Name))
			{
				throw new NotImplementedException();
			}
			invocation.ReturnValue = methodImpls[invocation.Method.Name](client, invocation.Arguments);
		}
	}
}
