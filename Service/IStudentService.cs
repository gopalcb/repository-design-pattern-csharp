using Data.Models;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.Repositories;

namespace Service
{
	public interface IStudentService : IService<Student>
	{
		IEnumerable<Student> GetAll();
		Student GetByStudentId(int studentId);
		void InsertOrUpdate(Student student);
	}
}