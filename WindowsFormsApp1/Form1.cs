using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 创建一个数据表
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add("SomeColumn", typeof(string));
            myDataTable.Rows.Add("Hello World!");

            // 在窗体上添加一个文本框
            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(100, 100);
            this.Controls.Add(textBox1);

            // 将文本框绑定到数据表中的某个字段
            textBox1.DataBindings.Add("Text", myDataTable, "SomeColumn");
        }
    }
}