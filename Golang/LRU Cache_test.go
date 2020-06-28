package Golang

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestLRUCache_Get(t *testing.T) {
	cache := Constructor(2 /* 缓存容量 */)
	val := 0
	cache.Put(1, 1)
	cache.Put(2, 2)
	val = cache.Get(1) // 返回  1
	assert.Equal(t, 1, val)
	cache.Put(3, 3)    // 该操作会使得密钥 2 作废
	val = cache.Get(2) // 返回 -1 (未找到)
	assert.Equal(t, -1, val)
	cache.Put(4, 4)    // 该操作会使得密钥 1 作废
	val = cache.Get(1) // 返回 -1 (未找到)
	assert.Equal(t, -1, val)
	val = cache.Get(3) // 返回  3
	assert.Equal(t, 3, val)
	val = cache.Get(4) // 返回  4
	assert.Equal(t, 4, val)

}
