using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Point PrewPoint;
        Point CurrentPoint;
        Graphics g;
        Color CurrentColor = Color.Black;
        int PenWidth;
        Polygon p = new Polygon();
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            palettePanel.BackColor = CurrentColor;
            backfonePanel.BackColor = Color.White;
            PenWidth = 1;    
            this.WindowState = FormWindowState.Maximized;
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            if (pencilPanel.BackColor != Color.Green)
            {
                HidePictures();
                pencilPanel.BackColor = Color.Green;
            }
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            if (brushPanel.BackColor != Color.Green)
            {
                HidePictures();
                brushPanel.BackColor = Color.Green;
            }
        }

        private void Line_Click(object sender, EventArgs e)
        {
            if (linePanel.BackColor != Color.Green)
            {
                HidePictures();
                linePanel.BackColor = Color.Green;
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            if (circlePanel.BackColor != Color.Green)
            {
                HidePictures();
                circlePanel.BackColor = Color.Green;
            }
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            if (polygonPanel.BackColor != Color.Green)
            {
                HidePictures();
                polygonPanel.BackColor = Color.Green;
            }
        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            if (eraserPanel.BackColor != Color.Green)
            {
                HidePictures();
                eraserPanel.BackColor = Color.Green;
            }
            CurrentColor = picture.BackColor;
        }

        Color col = Color.Black;
        private void Palette_Click(object sender, EventArgs e)
        {
            Palette();
        }

        private void Menu_fill_Click(object sender, EventArgs e)
        {
            if (menu_fill.BackColor == SystemColors.Control)
            {
                menu_fill.ForeColor = Color.White;
                menu_fill.BackColor = CurrentColor;
                if (menu_fill.BackColor == Color.White)
                {
                    menu_fill.ForeColor = Color.Black;
                }
            }
            else
            {
                menu_fill.BackColor = SystemColors.Control;
                if (menu_fill.ForeColor != Color.Black)
                {
                    menu_fill.ForeColor = Color.Black;
                }
            }
        }
        private void Backfone_Click(object sender, EventArgs e)
        {
            HidePictures();
            BackCl();
        }

        private void Menu_additionally_rect_Click(object sender, EventArgs e)
        {
            if (menu_additionally_rect.BackColor != Color.Green)
            {
                HidePictures();
                menu_additionally_rect.BackColor = Color.Green;
            }
        }

        private void Menu_additionally_square_Click(object sender, EventArgs e)
        {
            if (menu_additionally_square.BackColor != Color.Green)
            {
                HidePictures();
                menu_additionally_square.BackColor = Color.Green;
            }
        }

        private void Menu_additionally_circle_Click(object sender, EventArgs e)
        {
            if (menu_additionally_circle.BackColor != Color.Green)
            {
                HidePictures();
                menu_additionally_circle.BackColor = Color.Green;
            }
        }

        Point firstP, secondP;
        bool IsMoved = false;
        int width, height, leftX, leftY;
        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pencilPanel.BackColor == Color.Green || brushPanel.BackColor == Color.Green || eraserPanel.BackColor == Color.Green)
                {
                    PrewPoint = CurrentPoint;
                    CurrentPoint = e.Location;
                    Drawing();
                }

                if (linePanel.BackColor == Color.Green || circlePanel.BackColor == Color.Green || polygonPanel.BackColor == Color.Green 
                    || menu_additionally_rect.BackColor == Color.Green || menu_additionally_square.BackColor == Color.Green || menu_additionally_circle.BackColor == Color.Green)
                {
                    secondP = e.Location;
                    picture.Invalidate();
                    IsMoved = true;

                    if (circlePanel.BackColor == Color.Green)
                    {
                        width = (secondP.X - firstP.X) * 2;
                        height = (secondP.Y - firstP.Y) * 2;
                        leftX = 2 * firstP.X - secondP.X;
                        leftY = 2 * firstP.Y - secondP.Y;
                    }

                    if (polygonPanel.BackColor == Color.Green)
                    {
                        rad = (int)Math.Sqrt((secondP.X - firstP.X) * (secondP.X - firstP.X) + (secondP.Y - firstP.Y) * (secondP.Y - firstP.Y));
                        p.ToListPoints(points, firstP.X, firstP.Y, rad, AmountOfSides, Angle);
                    }

                    if (menu_additionally_rect.BackColor == Color.Green || menu_additionally_square.BackColor == Color.Green)
                    {
                        height = (secondP.Y - firstP.Y);
                        if (menu_additionally_square.BackColor == Color.Green)
                        {
                            width = height;
                        }
                        else
                        {
                            width = (secondP.X - firstP.X);
                        }
                    }

                    if (menu_additionally_circle.BackColor == Color.Green)
                    {
                        rad = (int)Math.Sqrt((secondP.X - firstP.X) * (secondP.X - firstP.X) + (secondP.Y - firstP.Y) * (secondP.Y - firstP.Y));
                        leftX = firstP.X - rad;
                        leftY = firstP.Y - rad;
                        width = 2 * rad;
                        height = 2 * rad;
                    }
                }
            }
        }

        bool IsChange = false;
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pencilPanel.BackColor == Color.Green || brushPanel.BackColor == Color.Green || eraserPanel.BackColor == Color.Green)
                {
                    CurrentPoint = e.Location;
                }

                if (linePanel.BackColor == Color.Green || circlePanel.BackColor == Color.Green || polygonPanel.BackColor == Color.Green
                    || menu_additionally_rect.BackColor == Color.Green || menu_additionally_square.BackColor == Color.Green || menu_additionally_circle.BackColor == Color.Green)
                {
                    firstP = e.Location;
                }

                IsChange = true;
            }
        }
        int rad;
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMoved == true)
            {
                if (linePanel.BackColor == Color.Green)
                {
                        g.DrawLine(new Pen(CurrentColor, PenWidth), firstP, secondP);      
                }

                if (circlePanel.BackColor == Color.Green)
                {
                    if (menu_fill.BackColor == SystemColors.Control)
                    {
                        g.DrawEllipse(new Pen(CurrentColor, PenWidth), leftX, leftY, width, height);
                    }
                    else
                    {
                        g.FillEllipse(new SolidBrush(CurrentColor), leftX, leftY, width, height);
                    }
                }

                if (polygonPanel.BackColor == Color.Green && AmountOfSides > 2)
                {
                    if (menu_fill.BackColor == SystemColors.Control)
                    {
                        g.DrawPolygon(new Pen(CurrentColor, PenWidth), points.ToArray());
                    }
                    else
                    {
                        g.FillPolygon(new SolidBrush(CurrentColor), points.ToArray());
                    }
                }

                if (menu_additionally_rect.BackColor == Color.Green || menu_additionally_square.BackColor == Color.Green)
                {
                    if (menu_fill.BackColor == SystemColors.Control)
                    {
                        g.DrawRectangle(new Pen(CurrentColor, PenWidth), firstP.X, firstP.Y, width, height);
                    }
                    else
                    {
                        g.FillRectangle(new SolidBrush(CurrentColor), firstP.X, firstP.Y, width, height);
                    }
                }

                if (menu_additionally_circle.BackColor == Color.Green)
                {
                    if (menu_fill.BackColor == SystemColors.Control)
                    {
                        g.DrawEllipse(new Pen(CurrentColor, PenWidth), new Rectangle(leftX, leftY, width, height));
                    }
                    else
                    {
                        g.FillEllipse(new SolidBrush(CurrentColor), new Rectangle(leftX, leftY, width, height));
                    }
                }

                picture.Invalidate();
                IsMoved = false;
            }
        }
        private void HidePictures()
        {
            if (pencilPanel.BackColor == Color.Green)
            {
                pencilPanel.BackColor = SystemColors.Control;
            }

            if (brushPanel.BackColor == Color.Green)
            {
                brushPanel.BackColor = SystemColors.Control;
            }

            if (linePanel.BackColor == Color.Green)
            {
                linePanel.BackColor = SystemColors.Control;
            }

            if (circlePanel.BackColor == Color.Green)
            {
                circlePanel.BackColor = SystemColors.Control;
            }

            if (polygonPanel.BackColor == Color.Green)
            {
                polygonPanel.BackColor = SystemColors.Control;
            }

            if (eraserPanel.BackColor == Color.Green)
            {
                eraserPanel.BackColor = SystemColors.Control;
            }

            if (eraserPanel.BackColor != Color.Green)
            {
                CurrentColor = col;
            }

            if (menu_additionally_rect.BackColor == Color.Green)
            {
                menu_additionally_rect.BackColor = SystemColors.Control;
            }

            if (menu_additionally_square.BackColor == Color.Green)
            {
                menu_additionally_square.BackColor = SystemColors.Control; 
            }

            if (menu_additionally_circle.BackColor == Color.Green)
            {
                menu_additionally_circle.BackColor = SystemColors.Control;
            }
        }

        private void Drawing()
        {
            Pen p = new Pen(CurrentColor, PenWidth);
            if (brushPanel.BackColor == Color.Green || eraserPanel.BackColor == Color.Green)
            {
                p.StartCap = LineCap.Round;
                p.EndCap = LineCap.Round;
                p.LineJoin = LineJoin.Round;
                g.SmoothingMode = SmoothingMode.AntiAlias;
            }
            if (pencilPanel.BackColor == Color.Green)
            {
                p.StartCap = LineCap.Flat;
                p.EndCap = LineCap.Flat;
                p.LineJoin = LineJoin.Bevel;
                g.SmoothingMode = SmoothingMode.Default;
            }
            g.DrawLine(p, PrewPoint, CurrentPoint);
            picture.Invalidate();
        }
        int i = 0;
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (i < 2)
            {
                ForDraw();
                i++;
            }
        }

        private void Menu_comboBox_PenThickness_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PenWidth = Convert.ToInt32(menu_comboBox_PenThickness.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод!");
                menu_comboBox_PenThickness.Text = "1";
            }
        }

        private void Menu_PenColor_Click(object sender, EventArgs e)
        {
            Palette();
        }

        private void Palette()
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                if (eraserPanel.BackColor != Color.Green)
                {
                    CurrentColor = colorDialog1.Color;
                }
                col = colorDialog1.Color;
                palettePanel.BackColor = col;
                if (menu_fill.BackColor != SystemColors.Control)
                {
                    menu_fill.BackColor = CurrentColor;
                    if (CurrentColor == Color.White)
                    {
                        menu_fill.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void BackCl()
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                backfonePanel.BackColor = colorDialog1.Color;
                picture.BackColor = colorDialog1.Color;
                if (eraserPanel.BackColor == Color.Green)
                {
                    CurrentColor = picture.BackColor;
                }
                picture.Image = null;
                ForDraw();
            }
        }

        private void Menu_BackColor_Click(object sender, EventArgs e)
        {
            BackCl();
        }

        private void Menu_DeleteAll_Click(object sender, EventArgs e)
        {
            HidePictures();
            ForDraw();
            if (image != null)
            {
                var bitmap = new Bitmap(image, picture.Width, picture.Height);
                picture.Image = bitmap;
                g = Graphics.FromImage(bitmap);
            }
        }

        Bitmap image;
        private void Menu_Open_Click(object sender, EventArgs e)
        {
            HidePictures();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(openFileDialog1.FileName);
                    var bitmap = new Bitmap(image, picture.Width, picture.Height);
                    picture.Image = bitmap;
                    g = Graphics.FromImage(bitmap);
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат!\nВыберите изображение.");
            }
        }

        private void CloseImage_Click(object sender, EventArgs e)
        {
            HidePictures();
            picture.Image = null;
            image = null;
            ForDraw();
        }

        int Angle = 0;
        private void Menu_comboBox_Poly_turnAngle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Angle = Convert.ToInt32(menu_comboBox_Poly_turnAngle.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод!");
                menu_comboBox_Poly_turnAngle.Text = "0";
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            menu_comboBox_Poly_AmountOfSides.Text = "3";
            menu_comboBox_Poly_turnAngle.Text = "30";
        }

        private void Square_Click(object sender, EventArgs e)
        {
            menu_comboBox_Poly_AmountOfSides.Text = "4";
            menu_comboBox_Poly_turnAngle.Text = "45";
        }

        private void Pentagon_Click(object sender, EventArgs e)
        {
            menu_comboBox_Poly_AmountOfSides.Text = "5";
            menu_comboBox_Poly_turnAngle.Text = "55";
        }

        private void ForDraw()
        {
            var bitmap = new Bitmap(picture.Width, picture.Height);
            picture.Image = bitmap;
            g = Graphics.FromImage(bitmap);
        }


        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (linePanel.BackColor == Color.Green)
            {
                    e.Graphics.DrawLine(new Pen(CurrentColor, PenWidth), firstP, secondP);  
            }

            if (circlePanel.BackColor == Color.Green)
            {
                if (menu_fill.BackColor == SystemColors.Control)
                {
                    e.Graphics.DrawEllipse(new Pen(CurrentColor, PenWidth), leftX, leftY, width, height);
                }
                else
                {
                    e.Graphics.FillEllipse(new SolidBrush(CurrentColor), leftX, leftY, width, height);
                }
            }

            if (polygonPanel.BackColor == Color.Green && AmountOfSides > 2)
            {
                if (menu_fill.BackColor == SystemColors.Control)
                {
                    e.Graphics.DrawPolygon(new Pen(CurrentColor, PenWidth), points.ToArray());
                }
                else
                {
                    e.Graphics.FillPolygon(new SolidBrush(CurrentColor), points.ToArray());
                }
            }

            if (menu_additionally_rect.BackColor == Color.Green || menu_additionally_square.BackColor == Color.Green)
            {
                if (menu_fill.BackColor == SystemColors.Control)
                {
                    e.Graphics.DrawRectangle(new Pen(CurrentColor, PenWidth), firstP.X, firstP.Y, width, height);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(CurrentColor), firstP.X, firstP.Y, width, height);
                }
            }

            if (menu_additionally_circle.BackColor == Color.Green)
            {
                if (menu_fill.BackColor == SystemColors.Control)
                {
                    e.Graphics.DrawEllipse(new Pen(CurrentColor, PenWidth), new Rectangle(leftX, leftY, width, height));
                }
                else
                {
                    e.Graphics.FillEllipse(new SolidBrush(CurrentColor), new Rectangle(leftX, leftY, width, height));
                }
            }
        }

        int AmountOfSides = 1;
        private void Menu_comboBox_Poly_AmountOfSides_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AmountOfSides = Convert.ToInt32(menu_comboBox_Poly_AmountOfSides.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод!");
                menu_comboBox_Poly_AmountOfSides.Text = "1";
            }
        }

        private void Menu_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Image Files|*.png|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
                picture.DrawToBitmap(bitmap, new Rectangle(0, 0, picture.Width, picture.Height));
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.CheckPathExists = true;
                bitmap.Save(saveFileDialog1.FileName);
                IsChange = false;
            }
        }
        private void Menu_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChange == true)
            {
                SaveAs();
            }
        }
    }
}
