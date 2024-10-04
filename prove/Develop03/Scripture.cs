public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    public string Text { get; private set; }
    public ScriptureWord[] Words { get; private set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = text.Split().Select(word => new ScriptureWord(word)).ToArray();
    }

    public string GetTextWithHiddenWords()
    {
        return string.Join(" ", Words.Select(word => word.ToString()));
    }
}