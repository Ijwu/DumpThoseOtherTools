<Query Kind="Program">
  <Namespace>Microsoft.AspNetCore.Builder</Namespace>
  <IncludeAspNet>true</IncludeAspNet>
</Query>

/// <summary>
/// 	In the Query Properties window (F4) you can check the "Reference ASP.NET Core Assemblies" to easily add ASP.NET Core functionality to a query.
/// 	After checking the box and hitting "OK" you can add the relevant namespaces and create a web application.
/// 
/// 	The example below produces random numbers for clients, optionally within a bounds. The example attempts to demonstrate using LINQPad to easily
/// 	store state for use within the query.
/// </summary>

Random rng = new Random();
int? lowerBound = null;
int? upperBound = null;

void Main()
{
	var builder = WebApplication.CreateBuilder();
	var app = builder.Build();
	app.MapGet("/", () =>
	{	
		if (lowerBound != null && upperBound != null)
		{
			return rng.Next(lowerBound.Value, upperBound.Value);
		}
		return rng.Next();
	});
	
	app.MapPost("/", async (context) => 
	{
		await context.Request.ReadFormAsync();
		lowerBound = Convert.ToInt32(context.Request.Form["lower"].First());
		upperBound = Convert.ToInt32(context.Request.Form["upper"].First());
	});
	
	app.MapDelete("/", () =>
	{
		lowerBound = null;
		upperBound = null;
	});
	
	app.Run();
}