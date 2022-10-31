class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        n = len(nums)
        answerArr = [1]*n
        leftSoFar=1
        for i in range(0, n):
            answerArr[i] = leftSoFar
            leftSoFar = leftSoFar*nums[i]
        rightSoFar = 1
        for i in reversed(range(0, n)):
            answerArr[i] = answerArr[i]*rightSoFar
            rightSoFar = rightSoFar * nums[i]
        return answerArr
            