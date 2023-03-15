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
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace KMCBinarySearchTree
{
    internal class KMCBinarySearchTree
    {
        #region enum
        public enum Traversal : byte {  InOrder, PreOrder, PostOrder };
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
