<Query Kind="Statements" />

/// <summary>
///     This script introduces the LINQPad "C# Statement(s)" mode, which allows for multiple statements in a file.
///     This mode is akin to creating a new Console application in Visual Studio and typing away in the Program.Main() function.
/// 
///     This script also introduces the .Dump() extension method. This method is available on all types and is exclusive to LINQPad.
///     .Dump() outputs a representation of an object into the Results Window (Ctrl+R).
/// 
///     LINQPad also outputs more complex object dumps when presented with more complex objects.
///     It can also output a string representation of more simple objects, such as with the Version object below.
/// 
///     For objects without a standard dump mechanic, LINQPad will output a representation that allows you to browse the
///     object state more easily. This can be seen with the MemoryStream object below.
/// </summary>

var integerList = new List<int>();

for (int i = 0; i < 100; i++)
{
    integerList.Add(i);
}

var dictionary = new Dictionary<string, string>()
{
	["TestKey"] = "TestValue",
	["TestKey2"] = "TestValue2"
};

var complexDictionary = new Dictionary<string, Dictionary<string, int>>()
{
	["Hussein"] = new Dictionary<string, int>()
	{
		["Math"] = 85,
		["English"] = 90,
		["Science"] = 85
	}
};

integerList.Where(x => x > 90).Dump();

dictionary.Dump();

complexDictionary.Dump();

new Version(1, 0, 0).Dump();

new MemoryStream().Dump();