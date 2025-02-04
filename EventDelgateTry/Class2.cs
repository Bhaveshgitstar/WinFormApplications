namespace EventDelgateTry
{
    public class Class2
    {
        public static void Main()
        {
            Class1 sample = new Class1();

            MyDelegate1 myDelegate;
            myDelegate = sample.Add;
            myDelegate += sample.Multiply;

            myDelegate.Invoke(40, 50);


        }
    }
}
