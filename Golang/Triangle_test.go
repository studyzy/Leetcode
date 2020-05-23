package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestMinimumTotal(t *testing.T) {
	triangle := [][]int{}
	triangle = append(triangle, []int{2})
	triangle = append(triangle, []int{3, 4})
	triangle = append(triangle, []int{6, 5, 7})
	triangle = append(triangle, []int{4, 1, 8, 3})
	min := minimumTotal(triangle)
	assert.Equal(t, 11, min)
	triangle = [][]int{}
	min = minimumTotal(triangle)
	assert.Equal(t, 0, min)
	triangle = append(triangle, []int{2})
	min = minimumTotal(triangle)
	assert.Equal(t, 2, min)
	triangle = append(triangle, []int{3, 4})
	min = minimumTotal(triangle)
	assert.Equal(t, 5, min)
}
