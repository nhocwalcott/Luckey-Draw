using System;

namespace BPVN.LuckyDraw.Model
{
	[Serializable]
	public class EmployeeInfo
	{
		public int Id { get; set; }

		public string EmployeeId { get; set; }

		public string Name { get; set; }

		public string Department { get; set; }

		public string Post { get; set; }

        public bool Sign { get; set; }


	}
}
