public class MinStack
{
    int minValue = int.MaxValue;

    private Stack<(int value, int minValue)> stack;
    
    public MinStack()
    {
        stack = new Stack<(int value, int minValue)>();
    }

    public void Push(int val)
    {
        if (val < minValue)
        {
            minValue = val;
        }
        
        stack.Push((val, minValue));
    }

    public void Pop()
    {
        stack.Pop();

        if (stack.Count > 0)
        {
            minValue = stack.Peek().minValue;
        }
        else
        {
            minValue = int.MaxValue;
        }
    }

    public int Top()
    {
        return stack.Peek().value;
    }

    public int GetMin()
    {
        return minValue;
    }
}