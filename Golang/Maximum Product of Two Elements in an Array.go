package Golang

//https://leetcode-cn.com/problems/maximum-product-of-two-elements-in-an-array/
func maxProduct(nums []int) int {
	top1, top2 := 0, 0
	for _, i := range nums {
		if i >= top1 {
			top2 = top1
			top1 = i
		} else if i > top2 {
			top2 = i
		}
	}

	return (top1 - 1) * (top2 - 1)
}
