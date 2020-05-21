package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestRotateRight(t *testing.T){
	table:= []struct{head *ListNode;k int;expect *ListNode}{
		{head:buildListNodes([]int{1,2,3,4,5}),k:2,expect:buildListNodes([]int{4,5,1,2,3})},
		{head:buildListNodes([]int{1,2,3,4,5}),k:0,expect:buildListNodes([]int{1,2,3,4,5})},
		{head:buildListNodes([]int{0,1,2}),k:4,expect:buildListNodes([]int{2,0,1})},
		{head:buildListNodes([]int{1}),k:1,expect:buildListNodes([]int{1})},
	}
	for _,row:=range table{
		result:=rotateRight(row.head,row.k)
		t.Log(printListNodes(result))
		assert.Equal(t,printListNodes(row.expect),printListNodes(result),printListNodes(row.head))
	}
}