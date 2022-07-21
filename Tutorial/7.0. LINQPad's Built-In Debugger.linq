<Query Kind="Statements" />

/// <summary>
///     The highest paid tier of LINQPad comes with a built in debugger. The debugger is full functional and has the ability to
///     break on breakpoints, move the current execution, inspect locals, and step through code.
/// 
///     You can turn on the debugger by placing a breakpoint by clicking in the left margin of the code editor or you can click
///     one of the "bug" buttons in the header margin to instruct LINQPad to break on any exception thrown OR only any unhandled exception.
/// 
///     LINQPad tracks current execution of your query, so you always know where the call stack is at. You can use the tracking cursor
///     to move the next statement to be executed.
/// </summary>

"Doing some calculation...".Dump();

Thread.Sleep(500);

"Some calculation of greater complexity, now...".Dump();

// Try skipping the Thread.Sleep() call entirely by dragging the execution cursor in the left margin.
var itTakesThisLongToCalculate = 1_000_000_000;
Thread.Sleep(itTakesThisLongToCalculate);

try
{
    // Try turning on "Break when exception is thrown" (Ctrl+') and see if you break on this line.
    throw new Exception();
}
catch (Exception)
{
    "Caught an exception...".Dump();
}


// Try turning on "Break when exception is unhandled" (Ctrl+U) and see if you break on this line.
throw new Exception();