(function () {
	angular.module('StudentApp').controller('studentController', ['$scope', 'StudentService', '$location', function ($scope, studentService, $location) {

		$scope.students = [];

		$scope.getAllStudents = function () {
			debugger 
			studentService.GetAll().then(function (data) {
				if (data) {
					$scope.students = data;
				}
			});
		}

		$scope.deleteStudent = function (self) {
			studentService.Delete(self.$id).then(function (data) {
				//$scope.getAllStudents();
				$location.path('/list');
			});
		}

		$scope.saveStudent = function () {
			$scope.Save = function () {

				var obj = {
					StudentID: $scope.StudentID,
					Name: $scope.Name,
					Email: $scope.Email,
					University: $scope.University
				};

				studentService.Save(obj).then(function (data) {
					$location.path('/list');
				});
			}
		}

		$scope.getAllStudents();

		$scope.saveStudent();

	}]);

	angular.module('StudentApp').controller('studentGetController', ['$scope', 'StudentService', '$location', '$routeParams', function ($scope, studentService, $location, $routeParams) {

		$scope.students = [];

		$scope.GetStudent = function () {
			studentService.Get($routeParams.id).then(function (data) {
				$scope.StudentID = data.StudentID;
				$scope.Name = data.Name;
				$scope.Email = data.Email;
				$scope.University = data.University;
			});
		}

		$scope.GetStudent();

	}]);

}());