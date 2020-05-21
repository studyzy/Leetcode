package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestBuildTree(t *testing.T){
	str:="1,2,3,null,5"
	root:=buildTree(str)
	assert.Equal(t,2,root.Left.Val)
	assert.Equal(t,3,root.Right.Val)
	assert.Nil(t,root.Left.Left)
	assert.Equal(t,5,root.Left.Right.Val)
}
