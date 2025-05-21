/*You are given the root of a binary search tree (BST) and an integer val.
Find the node in the BST that the node's value equals val and return the subtree rooted with that node. 
If such a node does not exist, return null. */

using System;

// Definition for a binary tree node given by leetcode
public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        //Tested on Leetcode
    }
    static TreeNode SearchBST(TreeNode root, int val)
    {
        // if root is null, return null
        // root val = target, return current node
        // Search is recursive
        // Similar to notes, instead of searching for individual nodes, find the subtree
        if (root == null)
            return null;
        else if (root.val == val)
            return root;
        else if (root.val < val)
            return SearchBST(root.right, val);
        else
            return SearchBST(root.left, val);
    }
}