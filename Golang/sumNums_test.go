package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestSumNums(t *testing.T) {
	table := []struct {
		N   int
		Sum int
	}{
		{N: 3, Sum: 6},
		{N: 100, Sum: 5050},
	}
	for _, row := range table {
		result := sumNums(row.N)
		assert.Equal(t, row.Sum, result, row.N)
	}
}
