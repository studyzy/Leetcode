package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestIsMatch(t *testing.T){

	table:=[]struct{s,p string;match bool}{
		{s:"aa",p:"a",match:false},
		{s:"aa",p:"a.",match:true},
		{s:"aab",p:"c*a*b",match:true},
	}
	for _,row:=range table{
		result:=isMatch(row.s,row.p)
		assert.Equal(t,row.match,result,row.p)
	}
}