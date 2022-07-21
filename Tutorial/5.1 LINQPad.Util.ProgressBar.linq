<Query Kind="Statements" />

/// <summary>
///     LINQPad.Util also offers a progress bar in case you'd like to update progress as a long running query executes.
///     This can be done by altering the built-in progress bar or dumping your own!
/// </summary>

// Create a new Util.ProgressBar object to have your own bar you can dump!
var progBar = new Util.ProgressBar().Dump();
progBar.Caption = "0/100";

foreach (var element in Enumerable.Range(0, 100))
{
    Thread.Sleep(100);
    var percentComplete = element+1;
    
    // Update Util.Progress to alter LINQPad's built-in progress bar percentage.
    Util.Progress = percentComplete;
    
    progBar.Caption = $"{percentComplete}/100";
    progBar.Percent = percentComplete;
}