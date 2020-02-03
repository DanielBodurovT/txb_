using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem_v1
{
    public class User
    {
        private static Int32 m_iLoggedInUserId = -1;
        private static string m_strLoggedInUserNickname = null;

        public static void GetCurrentUserInfo(ref Int32 iId, ref string strNickname)
        {
            iId = m_iLoggedInUserId;
            strNickname = m_strLoggedInUserNickname;
        }

        public static void Login(Int32 iId, string strNickname)
        {
            m_iLoggedInUserId = iId;
            m_strLoggedInUserNickname = strNickname;
        }
        public static void Logout()
        {
            m_iLoggedInUserId = -1;
            m_strLoggedInUserNickname = null;
        }
    }
}
