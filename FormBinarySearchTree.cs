/* ********************************************************************
 * Projct:      Binary Search Tree
 * File:        FormBinaryTreeSearch
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
 * 0.3   KMC 03/20/2023 - added functionality to traverse the list in order
 *                     
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMCBinarySearchTree
{
    public partial class FormBinarySearchTree : Form
    {

        KMCNode veryLonelyNode = new KMCNode(57);

        KMCBinarySearchTree myBST = new KMCBinarySearchTree();

        public FormBinarySearchTree()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            myBST.Add(57);
            myBST.Add(5);
            myBST.Add(7);
            myBST.Add(75);

            // pre-order
            listBoxPreOrder.Items.Clear();

            foreach (KMCNode node in myBST.PreOrderTraversal())
            {
                listBoxPreOrder.Items.Add(node.Dump());
            }

            MessageBox.Show(veryLonelyNode.Dump());

            // in-order
            listBoxInOrder.Items.Clear();

            foreach (KMCNode node in myBST.InOrderTraversal())
            {
                listBoxInOrder.Items.Add(node.Dump());
            }

            MessageBox.Show(veryLonelyNode.Dump());

            // post-order
            listBoxPostOrder.Items.Clear();

            foreach (KMCNode node in myBST.PostOrderTraversal())
            {
                listBoxPostOrder.Items.Add(node.Dump());
            }

            MessageBox.Show(veryLonelyNode.Dump());

        }

        private void FormBinarySearchTree_Load(object sender, EventArgs e)
        {

        }

        private void listBoxInOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
