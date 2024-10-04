public class ScriptureReference
{
    private string book;
    private int startChapter;
    private int startVerse;
    private int? endChapter;
    private int? endVerse;

    public ScriptureReference(string book, int startChapter, int startVerse)
        : this(book, startChapter, startVerse, null, null) { }

    public ScriptureReference(string book, int startChapter, int startVerse, int? endChapter, int? endVerse)
    {
        this.book = book;
        this.startChapter = startChapter;
        this.startVerse = startVerse;
        this.endChapter = endChapter;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (endChapter.HasValue && endVerse.HasValue)
            return $"{book} {startChapter}:{startVerse}-{endChapter}:{endVerse}";
        else
            return $"{book} {startChapter}:{startVerse}";
    }
}