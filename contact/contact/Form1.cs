using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact();
            obj.FirstName = txtFname.Text;
            obj.LastName = txtLname.Text;
            obj.Phone = txtPhone.Text;

            lstContacts.Items.Add(obj.ToString());
        }
    }
}
