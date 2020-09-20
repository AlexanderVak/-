using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЧМІ_1
{
    public partial class Form1 : Form
    {
        BindingList<Expression> expResults = new BindingList<Expression>();
        BindingList<double> methodResults = new BindingList<double>();
        

        double x, btmBorder, f, h, fDer, prevX, prevF, prevFDer;
        int highBorder;
        string expr;
        bool xIsNeg, fIsNeg, fDerIsNeg, prevXIsNeg, prevFIsNeg, prevFDerIsNeg;

        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = expResults;
            

        }
        public void RootDeataching(double x, string expr)
        {
            Expression expression = new Expression(x, expr);
            int counter = 0;
            do
            {

                f = expression.SolveExpression(x);
                fDer = expression.SolveDerivativeExpression();
                GetSigns(out xIsNeg, out fIsNeg, out fDerIsNeg);
                if (prevFIsNeg != fIsNeg)
                {

                    if (prevFDerIsNeg == fDerIsNeg)
                    {
                        expResults.Add(new Expression(prevX, expr));
                        expResults.Add(new Expression(x, expr));

                        methodResults.Add(expression.TransversalMethod(prevX, x));
                        string result = methodResults[counter].ToString();
                        var results = new ListViewItem(result);
                        listView1.Items.Add(results);
                        counter++;
                    }
                }
                prevX = x;
                prevF = f;
                prevFDer = fDer;
                prevXIsNeg = xIsNeg;
                prevFIsNeg = fIsNeg;
                prevFDerIsNeg = fDerIsNeg;

                x += h;



            }
            while (x <= highBorder);
        }
        private void getResult_btn_Click(object sender, EventArgs e)
        {
            btmBorder = Convert.ToDouble(btmBorder_tbx.Text.Replace('.', ','));
            x = btmBorder;
            h = Convert.ToDouble(step_tbx.Text.Replace('.', ','));
            highBorder = Convert.ToInt32(highBorder_tbx.Text); ;
            expr = expression_tbx.Text;

            RootDeataching(x, expr);



        }
        private void GetSigns(out bool xIsNeg, out bool fIsNeg, out bool fDerIsNeg)
        {
            if (x < 0)
                xIsNeg = true;
            else
                xIsNeg = false;
            if (f < 0)
                fIsNeg = true;
            else
                fIsNeg = false;
            if (fDer < 0)
                fDerIsNeg = true;
            else
                fDerIsNeg = false;
        }

    }
}
