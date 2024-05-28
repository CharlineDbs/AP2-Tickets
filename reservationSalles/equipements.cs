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
    public partial class frmEquipements : Form
    {

        DataTable tableEquipements;

        Boolean enregModifierEquipement;

        public frmEquipements()
        {
            InitializeComponent();
        }

        private void frmEquipements_Load(object sender, EventArgs e)
        {
            tableEquipements = frmM2LReservationSalles.reservationsSallesDataSet.Tables["Equipements"];



            lbxEquipements.DataSource = tableEquipements;
            lbxEquipements.DisplayMember = tableEquipements.Columns[1].ToString();
            lbxEquipements.ValueMember = tableEquipements.Columns[0].ToString();

            tbxNomEquipement.Enabled = false;
            tbxQuantiteEquipement.Enabled = false;
            tbxPrixEquipement.Enabled = false;


            btnEnregistrerEquipement.Visible = false;
            btnAnnulerEquipement.Visible = false;

            tbxNomEquipement.MaxLength = 40;
            tbxQuantiteEquipement.MaxLength = 3;
            tbxPrixEquipement.MaxLength = 8;

            AutoValidate = AutoValidate.Disable;
            errorProvider1.Clear();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

       

        private void lbxEquipements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEquipements.SelectedIndex != -1)
            {
                tbxNomEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[1].ToString();
                tbxQuantiteEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[2].ToString();
                tbxPrixEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[3].ToString();

            }
        }

        private void btnAjouterEquipement_Click(object sender, EventArgs e)
        {
            tbxNomEquipement.Text = "";
            tbxQuantiteEquipement.Text = "";
            tbxPrixEquipement.Text = "";



            tbxNomEquipement.Enabled = true;
            tbxQuantiteEquipement.Enabled = true;
            tbxPrixEquipement.Enabled = true;
           


            btnAjouterEquipement.Visible = false;
            btnSupprimerEquipement.Visible = false;
            btnModifierEquipement.Enabled = false;
            tbxRechercherEquipement.Enabled = false;
            btnRechercherEquipement.Enabled = false;

            lbxEquipements.Enabled = false;

            btnEnregistrerEquipement.Visible = true;
            btnAnnulerEquipement.Visible = true;


            enregModifierEquipement = false;
        }

        private void btnEnregistrerEquipement_Click(object sender, EventArgs e)
        {
            int idEquipement;
            short indice;

            indice = 0;


            tbxNomEquipement.Text = tbxNomEquipement.Text.Trim();
            tbxQuantiteEquipement.Text = tbxQuantiteEquipement.Text.Trim();
            tbxPrixEquipement.Text = tbxPrixEquipement.Text.Trim();
            const string message = "Es-tu sur de vouloir enregistrer";
            const string caption = "Enregistrer";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                errorProvider1.Clear();
                if (ValidateChildren())
                {


                    try
                    {

                        if (enregModifierEquipement == false)
                        {
                            dbConnexion.ajouterEquipement(tbxNomEquipement.Text, Convert.ToInt32(tbxQuantiteEquipement.Text), Convert.ToSingle(tbxPrixEquipement.Text));
                        }
                        else
                        {
                            idEquipement = Convert.ToInt32(tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[0]);
                            dbConnexion.modifierEquipement(idEquipement, tbxNomEquipement.Text, Convert.ToInt32(tbxQuantiteEquipement.Text), Convert.ToSingle(tbxPrixEquipement.Text));
                            indice = Convert.ToInt16(lbxEquipements.SelectedIndex);

                        }

                        dbConnexion.miseJourDataSet();

                        lbxEquipements.DataSource = tableEquipements;
                        lbxEquipements.DisplayMember = tableEquipements.Columns[1].ToString();
                        lbxEquipements.ValueMember = tableEquipements.Columns[0].ToString();


                        if (enregModifierEquipement == true)
                        {
                            lbxEquipements.SelectedIndex = indice;
                            enregModifierEquipement = false;
                        }
                        else
                        {
                            lbxEquipements.SelectedIndex = lbxEquipements.Items.Count - 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    tbxNomEquipement.Enabled = false;
                    tbxQuantiteEquipement.Enabled = false;
                    tbxPrixEquipement.Enabled = false;


                    btnAjouterEquipement.Visible = true;
                    btnSupprimerEquipement.Visible = true;
                    btnModifierEquipement.Enabled = true;

                    btnEnregistrerEquipement.Visible = false;
                    btnAnnulerEquipement.Visible = false;

                    lbxEquipements.Enabled = true;
                    tbxRechercherEquipement.Enabled = true;
                    btnRechercherEquipement.Enabled = true;

                    if (lbxEquipements.SelectedIndex != -1)
                    {
                        tbxNomEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[1].ToString();
                        tbxQuantiteEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[2].ToString();
                        tbxPrixEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[3].ToString();

                    }
                }
            }
        }

        private void btnAnnulerEquipement_Click(object sender, EventArgs e)
        {
            enregModifierEquipement = false;

            tbxNomEquipement.Enabled = false;
            tbxQuantiteEquipement.Enabled = false;
            tbxPrixEquipement.Enabled = false;

            btnAjouterEquipement.Visible = true;
            btnSupprimerEquipement.Visible = true;
            btnModifierEquipement.Enabled = true;

            btnEnregistrerEquipement.Visible = false;
            btnAnnulerEquipement.Visible = false;

            lbxEquipements.Enabled = true;
            tbxRechercherEquipement.Enabled = true;
            btnRechercherEquipement.Enabled = true;

            if (lbxEquipements.SelectedIndex != -1)
            {
                tbxNomEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[1].ToString();
                tbxQuantiteEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[2].ToString();
                tbxPrixEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[3].ToString();
            }
        }

        private void btnModifierEquipement_Click(object sender, EventArgs e)
        {
            if (tbxNomEquipement.Text != "")
            {
                enregModifierEquipement = true;
                tbxNomEquipement.Enabled = true;
                tbxQuantiteEquipement.Enabled = true;
                tbxPrixEquipement.Enabled = true;


                btnAjouterEquipement.Visible = false;
                btnSupprimerEquipement.Visible = false;
                btnModifierEquipement.Enabled = false;

                btnEnregistrerEquipement.Visible = true;
                btnAnnulerEquipement.Visible = true;

                lbxEquipements.Enabled = false;
                tbxRechercherEquipement.Enabled = false;
                btnRechercherEquipement.Enabled = false;
            }
        }

        private void btnSupprimerEquipement_Click(object sender, EventArgs e)
        {
            int idEquipement;
            const string message = "Es-tu sur de vouloir supprimer";
            const string caption = "Supprimer";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                try
                {
                    if (lbxEquipements.SelectedIndex >= 0)
                    {
                        idEquipement = Convert.ToInt32(tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[0]);
                        dbConnexion.supprimerEquipement(idEquipement);
                        dbConnexion.miseJourDataSet();

                        if (lbxEquipements.SelectedIndex != -1)
                        {
                            tbxNomEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[1].ToString();
                            tbxQuantiteEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[2].ToString();
                            tbxPrixEquipement.Text = tableEquipements.Rows[lbxEquipements.SelectedIndex].ItemArray[3].ToString();

                        }
                        else
                        {
                            tbxNomEquipement.Text = "";
                            tbxQuantiteEquipement.Text = "";
                            tbxPrixEquipement.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez sélectionner un équipement");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void tbxNomEquipement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }
        }

        private void tbxQuantiteEquipement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxPrixEquipement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbxRechercherEquipement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbxNomEquipement_Validating(object sender, CancelEventArgs e)
        {

            Regex nom = new Regex(@"^((([\p{L}]{1,30})[- ']?)+([\p{L}]{1,30}))$");
            if (!nom.IsMatch(this.tbxNomEquipement.Text))
            {
                errorProvider1.SetError(tbxNomEquipement, "Le nom est incorrect");
                tbxNomEquipement.Text = null;
                tbxNomEquipement.Focus();
                e.Cancel = true;

            }
        }

        private void tbxPrixEquipement_Validating(object sender, CancelEventArgs e)
        {
            Regex prixLoc = new Regex(@"^((([1-10000])(,[0-9]{1,2})?)|10000(,[0]{1,2})?)$");
            if (!prixLoc.IsMatch(this.tbxPrixEquipement.Text))
            {

                errorProvider1.SetError(tbxPrixEquipement, "Le prix est invalide");
                tbxPrixEquipement.Text = null;
                tbxPrixEquipement.Focus();
                e.Cancel = true;
            }
        }

        private void c(object sender, EventArgs e)
        {

        }
    }
}
