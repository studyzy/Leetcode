package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestValidPalindrome(t *testing.T){
	table:=map[string]bool{"a":true,"ab":true,"aabb":false,"abccbaa":true}
	for s,v:=range table{
		result:=validPalindrome(s)
		assert.Equal(t,v,result,s)
	}
}