namespace iterator_design_pattern.iterator;
public interface IIterator<T>
{
    bool HasNext();
    T Current();
    void Next();
}