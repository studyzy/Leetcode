package Golang

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestFindLeastNumOfUniqueInts(t *testing.T) {
	table := []struct {
		arr []int
		k   int
		exp int
	}{
		{arr: []int{5, 5, 4}, k: 1, exp: 1},
		{arr: []int{5, 5, 5, 4}, k: 2, exp: 1},
	}
	for _, row := range table {
		result := findLeastNumOfUniqueInts(row.arr, row.k)
		assert.Equal(t, row.exp, result)
	}
}
