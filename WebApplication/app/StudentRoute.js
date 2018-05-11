(function () {
	var app = angular.module('StudentApp', ['ngRoute']);

	app.config(function ($routeProvider) {
		$routeProvider

			.when('/list', {
				templateUrl: 'Views/List.cshtml',
				controller: 'studentController'
			})
			.when('/create', {
				templateUrl: 'Views/Create.cshtml',
				controller: 'studentController'
			})
			.when('/edit/:id', {
				templateUrl: 'Views/Create.cshtml',
				controller: 'studentGetController'
			})
			.otherwise({
				redirectTo: '/list'
			});
	});
}())