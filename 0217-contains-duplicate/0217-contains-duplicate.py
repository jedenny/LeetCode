class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        hashset = {}
        for item in nums:
            if(hashset.get(item) is not None):
                return True
            else:
                hashset[item] = 1
        return False