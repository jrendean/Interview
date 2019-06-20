from ll import List, Node

class LRU:
    maxCount = 0
    dictionary = {}
    ll = List()

    def __init__(self, maxCount):
        self.maxCount = maxCount

    def debug(self):
        self.ll.debug()

    def get(self, key):
        if (key == None):
            return
        if (not self.dictionary.has_key(key)):
            return None
        node = self.dictionary[key]
        self.ll.remove(node)
        self.ll.addToFront(node)
        return node.value

    def set(self, key, data):
        if (key == None or data == None):
            return
        if (self.dictionary.has_key(key)):
            node = self.dictionary[key]
            node.Value = data
            self.ll.remove(node)
            self.ll.addToFront(node)
            self.dictionary[key] = node
        else:
            if (self.ll.size == self.maxCount):
                node = self.ll.removeFromEnd()               
                del self.dictionary[node.key]
            node = Node(key, data)
            self.ll.addToFront(node)
            self.dictionary[key] = node

if __name__ == '__main__':
    lru = LRU(3)

    print(lru.get("a")) # None
    lru.set("a", 1)
    lru.debug() # 1,
    lru.set("b", 2)
    lru.debug() # 2,1,
    print(lru.get("a")) # 1
    lru.debug() # 1,2,
    lru.set("c", 3)
    lru.debug() # 3,1,2,
    lru.set("d", 4)
    lru.debug() # 4,3,1,
    print(lru.get("b")) # None
    print(lru.get("c")) # 3
    lru.debug() # 3,4,1,
    lru.set("e", 5)
    lru.set("f", 6)
    lru.debug() # 6,5,3
    lru.set("g", 7)
    lru.debug() # 7,6,5
    lru.set("h", 8)
    lru.debug() # 8,7,6,