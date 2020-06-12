package Golang

func reformat(s string) string {
	str, num := []byte{}, []byte{}
	for _, c := range []byte(s) {
		if c >= '0' && c <= '9' {
			num = append(num, c)
		} else {
			str = append(str, c)
		}
	}
	if len(str)-len(num) > 1 {
		return ""
	}
	if len(str)-len(num) == 1 {
		return crossJoin(str, num)
	}
	if len(num)-len(str) <= 1 {
		return crossJoin(num, str)
	}
	return ""
}
func crossJoin(a, b []byte) string {
	result := []byte{}
	for i, c := range b {
		result = append(result, a[i], c)
	}
	if len(a) > len(b) {
		result = append(result, a[len(a)-1])
	}
	return string(result)
}
