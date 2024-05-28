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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace reservationSalles2018
{
    public partial class frmSalles : Form
    {
        DataTable tableSalles , tableTypes;
       
        Boolean enregModifierSalle;

        DataRelation sallesTypes = frmM2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoinSalleType"];


        public frmSalles()
        {
            InitializeComponent();
        }

        private void salles_Load(object sender, EventArgs e)
        {
            
            tableSalles = frmM2LReservationSalles.reservationsSallesDataSet.Tables["Salles"];
            tableTypes = frmM2LReservationSalles.reservationsSallesDataSet.Tables["Types"];
         

            lbxSalles.DataSource = tableSalles;
            lbxSalles.DisplayMember = tableSalles.Columns[1].ToString();
            lbxSalles.ValueMember = tableSalles.Columns[0].ToString();

            cbxTypeSalle.DataSource = tableTypes;
            cbxTypeSalle.DisplayMember = tableTypes.Columns[1].ToString();
            cbxTypeSalle.ValueMember = tableTypes.Columns[0].ToString();

            tbxNomSalle.Enabled = false;
            cbxTypeSalle.Enabled = false;
            tbxSurfaceSalle.Enabled = false;
            tbxCapaciteSalle.Enabled = false;
            tbxPrixLocationSalle.Enabled = false;

            btnEnregistrerSalle.Visible = false;
            btnAnnulerSalle.Visible = false;

            tbxRechercherSalle.MaxLength = 40;
            tbxNomSalle.MaxLength = 40;
            tbxCapaciteSalle.MaxLength = 3;
            tbxPrixLocationSalle.MaxLength = 8;
            tbxSurfaceSalle.MaxLength = 3;
            cbxTypeSalle.MaxLength = 20;

            AutoValidate = AutoValidate.Disable;
            errorProvider.Clear();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void lbxSalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSalles.SelectedIndex != -1)
            {
                tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                cbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].GetParentRow(sallesTypes)["libelleType"].ToString();
                tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
                tbxPrixLocationSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[5].ToString();
            }
        }

        private void btnRechercheSalle_Click(object sender, EventArgs e)
        {
            int index = lbxSalles.FindString(tbxRechercherSalle.Text);
            if (index == -1)
            {
                MessageBox.Show("Salle introuvable.");
            }
            else
            {
                lbxSalles.SetSelected(index, true);
            }
        }

        private void btnModifierSalle_Click(object sender, EventArgs e)
        {
            if (tbxNomSalle.Text != "")
            {
                enregModifierSalle = true;
                tbxNomSalle.Enabled = true;
                cbxTypeSalle.Enabled = true;
                tbxSurfaceSalle.Enabled = true;
                tbxCapaciteSalle.Enabled = true;
                tbxPrixLocationSalle.Enabled = true;

                btnAjouterSalle.Visible = false;
                btnSupprimerSalle.Visible = false;
                btnModifierSalle.Enabled = false;

                btnEnregistrerSalle.Visible = true;
                btnAnnulerSalle.Visible = true;

                lbxSalles.Enabled = false;
                tbxRechercherSalle.Enabled = false;
            }
        }

        private void btnAnnulerSalle_Click(object sender, EventArgs e)
        {
            enregModifierSalle = false;

            tbxNomSalle.Enabled = false;
            cbxTypeSalle.Enabled = false;
            tbxSurfaceSalle.Enabled = false;
            tbxCapaciteSalle.Enabled = false;
            tbxPrixLocationSalle.Enabled = false;

            btnAjouterSalle.Visible = true;
            btnSupprimerSalle.Visible = true;
            btnModifierSalle.Enabled = true;

            btnEnregistrerSalle.Visible = false;
            btnAnnulerSalle.Visible = false;

            lbxSalles.Enabled = true;
            tbxRechercherSalle.Enabled = true;

            if (lbxSalles.SelectedIndex != -1)
            {
                tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                cbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].GetParentRow(sallesTypes)["libelleType"].ToString();
                tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
                tbxPrixLocationSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[5].ToString();
            }
        }

        private void btnAjouterSalle_Click(object sender, EventArgs e)
        {
                        
        
                tbxNomSalle.Text = "";
                cbxTypeSalle.SelectedIndex = 0;
                tbxSurfaceSalle.Text = "";
                tbxCapaciteSalle.Text = "";
                tbxPrixLocationSalle.Text = "";


                tbxNomSalle.Enabled = true;
                cbxTypeSalle.Enabled = true;
                tbxSurfaceSalle.Enabled = true;
                tbxCapaciteSalle.Enabled = true;
                tbxPrixLocationSalle.Enabled = true;

                btnAjouterSalle.Visible = false;
                btnSupprimerSalle.Visible = false;
                btnModifierSalle.Enabled = false;

                btnEnregistrerSalle.Visible = true;
                btnAnnulerSalle.Visible = true;

                lbxSalles.Enabled = false;
                tbxRechercherSalle.Enabled = false;
            

            
        }

        private void btnEnregistrerSalle_Click(object sender, EventArgs e)
        {
            int idSalle;
            short indice;

            indice = 0;
            const string message = "Es-tu sur de vouloir enregistrer";
            const string caption = "Enregistrer";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                errorProvider.Clear();
                if (ValidateChildren())
                {
                    tbxNomSalle.Text = tbxNomSalle.Text.Trim();
                    cbxTypeSalle.Text = cbxTypeSalle.Text.Trim();

                    try
                    {

                        if (enregModifierSalle == false)
                        {
                            dbConnexion.ajouterSalle(tbxNomSalle.Text, Convert.ToInt32(cbxTypeSalle.SelectedValue), Convert.ToInt16(tbxSurfaceSalle.Text), Convert.ToInt16(tbxCapaciteSalle.Text), Convert.ToSingle(tbxPrixLocationSalle.Text));
                        }
                        else
                        {
                            idSalle = Convert.ToInt32(tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[0]);
                            dbConnexion.modifierSalle(idSalle, tbxNomSalle.Text, Convert.ToInt32(cbxTypeSalle.SelectedValue), Convert.ToInt16(tbxSurfaceSalle.Text), Convert.ToInt16(tbxCapaciteSalle.Text), Convert.ToSingle(tbxPrixLocationSalle.Text));
                            indice = Convert.ToInt16(lbxSalles.SelectedIndex);
                        }

                        dbConnexion.miseJourDataSet();
                        lbxSalles.DataSource = tableSalles;
                        lbxSalles.DisplayMember = tableSalles.Columns[1].ToString();

                        if (enregModifierSalle == true)
                        {
                            lbxSalles.SelectedIndex = indice;
                            enregModifierSalle = false;
                        }
                        else
                        {
                            lbxSalles.SelectedIndex = lbxSalles.Items.Count - 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    tbxNomSalle.Enabled = false;
                    cbxTypeSalle.Enabled = false;
                    tbxSurfaceSalle.Enabled = false;
                    tbxCapaciteSalle.Enabled = false;
                    tbxPrixLocationSalle.Enabled = false;

                    btnAjouterSalle.Visible = true;
                    btnSupprimerSalle.Visible = true;
                    btnModifierSalle.Enabled = true;

                    btnEnregistrerSalle.Visible = false;
                    btnAnnulerSalle.Visible = false;

                    lbxSalles.Enabled = true;
                    tbxRechercherSalle.Enabled = true;
                    if (lbxSalles.SelectedIndex != -1)
                    {
                        tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                        cbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].GetParentRow(sallesTypes)["libelleType"].ToString();
                        tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                        tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
                        tbxPrixLocationSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[5].ToString();


                    }
                }

            }
            
        }

        private void tbxNomSalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }
        }

        private void cbxTypeSalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxSurfaceSalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxCapaciteSalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxPrixLocationSalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbxRechercherSalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }
        }

        private void tbxNomSalle_Validating(object sender, CancelEventArgs e)
        {
            Regex nom = new Regex(@"^((([\p{L}]{1,30})[- ']?)+([\p{L}]{1,30}))$");
            if (!nom.IsMatch(this.tbxNomSalle.Text))
            {
                errorProvider.SetError(tbxNomSalle, "Le nom est incorrect");
                tbxNomSalle.Text = null;
                tbxNomSalle.Focus();
                e.Cancel = true;
            }
        }

        private void tbxSurfaceSalle_Validating(object sender, CancelEventArgs e)
        {
            int surface;
            if (!int.TryParse(tbxSurfaceSalle.Text, out surface) || surface <= 1 || surface > 400)
            {
                errorProvider.SetError(tbxSurfaceSalle, "La surface doit être comprise entre 1 et 400");
                tbxSurfaceSalle.Text = null;
                tbxSurfaceSalle.Focus();
                e.Cancel = true;
            }
        }

        private void tbxCapaciteSalle_Validating(object sender, CancelEventArgs e)
        {
            int surface;
            if (!int.TryParse(tbxCapaciteSalle.Text, out surface) || surface <= 1 || surface > 300)
            {
                errorProvider.SetError(tbxCapaciteSalle, "La capacité de la salle doit être comprise entre 1 et 400");
                tbxCapaciteSalle.Text = null;
                tbxCapaciteSalle.Focus();
                e.Cancel = true;
            }
        }
        
        private void tbxPrixLocationSalle_Validating(object sender, CancelEventArgs e)
        {
            Regex prixLoc = new Regex(@"^((([1-9999])(,[0-9][0-9])?)|10000(,[0]{1,2})?)$");
            
            if (!prixLoc.IsMatch(this.tbxPrixLocationSalle.Text))
            {
                errorProvider.SetError(tbxPrixLocationSalle, "Le prix est invalide");
                tbxPrixLocationSalle.Text = null;
                tbxPrixLocationSalle.Focus();
                e.Cancel = true;
            }
        }


        private void btnSupprimerSalle_Click(object sender, EventArgs e)
        {
            int idSalle;


            const string message = "Es-tu sur de vouloir supprimer";
            const string caption = "Supprimer";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { 
                try
                {
                    if (lbxSalles.SelectedIndex >= 0)
                    {
                        idSalle = Convert.ToInt32(tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[0]);
                        dbConnexion.supprimerSalle(idSalle);
                        dbConnexion.miseJourDataSet();

                        if (lbxSalles.SelectedIndex != -1)
                        {
                            tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                            cbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].GetParentRow(sallesTypes)["libelleType"].ToString();
                            tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                            tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
                            tbxPrixLocationSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[5].ToString();

                        }
                        else
                        {
                            tbxNomSalle.Text = "";
                            cbxTypeSalle.Text = "";
                            tbxSurfaceSalle.Text = "";
                            tbxCapaciteSalle.Text = "";
                            tbxPrixLocationSalle.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez sélectionner une salle");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

    }
}
