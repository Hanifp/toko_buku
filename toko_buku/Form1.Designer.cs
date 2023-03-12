namespace toko_buku
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            id_box = new TextBox();
            title_box = new TextBox();
            category_box = new TextBox();
            stock_box = new TextBox();
            id_label = new Label();
            stock_label = new Label();
            category_label = new Label();
            insert_button = new Button();
            store_label = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            edit_button = new Button();
            etitle_box = new TextBox();
            ecategory_box = new TextBox();
            estock_box = new TextBox();
            etitle_label = new Label();
            ecategory_label = new Label();
            estock_label = new Label();
            search_box = new TextBox();
            title_label = new Label();
            pictureBox2 = new PictureBox();
            search_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 387);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(860, 215);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_box
            // 
            id_box.Location = new Point(672, 141);
            id_box.Name = "id_box";
            id_box.Size = new Size(200, 31);
            id_box.TabIndex = 1;
            id_box.TextChanged += id_box_TextChanged;
            // 
            // title_box
            // 
            title_box.Location = new Point(340, 141);
            title_box.Name = "title_box";
            title_box.Size = new Size(200, 31);
            title_box.TabIndex = 2;
            title_box.TextChanged += title_box_TextChanged;
            // 
            // category_box
            // 
            category_box.Location = new Point(340, 181);
            category_box.Name = "category_box";
            category_box.Size = new Size(200, 31);
            category_box.TabIndex = 3;
            category_box.TextChanged += category_box_TextChanged;
            // 
            // stock_box
            // 
            stock_box.Location = new Point(340, 221);
            stock_box.Name = "stock_box";
            stock_box.Size = new Size(200, 31);
            stock_box.TabIndex = 4;
            stock_box.TextChanged += stock_box_TextChanged;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(577, 144);
            id_label.Name = "id_label";
            id_label.Size = new Size(30, 25);
            id_label.TabIndex = 5;
            id_label.Text = "ID";
            id_label.Click += id_label_Click;
            // 
            // stock_label
            // 
            stock_label.AutoSize = true;
            stock_label.Location = new Point(234, 224);
            stock_label.Name = "stock_label";
            stock_label.Size = new Size(55, 25);
            stock_label.TabIndex = 8;
            stock_label.Text = "Stock";
            stock_label.Click += stock_label_Click;
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.Location = new Point(234, 184);
            category_label.Name = "category_label";
            category_label.Size = new Size(84, 25);
            category_label.TabIndex = 7;
            category_label.Text = "Category";
            category_label.Click += category_label_Click;
            // 
            // insert_button
            // 
            insert_button.Location = new Point(428, 298);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(112, 34);
            insert_button.TabIndex = 10;
            insert_button.Text = "Insert";
            insert_button.UseVisualStyleBackColor = true;
            insert_button.Click += insert_button_Click;
            // 
            // store_label
            // 
            store_label.AutoSize = true;
            store_label.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            store_label.ForeColor = Color.Cornsilk;
            store_label.Location = new Point(148, 44);
            store_label.Name = "store_label";
            store_label.Size = new Size(275, 36);
            store_label.TabIndex = 11;
            store_label.Text = "Hanif's Book Store";
            store_label.Click += store_label_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(store_label);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 117);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book__1_1;
            pictureBox1.Location = new Point(32, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // edit_button
            // 
            edit_button.Location = new Point(760, 298);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(112, 34);
            edit_button.TabIndex = 13;
            edit_button.Text = "Edit";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += edit_button_Click;
            // 
            // etitle_box
            // 
            etitle_box.Location = new Point(672, 181);
            etitle_box.Name = "etitle_box";
            etitle_box.Size = new Size(200, 31);
            etitle_box.TabIndex = 14;
            etitle_box.TextChanged += etitle_box_TextChanged;
            // 
            // ecategory_box
            // 
            ecategory_box.Location = new Point(672, 221);
            ecategory_box.Name = "ecategory_box";
            ecategory_box.Size = new Size(200, 31);
            ecategory_box.TabIndex = 15;
            ecategory_box.TextChanged += ecategory_box_TextChanged;
            // 
            // estock_box
            // 
            estock_box.Location = new Point(672, 261);
            estock_box.Name = "estock_box";
            estock_box.Size = new Size(200, 31);
            estock_box.TabIndex = 16;
            estock_box.TextChanged += estock_box_TextChanged;
            // 
            // etitle_label
            // 
            etitle_label.AutoSize = true;
            etitle_label.Location = new Point(577, 184);
            etitle_label.Name = "etitle_label";
            etitle_label.Size = new Size(44, 25);
            etitle_label.TabIndex = 17;
            etitle_label.Text = "Title";
            etitle_label.Click += etitle_label_Click;
            // 
            // ecategory_label
            // 
            ecategory_label.AutoSize = true;
            ecategory_label.Location = new Point(577, 221);
            ecategory_label.Name = "ecategory_label";
            ecategory_label.Size = new Size(84, 25);
            ecategory_label.TabIndex = 18;
            ecategory_label.Text = "Category";
            ecategory_label.Click += ecategory_label_Click;
            // 
            // estock_label
            // 
            estock_label.AutoSize = true;
            estock_label.Location = new Point(577, 261);
            estock_label.Name = "estock_label";
            estock_label.Size = new Size(55, 25);
            estock_label.TabIndex = 19;
            estock_label.Text = "Stock";
            estock_label.Click += estock_label_Click;
            // 
            // search_box
            // 
            search_box.Location = new Point(121, 350);
            search_box.Name = "search_box";
            search_box.Size = new Size(751, 31);
            search_box.TabIndex = 21;
            search_box.TextChanged += search_box_TextChanged;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(234, 144);
            title_label.Name = "title_label";
            title_label.Size = new Size(44, 25);
            title_label.TabIndex = 22;
            title_label.Text = "Title";
            title_label.Click += title_label_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(34, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // search_label
            // 
            search_label.AutoSize = true;
            search_label.Location = new Point(34, 353);
            search_label.Name = "search_label";
            search_label.Size = new Size(64, 25);
            search_label.TabIndex = 24;
            search_label.Text = "Search";
            search_label.Click += search_label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 706);
            Controls.Add(search_label);
            Controls.Add(pictureBox2);
            Controls.Add(title_label);
            Controls.Add(search_box);
            Controls.Add(estock_label);
            Controls.Add(ecategory_label);
            Controls.Add(etitle_label);
            Controls.Add(estock_box);
            Controls.Add(ecategory_box);
            Controls.Add(etitle_box);
            Controls.Add(edit_button);
            Controls.Add(panel1);
            Controls.Add(insert_button);
            Controls.Add(stock_label);
            Controls.Add(category_label);
            Controls.Add(id_label);
            Controls.Add(stock_box);
            Controls.Add(category_box);
            Controls.Add(title_box);
            Controls.Add(id_box);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox id_box;
        private TextBox title_box;
        private TextBox category_box;
        private TextBox stock_box;
        private Label id_label;
        private Label ins_title;
        private Label stock_label;
        private Label category_label;
        private Button insert_button;
        private Label store_label;
        private Panel panel1;
        private Button edit_button;
        private TextBox etitle_box;
        private TextBox ecategory_box;
        private TextBox estock_box;
        private Label etitle_label;
        private Label ecategory_label;
        private Label estock_label;
        private Label labeltitle;
        private TextBox search_box;
        private PictureBox pictureBox1;
        private Label title_label;
        private PictureBox pictureBox2;
        private Label search_label;
    }
}