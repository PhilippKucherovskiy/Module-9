namespace DelegatePractices
{
    class MyException : Exception
        {
            public MyException(string message) : base(message) { }
        }

        class Program
        {
            static void Main()
        { Exception[] exceptions = {
            new DivideByZeroException(),
            new IndexOutOfRangeException(),
            new InvalidOperationException(),
            new MyException("My custom exception"),
            new ArgumentException()};
             
                try
                {
                    for (int i = 0; i < exceptions.Length; i++)
                    {
                        throw exceptions[i];
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Finally block executed.");
                }
            }
        }

    
}
