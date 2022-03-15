//define node class
public class node
{
    public int data;
    public node left;
    public node right;
    public node(int data){
        this.data = data;
        left = null;
        right = null;
    }
    public node(int data, node left, node right){
        this.data = data;
        this.left = left;
        this.right = right;
    }
}

//create a binary tree with root node
/*
    1
   / \
  2   3
 / \ / \
4  5 6  7
*/
root = new node(1, new node(2, new node(4), new node(5)), new node(3, new node(6), new node(7)));

public class BinaryTree{
    public node root;
    public BinaryTree(){
        root = null;
    }
    public BinaryTree(node root){
        this.root = root;
    }
    public void printTreeInOrder(node root){
        if(root == null){
            return;
        }
        printTreeInOrder(root.left);
        System.out.print(root.data + " ");
        printTreeInOrder(root.right);
    }
    public void printTreeInOrder(){
        printTreeInOrder(this.root);
    }
    public void printTreePreOrder(node root){
        if(root == null){
            return;
        }
        System.out.print(root.data + " ");
        printTreePreOrder(root.left);
        printTreePreOrder(root.right);
    }
    public void printTreePreOrder(){
        printTreePreOrder(this.root);
    }
    public void printTreePostOrder(node root){
        if(root == null){
            return;
        }
        printTreePostOrder(root.left);
        printTreePostOrder(root.right);
        System.out.print(root.data + " ");
    }
    public void printTreePostOrder(){
        printTreePostOrder(this.root);
    }
    public void printTreeLevelOrder(){
        Queue<node> q = new LinkedList<node>();
        q.add(root);
        while(!q.isEmpty()){
            node n = q.remove();
            System.out.print(temp.data + " ");
            if(n.left != null){
                q.add(n.left);
            }
            if(n.right != null){
                q.add(n.right);
            }
        }
    }
    public void printTreePreOrder(){
        printTreePreOrder(this.root);
    }
    public void printTree(){
        printTreeInOrder();
        System.out.println();
        printTreePreOrder();
        System.out.println();
        printTreePostOrder();
        System.out.println();
        printTreeLevelOrder();
    }
}

//create a binary tree with root node
binarytree = new BinaryTree(root);
//print the tree in every order
binarytree.printTree();



