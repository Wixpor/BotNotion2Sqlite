using SQLiteHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotNotion2Sqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dbManager = new SQLiteDatabaseManager("C:\\BotGhl2Notion\\BatchNotion.db");


            //dbManager.CreateDatabase();

            //dbManager.CreateTable("NotionSync","NOSY_ID INTEGER PRIMARY KEY AUTOINCREMENT" +
            //                                   ", NOSY_EMAIL TEXT NOT NULL UNIQUE" +
            //                                   ", NOSY_INSERT_DATETIME DATETIME DEFAULT CURRENT_TIMESTAMP");



            var Lista_NotionEmail = ControllerNotionSync.Get_Lst_Enti_NotionEmails();
            if (Lista_NotionEmail._Status_Code == 200)
            {
                foreach(var notionEmail in Lista_NotionEmail.Lst_NotionSync)
                {
                    Console.WriteLine(notionEmail.NOSY_EMAIL);
                }
                Console.WriteLine(Lista_NotionEmail.Lst_NotionSync.Count);
            }
            else
            {
                Console.WriteLine(Lista_NotionEmail._Status_Code);
                Console.WriteLine(Lista_NotionEmail._Error_Desc);
            }
            Console.ReadLine();

        }
    }
}
