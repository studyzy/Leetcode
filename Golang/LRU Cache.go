package Golang

type LRUCache struct {
	size       int
	capacity   int
	cache      map[int]*DLinkedNode
	head, tail *DLinkedNode
}

//双向链表
type DLinkedNode struct {
	key, value int
	prev, next *DLinkedNode
}

func newDLinkedNode(key, value int) *DLinkedNode {
	return &DLinkedNode{
		key:   key,
		value: value,
	}
}

func Constructor(capacity int) LRUCache {
	lru := LRUCache{
		size:     0,
		capacity: capacity,
		cache:    make(map[int]*DLinkedNode),
		head:     newDLinkedNode(0, 0),
		tail:     newDLinkedNode(0, 0),
	}
	lru.head.next = lru.tail
	lru.tail.prev = lru.head
	return lru
}

func (this *LRUCache) Get(key int) int {
	node, ok := this.cache[key]
	if !ok {
		return -1
	}
	this.moveNode2Head(node)
	return node.value
}

func (this *LRUCache) Put(key int, value int) {
	//exist?
	node, ok := this.cache[key]
	if ok {
		node.value = value
		this.moveNode2Head(node)
		return
	}
	//not exist
	//overflow? remove tail
	if this.size >= this.capacity {
		this.removeTailNode()
	}
	this.addNode2Head(key, value)
}

func (this *LRUCache) moveNode2Head(node *DLinkedNode) {
	//remove from old place
	node.prev.next = node.next
	node.next.prev = node.prev
	//set head
	node.next = this.head.next
	node.next.prev = node

	this.head.next = node
	node.prev = this.head
}
func (this *LRUCache) removeTailNode() {
	node := this.tail.prev
	delete(this.cache, node.key)
	this.size--

	this.tail.prev = node.prev
	node.prev.next = this.tail
}
func (this *LRUCache) addNode2Head(key, value int) {
	node := newDLinkedNode(key, value)
	this.cache[key] = node
	this.size++

	//set head
	node.next = this.head.next
	node.next.prev = node

	this.head.next = node
	node.prev = this.head

}
