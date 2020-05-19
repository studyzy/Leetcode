package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestLengthOfLongestSubstring(t *testing.T){
	table:=[]struct{s string;length int}{
		{"", 0},
		{"a",1},
		{"abcabcbb",3},
		{"bbbbbbbb",1},
	}
	for _,row:=range table{
		result:=lengthOfLongestSubstring(row.s)
		assert.Equal(t,row.length,result,row.s)
	}
}
