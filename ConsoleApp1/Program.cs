using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a= "dbName*count* - copy", b;
            int al = a.Length;
            string dbName = a.Replace("*count*", a.Length.ToString());

            Console.WriteLine(dbName);
            Console.ReadLine();
            string ServerNametxt = @"sbd\mssql",
                db1Name = "wsr-01",
                dbCopyName = "11AAA11AAA";
            SqlConnection connection = new SqlConnection($"Data Source = {ServerNametxt}; Initial Catalog = {dbName}; Integrated Security = true");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            connection.Open();

            SqlCommand backup = new SqlCommand(
                $@"USE master 
                   
                   BACKUP DATABASE [{dbName}] TO  DISK = N'd:\backup\{dbName}' WITH NOFORMAT, NOINIT,  NAME = N'{dbName}-Полная База данных Резервное копирование', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
                   ",
                connection);
            backup.ExecuteNonQuery();

            SqlCommand restore = new SqlCommand(
                $@"USE master
                   
                   RESTORE DATABASE [{dbCopyName}] FROM  DISK = N'd:\backup\{dbName}.bak' WITH  MOVE N'{dbName}' TO N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\DATA\{dbCopyName}.mdf',  MOVE N'{dbName}_log' TO N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\DATA\{dbCopyName}.ldf',  NOUNLOAD,  STATS = 5
                   ",
                connection);
            restore.ExecuteScalar();

            Console.WriteLine("ок");

            connection.Close();

            Console.ReadLine();
        }
    }
}
