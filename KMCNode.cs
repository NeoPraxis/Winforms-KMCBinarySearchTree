/* ********************************************************************
 * Projct:      Binary Search Tree
 * File:        KMCNode
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
 * 0.2   KMC 03/15/2023                     
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMCBinarySearchTree
{
    /// <summary>
    /// The node class represents one element (or node) in the
    /// Binary Search Tree (BST). Items will be ordered by the
    /// keyValue in the acending order.
    /// </summary>
    internal class KMCNode
    {
        #region data
        #endregion data

        #region properties
        public int KeyValue { get; set; }
        public KMCNode leftChild { get; set; }
        public KMCNode rightChild { get; set; }
        #endregion properties

        #region constructor
        public KMCNode(int key)
        {
            KeyValue = key;
            leftChild = null;
            rightChild = null;
        }
        #endregion constructor

        #region methods
        /// <summary>
        /// This method returns the degree of the node, which is
        /// equivalent to the number of children
        /// </summary>
        /// <returns></returns>
        public int Degree()
        {
            int result = 0;

            // if it has both, || statements would not work, so we use two if statements***

            if (leftChild != null)
            {
                result++;
            }
            if (rightChild != null)
            {
                result++;
            }
            return result;
        }

        /// <summary>
        /// This routine is intended for debugging purposes
        /// and displays the contents of the node
        /// </summary>
        /// <returns></returns>
        public String Dump()
        {
            return String.Format("Key = {0}, Left Child = {1}, Right Child = {2}",
                KeyValue.ToString(),
                leftChild == null ? "null" : leftChild.KeyValue.ToString(),
                rightChild == null ? "null" : rightChild.KeyValue.ToString());

        }
        #endregion methods


    }
}
