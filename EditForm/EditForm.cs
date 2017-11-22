using ConnectToHostDLL;
using DrawMatrixDLL;
using GitCalc;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditForm
{
    public partial class EditMatrix : Form
    {
        private bool IsEnabled { get; set; }
        private bool IsChecked { get; set; }
        private bool btnStart { get; set; }
        private bool btnFinish { get; set; }
        private bool btnRoad { get; set; }
        private bool btnTower { get; set; }
        private bool btnGround { get; set; }
        private List<RectangleGame> list;
        RectangleGame matrix;
        Point DrawColorRed;
        Graphics g;
        ConnectToHost connectToHost;

        public EditMatrix()
        {
            DrawColorRed = new Point(0, 0);
            InitializeComponent();
            IsEnabled = false;
            list = new List<RectangleGame>();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            IsEnabled = true;
            
            try
            {
                if (!string.IsNullOrEmpty(txtBox_Width.Text) && !string.IsNullOrEmpty(txtBox_Length.Text))
                {
                    matrix = new RectangleGame();

                    if (int.Parse(txtBox_Length.Text) >= 100 && int.Parse(txtBox_Width.Text) >= 100) //якщо матриця >= (100, 100) -> матриця (100, 100)
                    {
                        matrix.Length = 100;
                        matrix.Width = 100;
                    }
                    else if (int.Parse(txtBox_Length.Text) >= 100) // якщо Length вимір матриці >= 100
                    {
                        matrix.Length = 100;
                        matrix.Width = int.Parse(txtBox_Width.Text);
                    }
                    else if (int.Parse(txtBox_Width.Text) >= 100) //якщо Width вимір матриці >= 100
                    {
                        matrix.Width = 100;
                        matrix.Length = int.Parse(txtBox_Length.Text);
                    }
                    else //якщо все нормас
                    {
                        matrix.Length = int.Parse(txtBox_Length.Text);
                        matrix.Width = int.Parse(txtBox_Width.Text);
                    }
                    GetLog($"**Create Matrix**\nMatrix Length, Width:{matrix.Length}, {matrix.Width}");

                    txtBox_Length.Text = matrix.Length.ToString();
                    txtBox_Width.Text = matrix.Width.ToString();

                    this.Invalidate(true);
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void txtBox_Width_KeyPress(object sender, KeyPressEventArgs e) // перевірка, чи користувач вводить цифру
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBox_Length_KeyPress(object sender, KeyPressEventArgs e) // та сама перевірка
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void EditMatrix_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            DrawMatrixClass drawMatrixClass = new DrawMatrixClass();
            if (IsEnabled)
            {
                
                list = drawMatrixClass.DrawRectangles(g, matrix.Width, matrix.Length);
            }
            if (IsChecked)
            {
                drawMatrixClass.ReDrawRectangles(g, list);
            }
            //if(DrawColorRed.X!=0 || DrawColorRed.Y!=0)
            //{
            //    Brush brush = new SolidBrush(Color.Black); // ініцалізація кісті
            //    g.FillRectangle(brush, DrawColorRed.X, DrawColorRed.Y, 30, 30); // заповнення кольорем елеметна матриці
            //    DrawColorRed.X = 0;
            //    DrawColorRed.Y = 0;
            //}
        }

        private void EditMatrix_MouseClick(object sender, MouseEventArgs e)
        {
            Point click = new Point(e.X, e.Y);
            List<RectangleGame> _list = new List<RectangleGame>();
            _list = list;
            for (int i = 0; i < list.Count; i++)
            {
                if(
                    ((click.X>list[i].Begin.X)&&(click.X<list[i].End.X)) &&
                    ((click.Y > list[i].Begin.Y) && (click.Y < list[i].End.Y))
                    )
                {
                    if (btnFinish == false)
                    {
                        list[i].Type = 3;
                        DrawColorRed.X = list[i].Begin.X;
                        DrawColorRed.Y = list[i].Begin.Y;
                        btnFinish = true;
                    }
                    if (btnStart == false)
                    {
                        list[i].Type = 2;
                        DrawColorRed.X = list[i].Begin.X;
                        DrawColorRed.Y = list[i].Begin.Y;
                        btnStart = true;
                    }
                    if (btnRoad == false)
                    {
                        list[i].Type = 4;
                        DrawColorRed.X = list[i].Begin.X;
                        DrawColorRed.Y = list[i].Begin.Y;
                        btnRoad = true;
                    }
                    if (btnTower == false)
                    {
                        list[i].Type = 1;
                        DrawColorRed.X = list[i].Begin.X;
                        DrawColorRed.Y = list[i].Begin.Y;
                        btnTower = true;
                    }
                    if (btnGround == false)
                    {
                        list[i].Type = 0;
                        DrawColorRed.X = list[i].Begin.X;
                        DrawColorRed.Y = list[i].Begin.Y;
                        btnGround = true;
                    }
                    if (_list[i].Type != list[i].Type)
                    {
                        GetLog($"element {list[i]} -> {list[i].Type}");
                    }
                    IsEnabled = false;
                    IsChecked = true;
                    Invalidate(true);
                }
            }
        }

        private void GetLog(string log)
        {
            rBox_log.Text += log + "\n";
        }

        private void pBoxTowerPlace_DragOver(object sender, DragEventArgs e)
        {
            
            if (IsChecked)
            {
                Point click = new Point(e.X, e.Y);
                for (int i = 0; i < list.Count; i++)
                {
                    if (
                        ((click.X > list[i].Begin.X) && (click.X < list[i].End.X)) &&
                        ((click.Y > list[i].Begin.Y) && (click.Y < list[i].End.Y))
                        )
                    {
                        list[i].Type = 1;
                        DrawColorRed.X = list[i].Begin.X;
                        DrawColorRed.Y = list[i].Begin.Y;

                        Invalidate(true);
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connectToHost.GetMapToByte(list);
            connectToHost.SendMessageToHost();
            //connectToHost.SendBytesToHost();
        }

        private void EditMatrix_Load(object sender, EventArgs e)
        {
            connectToHost = new ConnectToHost();
        }
        private void pBoxFinish_MouseClick(object sender, MouseEventArgs e)
        {
            btnFinish = false;

        }

        private void pBoxStart_MouseClick(object sender, MouseEventArgs e)
        {
            btnStart = false;
        }

        private void pBoxTowerPlace_MouseClick(object sender, MouseEventArgs e)
        {
            btnTower = false;
            IsChecked = true;
        }

        private void pBoxEnemyRoad_MouseClick(object sender, MouseEventArgs e)
        {
            btnRoad = false;
        }

        private void pBoxTower_MouseClick(object sender, MouseEventArgs e)
        {
            btnGround = false;
        }

        private void EditMatrix_FormClosed(object sender, FormClosedEventArgs e)
        {
            connectToHost.End();
        }
    }
}
