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
                MessageBox.Show($"Error loading folder data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }


        public void insertFolder(string profileLink, string studentNumber, string first_name, string last_name, string middle_name, int year, int block, int status, string code)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {
                    try
                    {
                        using (IDbCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = addFolderData();
                            cmd.Transaction = transaction;

                            var paramUrl = cmd.CreateParameter();
                            paramUrl.ParameterName = "@profile_link";
                            paramUrl.Value = profileLink;
                            cmd.Parameters.Add(paramUrl);

                            var paramNumber = cmd.CreateParameter();
                            paramNumber.ParameterName = "@student_number";
                            paramNumber.Value = studentNumber;
                            cmd.Parameters.Add(paramNumber);

                            var paramFirstName = cmd.CreateParameter();
                            paramFirstName.ParameterName = "@first_name";
                            paramFirstName.Value = first_name;
                            cmd.Parameters.Add(paramFirstName);

                            var paramLastName = cmd.CreateParameter();
                            paramLastName.ParameterName = "@last_name";
                            paramLastName.Value = last_name;
                            cmd.Parameters.Add(paramLastName);

                            var paramMiddleName = cmd.CreateParameter();
                            paramMiddleName.ParameterName = "@middle_name";
                            paramMiddleName.Value = middle_name;
                            cmd.Parameters.Add(paramMiddleName);

                            var paramYear = cmd.CreateParameter();
                            paramYear.ParameterName = "@year";
                            paramYear.Value = year;
                            cmd.Parameters.Add(paramYear);

                            var paramBlock = cmd.CreateParameter();
                            paramBlock.ParameterName = "@block";
                            paramBlock.Value = block;
                            cmd.Parameters.Add(paramBlock);

                            var paramStatus = cmd.CreateParameter();
                            paramStatus.ParameterName = "@status";
                            paramStatus.Value = status;
                            cmd.Parameters.Add(paramStatus);

                            var paramCode = cmd.CreateParameter();
                            paramCode.ParameterName = "@code";
                            paramCode.Value = code;
                            cmd.Parameters.Add(paramCode);


                            cmd.ExecuteNonQuery();
                        }


                        transaction.Commit();
                    }
                    catch
                    {

                        transaction.Rollback();
                        MessageBox.Show("There was an error when inserting to database!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw; 
                    }
                }
            }
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

        private string addFolderData()
        {
            return @"
                INSERT INTO STUDENTS (profile_link, student_number, first_name, last_name, middle_name, year, block, status, code)
                VALUES(@profile_link, @student_number, @first_name, @last_name, @middle_name, @year, @block, @status, @code)
            ";
        }
    }
}
