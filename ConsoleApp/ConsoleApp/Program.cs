
var stack = new Stack();
stack.Push(1);
stack.Push(3);
stack.Push(5);

Console.WriteLine(stack.Pop()); // 5
Console.WriteLine(stack.Peek()); // 3
Console.WriteLine(stack.Pop()); // 3

public class Stack
{
    private List<int> _stack = new List<int>();

    public void Push(int item)
    {
        _stack.Add(item);
    }

    public int Pop()
    {
        var item = _stack.Last();
        _stack.Remove(item);
        return item;
    }

    public int Peek()
    {
        return _stack.Last();
    }
}