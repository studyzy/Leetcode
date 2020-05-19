package Golang

import "testing"

func TestThreeSum(t *testing.T){
	array:=[]int{-1, 0, 1, 2, -1, -4}
	result:= threeSum(array)
	for _,row:=range result{
		t.Log(row)
	}

	array=[]int{0,0,0}
	result= threeSum(array)
	for _,row:=range result{
		t.Log(row)
	}
}
