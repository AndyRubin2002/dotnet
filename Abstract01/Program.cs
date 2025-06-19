internal class Program
{
    private static void Main(string[] args)
    {
        Demo d = new Myclass();
        d.Display("Dinesh");
        d.foo();
        d.show();
    }

    public abstract class Demo
    {
        public Demo()
        {
            Console.WriteLine("In Demo Constrictor");
        }
        public  abstract void Display(String nm);
        public abstract void foo();
        public void show()
        {
            Console.WriteLine("In show Method");
        }
    }

    public abstract class Test : Demo
    {
        protected Test()
        {
            Console.WriteLine("In Test Constructor");
        }
        public override void Display(string nm)
        {
            Console.WriteLine($"In Display Method{nm}");
        }

    }

    public class Myclass : Test
    {
        public Myclass()
        {
            Console.WriteLine("In Mytest Constructor");
        }
        public override void foo()
        {
            Console.WriteLine("In Foo Method");
        }
    }
}
