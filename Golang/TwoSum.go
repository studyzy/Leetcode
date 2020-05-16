package Golang
//https://leetcode-cn.com/problems/two-sum/
func twoSum(nums []int, target int) []int {
	for i,a:=range nums{
		for j,b:=range nums[i+1:]{
			if a+b==target{
				return []int{i,i+j+1}
			}
		}
	}
	return []int{}
}
