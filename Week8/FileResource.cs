namespace Week8;

public class FileResource: Resource, IDisposable
{
    public FileResource(string name) : base(name) { }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"{Name} is opened.");
    }
    
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"{Name} is closed.");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"{Name} was disposed.");
    }
}