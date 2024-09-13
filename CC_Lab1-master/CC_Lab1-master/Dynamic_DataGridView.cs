using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CC_Lab1.Dynamic_DataGridView;

namespace CC_Lab1
{
    public partial class Dynamic_DataGridView : Form
    {
        List<Emp> list = new List<Emp>();
        int newID;
        string newName;
        string newCity;
        public Dynamic_DataGridView()
        {
            InitializeComponent();
        }

        private void Dynamic_DataGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list;
        }
        public class Emp
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public Emp(int id, string name, string city)
            {
                this.ID = id;
                this.Name = name;
                this.City = city;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(id_field.Text, out newID))
            {
                newName = name_field.Text;
                newCity = address_field.Text;

                // Check if other fields are valid
                if (!string.IsNullOrEmpty(newName) && !string.IsNullOrEmpty(newCity))
                {
                    list.Add(new Emp(newID, newName, newCity));
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                    id_field.Text = "";
                    name_field.Text = "";
                    address_field.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter valid Name and City fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value for ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Clear_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
