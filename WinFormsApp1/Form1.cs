using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileStream file_Stream;
        StreamReader fileReader;
        StreamWriter fileWriter;
        FileStream index_Stream;
        StreamReader indexReader;
        StreamWriter indexWriter;
        string filename = "Test.txt";
        string indexname = "Index.txt";
        SortedDictionary<int, long> dic = new SortedDictionary<int, long>();// dictionary store int(key),long(position)
        #region Open
        private void open_Click(object sender, EventArgs e)
        {
            file_Stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fileReader = new StreamReader(file_Stream);
            fileWriter = new StreamWriter(file_Stream);
            MessageBox.Show("File Opened.");
            insert.Enabled =
            search.Enabled =
            delete.Enabled =
            exit.Enabled =
            rewrite.Enabled =
            load.Enabled =
            clear.Enabled = true;
        }
        #endregion
        #region Insert
        private void insert_Click(object sender, EventArgs e)
        {
            file_Stream.Seek(0, SeekOrigin.End);
            long loc = file_Stream.Position; // store position in var.(loc)
            int key = int.Parse(aid.Text);

            if (dic.ContainsKey(key))//check the key isn't exist optional
            {
                // ContainsKey(key) return values true is found or false
                MessageBox.Show("Key already exists.");
                return;
            }
            string record = aid.Text + "|" + fName.Text + "|" + lName.Text + "|" + balance.Text;
            fileWriter.WriteLine(record);
            fileWriter.Flush();
            dic.Add(key, loc); // store primary key and his position
            MessageBox.Show("Record Inserted.");
            aid.Clear();
            fName.Clear();
            lName.Clear();
            balance.Clear();
        }
        #endregion

        #region Load Index
        private void load_Click(object sender, EventArgs e)
        {
            index_Stream = new FileStream(indexname, FileMode.Open, FileAccess.Read);
            indexReader = new StreamReader(index_Stream);

            dic.Clear();
            textBox5.Clear();
            textBox5.Text = "Key\tLocation\r\n";
            string line;
            while ((line = indexReader.ReadLine()) != null) // loop to read line in index file
            {
                string[] arr = line.Split('|');
                int key = int.Parse(arr[0]);
                long loc = long.Parse(arr[1]);

                if (!dic.ContainsKey(key)) // check key isn't exist
                {
                    dic.Add(key, loc);
                    textBox5.Text += key + "\t" + loc + "\r\n";
                }
            }
            indexReader.Close();
            index_Stream.Close();
            MessageBox.Show("Index Loaded.");
        }
        #endregion

        #region Rewrite Index
        private void rewrite_Click(object sender, EventArgs e)
        {
            index_Stream = new FileStream(indexname, FileMode.Create, FileAccess.Write);
            indexWriter = new StreamWriter(index_Stream);

           foreach (KeyValuePair<int,long> item in dic)
            {
                indexWriter.WriteLine(item.Key + "|" + item.Value);
            }
            indexWriter.Close();
            index_Stream.Close();
            MessageBox.Show("Index Rewritten.");
        }
        #endregion
        #region Search
        private void search_Click(object sender, EventArgs e)
        {
            int key = int.Parse(aid.Text);
            long loc = SearchKey(key);

            if (loc == -1)
            {
                MessageBox.Show("Not Found.");
                return;
            }
            fileReader.DiscardBufferedData(); // to clear the buffer
            file_Stream.Seek(loc, SeekOrigin.Begin);// move to the position in begin
            string line = fileReader.ReadLine();
            string[] field = line.Split('|');
            aid.Text = field[0];
            fName.Text = field[1];
            lName.Text = field[2];
            balance.Text = field[3];
        }
        #endregion

        #region Search Method
        long SearchKey(int key)
        {
            if (dic.TryGetValue(key, out long loc))
                // return true if found and store position in loc
                // out long loc is used to return the position
                return loc;

            return -1;// flag value not found
        }
        #endregion

        #region Delete
        private void delete_Click(object sender, EventArgs e)
        {
            int key = int.Parse(aid.Text);
            long loc = SearchKey(key); // get position from search method

            if (loc == -1)
            {
                MessageBox.Show("Not Found.");
                return; 
            }
            file_Stream.Seek(loc, SeekOrigin.Begin);// move to the position in begin line
            fileWriter.Write("*");
            fileWriter.Flush();
            dic.Remove(key);// remove key from dictionary
            MessageBox.Show("Record Deleted.");
            clear_Click(sender, e);
        }
        #endregion

        #region Clear
        private void clear_Click(object sender, EventArgs e)
        {
            aid.Clear();
            fName.Clear();
            lName.Clear();
            balance.Clear();
            textBox5.Clear();
        }
        #endregion

        #region Exit
        private void exit_Click(object sender, EventArgs e)
        {
            fileWriter.Close();
            fileReader.Close();
            file_Stream.Close();
            this.Close();
        }
        #endregion

        #region KeyDown
        private void aid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fName.Focus();
        }

        private void fName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lName.Focus();
        }

        private void lName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                balance.Focus();
        }
        #endregion
    }
}
