using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Data.Models;
using Repository.Pattern.Repositories;

namespace Repository
{
    public static class StudentRepository
    {
		public static List<Student> GetAllStudent(this IRepositoryAsync<Student> repository)
		{
			var stds = repository.Queryable().ToList();
			return stds;
		}
	}
}
