using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        decimal conta = 0;
        bool res = false;
        bool soma = false;
        bool sub = false;
        bool mult = false;
        bool div = false;
        bool sqrt = false;
        bool ifRes = true;
        bool ifop = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            /*if (ifRes == true)
            {
                boxResultado.Text = "1";
                ifRes = false;
                if (res == true)
                {
                    boxOp.Text = "1";
                }
                else
                {
                    boxOp.Text += "1";
                }

            }
            else
            {
                boxResultado.Text += "1";
                boxOp.Text += "1";
            }*/
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Button nome = sender as Button;
            btnNum(nome.Text);
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (boxOp.Text == "")
            {
                boxOp.Text += "0,";
                boxResultado.Text += ",";
            }
            else
            {
                boxOp.Text += ",";
                boxResultado.Text += ",";
            }
        }
        private void btnNum(string butn)
        {
            if (ifRes == true)
            {
                boxResultado.Text = butn;
                ifRes = false;
                ifop = true;
                if (res == true)
                {
                    boxOp.Text = butn;
                }
                else
                {
                    boxOp.Text += butn;
                }

            }
            else
            {
                boxResultado.Text += butn;
                boxOp.Text += butn;
            }
        }
        private void boxResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            addTextOp("+");
            operacao();

            soma = true;
            sub = false;
            mult = false;
            div = false;
            ifop = false;
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            addTextOp("-");
            operacao();

            soma = false;
            sub = true;
            mult = false;
            div = false;
            ifop = false;
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            addTextOp("x");
            operacao();

            soma = false;
            sub = false;
            mult = true;
            div = false;
            ifop = false;
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            addTextOp("/");
            operacao();

            soma = false;
            sub = false;
            mult = false;
            div = true;
            ifop = false;
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            operacao();

            boxOp.Text = boxOp.Text.Insert(0, "√(");
            boxOp.Text = boxOp.Text.Insert(boxOp.Text.Length, ")");

            ifRes = false;
            soma = false;
            sub = false;
            mult = false;
            div = false;
            sqrt = true;
            operacao();
        }

        private void addTextOp(string op)
        {
            if(ifop == true) 
            {
                boxOp.Text += op;
            }
            else
            {
                ///boxOp.Text += "a";
                boxOp.Text = boxOp.Text.Remove(boxOp.Text.Length - 1,1);
                boxOp.Text += op;
            }
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            operacao();
        }
        private void operacao()
        {
            if(ifRes == false)
            {
                if (soma == true)
                {
                    conta = conta + decimal.Parse(boxResultado.Text);
                    boxResultado.Text = Convert.ToString(conta);
                    soma = false;
                    ifRes = true;
                }
                else if (sub == true)
                {
                    conta = conta - decimal.Parse(boxResultado.Text);
                    boxResultado.Text = Convert.ToString(conta);
                    sub = false;
                    ifRes = true;
                }
                else if (mult == true)
                {
                    conta = conta * decimal.Parse(boxResultado.Text);
                    boxResultado.Text = Convert.ToString(conta);
                    mult = false;
                    ifRes = true;
                }
                else if (div == true)
                {
                    if (decimal.Parse(boxResultado.Text) == 0)
                    {
                        clear();
                        boxResultado.Text = "Math ERROR";
                    }
                    else
                    {
                        conta = conta / decimal.Parse(boxResultado.Text);
                        boxResultado.Text = Convert.ToString(conta);
                    }
                    div = false;
                    ifRes = true;
                }
                else if (sqrt == true)
                {
                    if (conta < 0)
                    {
                        boxResultado.Text = "a";
                        clear();
                        boxResultado.Text = "Entrada inválida.";
                    }
                    else
                    {
                        conta = decimal.Parse(boxResultado.Text);
                        conta = (decimal)Math.Sqrt((double)conta);
                        boxResultado.Text = Convert.ToString(conta);
                    }
                    sqrt = false;
                    ifRes = true;
                }
                else
                {
                    if (decimal.Parse(boxResultado.Text) == 0)
                    {
                        boxOp.Text = "0";
                    }
                    conta = decimal.Parse(boxResultado.Text);
                    ifRes = true;
                    res = false;
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            boxResultado.Text = "0";
            boxOp.Text = "";
            conta = 0;
            sub = false;
            mult = false;
            div = false;
            soma = false;
            res = false;
            ifRes = true;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (boxOp.Text.Length != 0) {
                if (ifRes == false) { 
                    string x = boxOp.Text;
                    x = x.Remove(x.Length - 1, 1);
                    boxResultado.Text = x;
                    boxOp.Text = x;
                }
                else
                {
                    boxOp.Text = "";
                }
            }
        }
    }
}
