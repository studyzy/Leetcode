package Golang

import "testing"

func TestBinaryTreePaths(t *testing.T)  {
	root:=buildTree("1,2,3,null,5")
	result:= binaryTreePaths(root)
	for _,s:=range result{
		t.Log(s)
	}
}