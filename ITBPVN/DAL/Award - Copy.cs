using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using BPVN.LuckyDraw.Utils;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.DAL
{
	public class Award
	{
        private const string SQL_SELECT_AWARD = "SELECT name,tcount,oncecount,seq FROM award ORDER BY seq";
		private const string SQL_SELECT_AWARD_COUNT = "SELECT COUNT(*) FROM [award] WHERE [name]=@name";
        private const string SQL_INSERT_AWARD = "INSERT INTO award (name,tcount,oncecount,seq) VALUES(@name,@tcount,@oncecount,@seq)";
		private const string SQL_DELETE_AWARD = "DELETE FROM award WHERE name=@name";
        private const string SQL_UPDATE_AWARD = "UPDATE award SET tcount=@tcount,oncecount=@oncecount,seq=@seq WHERE name=@name";


        public List<AwardRecords> GetAllAwards(bool showtcount)
		{
            List<AwardRecords> awards = new List<AwardRecords>();

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_AWARD);

			while (rdr.Read()) {

                awards.Add(new AwardRecords{Name=rdr["name"].ToString(),Tcount=(int)rdr["tcount"] ,Oncecount=(int)rdr["oncecount"],Seq=(int)rdr["seq"]});
			}

			rdr.Close();

			return awards;
		}

        public List<string> GetAllAwards()
        {
            List<string> awards = new List<string>();

            IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_AWARD);

            while (rdr.Read())
            {
                awards.Add(rdr["name"].ToString());
            }

            rdr.Close();

            return awards;
        }

		/// <summary>
	
		/// </summary>
	
		/// <returns>bool</returns>
		public bool IsExist(string award)
		{
			if (String.IsNullOrEmpty(award)) {
				throw new ArgumentException("award", "Tên giải thưởng không hợp lệ.");
			}

			SQLiteParameter parameter = new SQLiteParameter("@name", DbType.String, 50);
			parameter.Value = award;

			object val = SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_AWARD_COUNT, parameter);

			return Convert.ToInt32(val) > 0;
		}

        public void AddAward(string name, int tcount, int OnceCount,int Seq)
		{
			if (String.IsNullOrEmpty(name)) {
				throw new ArgumentException("name", "Name Không thể để trống");
			}
            if (tcount < 1)
            {
                throw new ArgumentException("tcount", "tcount Không được nhỏ hơn hoặc bằng 0");
            }
            if (OnceCount < 1 || OnceCount>50)
            {
                throw new ArgumentException("oncecount", "oncecount Từ 1-->50.");
            }

			SQLiteParameter parameter = new SQLiteParameter("@name", DbType.String, 50);
			parameter.Value = name;

            SQLiteParameter parameter1 = new SQLiteParameter("@tcount", DbType.Int32);
            parameter1.Value = tcount;

            SQLiteParameter parameter2 = new SQLiteParameter("@oncecount", DbType.Int32);
            parameter2.Value = OnceCount;

            SQLiteParameter parameter3 = new SQLiteParameter("@seq", DbType.Int32);
            parameter3.Value = Seq;

            if (IsExist(name))
            {
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_UPDATE_AWARD, parameter, parameter1, parameter2, parameter3);
                if (result < 1)
                {
                    throw new ApplicationException("Cập nhật nội dung giải thưởng không thành công!");
                }
            }
            else
            {
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_INSERT_AWARD, parameter, parameter1, parameter2, parameter3);
                if (result < 1)
                {
                    throw new ApplicationException("Chèn tên giải thưởng không thành công!");
                }
            }
		}

		public void RemoveAward(string name)
		{
			if (String.IsNullOrEmpty(name)) {
				throw new ArgumentException("name", "Name Không thể để trống.");
			}

			SQLiteParameter parameter = new SQLiteParameter("@name", DbType.String, 50);
			parameter.Value = name;

			int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_DELETE_AWARD, parameter);
			if (result < 1) {
				throw new ApplicationException("Xóa giải thưởng không thành công!");
			}
		}

	}
}
