namespace WinFormsApp1
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
            insert = new Button();
            clear = new Button();
            load = new Button();
            rewrite = new Button();
            exit = new Button();
            delete = new Button();
            search = new Button();
            open = new Button();
            textBox5 = new TextBox();
            balance = new TextBox();
            label5 = new Label();
            lName = new TextBox();
            label4 = new Label();
            fName = new TextBox();
            label3 = new Label();
            aid = new TextBox();
            id = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // insert
            // 
            insert.BackColor = Color.MediumSeaGreen;
            insert.Enabled = false;
            insert.Location = new Point(5, 138);
            insert.Name = "insert";
            insert.Size = new Size(222, 23);
            insert.TabIndex = 37;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // clear
            // 
            clear.Enabled = false;
            clear.Location = new Point(53, 96);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 36;
            clear.Text = "Clear Form";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // load
            // 
            load.Enabled = false;
            load.Location = new Point(12, 67);
            load.Name = "load";
            load.Size = new Size(75, 23);
            load.TabIndex = 35;
            load.Text = " Load Index";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // rewrite
            // 
            rewrite.Enabled = false;
            rewrite.Location = new Point(93, 67);
            rewrite.Name = "rewrite";
            rewrite.Size = new Size(75, 23);
            rewrite.TabIndex = 34;
            rewrite.Text = "Rewrite Index";
            rewrite.UseVisualStyleBackColor = true;
            rewrite.Click += rewrite_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Enabled = false;
            exit.Location = new Point(169, 393);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 33;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.IndianRed;
            delete.Enabled = false;
            delete.Location = new Point(81, 22);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 32;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.BackColor = Color.MediumSeaGreen;
            search.Enabled = false;
            search.Location = new Point(0, 22);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 31;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // open
            // 
            open.Location = new Point(5, 393);
            open.Name = "open";
            open.Size = new Size(75, 23);
            open.TabIndex = 30;
            open.Text = "Open";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 26);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(226, 162);
            textBox5.TabIndex = 29;
            // 
            // balance
            // 
            balance.Location = new Point(81, 109);
            balance.Name = "balance";
            balance.Size = new Size(100, 23);
            balance.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 112);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 26;
            label5.Text = "Balance";
            // 
            // lName
            // 
            lName.Location = new Point(81, 80);
            lName.Name = "lName";
            lName.Size = new Size(100, 23);
            lName.TabIndex = 25;
            lName.KeyDown += lName_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 83);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 24;
            label4.Text = "Last Name";
            // 
            // fName
            // 
            fName.Location = new Point(81, 51);
            fName.Name = "fName";
            fName.Size = new Size(100, 23);
            fName.TabIndex = 23;
            fName.KeyDown += fName_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 54);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 22;
            label3.Text = "First Name";
            // 
            // aid
            // 
            aid.Location = new Point(81, 22);
            aid.Name = "aid";
            aid.Size = new Size(100, 23);
            aid.TabIndex = 21;
            aid.KeyDown += aid_KeyDown;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(5, 25);
            id.Name = "id";
            id.Size = new Size(18, 15);
            id.TabIndex = 20;
            id.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(5, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 194);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Index File";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(aid);
            groupBox2.Controls.Add(id);
            groupBox2.Controls.Add(insert);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(fName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(balance);
            groupBox2.Location = new Point(7, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 176);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Welcome Page";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkGray;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(delete);
            groupBox3.Controls.Add(rewrite);
            groupBox3.Controls.Add(clear);
            groupBox3.Controls.Add(load);
            groupBox3.Controls.Add(search);
            groupBox3.Location = new Point(250, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(174, 136);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buttons";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 37;
            label1.Text = "Search Or Delete in TextBox ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(455, 449);
            Controls.Add(open);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(exit);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button insert;
        private Button clear;
        private Button load;
        private Button rewrite;
        private Button exit;
        private Button delete;
        private Button search;
        private Button open;
        private TextBox textBox5;
        private TextBox balance;
        private Label label5;
        private TextBox lName;
        private Label label4;
        private TextBox fName;
        private Label label3;
        private TextBox aid;
        private Label id;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
    }
}
