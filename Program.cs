using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
            int[] nums = {2, 0};
            bool value = CanJump(nums);
            Console.WriteLine($"Value: {value}");
            Console.WriteLine("...End");
        }

        static bool CanJump(int[] nums){
            int finishIndex = nums.Length - 1;

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if(i + nums[i] >= finishIndex)
                {
                    if (i == 0) return true;
                    finishIndex = i;
                }
            }

            return false;
        }
    }
}
