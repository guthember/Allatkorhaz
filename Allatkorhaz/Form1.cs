using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Allatkorhaz
{
    public partial class frmKezelesTipus : Form
    {
        DB adatbazis = new DB("localhost","centrum","root");
        bool modositas = false;
        bool uj = false;
        public frmKezelesTipus()
        {
            InitializeComponent();

            KezelesTipusokFeltoltese();
        }

        private void KezelesTipusokFeltoltese()
        {
            try
            {
                string sql = "SELECT * FROM kezelestipus";

                adatbazis.MySqlKapcsolat.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, adatbazis.MySqlKapcsolat);
                DataTable tipusokTabla = new DataTable();
                da.Fill(tipusokTabla);
                dgvKezelesTipusok.DataSource = tipusokTabla;
                dgvKezelesTipusok.Rows[0].Selected = true;
                AdatotBeir(0);

                adatbazis.MySqlKapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdatotBeir(int idx)
        {
            tbTipus.Text = dgvKezelesTipusok.Rows[idx].Cells[1].Value.ToString();
        }

        private void VezerlokBeallitasa()
        {
            btnModositas.Enabled = !btnModositas.Enabled;
            btnUj.Enabled = !btnUj.Enabled;
            btnMegsem.Enabled = !btnMegsem.Enabled;
            btnMentes.Enabled = !btnMentes.Enabled;
            dgvKezelesTipusok.Enabled = !dgvKezelesTipusok.Enabled;
            tbTipus.Enabled = !tbTipus.Enabled;
        }

        private void dgvKezelesTipusok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kivalasztottSor = dgvKezelesTipusok.CurrentCell.RowIndex;
            AdatotBeir(kivalasztottSor);
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            VezerlokBeallitasa();
            modositas = true;
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            VezerlokBeallitasa();
            dgvKezelesTipusok.Rows[0].Selected = true;
            AdatotBeir(0);
            modositas = false;
            uj = false;
        }

        private void frmKezelesTipus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modositas || uj)
            {
                switch(MessageBox.Show("Módosítás alatt biztos kilépsz?", "Megerősítés" , MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (tbTipus.Text != "")
            {
                if (modositas)
                {
                    int idx = dgvKezelesTipusok.CurrentCell.RowIndex;
                    string id = dgvKezelesTipusok.Rows[idx].Cells[0].Value.ToString();

                    // itt még lehet ellenőrzini, hogy van-e már ilyen jelleg
                    string sql = $"update kezelestipus set jelleg='{tbTipus.Text}' where id = {id};";

                    try
                    {
                        adatbazis.MySqlKapcsolat.Open();

                        MySqlCommand cmd = new MySqlCommand(sql, adatbazis.MySqlKapcsolat);
                        cmd.ExecuteNonQuery();

                        adatbazis.MySqlKapcsolat.Close();

                        KezelesTipusokFeltoltese();
                        dgvKezelesTipusok.Rows[0].Selected = true;
                        AdatotBeir(0);

                        VezerlokBeallitasa();

                        modositas = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        VezerlokBeallitasa();
                    } 
                }
                else
                {
                    // itt még lehet ellenőrzini, hogy van-e már ilyen jelleg
                    string sql = $"INSERT INTO kezelestipus(jelleg) VALUES ('{tbTipus.Text}')";
                    try
                    {
                        adatbazis.MySqlKapcsolat.Open();

                        MySqlCommand cmd = new MySqlCommand(sql, adatbazis.MySqlKapcsolat);
                        cmd.ExecuteNonQuery();

                        adatbazis.MySqlKapcsolat.Close();

                        KezelesTipusokFeltoltese();
                        dgvKezelesTipusok.Rows[0].Selected = true;
                        AdatotBeir(0);

                        VezerlokBeallitasa();

                        uj = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        VezerlokBeallitasa();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Nem lehet üres adat!");
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            VezerlokBeallitasa();
            tbTipus.Text = "";
            uj = true;
        }
    }
}
