using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using BPVN.LuckyDraw.Utils;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.DAL
{
	public class Detail
	{
        private const string SQL_SELECT_AWARD = "SELECT name,id_award,qty FROM detail";
		private const string SQL_SELECT_AWARD_COUNT = "SELECT COUNT(*) FROM [award] WHERE [name]=@name";
        private const string SQL_INSERT_AWARD = "INSERT INTO detail(name,id_award,qty) VALUES(@name,@id_award,@qty)";
		


        public List<DetailRecord> GetAllDetail()
		{
            List<DetailRecord> details = new List<DetailRecord>();

			IDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, SQL_SELECT_AWARD);

			while (rdr.Read()) {

                details.Add(new DetailRecord { Name=rdr["name"].ToString(), Qty=rdr["qty"].ToString() ,Id_award =rdr["id_award"].ToString()});
			}

			rdr.Close();

			return details;
		}


		/// <summary>
	
		/// </summary>
	
		/// <returns>bool</returns>

        public void AddDetail(string name, string id_award , string qty)
		{
			
			SQLiteParameter parameter = new SQLiteParameter("@name", DbType.String, 50);
			parameter.Value = name;

            SQLiteParameter parameter1 = new SQLiteParameter("@id_award", DbType.Int32);
            parameter1.Value = id_award;

            SQLiteParameter parameter2 = new SQLiteParameter("@qty", DbType.Int32);
            parameter2.Value = qty;

           
           int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, SQL_INSERT_AWARD, parameter, parameter1, parameter2);
           
		}

	

	}
}
