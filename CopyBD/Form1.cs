using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CopyBD
{
    public partial class Form1 : Form
    {
        string server = string.Empty;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            if (ServerNametxt.Text != string.Empty || UniNametxt.Text != string.Empty || UniCopyNametxt.Text != string.Empty ) //
            {
                string dbName, dbCopyName;
                if (numericUpDownFROM.Value > numericUpDownTO.Value )
                {
                    MessageBox.Show("значение первого счетичка (\"с\") дожно быть выше значения второго счетчика (\"по\")");
                }
                else
                {
                    for (int i = Convert.ToInt32(numericUpDownFROM.Value); i < Convert.ToInt32(numericUpDownTO.Value)+1; i++)
                    {
                        try
                        {

                            dbName = UniNametxt.Text.Replace("*count*", i < 10 ? $"0{i}" : i.ToString());
                            dbCopyName = UniCopyNametxt.Text.Replace("*count*", i < 10 ? $"0{i}" : i.ToString());

                            SqlConnection connection = new SqlConnection($"Data Source = {ServerNametxt.Text}; Initial Catalog = {dbName}; Integrated Security = true");

                            connection.Open();

                            SqlCommand backup = new SqlCommand(
                                $@"BACKUP DATABASE [{dbName}] TO  DISK = N'd:\backup\{dbName}' WITH NOFORMAT, NOINIT,  NAME = N'{dbName}-Полная База данных Резервное копирование', SKIP, NOREWIND, NOUNLOAD,  STATS = 10",
                                connection);
                            backup.ExecuteNonQuery();

                            SqlCommand restore = new SqlCommand(
                                $@"RESTORE DATABASE [{dbCopyName}] FROM  DISK = N'd:\backup\{dbName}.bak' WITH  MOVE N'{dbName}' TO N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\DATA\{dbCopyName}.mdf',  MOVE N'{dbName}_log' TO N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\DATA\{dbCopyName}.ldf',  NOUNLOAD,  STATS = 5",
                                connection);
                            restore.ExecuteNonQuery();

                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }

                    }
                    MessageBox.Show("Успешно!");
                }
                
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя/адрес сервера");
            }





        }

        private void SelectBackupPathbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
