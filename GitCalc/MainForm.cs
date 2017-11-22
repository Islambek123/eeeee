using ConnectToHostDLL;
using DrawMatrixDLL;
using SendBytesToClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitCalc
{
    public partial class MainForm : Form
    {
        public bool LoadMatrix { get; set; }
        private List<RectangleGame> list;
        Graphics g;
        ConnectToHost connectToHost;
        //Thread thread;

        public MainForm()
        {
            InitializeComponent();
            list = new List<RectangleGame>();
            LoadMatrix = false;
            

        }

        private void btn_loadMatrix_Click(object sender, EventArgs e)
        {
            LoadMatrix = true;
            this.Invalidate(true);
            connectToHost.GetMapToByte(list);
            connectToHost.SendMessageToHost();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            if (LoadMatrix)
            {
                DrawMatrixClass drawMatrixClass = new DrawMatrixClass();
                list = drawMatrixClass.DrawRectangles(g, 10, 10);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connectToHost = new ConnectToHost();
        }
    }


}
