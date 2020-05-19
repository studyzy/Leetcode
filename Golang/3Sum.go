package Golang

import "sort"

func threeSum(nums []int) [][]int {
	if len(nums)<3 {
		return nil
	}
	result:=[][]int{}
	sort.Ints(nums)
	for i,a:=range nums{
		if a>0{
			return result
		}
		if i>0 && a==nums[i-1]{
			continue
		}
		L:=i+1
		R:=len(nums)-1
		for L<R{
			if a+nums[L]+nums[R]==0{
				result=append(result,[]int{a,nums[L],nums[R]})
				for L<R && nums[L]==nums[L+1] {
					L++
				}
				for L<R && nums[R]==nums[R-1] {
					R --
				}
				L++
				R--
			}else if a+nums[L]+nums[R]>0{
				R--
			}else {
				L++
			}
		}
	}
	return result
}
