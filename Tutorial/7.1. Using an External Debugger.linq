<Query Kind="Statements">
  <Reference Relative="..\..\..\source\repos\ArchipelagoMW\Archipelago.MultiClient.Net\Archipelago.MultiClient.Net\bin\Debug\netstandard2.0\Archipelago.MultiClient.Net.dll">C:\Users\Ijwu\source\repos\ArchipelagoMW\Archipelago.MultiClient.Net\Archipelago.MultiClient.Net\bin\Debug\netstandard2.0\Archipelago.MultiClient.Net.dll</Reference>
  <Reference Relative="..\..\..\source\repos\ArchipelagoMW\Archipelago.MultiClient.Net\Archipelago.MultiClient.Net\bin\Debug\netstandard2.0\Newtonsoft.Json.dll">C:\Users\Ijwu\source\repos\ArchipelagoMW\Archipelago.MultiClient.Net\Archipelago.MultiClient.Net\bin\Debug\netstandard2.0\Newtonsoft.Json.dll</Reference>
  <Reference Relative="..\..\..\source\repos\ArchipelagoMW\Archipelago.MultiClient.Net\Archipelago.MultiClient.Net\bin\Debug\netstandard2.0\websocket-sharp.dll">C:\Users\Ijwu\source\repos\ArchipelagoMW\Archipelago.MultiClient.Net\Archipelago.MultiClient.Net\bin\Debug\netstandard2.0\websocket-sharp.dll</Reference>
</Query>

/// <summary>
///     LINQPad also allows for the attachment of an external debugger to the current LINQPad query. This allows you to use any other debugger, 
///     such as Visual Studio's built-in debugger, to track execution of the query. This is useful if you are referencing a class library in LINQPad
///     that is currently open in Visual Studio. You can use Visual Studio to set breakpoints into the class library and be capable of hitting them
///     from code that is run through LINQPad.
/// </summary>

Debugger.Launch();

Archipelago.MultiClient.Net.ArchipelagoSessionFactory.CreateSession("localhost");