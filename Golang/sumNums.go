package Golang

func sumNums(n int) int {
	total := 0
	var sum func(i int) bool
	sum = func(i int) bool {
		total += i
		return i == n || sum(i+1)
	}
	sum(0)
	return total
}
