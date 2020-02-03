using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem_v1
{
    public class Task
    {
		private Int32 m_iId;
		private DateTime m_dateCreated;
		private DateTime m_dateRequired;
		private string m_strDescription;
		private Int32 m_iStatus;
		private Int32 m_iType;
		private DateTime m_dateNextAction;
		private List<Int32> m_AssignedToList;

		public Task()
		{
			m_iId = 0;
			m_dateCreated = new DateTime(0);
			m_dateRequired = new DateTime(0);
			m_strDescription = "";
			m_iStatus = 0;
			m_iType = 0;
			m_dateNextAction = new DateTime(0);
			m_AssignedToList = new List<Int32>();
		}
		public Task(Int32 iId, DateTime dateCreated, DateTime dateRequired,
					string strDescr, Int32 iStatus, Int32 iType,
					DateTime dateNextAction, List<Int32> ListOfAssignedUsers)
		{
			m_iId = iId;
			m_dateCreated = dateCreated;
			m_dateRequired = dateRequired;
			m_strDescription = strDescr;
			m_iStatus = iStatus;
			m_iType = iType;
			m_dateNextAction = dateNextAction;
			m_AssignedToList = ListOfAssignedUsers;
		}

		public string GetDescription()
		{
			return m_strDescription;
		}

		public Int32 GetTaskType()
		{
			return m_iType;
		}
		public Int32 GetTaskStatus()
		{
			return m_iStatus;
		}

		public DateTime GetCreationDate()
		{
			return m_dateCreated;
		}

		public DateTime GetRequiredByDate()
		{
			return m_dateRequired;
		}

		public DateTime GetNextActionDate()
		{
			return m_dateNextAction;
		}

		public List<Int32> GetAssignedToList()
		{
			return m_AssignedToList;
		}
	}
}
