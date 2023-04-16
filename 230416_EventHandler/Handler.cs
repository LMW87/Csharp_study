class Program
{
    private void Calculate(int a)
    {
        a *= 2;
    }

    static void Main(string[] args)
    {
        Program p = new Program();

        int val = 100;
        p.Calculate(val);
        // val는 그대로 100        
    }
}