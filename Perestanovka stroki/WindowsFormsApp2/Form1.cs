using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Text_result.Text = "";
            Text_errors.Text = "";

            if (Text_setence.Text == "")
            {
                Text_errors.Text = "Строка не введена.";
                return;
            }

            if (Text_start.Text == "")
            {
                Text_errors.Text = "Начальная граница не введена.";
                return;
            }

            if (Text_end.Text == "")
            {
                Text_errors.Text = "Конечная граница не введена.";
                return;
            }

            int start = Convert.ToInt32(Text_start.Text);
            int end = Convert.ToInt32(Text_end.Text);

            if (start < 1 || end < 1)
            {
                Text_errors.Text = "Значение начальной или конечной границы не может быть меньше 1.";
                return;
            }

            if (start > end)
            {
                Text_errors.Text = "Значение начальной границы не может быть больше конечной.";
                return;
            }

            string[] sentence = Text_setence.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (end > sentence.Length)
            {
                Text_errors.Text = "Значение конечной границы не может быть больше числа слов во введенной строке.";
                return;
            }

            if (end == sentence.Length)
            {
                Text_result.Text = Text_setence.Text;
                return;
            }

            int i;
            string res = "";

            for (i=0; i<start-1; i++)
            {
                res += sentence[i] + " ";
            }

            for (i=end; i<sentence.Length; i++)
            {
                res += sentence[i] + " ";
            }

            for (i=start-1; i<end; i++)
            {
                res += sentence[i] + " ";
            }

            Text_result.Text = res;
        }
    }
}
