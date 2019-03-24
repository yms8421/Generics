using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Numerator
{
    public partial class frmClient : Form
    {
        private frmMain parentForm;
        public frmClient(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            btnSave.KeyDown += txtName_KeyDown;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                parentForm.AddToQueue(txtName.Text.Trim());
                this.Close();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (txtName.Text.Length > 0)
                {
                    txtName.Clear();
                }
                else if (txtName.Text.Length == 0)
                {
                    this.Close();
                }
            }
        }
    }
}
