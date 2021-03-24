using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab_1;
using Lab_1.Shape;
using OOP_Lab2_Form.Shapes.Factories;

namespace OOP_Lab2_Form
{
    public partial class Form1 : Form
    {
        private IShapeFactory _currentFactory;
        private BaseShape _currentShape;

        private bool _startPaint = false;
        private Bitmap _map;
        private Bitmap _bitmap_save;
        private Graphics _graphics;
        private Pen _pen;

        private Stack<Bitmap> _undo;
        private Stack<Bitmap> _redo;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawArea();
        }

        private void InitializeDrawArea()
        {
            Rectangle window = Screen.PrimaryScreen.Bounds;   
            _map = new Bitmap(window.Width, window.Height);
            _graphics = Graphics.FromImage(_map);
            _graphics.Clear(DrawPanel.BackColor);
            _currentFactory = new CircleFactory();
            _undo = new Stack<Bitmap>();
            _redo = new Stack<Bitmap>();
        }


        private void Reload(Bitmap map)
        {
            _map = new Bitmap(map);
            _graphics = Graphics.FromImage(_map);
            _graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Update();
            GC.Collect();
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _currentShape = _currentFactory.CreateShape(e.X, e.Y);
            _pen = new Pen(ColorButt.BackColor, PenWidthBar.Value);
            _startPaint = true;
            _bitmap_save = new Bitmap(_map);
            _undo.Push(_bitmap_save);
            _redo.Clear();
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_startPaint)
            {
                return;
            }

            Reload(_bitmap_save);
            _currentShape.Init(e.X, e.Y);
            _currentShape.Draw(_graphics, _pen);
            DrawPanel.Image = _map;
        }


        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _startPaint = false;
        }


        private void UndoButt_Click(object sender, EventArgs e)
        {
            if (_undo.Count != 0)
            {
                _redo.Push(new Bitmap(DrawPanel.Image));
                Reload(_undo.Pop());
                DrawPanel.Image = _map; ;
            }
        }

        private void RedoButt_Click(object sender, EventArgs e)
        {
            if (_redo.Count != 0)
            {
                _undo.Push(new Bitmap(DrawPanel.Image));
                Reload(_redo.Pop());
                DrawPanel.Image = _map;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            _undo.Push(new Bitmap(DrawPanel.Image));
            _redo.Clear();
            _graphics.Clear(DrawPanel.BackColor);
            DrawPanel.Image = _map;
            GC.Collect();
        }

        private void EllipseButt_Click(object sender, EventArgs e)
        {
            _currentFactory = new EllipseFactory();
        }

        private void CircleButt_Click(object sender, EventArgs e)
        {
            _currentFactory = new CircleFactory();
        }


        private void SquareButt_Click(object sender, EventArgs e)
        {
            _currentFactory = new SquareFactory();
        }

        private void LineButt_Click(object sender, EventArgs e)
        {
            _currentFactory = new LineFactory();
        }

        private void RectButt_Click(object sender, EventArgs e)
        {
            _currentFactory = new RectangleFactory();
        }

        private void TriangleButt_Click(object sender, EventArgs e)
        {
            _currentFactory = new TriangleFactory();
        }

        private void ColorButt_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorButt.BackColor = ColorDialog.Color;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to close application?", "Close verification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DrawPanel.Image.Save(SaveFileDialog.FileName);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Reload(new Bitmap(OpenFileDialog.FileName));
                DrawPanel.Image = _map;
                _undo.Clear();
                _redo.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}