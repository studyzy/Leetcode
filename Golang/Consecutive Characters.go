package Golang

func maxPower(s string) int {
	if len(s) == 0 {
		return 0
	}
	b := []byte(s)
	c := b[0]
	max := 1
	currentLen := 0
	for _, w := range b {
		if w == c {
			currentLen++
		} else {
			c = w
			if currentLen > max {
				max = currentLen
			}
			currentLen = 1
		}
	}
	if currentLen > max {
		max = currentLen
	}
	return max
}
