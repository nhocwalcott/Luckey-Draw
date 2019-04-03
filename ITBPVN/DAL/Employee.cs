using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using BPVN.LuckyDraw.Utils;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.DAL
{
	public class Employee
	{
		private const string SQL_INSERT_EMPLOYEE = "INSERT INTO [employee] ([empid],[name],[dept],[post],[group]) VALUES(@empid,@name,@dept,@post,@group);";
		
		private const string SQL_DELETE_EMPLOYEE = "DELETE FROM [employee] WHERE [empid]=@empid";
		
		private const string SQL_DELETE_ALL_EMPLOYEE = "DELETE FROM [employee]";

		private const string SQL_DELETE_EMPLOYEE_BY_GROUP = "DELETE FROM [employee] WHERE [group]=@group";

		private const string SQL_DELETE_EMPLOYEE_BY_ID = "DELETE FROM [employee] WHERE [id]=@id";

		private const string SQL_SELECT_EMPLOYEE = "SELECT [id],[empid],[name],[dept],[post] FROM [employee]";

		private const string SQL_SELECT_EMPLOYEE_BY_GROUP = "SELECT [id],[empid],[name],[dept],[post] FROM [employee] WHERE [group]=@group";

		private const string SQL_SELECT_ALL_GROUP = "SELECT DISTINCT [group] FROM [employee]";


		#region Thêm hoạt động

	
		public void AddEmployee(string empid, string name, string dept, string post, string group)
		{
			SQLiteParameter[] parameters = new SQLiteParameter[] { 
				new SQLiteParameter("@empid",DbType.String, 20),
				new SQLiteParameter("@name", DbType.String, 20),
				new SQLiteParameter("@dept", DbType.String, 50),
				new SQLiteParameter("@post", DbType.String, 50),
				new SQLiteParameter("@group", DbType.String, 50)
			};

			parameters[0].Value = empid;
			parameters[1].Value = name;
			parameters[2].Value = dept;
			parameters[3].Value = post;
			parameters[4].Value = group;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_INSERT_EMPLOYEE, parameters);

			if (result < 1) {
				throw new ApplicationException("Thêm không thành công!");
			}
		}

		/// <summary>
	
		/// </summary>

		public delegate void ProgressDelegate(int percent);

		/// <summary>

		public void AddEmployee(List<EmployeeInfo> employee, string group, ProgressDelegate callback)
		{
			using (SQLiteConnection conn = new SQLiteConnection(SqlHelper.ConnectionString)) {

				conn.Open();
				SQLiteTransaction trans = conn.BeginTransaction();

				try {

					SQLiteParameter[] parameters = new SQLiteParameter[] { 
							new SQLiteParameter("@empid",DbType.String, 20),
							new SQLiteParameter("@name", DbType.String, 20),
							new SQLiteParameter("@dept", DbType.String, 50),
							new SQLiteParameter("@post", DbType.String, 50),
							new SQLiteParameter("@group", DbType.String, 50)
					};

					int count = 1;
					foreach (EmployeeInfo empinfo in employee) {

						parameters[0].Value = empinfo.EmployeeId;
						parameters[1].Value = empinfo.Name;
						parameters[2].Value = empinfo.Department;
						parameters[3].Value = empinfo.Post;
						parameters[4].Value = group;

						SqlHelper.ExecuteNonQuery(trans, CommandType.Text, SQL_INSERT_EMPLOYEE, parameters);


						if (callback != null) {
							callback((int)(((float)count++ / (float)employee.Count) * 100));
						}
					}

					trans.Commit();

				} catch (SQLiteException) {
					trans.Rollback();
				}

			}
		}

		#endregion

		#region Xóa thao tác

		/// <summary>

		/// </summary>
		public void EmptyEmployee()
		{
			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_DELETE_ALL_EMPLOYEE);

			if (result < 1) {
				throw new ApplicationException("Không được");
			}
		}

		/// <summary>

		/// </summary>
		/// <param name="empid">工号</param>
		public void RemoveEmployee(string empid)
		{
			if (String.IsNullOrEmpty(empid)) {
				throw new ArgumentException("Mã không hợp lệ");
			}

			SQLiteParameter parameter = new SQLiteParameter("@empid", DbType.String, 20);
			parameter.Value = empid;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_DELETE_EMPLOYEE, parameter);

			if (result < 1) {
				throw new ApplicationException("Xóa không thành công");
			}
		}

		/// <summary>
	
		/// </summary>
		/// <param name="id">ID</param>
		public void RemoveEmployeeById(string id)
		{
			int temp;
			if (String.IsNullOrEmpty(id) || !int.TryParse(id, out temp)) {
				throw new ArgumentException("id", "ID không hợp lệ");
			}

			SQLiteParameter parameter = new SQLiteParameter("@id", DbType.Int32);
			parameter.Value = id;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_DELETE_EMPLOYEE_BY_ID, parameter);

			if (result < 1) {
				throw new ApplicationException("Xóa không thành công");
			}
		}

		/// <summary>
		
		/// </summary>
		/// <param name="group"></param>
		public void RemoveEmployeeByGroup(string group)
		{
			if (group == null) { 
				throw new ArgumentNullException("group", "Tham số group Không thể null。");
			}

			SQLiteParameter parameter = new SQLiteParameter("@group", DbType.String, 50);
			parameter.Value = group;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_DELETE_EMPLOYEE_BY_GROUP, parameter);

			if (result < 1) {
				throw new ApplicationException("Xóa không thành công!");	
			}
		}

		#endregion

		#region Thao tác truy vấn

		public List<EmployeeInfo> GetAllEmployee()
		{
			List<EmployeeInfo> employees = new List<EmployeeInfo>();

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_EMPLOYEE);
			while (rdr.Read()) {
				employees.Add(new EmployeeInfo { Id = Convert.ToInt32(rdr["id"]) , EmployeeId = rdr["empid"].ToString(), Name = rdr["name"].ToString(), Department = rdr["dept"].ToString(), Post = rdr["post"].ToString() });
			}

			rdr.Close();

			return employees;
		}

		/// <summary>
		
		/// </summary>

		/// <returns></returns>
		public List<EmployeeInfo> GetEmployeeByGroup(string group)
		{
			List<EmployeeInfo> employees = new List<EmployeeInfo>();

			SQLiteParameter parameter = new SQLiteParameter("@group", DbType.String, 50);
			parameter.Value = group;

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_EMPLOYEE_BY_GROUP, parameter);
			while (rdr.Read()) {
				employees.Add(new EmployeeInfo { Id = Convert.ToInt32(rdr["id"]), EmployeeId = rdr["empid"].ToString(), Name = rdr["name"].ToString(), Department = rdr["dept"].ToString(), Post = rdr["post"].ToString() });
			}

			rdr.Close();

			return employees;
		}
		
		/// <summary>

		/// </summary>
		/// <returns></returns>
		public List<string> GetAllGroups()
		{
			List<string> groups = new List<string>();

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_ALL_GROUP);
			while (rdr.Read()) {
				groups.Add(rdr["group"].ToString());
			}

			rdr.Close();

			return groups;
		}

		/// <summary>

		/// </summary>
		/// <param name="group"></param>
		/// <returns></returns>
		public bool GroupIsExists(string group)
		{
			SQLiteParameter parameter = new SQLiteParameter("@group", DbType.String, 50);
			parameter.Value = group;

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_EMPLOYEE_BY_GROUP, parameter);

			bool result = rdr.Read();

			rdr.Close();

			return result;
		}

		#endregion
	}
}
