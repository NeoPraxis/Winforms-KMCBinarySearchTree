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

        public FormBinarySearchTree()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(veryLonelyNode.Dump());
        }
    }
}
