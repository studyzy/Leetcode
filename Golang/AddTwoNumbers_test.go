package Golang

import (
 "testing"

 "github.com/stretchr/testify/assert"
)

func TestAddTwoNumbers(t *testing.T) {
 l1 := buildListNodes([]int{2, 4, 3})
 l2 := buildListNodes([]int{5, 6, 4})
 result := addTwoNumbers(l1, l2)
 t.Log(printListNodes(result))
 assert.Equal(t, "7,0,8", printListNodes(result))
 l1=&ListNode{Val:5}
 l2=&ListNode{Val:5}
 result = addTwoNumbers(l1, l2)
 t.Log(printListNodes(result))
 assert.Equal(t, "0,1", printListNodes(result))

 l1=buildListNodes([]int{5, 4, 3})
 l2=&ListNode{Val:5}
 result = addTwoNumbers(l1, l2)
 t.Log(printListNodes(result))
 assert.Equal(t, "0,5,3", printListNodes(result))
}
