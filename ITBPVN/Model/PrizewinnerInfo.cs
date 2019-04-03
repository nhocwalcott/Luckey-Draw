using System;

namespace BPVN.LuckyDraw.Model
{
	[Serializable]
	public class PrizewinnerInfo
	{
		public int Id { get; set; }

		public string EmployeeId { get; set; }

		public string Name { get; set; }

		public string Department { get; set; }

		public string Post { get; set; }

		public string Award { get; set; }

        public Boolean Sign { get; set; }
	}
}
