package Golang

func buildArray(target []int, n int) []string {
	result := []string{}
	p := 0
	for i := 1; i <= n; i++ {
		if p == len(target) {
			return result
		}
		if target[p] == i {
			result = append(result, "Push")
			p++
		} else if i < target[p] {
			result = append(result, "Push", "Pop")
		}
	}
	return result
}
