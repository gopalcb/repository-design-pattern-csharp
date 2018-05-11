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
	public class StudentService : Service<Student>, IStudentService {
		private readonly IRepositoryAsync<Student> _repository;
		public StudentService(IRepositoryAsync<Student> repository)
            : base(repository)
		{
			_repository = repository;
		}

		public IEnumerable<Student> GetAll()
		{
			return _repository.Queryable().ToList();
		}

		public Student GetByStudentId(int studentId)
		{
			return _repository.Find(studentId);
		}

		public void InsertOrUpdate(Student student)
		{
			_repository.InsertOrUpdateGraph(student);
		}
	}
}