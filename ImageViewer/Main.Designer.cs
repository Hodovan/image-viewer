namespace ImageViewer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2014");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2015");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Vacation", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.trvSelector = new System.Windows.Forms.TreeView();
            this.pibImageViewer = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pibImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // trvSelector
            // 
            this.trvSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvSelector.Location = new System.Drawing.Point(0, 0);
            this.trvSelector.Name = "trvSelector";
            treeNode10.Name = "Node1";
            treeNode10.Text = "2014";
            treeNode11.Name = "Node4";
            treeNode11.Text = "2015";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Vacation";
            this.trvSelector.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.trvSelector.Size = new System.Drawing.Size(130, 511);
            this.trvSelector.TabIndex = 0;
            this.trvSelector.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvSelector_NodeMouseDoubleClick);
            // 
            // pibImageViewer
            // 
            this.pibImageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pibImageViewer.Location = new System.Drawing.Point(142, 61);
            this.pibImageViewer.Name = "pibImageViewer";
            this.pibImageViewer.Size = new System.Drawing.Size(630, 438);
            this.pibImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImageViewer.TabIndex = 1;
            this.pibImageViewer.TabStop = false;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward.Location = new System.Drawing.Point(697, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 43);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackward.Location = new System.Drawing.Point(616, 12);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 43);
            this.btnBackward.TabIndex = 3;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "jpg";
            this.openFileDialog.Filter = "Image files|*.jpg";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(255, 255);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.pibImageViewer);
            this.Controls.Add(this.trvSelector);
            this.Name = "Main";
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pibImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvSelector;
        private System.Windows.Forms.PictureBox pibImageViewer;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ImageList imageList;
    }
}

