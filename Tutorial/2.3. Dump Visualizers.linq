<Query Kind="Statements">
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
</Query>

/// <summary>
///     In this script we examine DumpContainers which allow us to have dynamic content in the results window.
///     We also explore the various visualizer types for objects which may be dumped. .Dump() can show you the world!
/// </summary>

var container = new DumpContainer();
container.Dump();

container.Content = new int[20, 20];

Util.Break();

container.Content = Util.Image ("http://www.linqpad.net/images/LINQPad.png");

Util.Break();

container.Content = Util.RawHtml ("<h1>This is big text</h1>");

Util.Break();

container.Content = XElement.Parse ("<root> <customer id='123'> <name>Joe Bloggs</name> </customer> </root>");

Util.Break();

container.Content = Util.OnDemand("Click me for a cookie.", () => "I lied, no cookie.");

Util.Break();

new GroupBox
{
    Header = "You can dump WPF and Windows Forms controls",
    Content = new TextBox
    {
        Text = "and they will render! You can use this to create custom visualizers."
    },
    Padding = new Thickness(5)
}.Dump();