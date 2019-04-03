using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using BPVN.LuckyDraw.Utils;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.DAL
{
	public class Prizewinner
	{
		private const string SQL_INSERT_PRIZEWINNER = "INSERT INTO [prizewinner]([empid],[name],[dept],[post],[group],[award]) VALUES(@empid,@name,@dept,@post,@group,@award);";
		
		private const string SQL_DELETE_PRIZEWINNER = "DELETE FROM [prizewinner]";

		private const string SQL_DELETE_PRIZEWINNER_BY_ID = "DELETE FROM [prizewinner] WHERE [id]=@id";

        private const string SQL_UPDATE_PRIZEWINNER_BY_ID = "UPDATE [prizewinner] SET [sign]=@sign WHERE [id]=@id";

        private const string SQL_UPDATE_PRIZEWINNER_BY_EMPID = "UPDATE [prizewinner] SET [sign]=@sign WHERE [empid]=@empid";

		private const string SQL_SELECT_PRIZEWINNER = "SELECT [id],[empid],[name],[dept],[post],[award],[sign] FROM [prizewinner]";

		private const string SQL_SELECT_GROUPS = "SELECT DISTINCT [group] FROM [prizewinner]";
	
		private const string SQL_SELECT_EMPID_BY_GROUP = "SELECT DISTINCT [empid] FROM [prizewinner] WHERE [group]=@group";

        private const string SQL_SELECT_PRIZEWINNER_COUNT = "SELECT COUNT(*) AS CC FROM [prizewinner] WHERE [group]=@group AND [award]=@award";

        private const string SQL_SELECT_PRIZEWINNER_COUNT_SIGN = "SELECT COUNT(*) AS CC FROM [prizewinner] WHERE sign=1 AND [group]=@group AND [award]=@award";


		#region Thêm hoạt động

		
		public void AddPrizewinner(string empid, string name, string dept, string post, string group, string award)
		{
			SQLiteParameter[] parameters = new SQLiteParameter[] { 
				new SQLiteParameter("@empid", DbType.String, 20),
				new SQLiteParameter("@name", DbType.String, 20),
				new SQLiteParameter("@dept", DbType.String, 50),
				new SQLiteParameter("@post", DbType.String, 50),
				new SQLiteParameter("@group", DbType.String, 50),
				new SQLiteParameter("@award", DbType.String, 50)
			};

			parameters[0].Value = empid;
			parameters[1].Value = name;
			parameters[2].Value = dept;
			parameters[3].Value = post;
			parameters[4].Value = group;
			parameters[5].Value = award;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_INSERT_PRIZEWINNER, parameters);

			if (result < 1) {
				throw new ApplicationException("Không thể thêm người thắng cuộc!");
			}
		}

		#endregion

		#region Xóa thao tác

		
		public void RemovePrizewinnerByGroupAndAward(string group, string award)
		{
			StringBuilder strSQL = new StringBuilder();
			strSQL.Append(SQL_DELETE_PRIZEWINNER).Append(" WHERE 1=1");

			List<SQLiteParameter> parameters = new List<SQLiteParameter>();
			if (!String.IsNullOrEmpty(group)) {
				strSQL.Append(" AND [group]=@group");
				parameters.Add(new SQLiteParameter { ParameterName = "@group", DbType = DbType.String, Size = 50, Value = group });
			}

			if (!String.IsNullOrEmpty(award)) {
				strSQL.Append(" AND [award]=@award");
				parameters.Add(new SQLiteParameter { ParameterName = "@award", DbType = DbType.String, Size = 50, Value = award });
			}

			SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, strSQL.ToString(), parameters.ToArray());
		}

		
		public void RemovePrizewinnerById(string id)
		{
			int temp;
			if (String.IsNullOrEmpty(id) || !int.TryParse(id, out temp)) {
				throw new ArgumentException("id", "ID không hợp lệ");
			}

			SQLiteParameter parameter = new SQLiteParameter("@id", DbType.Int32);
			parameter.Value = id;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_DELETE_PRIZEWINNER_BY_ID, parameter);

			if (result < 1) {
				throw new ApplicationException("Không thể xóa");
			}
		}

		#endregion

		#region Truy vấn

		public List<PrizewinnerInfo> GetAllPrizewinners()
		{
			List<PrizewinnerInfo> prizewinners = new List<PrizewinnerInfo>();

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_PRIZEWINNER);

			while (rdr.Read()) {
				prizewinners.Add(new PrizewinnerInfo { Id = Convert.ToInt32(rdr["id"]), EmployeeId = rdr["empid"].ToString(), Name = rdr["name"].ToString(), Department = rdr["dept"].ToString(), Post = rdr["post"].ToString(), Award = rdr["award"].ToString() });
			}

			rdr.Close();

			return prizewinners;
		}

		
		public List<PrizewinnerInfo> GetPrizewinnersByGroupAndAward(string group, string award)
		{
			List<PrizewinnerInfo> prizewinners = new List<PrizewinnerInfo>();

			StringBuilder strSQL = new StringBuilder();
			strSQL.Append(SQL_SELECT_PRIZEWINNER).Append(" WHERE 1=1");

			List<SQLiteParameter> parameters = new List<SQLiteParameter>();
			if (!String.IsNullOrEmpty(group)) {
				strSQL.Append(" AND [group]=@group");
				parameters.Add(new SQLiteParameter { ParameterName = "@group", DbType = DbType.String, Size = 50, Value = group });
			}

			if (!String.IsNullOrEmpty(award)) {
				strSQL.Append(" AND [award]=@award");
				parameters.Add(new SQLiteParameter { ParameterName = "@award", DbType = DbType.String, Size = 50, Value = award });
			}

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, strSQL.ToString(), parameters.ToArray());

			while (rdr.Read()) {
                prizewinners.Add(new PrizewinnerInfo { Id = Convert.ToInt32(rdr["id"]), EmployeeId = rdr["empid"].ToString(), Name = rdr["name"].ToString(), Department = rdr["dept"].ToString(), Post = rdr["post"].ToString(), Award = rdr["award"].ToString(), Sign =(bool)rdr["sign"] });
			}

			rdr.Close();

			return prizewinners;
		}

        public int GetPrizewinnersByGroupAndAwardCount(string group, string award,bool Sign)
        {
            int ret = 0;

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter { ParameterName = "@group", DbType = DbType.String, Size = 50, Value = group });
            parameters.Add(new SQLiteParameter { ParameterName = "@award", DbType = DbType.String, Size = 50, Value = award });

            string XX = SQL_SELECT_PRIZEWINNER_COUNT;
            if (Sign)
            {
                XX = SQL_SELECT_PRIZEWINNER_COUNT_SIGN;
            }

            IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, XX, parameters.ToArray());

            while (rdr.Read())
            {
                int.TryParse(rdr["CC"].ToString(), out ret);
                //prizewinners.Add(new PrizewinnerInfo { Id = Convert.ToInt32(rdr["id"]), EmployeeId = rdr["empid"].ToString(), Name = rdr["name"].ToString(), Department = rdr["dept"].ToString(), Post = rdr["post"].ToString(), Award = rdr["award"].ToString(), Sign = (bool)rdr["sign"] });
            }

            rdr.Close();

            return ret;
        }

		
		public List<string> GetEmployeeIdByGroup(string group)
		{
			if (String.IsNullOrEmpty(group)) {
				throw new ArgumentNullException("group", "Tham số group Không thể null。");
			}

			List<string> employee = new List<string>();

			SQLiteParameter parameter = new SQLiteParameter("@group", DbType.String, 50);
			parameter.Value = group;

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_EMPID_BY_GROUP, parameter);

			while (rdr.Read()) {
				employee.Add(rdr["empid"].ToString());
			}

			rdr.Close();

			return employee;
		}

		
		public List<string> GetGroups()
		{
			List<string> groups = new List<string>();

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_GROUPS);
			while (rdr.Read()) {
				groups.Add(rdr["group"].ToString());
			}

			rdr.Close();

			return groups;
		}

		#endregion


        #region Cập nhật thắng cuộc

        
        public void UpdateSignPrizewinnerById(string id,bool YesOrNo)
        {
            int temp;
            if (String.IsNullOrEmpty(id) || !int.TryParse(id, out temp))
            {
                throw new ArgumentException("id", "ID không hợp lệ");
            }

            SQLiteParameter parameter = new SQLiteParameter("@id", DbType.Int32);
            parameter.Value = id;

            SQLiteParameter parameter1 = new SQLiteParameter("@sign", DbType.Boolean);
            parameter1.Value = YesOrNo;

            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_UPDATE_PRIZEWINNER_BY_ID,parameter,parameter1);

            if (result < 1)
            {
                throw new ApplicationException("Không thể cập nhật");
            }
        }

       
        public void UpdateSignPrizewinnerByEmpID(string empid, bool YesOrNo)
        {
            if (String.IsNullOrEmpty(empid))
            {
                throw new ArgumentException("empid", "Không hợp lệ.");
            }

            SQLiteParameter parameter = new SQLiteParameter("@empid", DbType.String);
            parameter.Value = empid;

            SQLiteParameter parameter1 = new SQLiteParameter("@sign", DbType.Boolean);
            parameter1.Value = YesOrNo;

            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_UPDATE_PRIZEWINNER_BY_EMPID, parameter, parameter1);

            if (result < 1)
            {
                throw new ApplicationException("Cập nhật thất bại.");
            }
        }

        #endregion
	}
}
