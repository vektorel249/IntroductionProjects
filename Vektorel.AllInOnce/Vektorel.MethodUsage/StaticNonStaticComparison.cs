namespace Vektorel.MethodUsage
{
    class StaticNonStaticComparison
    {
        private int number; 
        private static int staticNumber; 
        public void Write(int value)
        {
            number = value;
        }

        public static void WriteToStatic(int value)
        {
            staticNumber = value;
        }
    }
}
