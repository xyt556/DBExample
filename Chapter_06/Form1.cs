using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“_8层DataSet.全区各点信息”中。您可以根据需要移动或移除它。
            //this.全区各点信息TableAdapter.Fill(this._8层DataSet.全区各点信息);
            // TODO: 这行代码将数据加载到表“_8层DataSet.各点煤层煤系基本数据”中。您可以根据需要移动或删除它。
            this.各点煤层煤系基本数据TableAdapter.Fill(this._8层DataSet.各点煤层煤系基本数据);

        }
    }
}
