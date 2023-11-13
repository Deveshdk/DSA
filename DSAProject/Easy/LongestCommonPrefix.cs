using System;
namespace DSAProject.Easy
{
	public class LongestCommonPrefix
	{
		public string LongestCommonPrefixx(string[] str)
		{
			string output="";
                for (int i = 0; i < str[0].Length; i++)
                {
                    foreach (string s in str)
                    {
                        if (s[i] == str[0][i])
                        {

                        }
                    }
                output += str[i][i];
                }
			return output;
		}
	}
}

