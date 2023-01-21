using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRJ_Auto_Watering
{
    public partial class EditForm : Form
    {
        Datahandler db = new Datahandler();
        BindingSource source = new BindingSource();
        string path;
        public EditForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.updatePData(int.Parse(txtID.Text), txtName.Text, int.Parse(txtMoisture.Text), rtxtDescription.Text);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Select Valid Document(*.png; *.jpg; *.jpeg; *.gif; *.jfif)|*.png; *.jpg; *.jpeg; *.gif; *.jfif";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        lblPath.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Images\\" + filename);
                    MessageBox.Show("Document uploaded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = db.getPlants();
            if (reader == null) return;
            source.DataSource = reader;
            dgvPlants.DataSource = source;
            db.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void dgvPlants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvPlants.CurrentCell.RowIndex;
            txtID.Text = dgvPlants.Rows[rowindex].Cells[0].Value.ToString();
            txtName.Text = dgvPlants.Rows[rowindex].Cells[1].Value.ToString();
            txtMoisture.Text = dgvPlants.Rows[rowindex].Cells[2].Value.ToString();
            rtxtDescription.Clear();
            rtxtDescription.Text = dgvPlants.Rows[rowindex].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.insertPData(txtName.Text, int.Parse(txtMoisture.Text), rtxtDescription.Text, path);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.deletePData(int.Parse(txtID.Text));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AI_From ai = new AI_From();
            ai.Show();
            this.Hide();
            
        }

        private void addEditPlantsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
