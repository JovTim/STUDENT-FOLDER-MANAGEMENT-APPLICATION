using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace folder_management
{
    internal class sqliteDataAccess
    {
        public List<string[]> loadFolderData(int pageSize, int currentIndex)
        {
            List<string[]> output = new List<string[]>();
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = folderData(pageSize, currentIndex);
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


        public List<string[]> loadFolderDataStudent(string value)
        {
            List<string[]> output = new List<string[]>();
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = queryFolderDataStudent();
                        var paramValue = cmd.CreateParameter();
                        paramValue.ParameterName = "@value";
                        paramValue.Value = value;
                        cmd.Parameters.Add(paramValue);

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
                                var code = reader.GetString(6);

                                string[] studentFolderInformation = { profile_link, student_number, full_name, year, block, status, code };
                                output.Add(studentFolderInformation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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

        public void insertTempData(string tempData)
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
                            cmd.CommandText = addTempData();
                            cmd.Transaction = transaction;

                            var paramTempData = cmd.CreateParameter();
                            paramTempData.ParameterName = "@number";
                            paramTempData.Value = tempData;
                            cmd.Parameters.Add(paramTempData);

                            cmd.ExecuteNonQuery ();
                        }
                        transaction.Commit ();
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

        public string loadTempData()
        {
            string result = "";
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = tempData();
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            result = reader.GetString(0);
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

            return result;
        }

        public List<string[]> LoadEditFolderData()
        {
            List<string[]> output = new List<string[]>();
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = editFolderData();
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var profile_link = reader.GetString(0);
                                var student_number = reader.GetString(1);
                                var first_name = reader.GetString(2);
                                var last_name = reader.GetString(3);
                                var middle_name = reader.GetString(4);
                                var year = reader.GetInt32(5);
                                var block = reader.GetInt32(6);
                                var code = reader.GetString(7);
                                var id = reader.GetInt32(8);

                                string[] folderInformation = { profile_link, student_number, first_name, last_name, middle_name, Convert.ToString(year), Convert.ToString(block), code, Convert.ToString(id) };
                                output.Add(folderInformation);
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading folder data: {ex.Message}");
                MessageBox.Show($"Error loading folder data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }


        public void updateStudentFolderData(int id, string url, string student_number, string first, string last, string middle, int year, int block, string code)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbTransaction transaction = cnn.BeginTransaction())
                {
                    try
                    {
                        using (IDbCommand cmd = cnn.CreateCommand())
                        {
                            cmd.Transaction = transaction;
                            cmd.CommandText = updateFolderData();

                            var paramUrl = cmd.CreateParameter();
                            paramUrl.ParameterName = "@profile_link";
                            paramUrl.Value = url;
                            cmd.Parameters.Add(paramUrl);

                            var paramNumber = cmd.CreateParameter();
                            paramNumber.ParameterName = "@student_number";
                            paramNumber.Value = student_number;
                            cmd.Parameters.Add(paramNumber);

                            var paramFirst = cmd.CreateParameter();
                            paramFirst.ParameterName = "@first_name";
                            paramFirst.Value = first;
                            cmd.Parameters.Add(paramFirst);

                            var paramLast = cmd.CreateParameter();
                            paramLast.ParameterName = "@last_name";
                            paramLast.Value = last;
                            cmd.Parameters.Add(paramLast);

                            var paramMiddle = cmd.CreateParameter();
                            paramMiddle.ParameterName = "@middle_name";
                            paramMiddle.Value = middle;
                            cmd.Parameters.Add(paramMiddle);

                            var paramYear = cmd.CreateParameter();
                            paramYear.ParameterName = "@year";
                            paramYear.Value = year;
                            cmd.Parameters.Add(paramYear);

                            var paramBlock = cmd.CreateParameter();
                            paramBlock.ParameterName = "@block";
                            paramBlock.Value = block;
                            cmd.Parameters.Add(paramBlock);

                            var paramCode = cmd.CreateParameter();
                            paramCode.ParameterName = "@code";
                            paramCode.Value = code;
                            cmd.Parameters.Add(paramCode);

                            var paramID = cmd.CreateParameter();
                            paramID.ParameterName = "@id";
                            paramID.Value = id;
                            cmd.Parameters.Add(paramID);

                            cmd.ExecuteNonQuery();
                        }

                        // Commit the transaction if all commands succeed
                        transaction.Commit();
                    }
                    catch
                    {
                        // Roll back the transaction if any command fails
                        transaction.Rollback();
                        MessageBox.Show("There was an error when updating the database!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }


        public void updateFolderStatus(string student_number, int status)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbTransaction transaction = cnn.BeginTransaction())
                {
                    try
                    {
                        using (IDbCommand  cmd = cnn.CreateCommand())
                        {
                            cmd.Transaction = transaction;
                            cmd.CommandText = folderStatus();

                            var paramNumber = cmd.CreateParameter();
                            paramNumber.ParameterName = "@student_number";
                            paramNumber.Value = student_number;
                            cmd.Parameters.Add(paramNumber);

                            var paramStatus = cmd.CreateParameter();
                            paramStatus.ParameterName = "@status";
                            paramStatus.Value = status;
                            cmd.Parameters.Add(paramStatus);


                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("There was an error when updating the database!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        public List<string[]> loadFolderHistory(int pageSize, int currentIndex)
        {
            List<string[]> output = new List<string[]>();
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = queryHistoryData(pageSize, currentIndex);
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student_number = reader.GetString(0);
                                var full_name = reader.GetString(1);
                                var history_type = reader.GetString(2);
                                var history_date = reader.GetString(3);
                                var history_code = reader.GetString(4);
                                var history_information = reader.IsDBNull(5) ? "" : reader.GetString(5);


                                string[] historyFolderInformation = { student_number, full_name, history_type, history_date, history_code, history_information};
                                output.Add(historyFolderInformation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading folder data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return output;
        }

        public List<string[]> loadArchiveFolder(int pageSize, int currentIndex)
        {
            List<string[]> output = new List<string[]>();
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = queryArchiveFolder(pageSize, currentIndex);
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var studentNumber = reader.GetString(0);
                                var lastName = reader.GetString(1);
                                var first_name = reader.GetString(2);
                                var middle_name = reader.GetString(3);
                                var date = reader.GetString(4);

                                string[] archiveHistory = { studentNumber, lastName, first_name, middle_name, date };
                                output.Add(archiveHistory);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading folder data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
            return output;
        }


        public void insertArchive(string studentNumber)
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
                            cmd.CommandText = queryInsertArchive();
                            cmd.Transaction = transaction;


                            var paramStudentNumber = cmd.CreateParameter();
                            paramStudentNumber.ParameterName = "@student_number";
                            paramStudentNumber.Value = studentNumber;
                            cmd.Parameters.Add(paramStudentNumber);

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

        public void unarchiveFolder(string studentNumber)
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
                            cmd.CommandText = queryUnarchive();
                            cmd.Transaction = transaction;

                            var paramStudentNumber = cmd.CreateParameter();
                            paramStudentNumber.ParameterName = "@student_number";
                            paramStudentNumber.Value = studentNumber;
                            cmd.Parameters.Add(paramStudentNumber);

                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("There was an error when updating database!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        public void deleteFolder(string studentNumber)
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
                            cmd.CommandText = queryDeleteFolder();
                            cmd.Transaction = transaction;

                            var paramStudentNumber = cmd.CreateParameter();
                            paramStudentNumber.ParameterName = "@student_number";
                            paramStudentNumber.Value = studentNumber;
                            cmd.Parameters.Add(paramStudentNumber);

                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("There was an error when updating database!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        private string loadConnectionString(string id = "Default")
        {
            return "Data Source=.\\studentFolderDb.db;Version=3;";
        }



        private string folderData(int pageSize, int currentIndex)
        {
            return $@"
                SELECT 
                    STUDENTS.profile_link, 
                    STUDENTS.student_number, 
                    STUDENTS.last_name || ', ' || STUDENTS.first_name || ' ' || STUDENTS.middle_name AS full_name,
                    'YEAR ' || STUDENTS.year AS year, 
                    'BLOCK ' || STUDENTS.block AS block, 
                    FOLDER_STATUS.status_type, 
                    STUDENTS.code
                FROM STUDENTS
                LEFT JOIN FOLDER_STATUS 
                    ON FOLDER_STATUS.id_status = STUDENTS.status
                LEFT JOIN ARCHIVES
                    ON STUDENTS.id_students = ARCHIVES.student_id
                WHERE ARCHIVES.student_id IS NULL
                ORDER BY year, block, full_name
                LIMIT {pageSize} OFFSET {(currentIndex - 1) * pageSize};
            ";
        }

        private string queryFolderDataStudent()
        {
            return @"
                    SELECT 
                        STUDENTS.profile_link, 
                        STUDENTS.student_number, 
                        STUDENTS.last_name || ', ' || STUDENTS.first_name || ' ' || STUDENTS.middle_name AS full_name,
                        'YEAR ' || STUDENTS.year AS year, 
                        'BLOCK ' || STUDENTS.block AS block, 
                        FOLDER_STATUS.status_type, 
                        STUDENTS.code
                    FROM STUDENTS
                    LEFT JOIN FOLDER_STATUS 
                        ON FOLDER_STATUS.id_status = STUDENTS.status
                    LEFT JOIN ARCHIVES
                        ON STUDENTS.id_students = ARCHIVES.student_id
                    WHERE ARCHIVES.student_id IS NULL AND (student_number LIKE @value 
                    OR full_name LIKE @value)
                    ORDER BY year, block, full_name;
                    ";
        }

        private string addFolderData()
        {
            return @"
                INSERT INTO STUDENTS (profile_link, student_number, first_name, last_name, middle_name, year, block, status, code)
                VALUES(@profile_link, @student_number, @first_name, @last_name, @middle_name, @year, @block, @status, @code)
            ";
        }

        private string addTempData()
        {
            return @"INSERT INTO TEMP_DATA(number) VALUES (@number)";
        }

        private string tempData()
        {
            return @"SELECT number FROM TEMP_DATA ORDER BY id DESC LIMIT 1";
        }

        private string editFolderData()
        {
            return @"
            SELECT 
            STUDENTS.profile_link, STUDENTS.student_number, 
            STUDENTS.first_name, STUDENTS.last_name, STUDENTS.middle_name,
            STUDENTS.year, 
            STUDENTS.block, 
            STUDENTS.code,
            STUDENTS.id_students
            FROM STUDENTS
            LEFT JOIN FOLDER_STATUS 
            ON FOLDER_STATUS.id_status = STUDENTS.status
            WHERE STUDENTS.student_number = (SELECT number FROM TEMP_DATA ORDER BY id DESC LIMIT 1);
            ";
        }

        private string updateFolderData()
        {
            return @"
                UPDATE STUDENTS
                SET profile_link = @profile_link,
                    student_number = @student_number,
                    first_name = @first_name,
                    last_name = @last_name,
                    middle_name = @middle_name,
                    year = @year,
                    block = @block,
                    code = @code
                WHERE id_students = @id;
                ";
        }

        private string folderStatus()
        {
            return @"
            UPDATE STUDENTS
            SET status = @status
            WHERE student_number = @student_number;
            ";
        }

        private string queryHistoryData(int pageSize, int currentIndex)
        {
            return $@"
            SELECT 
                STUDENTS.student_number,
                STUDENTS.last_name || ', ' || STUDENTS.first_name || ' ' || STUDENTS.middle_name AS full_name,
                STATUS_HISTORY.history_type, 
                HISTORY.history_date, 
                STUDENTS.code, 
                HISTORY.information
            FROM STUDENTS
            INNER JOIN HISTORY
                ON STUDENTS.id_students = HISTORY.student_id
            INNER JOIN STATUS_HISTORY
                ON HISTORY.history_status = STATUS_HISTORY.id_history_status
            ORDER BY HISTORY.history_date DESC
            LIMIT {pageSize} OFFSET {(currentIndex - 1) * pageSize}
            ";
        }

        private string queryArchiveFolder(int pageSize, int currentIndex)
        {
            return $@"
            SELECT 
                STUDENTS.student_number, 
                STUDENTS.last_name,
                STUDENTS.first_name,
                STUDENTS.middle_name,
                ARCHIVES.archive_date
            FROM STUDENTS
            INNER JOIN ARCHIVES
	            ON STUDENTS.id_students = ARCHIVES.student_id
            LIMIT {pageSize} OFFSET {(currentIndex - 1) * pageSize}
            ";
        }

        private string queryInsertArchive()
        {
            return @"
            INSERT INTO ARCHIVES (student_id)
                SELECT STUDENTS.id_students
                FROM STUDENTS
                WHERE student_number = @student_number;
            ";
        }

        private string queryUnarchive()
        {
            return @"
            DELETE FROM ARCHIVES
            WHERE student_id = (
            SELECT STUDENTS.id_students 
            FROM STUDENTS
            WHERE student_number = @student_number
            );
            ";
        }

        private string queryDeleteFolder()
        {
            return @"
            DELETE FROM STUDENTS
            WHERE student_number = @student_number;
            ";
        }

    }
}
