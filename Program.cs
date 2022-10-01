namespace ProductOfArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,4};
            int[] result = ProductExceptSelf(nums);
            Console.WriteLine(string.Join(" ",result));
        }

        public static int[] ProductExceptSelf(int[] nums) {
        
            var res = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1) res[i] = nums[i];
                else res[i] = res[i + 1] * nums[i];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] * nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = (i == nums.Length - 1 ? 1: res[i + 1]) * (i ==0 ? 1: nums[i - 1]);
            }

            return res;
        }
    }
}