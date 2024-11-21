public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var i = 0;
        do
        {
            if (IsCompletelyHidden())
            {
                break;
            }

            var word = _words[random.Next(_words.Count)];
            if (word.IsHidden())
            {
                continue;
            }

            word.Hide();
            i++;
        } while (i < numberToHide);
    }

    public string GetDisplayText()
    {
        List<string> words = [];
        words.AddRange(_words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {string.Join(" ", words)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}