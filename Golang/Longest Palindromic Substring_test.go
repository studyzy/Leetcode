package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestLongestPalindrome(t *testing.T){
	table:=make(map[string]string)
	table["babad"]="bab"
	table["cbbd"]="bb"
	for s,expect:=range table{
		result:=longestPalindrome(s)
		assert.Equal(t,expect,result,s)
	}
}