﻿using System;
namespace DSAProject
{
	public class TwoSum
	{
        public int[] TwoNumSum(int[] nums, int target)
        {
            int length = nums.Length;
            int[] output = { };
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output = output.Append(i).ToArray();
                        output = output.Append(j).ToArray();
                    }
                }
            }
            return output;
        }
    }
}

