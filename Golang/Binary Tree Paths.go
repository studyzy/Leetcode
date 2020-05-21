package Golang

import "strconv"

func binaryTreePaths(root *TreeNode) []string {
	var res []string
	f(root, "", &res)
	return res
}

func f(root *TreeNode, s string, res *[]string) {
	if root != nil {
		if s == "" {
			s = strconv.Itoa(root.Val)
		} else {
			s += "->" + strconv.Itoa(root.Val)
		}
		f(root.Left, s, res)
		f(root.Right, s, res)
		if root.Left == nil && root.Right == nil {
			*res = append(*res, s)
		}
	}
}



//我自己写的太丑了，还是看别人的递归写法吧
//func binaryTreePaths(root *TreeNode) []string {
//	if root==nil{
//		return []string{}
//	}
//	if root.Left==nil && root.Right==nil{
//		return []string{strconv.Itoa( root.Val)}
//	}
//	cache:=make(map[*TreeNode]string)
//	result:=&[]string{}
//	cache[root]=strconv.Itoa( root.Val)
//	if root.Left!=nil{
//		printPath(root.Left,root,cache,result)
//	}
//	if root.Right!=nil{
//		printPath(root.Right,root,cache,result)
//	}
//	return *result
//}
//func printPath(node,parent *TreeNode,cache map[*TreeNode]string,result *[]string)   {
//	if node.Left==nil && node.Right==nil{
//		*result=append(*result, cache[parent]+"->"+strconv.Itoa( node.Val))
//		return
//	}
//	cache[node]=cache[parent]+"->"+strconv.Itoa( node.Val)
//	if node.Left!=nil{
//		printPath(node.Left,node,cache,result)
//	}
//	if node.Right!=nil{
//		printPath(node.Right,node,cache,result)
//	}
//}
