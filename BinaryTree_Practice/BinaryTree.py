class Node:
    def __init__(self, key):
        self.data = key
        self.left = None
        self.right = None
        
def LevelOrder(root):
    if root is None:
        return
    queue = []
    queue.append(root)
    while(len(queue) > 0):
        node = queue.pop(0)
        yield node.data
        if node.left:
            queue.append(node.left)
        if node.right:
            queue.append(node.right)
  
def InOrder(root):
  if root:
    for y in InOrder(root.left):
        yield y
    yield(root.data)
    for y in InOrder(root.right):
        yield y

def PostOrder(root):
    if root:
        for y in PostOrder(root.left):
            yield y
        for y in PostOrder(root.right):
            yield y
        yield root.data
  
def PreOrder(node):
    if node is not None:
        yield node.data
        for y in PreOrder(node.left):
            yield y
        for y in PreOrder(node.right):
            yield y
    
    
root = Node(1)
root.left = Node(2)
root.right = Node(3)
root.left.left = Node(4)
root.left.right = Node(5)
root.left.left.left = Node(6)
root.left.left.right = Node(7)

print( "Level Order:", list(LevelOrder(root)) )
print( "In Order:   ", list(InOrder(root))    )
print( "Post Order: ", list(PostOrder(root))  )
print( "Pre Order:  ", list(PreOrder(root))   )