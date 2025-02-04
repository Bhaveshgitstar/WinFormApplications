using System;

public class Child
{
    // Step 1: Define a delegate
    public delegate void NotifyParentEventHandler(object sender, EventArgs e);

    // Step 2: Declare an event
    public event NotifyParentEventHandler NotifyParent;

    // Method to raise the event
    protected virtual void OnNotifyParent()
    {
        if (NotifyParent != null)
        {
            NotifyParent(this, EventArgs.Empty);
        }
    }

    // Method to trigger the event
    public void DoSomething()
    {
        Console.WriteLine("Child is doing something...");
        OnNotifyParent();
    }
}

class Program
{
    //static void Main()
    //{
    //    Parent parent = new Parent();
    //    parent.StartProcess();
    //}
}