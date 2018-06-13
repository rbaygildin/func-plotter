using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//КДЗ №1 за 2 модуль Ярных Роман Вариант 26
namespace КДЗ___Ярных_Роман
{
    public partial class GrapherWindow : Form
    {
        private float Xunit, Yunit;
        private float XRight, YDown;
        private float XMiddle, YMiddle;
        private double XMin, XMax, Dx, YMin, YMax;
        private float XBound, YBound;
        private double XMouse;
        private bool IsDrawing;
        private Function myfunction;
        public GrapherWindow()
        {
            IsDrawing = false;
            InitializeComponent();
        }
        /// <summary>
        /// Рисуем график функции
        /// </summary>
        /// <param name="func"></param>
        private void PlotFunction(Function func, Graphics g)
        {
            double xstart = 0.0;
            double ystart, yend;
            ystart = 0.0;
            yend = 0.0;
            //Переводим декартовые координаты в координаты graphicsBox 
            Func<double, double, Point> decartes2fulldevice = (X, Y) =>
            {
                return new Point((int)((X - XMin) / (XMax - XMin) * (XRight - XBound)), (int)((YDown - (Y - YMin) / (YMax - YMin) * (YDown - YBound))));
            };
            Pen pen = new Pen(Color.Red, 2.0f);
            for (double x = XMin; x <= XMax; x += Dx)
            {
                if (x == XMin)
                {
                    xstart = x;
                    ystart = func[xstart];
                }
                else
                {
                    if (!func.GapPoint) //Проверяем, не является ли данная точка точкой разрыва
                    {
                        yend = func[x];
                            g.DrawLine(pen, decartes2fulldevice(xstart, ystart), decartes2fulldevice(x, yend));
                    }
                    xstart = x;
                    ystart = yend;
                }
            }
        }
        /// <summary>
        /// Рисуем линии абциссы и ординаты
        /// </summary>
        private void DrawAxes(Function func, double x, Graphics g)
        {
            Func<double, float> decartes2deviceX = X =>
            {
                return (float)((X - XMin) / (XMax - XMin) * (XRight - XBound));
            };
            Func<double, float> decartes2deviceY = Y =>
            {
                return (float)((YDown - (Y - YMin) / (YMax - YMin) * (YDown - YBound)));
            };
            double y = func[x];
            Pen pen = new Pen(Color.Black, 2.5f);
            g.DrawLine(pen, decartes2deviceX(x), 0.0f, decartes2deviceX(x), YDown);//Рисуем ось Y
            g.DrawLine(pen, 0.0f, decartes2deviceY(y), XRight, decartes2deviceY(y));//Рисуем ось X
            SolidBrush brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, new RectangleF(decartes2deviceX(x) - 6.0f, decartes2deviceY(y) - 6.0f, 12.0f, 12.0f));
            funcvaluestip.SetToolTip(graphicsBox, String.Format("X = {0:F2}, Y = {1:F2}", x, y));
        }
        /// <summary>
        /// Рисуем сетку координат
        /// </summary>
        private void DrawGrid(Graphics g)
        {
            Func<float, float> device2decartesX = (X) =>
            {
                return (float)(X * (XMax - XMin) / XRight + XMin);
            };
            Func<float, float> device2decartesY = (Y) =>
            {
                return (float)((YDown - Y) * (YMax - YMin) / YDown);
            };
            Pen pen = new Pen(Color.Wheat, 2.0f);
            SolidBrush brush = new SolidBrush(Color.Black);
            for (float Y = YBound; Y <= YDown - YBound; Y += Yunit)
            {
                for (float X = XBound; X <= XRight - XBound; X += Xunit)
                {
                    g.DrawLine(pen, new PointF(X, YBound), new PointF(X, YDown - YBound));
                    //g.DrawString(String.Format("{0:F2}", device2decartesX(X)), new Font("Ariel", 7.0f, FontStyle.Bold), brush, new PointF(X + 2.0f, YDown + 5.0f));
                }
                g.DrawLine(pen, new PointF(XBound, Y), new PointF(XRight - XBound, Y));
                //g.DrawString(String.Format("{0:F2}", device2decartesY(Y)), new Font("Ariel", 7.0f, FontStyle.Bold), brush, new PointF(XBound  + 2.0f, Y + 2.0f));
            }
        }
        /// <summary>
        /// Обрабатываем событие перерисовки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void graphicsBox_Paint(object sender, PaintEventArgs e)
        {
            if (IsDrawing)
            {
                Graphics g = e.Graphics;
                DrawGrid(g);
                PlotFunction(myfunction, g);
                DrawAxes(myfunction, XMouse, g);
            }
        }
        /// <summary>
        /// Инициализируем параметры для рисования графика
        /// </summary>
        private void InitGraphics()
        {
            XRight = graphicsBox.Size.Width;
            YDown = graphicsBox.Size.Height;
            Xunit = XRight / 40.0f;
            Yunit = YDown / 40.0f;
            XBound = 0.0f;
            YBound = 0.0f;
        }
        private void butDrawGraph_Click(object sender, EventArgs e)
        {
            bool tboxXMinIsNum, tboxXMaxIsNum, tboxDxIsNum;
            tboxXMinIsNum = Double.TryParse(tboxXmin.Text, out XMin);
            tboxXMaxIsNum = Double.TryParse(tboxXmax.Text, out XMax);
            tboxDxIsNum = Double.TryParse(tboxDx.Text, out Dx);
            if(tboxXMinIsNum && tboxXMaxIsNum && tboxDxIsNum){//Проверяем, являются ли значения полей ввода числами
                errorProvider.Clear(); //Очищаем все прошлые ошибки
                if (XMin >= XMax)
                {
                    MessageBox.Show("XMin не может быть больше XMax!", "Некорректный ввод данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsDrawing = false;
                }
                else if (trBarY.Value <= Math.Abs(XMin) && XMin < 0)
                {
                    MessageBox.Show("Параметр Y не соответствует области определения функции!", "Неправильно введена функция!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsDrawing = false;
                }
                else if (Dx == 0.0)
                {
                    errorProvider.SetError(tboxDx, "Значение dx не может быть нулевым!");
                    MessageBox.Show("Шаг функции не может быть нулевым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsDrawing = false;
                }
                else
                {
                    DialogResult dialog_result = System.Windows.Forms.DialogResult.Yes;
                    if ((XMax - XMin) / Dx > 10e6)//Если число точек очень велико, то выводим предупреждающее сообщение
                        dialog_result = MessageBox.Show(String.Format("{0}\n{1}", "Количество точек для вычисления функции слишком велико, что может негативно сказаться на скорости выполнения программы!", "Вы желаете продолжить?"), "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (Dx >= 0.1)
                        MessageBox.Show("Шаг функции достаточно большой. Точность графика будет снижена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog_result == System.Windows.Forms.DialogResult.Yes)
                    {
                        myfunction = new Function();
                        myfunction.Y = trBarY.Value;
                        myfunction.Z = trBarZ.Value;
                        List<double> func_values = new List<double>();
                        for (double x = XMin; x <= XMax; x += Dx)
                            func_values.Add(myfunction[x]);
                        YMax = func_values.Max();//Найдем максимальное значение функции
                        YMin = func_values.Min();//Найдем минимальное значение функции
                        XMiddle = (float)(Math.Abs(XMin) / (XMax - XMin) * XRight);
                        IsDrawing = true;
                        graphicsBox.Refresh();
                    }
                }
            }
            else
            {
                errorProvider.Clear();
                if(!tboxXMinIsNum)
                    errorProvider.SetError(tboxXmin, "Значение Xmin не действительное число!");
                if(!tboxXMaxIsNum)
                    errorProvider.SetError(tboxXmax, "Значение Xmax не действительное число!");
                if(!tboxDxIsNum)
                    errorProvider.SetError(tboxDx, "Значение dx не действительное число!");
                MessageBox.Show("Значения параметров функции должны быть действительными числами!", "Некорректный ввод!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsDrawing = false;
            }
        }
        /// <summary>
        /// Обработчик события загрузки окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrapherWindow_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            InitGraphics();
            graphicsBox.Refresh();
        }
        /// <summary>
        /// Обработчик события изменения размеров экрана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void graphicsBox_SizeChanged(object sender, EventArgs e)
        {
            InitGraphics();
            graphicsBox.Refresh();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}\n{1}", "КДЗ по программированию выполнено студентом", "101ПИ ФКН НИУ ВШЭ Ярных Романом."));
        }
        /// <summary>
        /// Обработчик события изменения параметров Y и Z
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trBar_Scroll(object sender, EventArgs e)
        {
            if((TrackBar)sender == trBarY)
                hintProvider.SetToolTip(trBarY, String.Format("Y = {0}", trBarY.Value));
            if((TrackBar)sender == trBarZ)
                hintProvider.SetToolTip(trBarZ, String.Format("Z = {0}", trBarZ.Value));
        }

        private void graphicsBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                //Переводим координаты graphicsBox в декартовые координаты
                Func<int, double> device2decartesX = (X) =>
                {
                    return X * (XMax - XMin) / XRight + XMin;
                };
                XMouse = device2decartesX(e.X);
                graphicsBox.Refresh();
            }
        }

    }
}
