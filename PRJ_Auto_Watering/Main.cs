using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Auto_Watering
{
    public partial class Main : Form
    {
        Datahandler db = new Datahandler();
        public Main()
        {
            InitializeComponent();
        }

        private void lbxPlantName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlDataReader reader = db.OrderByDifference(lbxPlantName.SelectedItem.ToString());
            if (reader.HasRows)
            {
                int moisture = reader.GetInt32(2);
                lblMoisture.Text = "Optimal Moisture Level: " + moisture.ToString() + "%";

                rtxtDescription.Text = reader.GetString(3);

                string path = reader.GetString(4);
                if (path.Length > 0)
                {
                    pbxPlant.Image = Image.FromFile(path);
                }
                else
                {
                    pbxPlant.Image = null;
                }
            }
            else
            {
                lblMoisture.Text = "No such plant was found.";
            }
            reader.Close();
            db.Close();
        }

        private void lbxPlantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader  = db.OrderByDifference(lbxPlantName.SelectedItem.ToString());
            if (reader.HasRows) 
            {
                int moisture = reader.GetInt32(2);
                lblMoisture.Text = "Optimal Moisture Level: " + moisture.ToString() +"%";

                rtxtDescription.Text = reader.GetString(3);
                
                string path = reader.GetString(4);
                if (path.Length > 0)
                {
                    pbxPlant.Image = Image.FromFile(path);
                }
                else
                {
                    pbxPlant.Image = null;
                }
            }
            else
            {
                lblMoisture.Text = "No such plant was found.";
            }
            reader.Close();
            db.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AI_From ai = new AI_From();
            ai.Show();
            this.Hide();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
