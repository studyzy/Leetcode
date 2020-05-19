package Golang

func lengthOfLongestSubstring(s string) int {
	if len(s)==0{
		return 0
	}
	ss:=[]byte(s)
	lastFindX:=make(map[byte]int)
	charIndex:=0
	maxLen:=1
	lastFindX[ss[0]]=0
	for i:=1;i<len(ss);i++{
		c:=ss[i]
		lastIndex,ok:=lastFindX[c]
		if ok && lastIndex>=charIndex{
			charIndex=lastIndex+1
		}
		lastFindX[c]=i
		currentLen:=i-charIndex+1
		if currentLen>maxLen{
			maxLen=currentLen
		}
	}
	return maxLen
}