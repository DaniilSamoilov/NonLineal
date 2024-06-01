using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonLineal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FunctionSelector.Items.AddRange(Functions.Keys.ToArray());
            ClearGraph();
        }
        private void GenerateTable_Click(object sender, EventArgs e)
        {
            int Size = 3;
            ArgumentsTable.RowCount = Size;
            ArgumentsTable.ColumnCount = Size + 2;
            for (int i = 0; i <= Size; i++)
            {
                ArgumentsTable.Columns[i].HeaderCell.Value = "X" + (i + 1).ToString();
            }
            ArgumentsTable.Columns[Size].HeaderCell.Value = "B";
            ArgumentsTable.Columns[Size + 1].HeaderCell.Value = "Корни";
        }
        public static double Bisection(double LeftBorder, double RightBorder, double Precision, Func<double,double> func)
        {
            if (func(LeftBorder)*func(RightBorder)>=0)//переходит через 0
            {
                return double.NaN;
            }
            double root = LeftBorder;
            while ((RightBorder-LeftBorder)/2 > Precision)
            {
                root = (LeftBorder + RightBorder) / 2;
                if (func(root) ==0.0)
                {
                    break;
                }
                if (func(LeftBorder)*func(root)<0)
                {
                    RightBorder = root;
                }
                else
                {
                    LeftBorder = root;
                }
            }
            return root;
        }
        public static double NewtonRaphson (double x0, double Precision, int MaxIterations, Func<double,double> func,Func<double,double> der)
        {
            double x = x0;
            for (int i = 0; i < MaxIterations; i++)
            {
                double fx = func(x);//значение функции в точке x
                double dfx =der(x);//значение производной в точке x
                if (Math.Abs(dfx)<1e-10)//прозводная не ноль
                {
                    return double.NaN;
                }

                double x1 = x - (fx / dfx);
                if (Math.Abs(x1-x)<Precision)//достигли ли нужной точности
                {
                    return x1;
                }
                x = x1;
            }
            return x;
        }
        private void BisectionBtn_Click(object sender, EventArgs e)
        {
            double LeftBorder = Convert.ToDouble(BottomBorder.Text);
            double RightBorder = Convert.ToDouble(TopBorder.Text);
            double Precission = Convert.ToDouble(Presic.Text);
            ClearGraph();
            double result = Bisection(LeftBorder, RightBorder, Precission, Functions[FunctionSelector.Text]);
            if (!double.IsInfinity(result) && !double.IsNaN(result))
            {
                Solution.Text = result.ToString();
                DrawGraph(Functions[FunctionSelector.Text], result);
            }
        }
        private void NutonBtn_Click(object sender, EventArgs e)
        {
            double InitialGuess = Convert.ToDouble(Guess.Text);
            double Precission = Convert.ToDouble(Presic.Text);
            ClearGraph();
            double result = NewtonRaphson(InitialGuess, Precission, 1000, Functions[FunctionSelector.Text], Derivatives[FunctionSelector.Text]);
            if (!double.IsInfinity(result)&&!double.IsNaN(result))
            {
                Solution.Text = result.ToString();
                DrawGraph(Functions[FunctionSelector.Text], result);   
            }
        }
        public void DrawGraph(Func<double,double> func, double root)
        {
            Graph.Series["Root"].Points.AddXY(root, func(root));
            for (double i = root-3; i < root+3; i +=0.01)
            {
                Graph.Series["Function"].Points.AddXY(i,func(i));
            }
        }
        public Dictionary<string, Func<double, double>> Functions = new Dictionary<string, Func<double, double>>
        {
            { "X^2",(x)=>Math.Pow(x,2) },
            {"x^3 - x - 2", (x)=>Math.Pow(x, 3) - x - 2},
            {"5x^2-4x-2",(x)=>5*Math.Pow(x,2)-4*x-2 },
            {"4x^4 - 3x^2 - 3",(x)=>Math.Pow(x,4)*4 - Math.Pow(x,2)*3 - 3 },
            
        };//функции
        public Dictionary<string, Func<double, double>> Derivatives = new Dictionary<string, Func<double, double>>
        {
            { "X^2",(x)=>2 },
            {"x^3 - x - 2", (x)=>3*Math.Pow(x, 2) - 1},
            {"5x^2-4x-2",(x)=>10*x-4 },
            {"4x^4 - 3x^2 - 3",(x)=>Math.Pow(x,3)*16 - x*6 },
        };//производные
        public Dictionary<string, List<Func<double, double>>> Systems = new Dictionary<string, List<Func<double, double>>>
        {
            
        };
        public void ClearGraph()
        {
            Graph.Series["Root"].Points.Clear();
            Graph.Series["Function"].Points.Clear();
        }
    }
}
