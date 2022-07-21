<Query Kind="Program">
  <Namespace>Xunit</Namespace>
</Query>

/// <summary>
///     LINQPad allows for easy integration with xunit, so you can quickly write tests to validate your code as you prototype it in LINQPad.
///     You can enable xunit support by clicking the "Query" menubar option and then clicking "Add XUnit Test Support". LINQPad will automatically
///     add the "xunit" query to your queries, it will then #load it into the current query, and then provide some sample code for you to learn from.
/// 
///     This query, besides this comment, is untouched from what LINQPad would provide for you.
/// 
///     You can easily execute tests using the Alt+Shift+T hotkey.
/// </summary>

#load "xunit"

void Main()
{
    RunTests();  // Call RunTests() or press Alt+Shift+T to initiate testing.
}

#region private::Tests

[Fact] void Test_Xunit() => Assert.True (1 + 1 == 2);

#endregion