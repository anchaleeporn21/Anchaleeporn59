using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Anchaleeporn3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
       private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//เช็คเงื่อนไข
            {
                double number1, Rom, number2;//number1=ขนาดถังน้ำมัน number2=จำรวนน้ำมัน Rom=ราคารวม
                number1 = Convert.ToDouble(textBox1.Text);//แปลง textbox1 เป็น number1
                number2 = Convert.ToDouble(textBox2.Text);//แปลง textbox2 เป็น number2
                if (number2 <= number1)//เช็คเงื่อนไข
                {
                    Double BZ95 = 32.86;//กำหนดค่า BZ95
                    Rom = (number2 * BZ95);//คำนวณค่า
                    label1.Text = Rom + "      บาท";//แสดงค่ารวมในlabel1
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเติมน้ำมันเกินถังได้");//แสดงข้อความ
                }
            }
            if (radioButton3.Checked)//เช็คเงื่อนไข
            {
                double number1, Rom, number2;//number1=ขนาดถังน้ำมัน number2=จำรวนน้ำมัน Rom=ราคารวม
                number1 = Convert.ToDouble(textBox1.Text);//แปลง textbox1 เป็น number1
                number2 = Convert.ToDouble(textBox2.Text);//แปลง textbox2 เป็น number2
                if (number2 <= number1)//เช็คเงื่อนไข
                {
                    double G91 = 25.48;//กำหนดค่า G91
                    Rom = (number2 * G91);//คำนวณค่า
                    label1.Text = Rom + "      บาท";//แสดงค่ารวมในlabel1
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเติมน้ำมันเกินถังได้");//แสดงข้อความ
                }
            }
        }
    }
}
