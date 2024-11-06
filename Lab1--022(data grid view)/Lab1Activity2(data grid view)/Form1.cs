namespace Lab1Activity2_data_grid_view_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Insert Data
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";

            string[] row = new string[]
           { "1", "Product 1", "1000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "5", "Product 5", "5000" };
            dataGridView1.Rows.Add(row);
        }

        // Retrive Data
        String value;
        private void button2_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count;
               col++)
                {
                    value +=
 dataGridView1.Rows[rows].Cells[col].Value.ToString();


                    value += "\t";

                }
                value += "\n";
            }
            MessageBox.Show(value);
            value = "";
        }

        // Insert Data in Run Time
        private void button3_Click(object sender, EventArgs e)
        {
            String id = id_textbox.Text;
            String name = name_textbox.Text;
            String price = price_textbox.Text;

            // String[] newRow = new String[3];
            // newRow[0] = id;
            // newRow[1] = name;
            // newRow[2] = price;

            // OR
            
            String[] newRow = new String[] {id, name, price };
            dataGridView1.Rows.Add(newRow);
            
        }
    }
}