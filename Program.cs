internal class Program
{
    private static void Main(string[] args)
    {
        ulong end = ulong.MaxValue;

        List <string> palindromes = new List<string>();

        int count = 0;

        for (ulong i = 0; i < end; i++)
        {
            char[] tester = ULongToCharArray(i);

            List<bool> success = new List<bool>(tester.Length);

            if (1 < tester.Length)
            {
                for (int j = 0; j < tester.Length; j++)
                {
                    if (tester[j] == tester[tester.Length - 1 - j])
                    {
                        success.Add(true);
                    }
                    else
                    {
                        success.Add(false);
                    }
                }
            }
            else
            {
                success.Add(true);
            }

            bool isPalindrome = false;

            foreach (bool test in success)
            {
                if (test == true)
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome == true)
            {
                count++;

                if (count == 100)
                {
                    Console.WriteLine(i);
                    count = 0;
                }

                // Console.WriteLine(i);
                
                palindromes.Add(i.ToString());
            }
        }

        System.IO.File.WriteAllLines("AllPalindromesULong.txt", palindromes);
    }
    public static char[] ULongToCharArray(ulong value)
    {
        return value.ToString().ToCharArray();
    }
}