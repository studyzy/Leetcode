package Golang
//https://leetcode-cn.com/problems/rotate-list/
//完全自己想的，肯定不是最优解
func rotateRight(head *ListNode, k int) *ListNode {
	if head==nil{
		return nil
	}
	root:=head
	len:=lenListNode(head)
	k=k%len
	if k==0{
		return root
	}
	var result *ListNode

	for i:=0;i<len;i++{

		if i==len-k{
				result=head
		}
		if i==len-k-1{
			t:=head.Next
			head.Next=nil
			head=t
		}else {
			if head.Next!=nil {
				head = head.Next
			}
		}
	}
	head.Next=root
	return result
}
func lenListNode(head *ListNode) int{
	len:=1
	for head.Next!=nil{
		len++
		head=head.Next
	}
	return len
}