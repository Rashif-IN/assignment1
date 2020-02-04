using System;
using System.Linq;


namespace algorithm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Anagram*/
            //Console.WriteLine("type something!");
            //string A = Console.ReadLine();
            //Console.WriteLine("type something again!");
            //string B = Console.ReadLine();
            //Console.WriteLine(anagram(A, B));

            /*Array manipulation*/
            //int[] data = new int[] { 4, 2, 1, 3, 5 };
            //int[] sortedData = sort(data);
            //Console.WriteLine(String.Join(" ", sortedData));
            //int[] reverseData = reverse(data);
            //Console.WriteLine(String.Join(" ", reverseData));
            //int[] splicedData = splice(data, 3, 6);
            //Console.WriteLine(String.Join(" ", splicedData));

            /*caesar cipher*/ //blom
            Console.WriteLine("type something!");
            string sente = Console.ReadLine();
            string caesar1 = caesarCipher(sente, -100);
            Console.WriteLine(caesar1);

            /*fizbuzz*/
            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string A = fizbuzz(num);
            //Console.WriteLine(A);

            /*Iteration*/
            //int[] data2 = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(indexOf(data2, 3));
            //Console.WriteLine(lastIndex(data2));
            //Console.WriteLine(includes(data2, 5));
            //Console.WriteLine(includes(data2, 6));
            //int[] filledData2 = fill(data2, 3);
            //Console.WriteLine(String.Join(" ", filledData2));
            //Console.WriteLine(join(data2));
            //Console.WriteLine(sum(data2));

            /*Max Character*/
            //Console.WriteLine("type something!");
            //string senten = Console.ReadLine();
            //Console.WriteLine(maxCharacter(senten));

            /*palindrome*/
            //Console.WriteLine("type something!");
            //string sentence = Console.ReadLine();
            //Console.WriteLine(palindrome(sentence));

            /*recursion*/
            //Console.WriteLine("enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //long fact = GetFactorial(number);
            //Console.WriteLine($"{number} factorial is {fact}");

            /*Sorting Algorithm*/
            //int[] numAr = { 5, 4, 3, 2, 1 };
            //int[] bub = bubbleSort(numAr);
            //Console.WriteLine(String.Join(" ",bub));
            //int[] ins = insertionSort(numAr);
            //Console.WriteLine(String.Join(" ",ins));
            //int[] sel = selectionSort(numAr);
            //Console.WriteLine(String.Join(" ",sel));

            /*String Capitalization*/
            //Console.WriteLine("type something!");
            //string sen = Console.ReadLine();
            //string capitalized = capital(sen);
            //Console.WriteLine(capitalized);

            /*reverse string*/
            //Console.WriteLine("type something!");
            //string Sentence = Console.ReadLine();
            //string reversed = reversal(Sentence);
            //Console.WriteLine(reversed);
        }

        public static bool anagram(string A, string B)
        {
            char[] a = A.ToCharArray();
            char[] b = B.ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            int count = 0;
            for(int i = 0; i<a.Length;i++)
            {
                if(a[i]==b[i])
                {
                    count++;
                }
            }
            if(count==a.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static int [] sort (int [] data)
        {
            Array.Sort(data);
            return data;
        }
        
        public static int[] reverse(int[] data)
        { 
            Array.Reverse(data);
            return data;
        }

        public static int[] splice(int[] data, int start, int value)
        {
            int[] ans = new int[data.Length + 1];
            for(int i =0; i<ans.Length-1; i++)
            {
                if(i==start)
                {
                    ans[i] = value;
                    ans[i + 1] = data[i];
                }
                else if(i<start)
                {
                    ans[i] = data[i];
                }
                else if(i>start)
                {
                    ans[i + 1] = data[i];
                }
            }
            
            return ans;
        }

        public static string caesarCipher(string sen, int n)
        {
            char[] c = sen.ToCharArray();
            int shift = Math.Abs(n) % 26;
            if (n < 0)
            {
                shift = 26-shift;
            }
            for (int i = 0; i < c.Length; i++)
            {
                
                char letter = c[i];
                if (letter == ' '|| letter == '!' || letter == '.' || letter == ',' || letter == '?' || letter == '/' || letter == '-')
                {
                    continue;
                }
                else
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        if (letter > 'Z')
                        {
                            letter = (char)(letter - 32 - 26);
                        }
                        else if (letter < 'A')
                        {
                            letter = (char)(letter - 32 + 26);
                        }
                        else
                        {
                            letter = (char)(letter - 26);
                        }
                    }
                    else if (letter < 'a')
                    {
                        
                            letter = (char)(letter + 26);
                        
                        
                    }
                    c[i] = letter;
                }
               
            }
            return new string(c);
        }

        public static string fizbuzz(int n)
        {
            string ans = " ";
            if(n%2==0)
            {
                if(n%3==0)
                {
                    ans = "Fizz Buzz";
                }
                else
                {
                    ans = "Fizz";
                }
            }
            else if(n%3==0)
            {
                ans = "Buzz";
            }
            return ans;
        }

        public static int indexOf(int[] ar, int num)
        {
           int ans = 0;
           for(int i =0;i<ar.Length;i++)
            {
                if(ar[i]==num)
                {
                    ans = i;
                }
            }
            return ans;
        }

        public static int lastIndex(int[] ar)
        {
            return ar.Length-1;
        }

        public static bool includes(int[] ar, int num)
        {
            bool ans=false;
            foreach(int n in ar)
            {
                if (n == num)
                {
                    ans = true;
                }
              
            }
            return ans;
        }

        public static int [] fill (int [] ar, int num)
        {
            for(int i =0;i<ar.Length;i++)
            {
                ar[i] = num;
            }
            return ar;
        }

        public static string join(int [] ar)
        {
            return (String.Join("-", ar));
        }

        public static int sum(int [] ar)
        {
            return ar.Sum(); 
        }

        public static char maxCharacter(string sen)
        {
            sen = sen.Replace(" ", "");
            sen.ToLower();
            char[] let = sen.ToCharArray();
            Array.Sort(let);
            char max = ' ';
            int count = 1;
            int countMax = 0;
            for(int i =0; i<let.Length-1; i++)
            {
                if(let[i]==let[i+1])
                {
                    count++;
                }
                else
                {
                    if(count>countMax)
                    {
                        countMax = count;
                        max = let[i];
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return max;
        }

        public static bool palindrome(string sen)
        {
            sen = sen.Replace(" ", "");
            sen = sen.Replace("!", "");
            sen = sen.Replace("@", "");
            sen = sen.Replace("#", "");
            sen = sen.Replace("$", "");
            sen = sen.Replace("%", "");
            sen = sen.Replace("^", "");
            sen = sen.Replace("&", "");
            sen = sen.Replace("*", "");
            sen = sen.Replace("(", "");
            sen = sen.Replace(")", "");
            sen = sen.Replace("_", "");
            sen = sen.Replace("-", "");
            sen = sen.Replace("=", "");
            sen = sen.Replace("+", "");
            sen = sen.Replace(",", "");
            sen = sen.Replace(".", "");
            sen = sen.Replace("<", "");
            sen = sen.Replace(">", "");
            sen = sen.Replace("?", "");
            sen = sen.Replace("/", "");
            sen = sen.Replace(":", "");
            sen = sen.Replace(";", "");
            sen = sen.Replace("\"", "");
            sen = sen.Replace("|", "");
            sen = sen.Replace("\\", "");
            sen = sen.Replace("[", "");
            sen = sen.Replace("]", "");
            sen = sen.Replace("{", "");
            sen = sen.Replace("}", "");
            sen = sen.Replace("'", "");
            sen.ToLower();
            char[] ch = sen.ToCharArray();
            string rev = " ";
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = sen.Equals(rev, StringComparison.OrdinalIgnoreCase);
            return b;
        }

        public static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }

        public static int [] bubbleSort( int [] ar)
        {
            int num = 0;
            for (int i = 0; i <= ar.Length - 2; i++)
            {
                for (int j = 0; j <= ar.Length - 2; j++)
                {
                    if (ar[j] > ar[j + 1])
                    {
                        num = ar[j + 1];
                        ar[j + 1] = ar[j];
                        ar[j] = num;
                    }
                }
            }
            return ar;
        }

        public static int [] insertionSort(int [] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (ar[j - 1] > ar[j])
                    {
                        int temp = ar[j - 1];
                        ar[j - 1] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            return ar;
        }

        public static int [] selectionSort(int [] ar)
        {
            int smallest;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                smallest = i;
                for (int index = i + 1; index < ar.Length; index++)
                {
                    if (ar[index] < ar[smallest])
                    {
                        smallest = index;
                    }
                }
                int temporary = ar[i];
                ar[i] = ar[smallest];
                ar[smallest] = temporary;
            }
            return ar;
        }

        public static string capital(string sen)
        {

            char[] ch = (sen.Trim()).ToCharArray();
            ch[0] = char.ToUpper(sen[0]);
            string ans;

          
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == ' ')
                    {
                        ch[i + 1] = char.ToUpper(ch[i + 1]);
                    }
                }
                ans = new string(ch);
            
            
            return ans;
        }

        public static string reversal(string sen)
        {
            string reverse = "";
            
            int Length = sen.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + sen[Length];
                Length--;
            }
            return reverse;
        }
    }
}
