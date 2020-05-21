package Golang
func validPalindrome(s string) bool {
	p1:=0
	p2:=len(s)-1
	for p1<p2{
		if s[p1]!=s[p2]{
			return isPalindrome(s[p1+1:p2+1])||isPalindrome(s[p1:p2])
		}
		p1++
		p2--
	}
	return true
}
func isPalindrome(s string) bool{
	p1:=0
	p2:=len(s)-1
	for p1<p2{
		if s[p1]!=s[p2]{
			return false
		}
		p1++
		p2--
	}
	return true
}