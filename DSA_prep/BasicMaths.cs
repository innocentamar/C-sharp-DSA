using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_prep
{
    public class BasicMaths : Program 
    { 
        public int countDigits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            return count;
        }
        public int reverseNumber(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                rev = rev * 10 + lastDigit;
                n = n / 10;
            }
            return rev;
        }
        public int sumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                sum = sum + lastDigit;
                n = n / 10;
            }
            return sum;
        }
        public int productOfDigits(int n)
        {
            int product = 1;
            while (n > 0)
            {
                int lastDigit = n % 10;
                product = product * lastDigit;
                n = n / 10;
            }
            return product;
        }
        public int power(int x, int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * x;
            }
            return result;
        }
        public bool checkPalindrome(int n)
        {
            int original = n;
            int rev = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                rev = rev * 10 + lastDigit;
                n = n / 10;
            }
            if (original != rev)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }
        public int factorial(int n)
        {
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public int[] reverseArray(int[] arr)
        {
            
            int start = 0;
            int end = arr.Length - 1;
            while(start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }
    }
}
