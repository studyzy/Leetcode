package Golang

import (
	"fmt"
	"strconv"
	"strings"
)

//func BuildListNodes( values string) *ListNode {
//var list = String2Int32List(values);
//return buildListNodes(list.ToArray());
//}
func buildListNodes( values []int) *ListNode {
	var result, p *ListNode = nil, nil
	for i, a := range values {
		node := &ListNode{Val: a}
		if i == 0 {
			result = node
		} else {
			p.Next = node

		}
		p = node
	}
	return result
}
func printListNodes(l *ListNode) string{
	result:=""
	for{
		if l==nil{
			break
		}
		result+=fmt.Sprintf("%d,",l.Val)
		l=l.Next
	}
	return result[:len(result)-1]
}
func Atoi(s string) int{
	i,_:=strconv.Atoi(s)
	return i
}
func buildTree(data string) *TreeNode{
	if len(data)==0|| data=="null"{
		return nil
	}
	 values:=strings.Split(data,",")
	 root:=NewTreeNodeValue(Atoi(values[0]))
	 index:=1
	 level:=1
	 levelNodes:=map[int][]*TreeNode{level:{root}}
	 for index<len(values) {
		 for i := 0; i < len(levelNodes[level]); i++ {
		 	if index==len(values){
		 		break
			}
			 value := values[index]
			 //left node
			 if value != "null" {
			 	node:=NewTreeNodeValue(Atoi(value))
				 levelNodes[level][i].Left = node
				 levelNodes[level+1]=append(levelNodes[level+1],node)
			 }
			 index++
			 value = values[index]
			 //right node
			 if value != "null" {
			 	node:=NewTreeNodeValue(Atoi(value))
				 levelNodes[level][i].Right = node
				 levelNodes[level+1]=append(levelNodes[level+1],node)
			 }

			 index++
		 }
		 level++
	 }
	 return root
}