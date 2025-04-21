

static int[] TwoSum(int[] nums, int target) {
       /* int TwoSum recieves two array nums and target as parameter 
       Method: Use dictionary
        Key = number itself, Value = index in array
       */
       Dictionary<int, int> map = new Dictionary<int, int>();
        // Loop through each element in the nums array
       for (int i = 0; i < nums.Length; i++) {
        
        // Calculate the number needed to reach target
        int complement = target - nums[i];
        // If number exist then returns index of complement and current index
        if (map.ContainsKey(complement)) {
            return new int[] {map[complement], i};
        }

        // if not found, add current number and its index to dictionary to check later
        map[nums[i]]= i;

       }

       // return empty if no solution found
       return new int[] {};       
    }