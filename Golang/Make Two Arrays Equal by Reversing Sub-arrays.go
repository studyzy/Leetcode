package Golang

func canBeEqual(target []int, arr []int) bool {
	map1 := getMap(target)
	map2 := getMap(arr)
	return mapIsSame(map1, map2)
}
func getMap(target []int) map[int]int {
	map1 := make(map[int]int)
	for _, i := range target {
		if count, ok := map1[i]; ok {
			map1[i] = count + 1
		} else {
			map1[i] = 1
		}
	}
	return map1
}
func mapIsSame(map1, map2 map[int]int) bool {
	if len(map1) != len(map2) {
		return false
	}
	for k1, v1 := range map1 {
		v2, ok := map2[k1]
		if !ok {
			return false
		}
		if v1 != v2 {
			return false
		}
	}
	return true
}
