using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.EF6;

namespace Data.Models {
	public class Student : Entity {
		public int StudentID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string University { get; set; }
	}
}
