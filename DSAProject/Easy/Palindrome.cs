using System;
namespace DSAProject.Easy
{
	public class Palindrome
	{
		public bool IsPalindrome(int x)
		{
            int r = 0, c = x;
            while (c > 0)
            {
                r = r * 10 + c % 10;
                c /= 10;
            }
            return r == x;
        }
	}
}

//public class Solution
//{
//    public bool IsPalindrome(int x)
//    {
//        var y = x.ToString().ToCharArray();
//        Array.Reverse(y); //Reverses char array.
//        return x.ToString() == new string(y);
//        //Checks if original string is equal to its reverse.
//    }
//}

