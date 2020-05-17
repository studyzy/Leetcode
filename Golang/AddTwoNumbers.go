package Golang
func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	step := 0
	var result, p *ListNode = nil, nil

	for {
		if l1 == nil && l2 == nil {
			break
		}
		a := 0
		if l1 != nil {
			a = l1.Val
		}
		b := 0
		if l2 != nil {
			b = l2.Val
		}
		val := a + b + step
		if val >= 10 {
			val -= 10
			step = 1
		} else {
			step = 0
		}
		if result == nil {
			result = &ListNode{Val: val}
			p = result
		} else {
			p.Next = &ListNode{Val: val}
			p=p.Next
		}
		if l1 != nil {
			l1 = l1.Next
		}
		if l2 != nil {
			l2 = l2.Next
		}
	}
	if step == 1 {
		p.Next = &ListNode{Val: 1}
	}
	return result
}