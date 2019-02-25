using System;
using System.Collections.Generic;

namespace InterviewPrep
{
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            data = value;
            left = null;
            right = null;
        }
    }

    public class BST
    {
        public TreeNode head;
        public BST(){
            head = null;
        }
        public TreeNode Insert(int value, TreeNode root){
            if(root == null) root = new TreeNode(value);
            else if(value <= root.data) root.left = Insert(value, root.left);
            else root.right = Insert(value, root.right);
            return root;
        }

        public bool Lookup(int target, TreeNode root){
            if(root == null) return false;
            if(root.data == target) return true;            
            else if (target <= root.data) return Lookup(target, root.left);
            else return Lookup(target, root.right);
        }

        public void BreadthFirst(TreeNode root){
            if(root == null) return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while(!(q.Count == 0)){
                TreeNode node = q.Dequeue();
                Console.Write(node.data + "--> ");
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
        }

        public void PreOrder(TreeNode root){
            if (root == null) return;
            Console.Write(root.data + "--> ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void InOrder(TreeNode root){
            if (root == null) return;
            InOrder(root.left);
            Console.Write(root.data + "--> ");
            InOrder(root.right);
        }

        public void PostOrder(TreeNode root){
            if (root == null) return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data + "--> ");
        }

        public int FindMin(TreeNode root){
            if (root == null) throw new Exception("Empty tree");
            if(root.left != null) return FindMin(root.left);
            else return root.data;
        }

        public int FindMax(TreeNode root){
            if (root == null) throw new Exception("Empty list");
            if (root.right != null) return FindMax(root.right);
            else return root.data;
        }

        public int Height(TreeNode root){
            if (root == null) return -1;
            return Math.Max(Height(root.left), Height(root.right)) + 1;
        }
    }


}
