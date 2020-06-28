package Golang

func isPathCrossing(path string) bool {
	points := make(map[Point]bool)
	current := Point{0, 0}
	points[current] = true
	for _, op := range []byte(path) {
		if op == 'E' {
			current = Point{current.X + 1, current.Y}
		} else if op == 'S' {
			current = Point{current.X, current.Y - 1}
		} else if op == 'W' {
			current = Point{current.X - 1, current.Y}
		} else if op == 'N' {
			current = Point{current.X, current.Y + 1}
		}
		if _, ok := points[current]; ok {
			return true
		}
		points[current] = true
	}
	return false
}

type Point struct {
	X, Y int
}
