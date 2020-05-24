using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Main : Form
    {
        private int imageIndex = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void trvSelector_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            imageList.Images.Clear();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    imageList.Images.Add(Image.FromFile(openFileDialog.FileNames[i]));
                }

                pibImageViewer.Image = imageList.Images[imageIndex];
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (imageList.Images.Count - 1 != imageIndex && imageList.Images.Count > 0)
            {
                pibImageViewer.Image = imageList.Images[++imageIndex];
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                pibImageViewer.Image = imageList.Images[--imageIndex];
            }
        }
    }
}
