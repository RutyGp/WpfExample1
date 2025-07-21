namespace ConsoleApp1
{
    internal class Program
    {
        public static int[] AAA(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int left = 0, right = c.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < b[i])
                {
                    c[left] = a[i];
                    left++;
                    c[right] = b[i];
                    right--;
                }
                else if (a[i] > b[i])
                {

                    c[left] = b[i];
                    left++;
                    c[right] = a[i];
                    right--;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    c[left] = a[i];
                    c[left+1] = b[i];
                    left+=2;

                }
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
