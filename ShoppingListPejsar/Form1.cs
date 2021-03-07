using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListPejsar
{
    public partial class Form1 : Form
    {
        int position;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            position = 120;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            TextBox txtBox = new TextBox();
            txtBox.Location = new Point(90, position);
            this.Controls.Add(txtBox);

            CheckBox checkBox = new CheckBox();
            checkBox.Location = new Point(470, position);
            this.Controls.Add(checkBox);

            Button btn = new Button();
            btn.Location = new Point(600, position);
            btn.Text = "odstraňit";
            btn.AutoSize = true;
            this.Controls.Add(btn);
            btn.Click += new EventHandler(Btn_Click);

            btnAdd.Location = new Point(80, position + 50);
            position += 30;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }

    }

    public class Item
    {
        public Item(int position)
        {
            TextBox itemTextBox = new TextBox();
            itemTextBox.Location = new Point(position);
            

            CheckBox itemCheckBox = new CheckBox();
            itemCheckBox.Location = new Point(position);
        }
    }
}
