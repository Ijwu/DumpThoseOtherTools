<Query Kind="Program" />

/// <summary>
///     We've previously introduced the LINQPad.Util class. It offers more than just customizing your Dump() output, though.
///     In this example we'll go over some of its contents in a high level overview.
/// </summary>

record ObjectForDiffing(string Name, List<int> FavoriteNumbers);

void Main()
{
    // Lots of `Util` just includes metadata or information about the current execution context.
    $"Use of {nameof(Util.AssemblyLoadContext)} allows you to load assemblies at runtime.".Dump();
    $"{nameof(Util.AssemblyResolver)} could also play a part in this.".Dump();
    $"{nameof(Util.BrowserEngine)} provides information about the WebView engine powering the rich text output in the results pane.".Dump();
    
    // Info on current query and execution.
    Util.CurrentCxString.Dump("CurrentCxString");
    Util.CurrentDataContext.Dump("CurrentDataContext");
    Util.CurrentQuery.Dump("CurrentQuery");
    Util.CurrentQueryPath.Dump("CurrentQueryPath");
    Util.HostProcessID.Dump("HostProcessId");
    Util.HostWindowHandle.Dump("HostWindowHandle");
    Util.IsDarkThemeEnabled.Dump("IsDarkThemeEnabled");
    Util.LINQPadFolder.Dump("LINQPadFolder");
    Util.MyQueriesFolder.Dump("MyQueriesFolder");
    Util.NewProcess.Dump("NewProcess");
    
    // Info on current framework version.
    Util.Framework.VersionString.Dump("Framework.VersionString");

    // Util provides more than just metadata. It provides methods and extensions which give utility, typically when Dump()'d.
    // Object diffing is just one example.
    var obj1 = new ObjectForDiffing("Johnny", new List<int>{1,2,3,4,5});
    var obj2 = new ObjectForDiffing("Jon", new List<int>{6,7,8,4,5});
    var dif = Util.Dif(obj1, obj2).Dump("Util.Dif provides a quick and easy object Diff in your output!");
    dif.IsSame.Dump("Are the objects the same?");
    
    // Object merging is another example. A bit of an operation on the other side of the spectrum, eh?
    Util.Merge(obj1, obj2).Dump("Util.Merge allows for merging of object properties into one.");
    
    // If you like your output to be row-based versus column-based, Util.Pivot gets the job done.
    Util.Pivot(obj1).Dump("Who rotated me 90 degrees? Well, I guess that's what Pivot means.");
}