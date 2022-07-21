<Query Kind="Program">
  <Namespace>LINQPad.Controls</Namespace>
</Query>

/// <summary>
///     LINQPad has a built-in HTML based UI library. This is separate from LINQPad's support for WinForms or WPF components.
/// 
///     Use this UI library to build quick and easy UIs for use within the LINQPad query results window. These UIs can have complex logic
///     associated with them without hassle due to being organized within a clean output (we hope).
/// </summary>

void Main()
{
    var totalClicksCounter = 0;
    var clickMeButton = new Button("Click me!");
    var howManyClicksLabel = new Label("0");

    // Events can be hooked on with a delegate which follows the `EventHandler` signature.
    clickMeButton.Click += (sender, eventargs) =>
    {
        totalClicksCounter++;
        howManyClicksLabel.Text = totalClicksCounter.ToString();
    };
    
    new WrapPanel(clickMeButton, howManyClicksLabel).Dump();
}

