angular.module('StudentApp').factory('StudentService', ['$q', '$http', function ($q, $http) {

	var baseUrl = 'http://localhost:57814/api/Student/';

	var studentService = {};

	studentService.Save = function (student) {
		var deferred = $q.defer();
		$http.post(baseUrl, student)
		   .success(function (data) {
		   	deferred.resolve(data);
		   }).error(function (error) {
		   	deferred.reject(error);
		   });
		return deferred.promise;
	}

	studentService.Get = function (id) {
		var deferred = $q.defer();
		$http.get(baseUrl + id)
		   .success(function (data) {

		   	deferred.resolve(data);
		   }).error(function (error) {
		   	deferred.reject(error);
		   });
		return deferred.promise;
	}

	studentService.GetAll = function () {
		var deferred = $q.defer();
		$http.get(baseUrl)
		   .success(function (data) {

		   	deferred.resolve(data);
		   }).error(function (error) {
		   	deferred.reject(error);
		   });
		return deferred.promise;
	}

	studentService.Delete = function (id) {
		bootbox.confirm('Are you sure?', function (result) {
			if (result) {
				$http.delete(baseUrl + id).success(function (data) {

				}).error(function (data) {
					$scope.error = 'An error has occured while deleting employee! ' + data.ExceptionMessage;
				});
			}
		});

		return deferred.promise;
	}

	//studentService.GetForReview = function (detailViewModel) {
	//	var deferred = $q.defer();
	//	$http.get(baseUrl + 'GetForReview', { params: detailViewModel })
	//	   .success(function (data) {

	//	   	deferred.resolve(data);
	//	   }).error(function (error) {
	//	   	deferred.reject(error);
	//	   });
	//	return deferred.promise;
	//}

	return studentService;

}]);