package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestTwoSum(t *testing.T){
	table:=[]struct {num []int;target int;result []int
	}{
		{num:[]int{2,7,11,15},target:9,result:[]int{0,1}},
		{num:[]int{2,7,15,11},target:9,result:[]int{0,1}},
		{num:[]int{2,11,7,15},target:22,result:[]int{2,3}},
	}
	for _,row:=range table {
		result := twoSum(row.num, row.target)
		assert.Equal(t, row.result, result)
	}
}
