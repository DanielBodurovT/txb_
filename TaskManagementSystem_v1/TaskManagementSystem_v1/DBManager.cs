using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagementSystem_v1
{
    public static class DBManager
    {
        private static string sqlConnStr = @"Server = (local); Database = txb; Trusted_Connection = True;";

        public static void DB_UnAssignTaskToUser(Int32 iUserId, Int32 iTaskId)
        {
            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str =
                        String.Format("DELETE FROM [ASSIGNMENTS_RELATIONS] WHERE [ID_USER] = '{0}' AND [ID_TASK] = '{1}'",
                        iUserId, iTaskId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sqlConn.Close();
                }
            }
        }

        public static void DB_AssignTaskToUser(Int32 iUserId, Int32 iTaskId)
        {
            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str =
                        String.Format("INSERT INTO [ASSIGNMENTS_RELATIONS] VALUES('{0}', '{1}')", iTaskId, iUserId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sqlConn.Close();
                }
            }
        }

        public static List<string> GetUserListUnassignedForTask(Int32 iTaskId)
        {
            List<Int32> AssignedUsersIdsList = new List<Int32>();
            List<string> UnAssignedUsersNamesList = GetUserList();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [ASSIGNMENTS_RELATIONS] WHERE [ID_TASK] = '{0}'",
                        iTaskId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AssignedUsersIdsList.Add(Int32.Parse(reader["ID_USER"].ToString()));
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                    foreach (Int32 iUserId in AssignedUsersIdsList)
                        UnAssignedUsersNamesList.Remove(DB_GetUserNickname(iUserId));
                }
            }

            return UnAssignedUsersNamesList;
        }

        public static List<string> GetUserListAssignedForTask(Int32 iTaskId)
        {
            List<Int32> AssignedUsersIdsList = new List<Int32>();
            List<string> AssignedUsersNamesList = new List<string>();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [ASSIGNMENTS_RELATIONS] WHERE [ID_TASK] = '{0}'",
                        iTaskId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AssignedUsersIdsList.Add(Int32.Parse(reader["ID_USER"].ToString()));
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();

                    foreach (Int32 iUserId in AssignedUsersIdsList) // to do: optimize (too many open&close connection this way)
                        AssignedUsersNamesList.Add(DB_GetUserNickname(iUserId));
                }
            }

            return AssignedUsersNamesList;
        }

        public static Dictionary<Int32, string> GetAllTaskTypes()
        {
            Dictionary<Int32, string> TypesDict = new Dictionary<Int32, string>();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [TASK_TYPES]");

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TypesDict[Int32.Parse(reader["ID"].ToString())] = reader["TYPE_NAME"].ToString();
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return TypesDict;
        }

        public static Dictionary<Int32, string> GetAllTaskStatuses()
        {
            Dictionary<Int32, string> StatusesDict = new Dictionary<Int32, string>();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [TASK_STATUSES]");

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        StatusesDict[Int32.Parse(reader["ID"].ToString())] = reader["STATUS_NAME"].ToString();
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return StatusesDict;
        }

        public static List<string> GetUserList()
        {
            List<string> UsersList = new List<string>();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [USER]");

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersList.Add(reader["NICKNAME"].ToString());
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return UsersList;
        }

        public static void RemoveTask(Int32 iTaskId)
        {
            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = null;
                    SqlCommand cmd = null;

                    cmd_str = String.Format("DELETE FROM [ASSIGNMENTS_RELATIONS] WHERE [ID_TASK] = '{0}'", iTaskId);

                    cmd = new SqlCommand(cmd_str, sqlConn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    cmd_str = String.Format("DELETE FROM [COMMENT] WHERE [ASSOCIATED_TO] = '{0}'", iTaskId);

                    cmd = new SqlCommand(cmd_str, sqlConn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    cmd_str = String.Format("DELETE FROM [TASK] WHERE [ID] = '{0}'", iTaskId);

                    cmd = new SqlCommand(cmd_str, sqlConn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sqlConn.Close();
                }
            }
        }

        public static string GetTaskStatus(Int32 iId)
        {
            string strStatus = "";

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [TASK_STATUSES] WHERE [ID] = '{0}'", iId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        strStatus = reader["STATUS_NAME"].ToString();
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return strStatus;
        }

        public static string GetTaskType(Int32 iId)
        {
            string strType = "";

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [TASK_TYPES] WHERE [ID] = '{0}'", iId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        strType = reader["TYPE_NAME"].ToString();
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return strType;
        }

        public static Task GetTaskData(Int32 iId)
        {
            Task tTask = null;
            List<Int32> AssignedToList = new List<Int32>();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [ASSIGNMENTS_RELATIONS] WHERE [ID_TASK] = '{0}'", iId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AssignedToList.Add(Int32.Parse(reader["ID_USER"].ToString()));
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [TASK] WHERE [ID] = '{0}'", iId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tTask = new Task(Int32.Parse(reader["ID"].ToString()),
                            DateTime.Parse(reader["CREATED_DATE"].ToString()),
                            DateTime.Parse(reader["REQUIRED_BY_DATE"].ToString()),
                            reader["TASK_DESCRIPTION"].ToString(),
                            Int32.Parse(reader["TASK_STATUS"].ToString()),
                            Int32.Parse(reader["TASK_TYPE"].ToString()),
                            DateTime.Parse(reader["NEXT_ACTION_DATE"].ToString()),
                            AssignedToList
                            );
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return tTask;
        }

        public static List<Int32> GetTasksList()
        {
            List<Int32> TaskIdsList = new List<Int32>();

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    // case sensitive search
                    string cmd_str = String.Format("SELECT * FROM [TASK]");

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TaskIdsList.Add(Int32.Parse(reader["ID"].ToString()));
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }
            
            return TaskIdsList;
        }

        public static string DB_GetUserNickname(Int32 iUserId)
        {
            string strNickname = null;

            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str = String.Format("SELECT * FROM [USER] WHERE [ID] = '{0}'",
                        iUserId);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        strNickname = reader["NICKNAME"].ToString();
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return strNickname;
        }

        public static Int32 DB_LookUpUser(string strNickname)
        {
            Int32 iResultId = -1;
            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    // case sensitive search
                    string cmd_str = String.Format("SELECT * FROM [USER] WHERE NICKNAME = '{0}' COLLATE Latin1_General_CS_AS",
                        strNickname); 

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        iResultId = Int32.Parse(reader["ID"].ToString());
                    }

                    cmd.Dispose();
                    reader.Close();

                    sqlConn.Close();
                }
            }

            return iResultId;
        }

        public static void DB_RegisterUser(string strNickname)
        {
            using (SqlConnection sqlConn = new SqlConnection(sqlConnStr))
            {
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();

                    string cmd_str =
                        String.Format("INSERT INTO [USER] VALUES('{0}')", strNickname);

                    SqlCommand cmd = new SqlCommand(cmd_str, sqlConn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sqlConn.Close();
                }
            }
        }
    }
}
