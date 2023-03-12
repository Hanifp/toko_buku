using MySql.Data.MySqlClient;
using System.Data;

namespace toko_buku
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = connections.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            conn = connections.getConnection();
            filldataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        public DataTable getDataBuku()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("title", typeof(string));
            table.Columns.Add("category", typeof(string));
            table.Columns.Add("stock", typeof(int));
            table.Columns.Add("Image", typeof(Image));

            using (MySqlConnection conn = connections.getConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT id, title, category, stock, Image FROM buku", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string title = reader.GetString(1);
                            string category = reader.GetString(2);
                            int stock = reader.GetInt32(3);
                            byte[] imgData = reader["Image"] as byte[];

                            Image image = null;
                            if (imgData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    image = Image.FromStream(ms);
                                }
                            }

                            table.Rows.Add(id, title, category, stock, image);
                        }
                    }
                }
            }

            return table;
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Image") && e.Value != null && e.Value != DBNull.Value)
            {
                byte[] img = e.Value as byte[];
                if (img != null && img.Length > 0)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream(img);
                        Image image = Image.FromStream(ms);
                        e.Value = image;
                        e.FormattingApplied = true;
                    }
                    catch (ArgumentException)
                    {
                        e.Value = null;
                    }
                }
                else
                {
                    e.Value = null;
                }
            }
        }



        public void filldataTable()
        {
            dataTable = getDataBuku();
            dataGridView1.DataSource = dataTable;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Cover";
            imageColumn.Name = "Image";
            imageColumn.DataPropertyName = "Image";
            dataGridView1.Columns.Remove("Image");
            dataGridView1.Columns.Insert(4, imageColumn);
            dataGridView1.Columns["Image"].ValueType = typeof(Image);

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "colEdit";
            dataGridView1.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "colDelete";
            dataGridView1.Columns.Add(colDelete);
        }



        private void store_label_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_label_Click(object sender, EventArgs e)
        {

        }

        private void title_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void category_label_Click(object sender, EventArgs e)
        {

        }

        private void category_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_label_Click(object sender, EventArgs e)
        {

        }

        private void stock_box_TextChanged(object sender, EventArgs e)
        {

        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(conn, "SET @id :=0; Update buku SET id = @id := (@id+1); " +
                "ALTER TABLE buku AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            // wrap MySqlConnection and MemoryStream in a using statement to ensure proper disposal
            using (MySqlConnection conn = connections.getConnection())
            using (MemoryStream ms = new MemoryStream())
            {
                MySqlCommand cmd;
                try
                {
                    // save the image to the MemoryStream object
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    string query = "INSERT INTO buku (title, category, stock, Image) VALUES (@title, @category, @stock, @Image)";

                    resetIncrement();

                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO buku (title, category, stock, Image) VALUE (@title, @category, @stock, @Image)";
                    cmd.Parameters.AddWithValue("@title", title_box.Text);
                    cmd.Parameters.AddWithValue("@category", category_box.Text);
                    cmd.Parameters.AddWithValue("@stock", stock_box.Text);
                    cmd.Parameters.AddWithValue("@Image", img);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Successfully saved");

                    dataGridView1.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["colEdit"].Index) // check if "Edit" button is clicked
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    id_box.Text = row.Cells["id"].Value.ToString();
                    etitle_box.Text = row.Cells["title"].Value.ToString();
                    ecategory_box.Text = row.Cells["category"].Value.ToString();
                    estock_box.Text = row.Cells["stock"].Value.ToString();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["colDelete"].Index) // check if "Delete" button is clicked
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        try
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM buku WHERE id=@id", conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.");
                                dataGridView1.Columns.Clear();
                                dataTable.Clear();
                                filldataTable();
                            }
                            else
                            {
                                MessageBox.Show("Record not found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void id_label_Click(object sender, EventArgs e)
        {

        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void etitle_label_Click(object sender, EventArgs e)
        {

        }

        private void etitle_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void ecategory_label_Click(object sender, EventArgs e)
        {

        }

        private void ecategory_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void estock_label_Click(object sender, EventArgs e)
        {

        }

        private void estock_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE buku SET title=@title, category=@category, stock=@stock WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@title", etitle_box.Text);
                cmd.Parameters.AddWithValue("@category", ecategory_box.Text);
                cmd.Parameters.AddWithValue("@stock", estock_box.Text);
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update Success.");
                    dataGridView1.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }
                else
                {
                    MessageBox.Show("Update Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;) | *.jpg;*.jpeg;*.png;*.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openfd.FileName);
            }
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM buku WHERE CONCAT (id, title, category, stock, Image) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void search_label_Click(object sender, EventArgs e)
        {

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            searchData(search_box.Text);
        }

    }
}