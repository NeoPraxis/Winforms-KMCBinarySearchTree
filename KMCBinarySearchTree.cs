/* ********************************************************************
 * Projct:      Binary Search Tree
 * File:        KMCBinarySearchTree
 * Language:    C#
 * 
 * Desription:  This program will demonstrate a simple binary search tree
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 03/03/2023 - initial writing
 *                      - added degree
 * 0.2   KMC 03/15/2023 - make the pointers private
 *                      - added an add method
 *                      
 * 0.3   KMC 03/20/2023 - Add In Order Traversal
 *                     
 * *******************************************************************/
using System.Collections.Generic;

namespace KMCBinarySearchTree
{
    internal class KMCBinarySearchTree
    {
        #region enum
        public enum Traversal : byte { InOrder, PreOrder, PostOrder };
        #endregion enum

        #region properties

        // the root of the tree
        public KMCNode Root { get; set; }
        // the number of nodes in the tree
        public int Count { get; set; }
        #endregion properties

        #region data
        #endregion data

        #region constructor
        public KMCBinarySearchTree()
        {
            Root = null;
            Count = 0;
        }
        #endregion constructor

        #region methods
        /// <summary>
        /// This routine will add the past number to the binary tree if the number is already in the
        /// tree then the routine will return false
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns>returns true if the keyValue was added to the tree, false if the key
        /// value was not added to the tree</returns>
        public bool Add(int keyValue)
        {
            // We do not use new here because we are accessing existing nodes
            KMCNode before = null;
            KMCNode after = this.Root;

            // walk down the tree until we find the appropriate leaf (leaf is a node with at least
            // a single null child)
            while (after != null)
            {
                before = after;

                // if A is less than B
                if (keyValue.CompareTo(after.KeyValue) < 0)
                {
                    // go down the left chain
                    after = after.leftChild;
                }
                // if A is greater than B
                else if (keyValue.CompareTo(after.KeyValue) > 0)
                {
                    after = after.rightChild;
                }
                // if A is equal to B
                else
                {
                    // exit right stage
                    return false;
                }
            }

            // create a new node and store the value to be added
            KMCNode newNode = new KMCNode(keyValue);

            // add the node to the tree
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            // add to appropriate branch
            else
            {
                if (keyValue.CompareTo(before.KeyValue) < 0)
                {
                    // hang off the left child
                    before.leftChild = newNode;
                }
                else
                {
                    // hang off the right child
                    before.rightChild = newNode;
                }
            }
            return true;
        }
        /// <summary>
        /// PREORDER traversal
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KMCNode> PreOrderTraversal()
        {
            foreach (KMCNode node in PreOrderTraversal(this.Root))
            {
                yield return node;
            }
        }

        private IEnumerable<KMCNode> PreOrderTraversal(KMCNode currentParent)
        {
            if (currentParent != null)
            {
                // handle the parent 
                yield return currentParent;

                // handle left subtree
                foreach (KMCNode node in PreOrderTraversal(currentParent.leftChild))
                {
                    yield return node;
                }

                // handle right subtree
                foreach (KMCNode node in PreOrderTraversal(currentParent.rightChild))
                {
                    yield return node;
                }
            }
        }

        /// <summary>
        /// This method will traverse the binary search tree using an in order traversal (Left, Parent, Right)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KMCNode> InOrderTraversal()
        {
            foreach (KMCNode node in InOrderTraversal(this.Root))
            {
                yield return node;
            }
        }

        private IEnumerable<KMCNode> InOrderTraversal(KMCNode currentParent)
        {
            if (currentParent != null)
            {
                // handle left subtree
                foreach (KMCNode node in InOrderTraversal(currentParent.leftChild))
                {
                    yield return node;
                }

                // handle the parent 
                yield return currentParent;

                // handle right subtree
                foreach (KMCNode node in InOrderTraversal(currentParent.rightChild))
                {
                    yield return node;
                }
            }
        }

        public IEnumerable<KMCNode> PostOrderTraversal()
        {
            foreach (KMCNode node in PreOrderTraversal(this.Root))
            {
                yield return node;
            }
        }

        private IEnumerable<KMCNode> PostOrderTraversal(KMCNode currentParent)
        {
            if (currentParent != null)
            {


                // handle left subtree
                foreach (KMCNode node in PostOrderTraversal(currentParent.leftChild))
                {
                    yield return node;
                }

                // handle right subtree
                foreach (KMCNode node in PostOrderTraversal(currentParent.rightChild))
                {
                    yield return node;
                }

                // handle the parent 
                yield return currentParent;
            }
        }

        /// <summary>
        /// This routine will return the maximum key value in the subtree defined by the node
        /// </summary>
        /// <returns></returns>
        public int MaxValue()
        {
            return MaxValue(Root);
        }


        public int MaxValue(KMCNode node)
        {
            int value = node.KeyValue;

            while (node.rightChild != null)
            {
                value = node.rightChild.KeyValue;
                node = node.rightChild;
            }
            return value;
        }

        /// <summary>
        /// This routine will return the minimum keyValue in the subtree
        /// defined by the node
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>

        public int MinValue()
        {
            return MinValue(Root);
        }

        public int MinValue(KMCNode node)
        {
            int value = node.KeyValue;

            while (node.leftChild != null)
            {
                value = node.leftChild.KeyValue;
                node = node.leftChild;
            }

            return value;
        }

        #endregion methods
    }
}
