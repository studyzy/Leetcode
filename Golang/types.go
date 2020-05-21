package Golang
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}
func NewTreeNodeValue(val int) *TreeNode{
	return &TreeNode{
		Val:   val,
	}
}
func NewTreeNode(val int,left, right *TreeNode) *TreeNode{
	return &TreeNode{
		Val:   val,
		Left:  left,
		Right: right,
	}
}
type ListNode struct {
	Val  int
	Next *ListNode
}