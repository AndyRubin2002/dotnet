namespace AccessModifies
{
    public class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;

        }
        private int sub(int x, int y)
        {
            return x - y;
        }

        protected int multi(int x, int y)
        {
            return x * y;
        }

        internal int div(int x, int y)
        {
            return x / y;
        }
        protected internal int Mod(int x, int y)
        {
            return x % y;
        }
    }

    public class AdvMath : CMath{
        public void Demo()
        {
           Console.WriteLine($"Add:{Add(12, 23)} , multi:{multi(2, 4)} div : {10,2} , Mod :{10,2}");
        }
     }

}
