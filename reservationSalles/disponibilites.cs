using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservationSalles2018
{
    public partial class frmDisponibilites : Form
    {
        
        DataTable tableTypes;
        public frmDisponibilites()
        {
            InitializeComponent();
        }

        private void frmDisponibilites_Load(object sender, EventArgs e)
        {
            tableTypes = frmM2LReservationSalles.reservationsSallesDataSet.Tables["Types"];

            cbxTypeSalles.DataSource = tableTypes;
            cbxTypeSalles.DisplayMember = tableTypes.Columns[1].ToString();
            cbxTypeSalles.ValueMember = tableTypes.Columns[0].ToString();



            cbxLPlages.Items.Add("Matin");
            cbxLPlages.Items.Add("Après midi");
            cbxLPlages.SelectedIndex = 0;

            textBox1.MaxLength = 3;
            textBox2.MaxLength = 3;
        }

        private void cbxTypeSalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxLPlages_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int min;
            if (!int.TryParse(textBox1.Text, out min) || min <= 1 || min >= 300)
            {
                errorProvider.SetError(textBox1, "La capacité minimale est compris entre 1 et 300" );
                textBox1.Text = null;
                textBox1.Focus();
                e.Cancel = true;
            }
        }
       
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
           
            int max;
            if (!int.TryParse(textBox1.Text, out max) || max <= 1 || max >= 300 )
            {
                errorProvider.SetError(textBox2, "La capacité maximale doit être compris entre 1 et 300 et dois être supérieur à la capacité minimale");
                textBox2.Text = null;
                textBox2.Focus();
                e.Cancel = true;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            
            errorProvider.Clear();
            ValidateChildren();

        }
    }
}
