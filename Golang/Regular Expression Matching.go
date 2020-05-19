package Golang
//https://leetcode-cn.com/problems/regular-expression-matching/
//回溯法，给定一个字符串和表达式，只判断第一个字母是否匹配，如果相同或者是.，那么匹配，接下来判断表达式第二个字符是不是*，
//如果是*，则分两种情况：
//	1.	匹配0个，那么就递归用完整字符串和2个字符后的表达式比
//	2.	匹配1或多个，那么就把字符串去掉第一个字符，后面的字符串和完整的表达式比
//如果不是*，那么就字符串和表达式去掉第一个字符，剩下的递归重新比。
func isMatch(s string, p string) bool {
	if len(p)==0{
		return len(s)==0
	}
	 first_match := len(s)!=0 && (p[0] == s[0] || p[0] == '.')

	if (len(p) >= 2 && p[1] == '*'){
		return isMatch(s, p[2:]) ||
			(first_match && isMatch(s[1:], p))
	} else {
		return first_match && isMatch(s[1:], p[1:])
	}

}