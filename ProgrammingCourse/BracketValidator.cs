// bracket validation
//var text = "(a)(b)(c)[{(test)}](text)[12][{x}{y}](abc)";
//var validator = new BracketValidator();

//var good1 = "(a)(b)(c)[{(test)}](text)[12][{x}{y}](abc)";
//var good2 = "[][][]";
//var good3 = "[{()()()}]";
//var good4 = "{}[]{}[](){[([]{{{}}}[])]}";

//Console.WriteLine($"Validation for: {good1} is {validator.Validate(good1)}");
//Console.WriteLine($"Validation for: {good2} is {validator.Validate(good2)}");
//Console.WriteLine($"Validation for: {good3} is {validator.Validate(good3)}");
//Console.WriteLine($"Validation for: {good4} is {validator.Validate(good4)}");

//var wrong1 = "(a)(b)(c)[{(test)}](text)[12][{x}{y}](abc";
//var wrong2 = "[][][][";
//var wrong3 = "[{()()()}]}";
//var wrong4 = "{}]{}";

//Console.WriteLine($"Validation for: {wrong1} is {validator.Validate(wrong1)}");
//Console.WriteLine($"Validation for: {wrong2} is {validator.Validate(wrong2)}");
//Console.WriteLine($"Validation for: {wrong3} is {validator.Validate(wrong3)}");
//Console.WriteLine($"Validation for: {wrong4} is {validator.Validate(wrong4)}");

public class BracketValidator
{
    public BracketValidator()
    {
    }

    public bool Validate(string text)
    {
        var brackets = new string[] { "()", "[]", "{}" };
        var stack = new Stack<char>();
        foreach (var letter in text)
        {
            if (brackets.Any(b => b[0] == letter))
            {
                stack.Push(letter);
            }

            if (brackets.Any(b => b[1] == letter))
            {
                if(stack.Count == 0) return false;

                if (brackets.First(b => b[1] == letter)[0] != stack.Pop())
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}