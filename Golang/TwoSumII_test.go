package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestTwoSumII(t *testing.T){
	table:=[]struct {num []int;target int;result []int
	}{
		{num:[]int{2,7,11,15},target:9,result:[]int{1,2}},
		{num:[]int{2,7,11,15},target:18,result:[]int{2,3}},
		{num:[]int{2,7,11,15},target:26,result:[]int{3,4}},
	}
	for _,row:=range table {
		result := twoSum2(row.num, row.target)
		assert.Equal(t, row.result, result)
	}
}
