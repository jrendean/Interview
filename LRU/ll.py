class Node:
    key = None
    value = None
    next = None

    def __init__(self, key, value):
        self.key = key
        self.value = value
        self.next = None

class List:
    head = None
    tail = None
    size = 0

    def debug(self):
        str = ""
        temp = self.head
        while (temp != None):
            str += "%s," % temp.value
            temp = temp.next
        print(str)

    def addToFront(self, node):
        if (node == None):
            return
        if (self.head == None and self.tail == None):
            self.head = node
            self.tail = node
            self.size += 1
        elif (self.head != None and self.tail != None):
            temp = self.head
            self.head = node
            self.head.next = temp
            self.size += 1
        else:
            raise Exception("adsf")

    def remove(self, node):
        if (node == None):
            return
        temp = self.head
        while (temp.next != node):
            temp = temp.next
        temp.next = node.next
        node.next = None
        self.size -= 1
        if (self.size == 1):
            self.tail = self.head

    def removeFromEnd(self):
        temp = self.head
        ret = self.tail
        while (temp.next != self.tail):
            temp = temp.next
        self.tail = temp
        self.tail.next = None
        self.size-=1
        return ret

if __name__ == '__main__DONTRUN':
    ll = List()
    ll.addToFront(Node("", 1))
    ll.addToFront(Node("", 2))
    ll.debug() # 2,1,
    a = ll.removeFromEnd() # 1
    ll.debug() # 2

    ll = List()
    ll.addToFront(Node("", 1))
    ll.addToFront(Node("", 2))
    ll.addToFront(Node("", 3))
    n = Node("", 4)
    ll.addToFront(n)
    ll.addToFront(Node("", 5))
    ll.addToFront(Node("", 6))
    ll.debug()

    ll.remove(n)
    ll.debug()

    a = ll.removeFromEnd()
    ll.debug()
    b = ll.removeFromEnd()
    ll.debug()
