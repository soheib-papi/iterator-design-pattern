using iterator_design_pattern.iterator;

var history = new BrowseHistory();

history.Push("A");
history.Push("B");
history.Push("C");

IIterator<string> iterator = history.CreateIterator();

while (iterator.HasNext())
{
    var item = iterator.Current();
    Console.WriteLine(item);
    iterator.Next();
}

Console.ReadLine();