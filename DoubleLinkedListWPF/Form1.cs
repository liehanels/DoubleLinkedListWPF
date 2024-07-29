using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleLinkedListWPF
{
    public partial class Form1 : Form
    {
        DoublyLinkedList list = new DoublyLinkedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string input = txtAdd.Text;
            list.AddFirst(input);
            txtAdd.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string input = txtRemove.Text;
            if (list.Remove(input)) { MessageBox.Show("Removed item"); }
            else { MessageBox.Show("Item not found"); }
            txtRemove.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearch.Text;
            if (list.Contains(input)) { MessageBox.Show(list.Find(input).Previous.Data + " <-- Previous | > "+ list.Find(input).Data + " < | Next --> " + list.Find(input).Next.Data); }
            else { MessageBox.Show("Item not found"); }
            txtSearch.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int count = 1;
            listView.Clear();
            foreach (Node item in list.GetEnumeratorReverse())
            {
                listView.Items.Add(count + ". " + item.Data);
                count++;
            }
        }
    }
}
