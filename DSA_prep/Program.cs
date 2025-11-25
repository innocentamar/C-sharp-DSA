namespace DSA_prep
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            int []n = [1,2,3,4,5];
            BasicMaths bm = new BasicMaths();
            int[] digitCount = bm.reverseArray(n);
            foreach (var item in digitCount)
            {
                Console.Write(item + " ");
            }
              Console.ReadLine();
        }
        
    }
}
