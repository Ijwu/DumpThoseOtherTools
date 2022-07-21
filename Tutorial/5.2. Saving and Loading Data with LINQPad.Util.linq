<Query Kind="Statements" />

/// <summary>
///     LINQPad.Util offers a few functions made to save and load various types of data between query executions.
///     These may be used to cache long-running enumerations, save strings or bytes, or retrieve passwords from LINQPad's password manager.
/// </summary>

Util.SaveString("cacheKey", "StringDataToSave");
Util.LoadString("cacheKey").Dump("Saved string data...");

Util.SaveBytes("bytesCacheKey", Encoding.Default.GetBytes("Converted string to bytes."));
Util.LoadBytes("bytesCacheKey").Dump("Saved bytes data...", collapseTo: 0);

Util.SetPassword("secret.application.password", "SecretPassword");
Util.GetPassword("secret.application.password").Dump("Secret password retrieved from password manager...");

Console.ReadLine();

Util.GetPassword("other.application.password").Dump("Password retrieved from user prompt...");
Util.GetPassword("other.application.password").Dump("Password retrieved from password manager after saved from prompt.");