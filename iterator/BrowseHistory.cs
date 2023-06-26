namespace iterator_design_pattern.iterator;
public class BrowseHistory
{
    private readonly List<string> _Urls = new();

    public void Push(string url) =>_Urls.Add(url);

    public string Pop()
    {
        var lastIndex = _Urls.Count - 1;
        var lastUrl = _Urls[lastIndex];
        _Urls.Remove(lastUrl);

        return lastUrl;
    }

    public IIterator<string> CreateIterator() => new ListIterator(this);
    public class ListIterator : IIterator<string>
    {
        private readonly BrowseHistory _history;
        private int _index;

        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }
        public string Current()
        {
            return _history._Urls.ElementAt(_index);
        }

        public bool HasNext()
        {
            return _index < _history._Urls.Count;
        }

        public void Next()
        {
            _index++;
        }
    }
}
