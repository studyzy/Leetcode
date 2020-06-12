package Golang

func checkIfExist(arr []int) bool {
	for i, a := range arr {
		for _, b := range arr[i+1:] {
			if a == b*2 || b == a*2 {
				return true
			}
		}
	}
	return false
}
