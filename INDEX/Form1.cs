namespace INDEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = "Test.txt";
        int numberRecord = 0;
        int length_Key = 10;
        int length_location = 10;
        int[] keys = new int[100];
        int[] locations = new int[100];
        FileStream myFile, findex;
        StreamReader filereader, indexReader;
        StreamWriter filewriter, indexWriter;

        #region open
        private void open_Click(object sender, EventArgs e)
        {
            myFile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            filereader = new StreamReader(myFile);
            filewriter = new StreamWriter(myFile);
            MessageBox.Show("The File Is Opened");
        }
        #endregion
        #region Clear Form
        private void clear_Click(object sender, EventArgs e)
        {
            aid.Text = fName.Text = lName.Text = balance.Text = null;
            MessageBox.Show("The File Is Cleared");
        }
        #endregion
        #region Exit
        private void exit_Click(object sender, EventArgs e)
        {
            filereader.Close();
            filewriter.Close();
            myFile.Close();
            this.Dispose();
        }
        #endregion
        #region Insert
        private void insert_Click(object sender, EventArgs e)
        {
            myFile.Seek(0, SeekOrigin.End);
            long location = myFile.Position;
            int id = int.Parse(aid.Text);
            string fn = fName.Text;
            string ln = lName.Text;
            string bal = balance.Text;
            string record = $"{id},{fn},{ln},{bal}";
            filewriter.WriteLine(record);
            filewriter.Flush();
            InsertKey(id, location);
            MessageBox.Show("Key inserted.");
        }
        #endregion
        #region insert Fuction To Shift Down
        void InsertKey(int primary_Key, long new_Location)
        {
            bool flag = false;
            int i, j;
            for (i = 0; i < length_Key; i++)
            {
                if (primary_Key < keys[i])
                {
                    flag = true;
                    break;
                }

            }
            if (flag)
            {
                for (j = length_Key - 1; j >= i; j++)
                {
                    keys[j + 1] = keys[j];
                    locations[j + 1] = locations[j];
                }
                keys[i] = primary_Key;
                locations[i] = (int)new_Location;
            }
            else
            {
                keys[length_Key] = primary_Key;
                locations[length_location] = (int)new_Location;
            }
            numberRecord++;
        }
        #endregion
        #region Fixed Length
        string Fixed_Length(int primary_Key, int Length)
        {
            string s = Convert.ToString(primary_Key);
            int length_Key = s.Length;
            for (int i = 1; i <= Length- length_Key; i++)
            {
                s += " ";
            }
            return s;
        }
        #endregion


    }

}
