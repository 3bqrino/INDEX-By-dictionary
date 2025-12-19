namespace INDEX
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
            label1 = new Label();
            id = new Label();
            aid = new TextBox();
            fName = new TextBox();
            label3 = new Label();
            lName = new TextBox();
            label4 = new Label();
            balance = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            open = new Button();
            search = new Button();
            delete = new Button();
            exit = new Button();
            rewrite = new Button();
            load = new Button();
            clear = new Button();
            insert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Index Form";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(12, 49);
            id.Name = "id";
            id.Size = new Size(18, 15);
            id.TabIndex = 1;
            id.Text = "ID";
            // 
            // aid
            // 
            aid.Location = new Point(88, 46);
            aid.Name = "aid";
            aid.Size = new Size(100, 23);
            aid.TabIndex = 2;
            // 
            // fName
            // 
            fName.Location = new Point(88, 75);
            fName.Name = "fName";
            fName.Size = new Size(100, 23);
            fName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // lName
            // 
            lName.Location = new Point(88, 104);
            lName.Name = "lName";
            lName.Size = new Size(100, 23);
            lName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // balance
            // 
            balance.Location = new Point(88, 133);
            balance.Name = "balance";
            balance.Size = new Size(100, 23);
            balance.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 7;
            label5.Text = "Balance";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 246);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(226, 129);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 228);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 9;
            label6.Text = "Index";
            // 
            // open
            // 
            open.Location = new Point(255, 55);
            open.Name = "open";
            open.Size = new Size(75, 23);
            open.TabIndex = 11;
            open.Text = "Open";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // search
            // 
            search.Location = new Point(93, 171);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 12;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(174, 171);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 13;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Location = new Point(255, 185);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 14;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // rewrite
            // 
            rewrite.Location = new Point(255, 142);
            rewrite.Name = "rewrite";
            rewrite.Size = new Size(94, 37);
            rewrite.TabIndex = 15;
            rewrite.Text = "Rewrite Index";
            rewrite.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            load.Location = new Point(255, 113);
            load.Name = "load";
            load.Size = new Size(75, 23);
            load.TabIndex = 16;
            load.Text = " Load Index";
            load.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            clear.Location = new Point(255, 84);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 17;
            clear.Text = "Clear Form";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // insert
            // 
            insert.Location = new Point(12, 171);
            insert.Name = "insert";
            insert.Size = new Size(75, 23);
            insert.TabIndex = 18;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 450);
            Controls.Add(insert);
            Controls.Add(clear);
            Controls.Add(load);
            Controls.Add(rewrite);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(search);
            Controls.Add(open);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(balance);
            Controls.Add(label5);
            Controls.Add(lName);
            Controls.Add(label4);
            Controls.Add(fName);
            Controls.Add(label3);
            Controls.Add(aid);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label id;
        private TextBox aid;
        private TextBox fName;
        private Label label3;
        private TextBox lName;
        private Label label4;
        private TextBox balance;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button open;
        private Button search;
        private Button delete;
        private Button exit;
        private Button rewrite;
        private Button load;
        private Button clear;
        private Button insert;
    }
}
