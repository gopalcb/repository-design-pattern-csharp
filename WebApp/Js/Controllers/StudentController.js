(function() {
	var app = angular.module("StudentController", []);

	var studentControllers = function ($scope, $http) {
		$http.get('/api/GetAllStudent').success(function (data) {
			debugger;
			$scope.students = data;
		});
	};

	app.controller("StudentController", studentControllers);
}());