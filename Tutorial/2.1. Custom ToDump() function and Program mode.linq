<Query Kind="Program" />

/// <summary>
///     LINQPad allows for customizing Dump output for objects. You can add a ToDump() extension method to an existing type or create
///     a custom ToDump() in your own types.
/// </summary>

void Main()
{
    new QuestionAnswer().Dump();
    
    new QuestionAnswer()
    {
        Answer = 13,
        Question = "How many are in a baker's dozen?"
    }.Dump();
}

class QuestionAnswer
{
    public int Answer { get; set; } = 42;
    public string Question { get; set; } = "What is the answer to the most important question in the universe?";

    public string ToDump() => $"{Question} It is {Answer}";
}