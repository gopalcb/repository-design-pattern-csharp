using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using ServiceApi.Models;
using System.Web.Http.Cors;
using Data.Models;
using Microsoft.Practices.Unity;
using Repository.Pattern.UnitOfWork;
using Service;

namespace ServiceApi.Controllers
{
    [AllowAnonymous]
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class StudentController : ApiController
    {
		private readonly IStudentService _studentService;
		private readonly IUnitOfWorkAsync _unitOfWorkAsync;

		public StudentController(IStudentService studentService, IUnitOfWorkAsync unitOfWorkAsync) {
			_studentService = studentService;
			_unitOfWorkAsync = unitOfWorkAsync;
		}
		
		// POST api/<controller>
		public async Task<IHttpActionResult> Post(Student student) {
			_studentService.InsertOrUpdateGraph(student);
			await _unitOfWorkAsync.SaveChangesAsync();
			return Ok(student.StudentID);
		}
		
		// GET api/<controller>
		public IEnumerable<Student> Get() {
			return _studentService.GetAll();
		}

		// GET api/<controller>/5
		public IHttpActionResult Get(int id) {
			var student = _studentService.GetByStudentId(id);
			return Ok(student);
		}

		// DELETE api/values/5
		public IHttpActionResult Delete(int id) 
		{
			var student = _studentService.GetByStudentId(id);
			_studentService.Delete(student);
			_unitOfWorkAsync.SaveChanges();
			return Ok(student.StudentID);
		}

		//[HttpGet]
		//[Route("api/Student/GetForReview")]
		//public IHttpActionResult GetForReview([FromUri]OverDetailViewModel detailViewModel) {
		//	try {
		//		var match = _matchService.GetForReview(detailViewModel);
		//		return Ok(match);
		//	} catch(Exception ex) {
		//		return BadRequest("Match Not Found!!");
		//	}
		//}
	}
}
