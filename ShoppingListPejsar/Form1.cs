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
        public List<ItemRow> ItemColumn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ItemColumn = new List<ItemRow>();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            ItemRow itemRow = new ItemRow(btnAdd.Left, btnAdd.Top, ItemColumn.Count);
            ItemColumn.Add(itemRow);

            itemRow.Smazat.Click += DeleteRow;

            Controls.Add(itemRow.ItemName);
            Controls.Add(itemRow.Hotovo);
            Controls.Add(itemRow.Smazat);

            btnAdd.Top += 50;
        }

        public void DeleteRow (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = (button.Tag as ItemRow).index;

            for (int i = index + 1; i < ItemColumn.Count; i++)
            {
                ItemColumn[i].ItemName.Top -= 50;
                ItemColumn[i].Hotovo.Top -= 50;
                ItemColumn[i].Smazat.Top -= 50;
                (ItemColumn[i].Smazat.Tag as ItemRow).index--;
            }

            Controls.Remove(ItemColumn[index].ItemName);
            Controls.Remove(ItemColumn[index].Hotovo);
            Controls.Remove(ItemColumn[index].Smazat);
            ItemColumn.Remove(ItemColumn[index]);
            btnAdd.Top -= 50;

            Refresh();
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

    public class ItemRow
    {
        public TextBox ItemName;
        public CheckBox Hotovo;
        public Button Smazat;
        public int index;

        public ItemRow (int positionX, int positionY, int aIndex)
        {
            ItemName = new TextBox();
            ItemName.Left = positionX;
            ItemName.Top = positionY;
            ItemName.Width = 350;

            Hotovo = new CheckBox();
            Hotovo.Checked = false;
            Hotovo.Left = ItemName.Left + ItemName.Width + 40;
            Hotovo.Top = positionY;
            Hotovo.Width = Hotovo.Height;

            Smazat = new Button();
            Smazat.Left = Hotovo.Left + Hotovo.Width + 40;
            Smazat.Top = positionY;
            Smazat.Tag = this;
            Smazat.Text = "Smazat";

            index = aIndex;
        }
    }
}
