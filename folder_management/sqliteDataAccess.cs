using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace folder_management
{
    internal class sqliteDataAccess
    {
        public List<string[]> loadFolderData()
        {
            List<string[]> output = new List<string[]>();
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = folderData();
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var profile_link = reader.GetString(0);
                                var student_number = reader.GetString(1);
                                var full_name = reader.GetString(2);
                                var year = reader.GetString(3);
                                var block = reader.GetString(4);
                                var status = reader.GetString(5);
                                var code =  reader.GetString(6);

                                string[] studentFolderInformation = { profile_link, student_number, full_name, year, block, status, code };
                                output.Add(studentFolderInformation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error and handle it (e.g., show a message or rethrow)
                Console.WriteLine($"Error loading folder data: {ex.Message}");
            }
            return output;
        }

        private string loadConnectionString(string id = "Default")
        {
            return "Data Source=.\\studentFolderDb.db;Version=3;";
        }



        private string folderData()
        {
            return @"
                SELECT 
                STUDENTS.profile_link, STUDENTS.student_number, 
                STUDENTS.last_name || ', ' || STUDENTS.first_name || ' ' || STUDENTS.middle_name AS full_name,
                'YEAR ' || STUDENTS.year AS year, 
                'BLOCK ' || STUDENTS.block AS block, 
                FOLDER_STATUS.status_type, 
                STUDENTS.code
                FROM STUDENTS
                INNER JOIN FOLDER_STATUS 
                ON FOLDER_STATUS.id_status = STUDENTS.status
            ";
        }
    }
}
