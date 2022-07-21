<Query Kind="Statements" />

/// <summary>
///     LINQPad provides a Util static class which contains a ton of useful methods and classes for integration with your queries.
///     In this query we'll look at ways to change your dump output using methods from LINQPad.Util.
///
/// 	We'll also look at some overloads of the Dump() function to see how it can be customizing within the call itself.2
/// </summary>

var integerValue = 42;
var stringValue = "Mr. Higginbottom bet all his money at the horse races.";

Util.HorizontalRun(true, integerValue, stringValue).Dump();
"".Dump();

Util.VerticalRun(integerValue, stringValue).Dump();
"".Dump();

Util.HorizontalRun(true, Util.Highlight(integerValue), Util.WithHeading(stringValue, "What happened to Mr. Higginbottom's money?")).Dump();

var objectList = Enumerable.Range(0, 100).Select(x => new { Int = x, String = x.ToString() });

objectList.Dump("Object list heading");

objectList.Dump(repeatHeadersAt: 20, noTotals: true, includePrivate: true);

objectList.Dump(true);