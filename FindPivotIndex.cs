﻿using System;
namespace Homework8
{
    public class Solution2
    {
        public int PivotIndex(int[] nums)
        {
            int n = nums.Length;
            int[] sumLeft = new int[n];
            int[] sumRight = new int[n];

            for (int i = 1; i < n; i++)
            {
                sumLeft[i] = sumLeft[i - 1] + nums[i - 1];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                sumRight[i] = sumRight[i + 1] + nums[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                if (sumLeft[i] == sumRight[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }

}

