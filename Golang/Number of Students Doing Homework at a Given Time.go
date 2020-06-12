package Golang

func busyStudent(startTime []int, endTime []int, queryTime int) int {
	count := 0
	for i, s := range startTime {
		if queryTime >= s && queryTime <= endTime[i] {
			count++
		}
	}
	return count
}
