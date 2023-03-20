namespace KMCBinarySearchTree
{
    partial class FormBinarySearchTree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelInOrder = new System.Windows.Forms.Label();
            this.listBoxInOrder = new System.Windows.Forms.ListBox();
            this.listBoxPreOrder = new System.Windows.Forms.ListBox();
            this.labelPreOrder = new System.Windows.Forms.Label();
            this.listBoxPostOrder = new System.Windows.Forms.ListBox();
            this.labelPostOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1050, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelInOrder
            // 
            this.labelInOrder.AutoSize = true;
            this.labelInOrder.Location = new System.Drawing.Point(355, 9);
            this.labelInOrder.Name = "labelInOrder";
            this.labelInOrder.Size = new System.Drawing.Size(116, 16);
            this.labelInOrder.TabIndex = 1;
            this.labelInOrder.Text = "In-Order Traversal";
            // 
            // listBoxInOrder
            // 
            this.listBoxInOrder.FormattingEnabled = true;
            this.listBoxInOrder.ItemHeight = 16;
            this.listBoxInOrder.Location = new System.Drawing.Point(358, 28);
            this.listBoxInOrder.Name = "listBoxInOrder";
            this.listBoxInOrder.Size = new System.Drawing.Size(340, 276);
            this.listBoxInOrder.TabIndex = 2;
            this.listBoxInOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxInOrder_SelectedIndexChanged);
            // 
            // listBoxPreOrder
            // 
            this.listBoxPreOrder.FormattingEnabled = true;
            this.listBoxPreOrder.ItemHeight = 16;
            this.listBoxPreOrder.Location = new System.Drawing.Point(12, 28);
            this.listBoxPreOrder.Name = "listBoxPreOrder";
            this.listBoxPreOrder.Size = new System.Drawing.Size(340, 276);
            this.listBoxPreOrder.TabIndex = 4;
            // 
            // labelPreOrder
            // 
            this.labelPreOrder.AutoSize = true;
            this.labelPreOrder.Location = new System.Drawing.Point(9, 9);
            this.labelPreOrder.Name = "labelPreOrder";
            this.labelPreOrder.Size = new System.Drawing.Size(127, 16);
            this.labelPreOrder.TabIndex = 3;
            this.labelPreOrder.Text = "Pre-Order Traversal";
            // 
            // listBoxPostOrder
            // 
            this.listBoxPostOrder.FormattingEnabled = true;
            this.listBoxPostOrder.ItemHeight = 16;
            this.listBoxPostOrder.Location = new System.Drawing.Point(704, 28);
            this.listBoxPostOrder.Name = "listBoxPostOrder";
            this.listBoxPostOrder.Size = new System.Drawing.Size(340, 276);
            this.listBoxPostOrder.TabIndex = 6;
            // 
            // labelPostOrder
            // 
            this.labelPostOrder.AutoSize = true;
            this.labelPostOrder.Location = new System.Drawing.Point(701, 9);
            this.labelPostOrder.Name = "labelPostOrder";
            this.labelPostOrder.Size = new System.Drawing.Size(133, 16);
            this.labelPostOrder.TabIndex = 5;
            this.labelPostOrder.Text = "Post-Order Traversal";
            // 
            // FormBinarySearchTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 316);
            this.Controls.Add(this.listBoxPostOrder);
            this.Controls.Add(this.labelPostOrder);
            this.Controls.Add(this.listBoxPreOrder);
            this.Controls.Add(this.labelPreOrder);
            this.Controls.Add(this.listBoxInOrder);
            this.Controls.Add(this.labelInOrder);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormBinarySearchTree";
            this.Text = "Binary Search Tree";
            this.Load += new System.EventHandler(this.FormBinarySearchTree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelInOrder;
        private System.Windows.Forms.ListBox listBoxInOrder;
        private System.Windows.Forms.ListBox listBoxPreOrder;
        private System.Windows.Forms.Label labelPreOrder;
        private System.Windows.Forms.ListBox listBoxPostOrder;
        private System.Windows.Forms.Label labelPostOrder;
    }
}

