package Golang

import "fmt"

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