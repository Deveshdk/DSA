using System;
namespace DSAProject.Easy
{
	public class RomanToInteger
	{
        public int RomansToInteger(string input)
		{
			int output = 0;
			Dictionary<char, int> romanValues = new Dictionary<char, int>
			{
				{'I',1 },
				{'V',5 },
				{'X',10 },
				{'L',50 },
				{'C',100 },
				{'D',500 },
				{'M',1000 }
			};
			for(int i=0;i<input.Length;i++)
			{
				// if current roman is smaller than the next one, substract its value
				if(i<input.Length - 1 && romanValues[input[i]] < romanValues[input[i + 1]])
				{
					output -= romanValues[input[i]];
				}
				else
				{
					output += romanValues[input[i]];
				};
			};
			return output;
		}
	}
}


// Roman characters are essentially Unicode characters, and C# supports Unicode characters through the char type.
