
/*var stack = new Stack();
stack.Push(1);
stack.Push(3);
stack.Push(5);

Console.WriteLine(stack.Pop()); // 5
Console.WriteLine(stack.Peek()); // 3
Console.WriteLine(stack.Pop()); // 3
*/

Console.WriteLine(Exercises.RemoveDupeLetters("xyzzy"));
Console.WriteLine(Exercises.RemoveDupeWords("the quick brown fox jumps over the lazy dog the quick brown fox jumps over the lazy dog"));

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

class Exercises
{
    public static string RemoveDupeLetters(string str)
    {
        var set = new HashSet<char>();
        foreach (var s in str)
        {
            set.Add(s);
        }
        return string.Join("", set);
    }

    public static string RemoveDupeWords(string str)
    {
        var set = new HashSet<string>();
        foreach (var s in str.Split(" "))
        {
            set.Add(s);
        }
        return string.Join(" ", set);
    }
}