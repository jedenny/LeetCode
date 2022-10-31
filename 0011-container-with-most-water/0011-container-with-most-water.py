class Solution:
    def maxArea(self, height: List[int]) -> int:
        left = 0
        right = len(height)-1
        maxArea = 0
        leftHeight = height[left]
        rightHeight = height[right]
        while left < right:
            #calculate area
            minheight = min(leftHeight, rightHeight)
            width = right-left
            area = minheight*width
            if area > maxArea:
                maxArea = area
            
            #move the pointer
            if leftHeight < rightHeight:
                left = left+1
                leftHeight = height[left]
            else:
                right = right-1
                rightHeight = height[right]
            
        return maxArea
        