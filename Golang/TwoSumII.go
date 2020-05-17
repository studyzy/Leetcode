package Golang
//https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted/
func twoSum2(numbers []int, target int) []int {
	i:=0
	j:=len(numbers)-1
	for{
		if numbers[i]+numbers[j]==target{
			return []int{i+1,j+1}
		}
		if numbers[i]+numbers[j]>target{
			j--
		}else{
			i++
		}
	}
	return []int{}
}
