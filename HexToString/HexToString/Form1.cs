using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HexToString
{
    public partial class HexToString : Form
    {
        public HexToString()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string InputHex = textBox1.Text;
            char[] value = InputHex.ToCharArray();
            int number = value.Length;

            for(int j=0;j<number;j++)
            {
                
                if(value[j]=='0'|| value[j] == '1' || value[j] == '2' || value[j] == '3' || value[j] == '4' 
                    || value[j] == '5' || value[j] == '6' || value[j] == '7' || value[j] == '8' || value[j] == '9' 
                    || value[j] == 'A'||value[j] == 'B' || value[j] == 'C' || value[j] == 'D' || value[j] == 'E' || value[j] == 'F' )
                {

                }else
                {
                    MessageBox.Show("请输入正确的Hex字符串,此Hex中包含非法字符！！！");
                    return;
                }

               //return;


            }
            List<string> strlist = new List<string>();
            string result=null;

            
            if((number%2)==0)
            {
                
                for (int i=0;i<number;i=i+2)
                {
                    string  temp=( Convert.ToString(value[i])+Convert.ToString(value[i+1]));
                    byte intItem = Convert.ToByte(temp, 16);        //Hex转为int型
                    string strItem = char.ConvertFromUtf32(intItem);     //int型转为char类型
                                                                         //strlist.Add(strItem);
                    result = result + strItem;
                   
                }


                textBox2.Text=result;
                //Console.WriteLine("{0}",result);
                
            }
            else
            {
                MessageBox.Show("请输入正确的Hex字符串！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
