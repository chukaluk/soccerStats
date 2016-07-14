using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLFunctions.refresh(this.dataGridView1);
            comboField.Text = "Choose field to edit";
            comboField.Items.Add("Name");
            comboField.Items.Add("Team");
            comboField.Items.Add("Goals");
            comboField.Items.Add("Assists");
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if(insertNameBox.Text != "")
            {
                int goals = Int32.Parse(insertGoalBox.Text);
                int assists = Int32.Parse(insertAssistBox.Text);
                SQLFunctions.Insert(insertNameBox.Text, insertTeamBox.Text, goals, assists);
                SQLFunctions.refresh(this.dataGridView1);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(deleteBox.Text);

            if (deleteBox.Text != "")
            {
                SQLFunctions.Delete(id);
                SQLFunctions.refresh(this.dataGridView1);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idBox.Text);

            if (comboField.Text == "Name" && updateNewValueBox.Text != "")
            {
                SQLFunctions.UpdateName(updateNewValueBox.Text, id);
                SQLFunctions.refresh(this.dataGridView1);
            }
            else if(comboField.Text == "Team" && updateNewValueBox.Text != "")
            {

                SQLFunctions.UpdateTeam(updateNewValueBox.Text, id);
                SQLFunctions.refresh(this.dataGridView1);
            }
            else if(comboField.Text == "Goals" && updateNewValueBox.Text != "")
            {
                int goals = Int32.Parse(updateNewValueBox.Text);
                SQLFunctions.UpdateGoals(goals, id);
                SQLFunctions.refresh(this.dataGridView1);
            }
            else if(comboField.Text == "Assists" && updateNewValueBox.Text != "")
            {
                int assists = Int32.Parse(updateNewValueBox.Text);
                SQLFunctions.UpdateAssists(assists, id);
                SQLFunctions.refresh(this.dataGridView1);
            }            
        }
    }
}
