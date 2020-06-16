package Golang

import "sort"

func findLeastNumOfUniqueInts(arr []int, k int) int {
	numCount := make(map[int]int)
	for _, i := range arr {
		if count, ok := numCount[i]; ok {
			numCount[i] = count + 1
		} else {
			numCount[i] = 1
		}
	}
	countList := make([]int, 0, len(numCount))
	for _, v := range numCount {
		countList = append(countList, v)
	}
	sort.Ints(countList)
	removed := 0
	for i, count := range countList {
		if removed+count == k {
			return len(countList) - i - 1
		}
		if removed+count > k {
			return len(countList) - i
		}
		removed += count
	}
	return 0

}
