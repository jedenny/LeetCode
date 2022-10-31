class Solution:
    def findMin(self, nums: List[int]) -> int:
        #First thought: binary search
        n = len(nums)
        left = 0
        right = len(nums)-1
        val = nums[0]
        while True:
            index = math.floor((left + right) / 2)
            val = nums[index]
            leftval = nums[left]
            rightval=nums[right]
            if left == right:
                break
            elif leftval < rightval:
                right = index
            elif val < rightval:
                right = index
            else:
                left = index+1
        return val
    