var app = angular.module('StudentApp', ['ngRoute']);

app.config(function($routeProvider, $locationProvider) {
	$routeProvider
		//.when('/', {
		//	redirectTo: function () {
		//		return '/home';
		//	}
		//})
		.when('/list', {
			templateUrl: 'Views/Student/List.html',
			controller: 'StudentController'
		})
		//.when('/contact/:Id', {
		//	templateUrl: '/Home/Contact',
		//	controller: 'ErrorController'
		//})
		//.when('/about', {
		//	templateUrl: '/Home/About',
		//	controller: 'ErrorController'
		//})
		//.when('/details', {
		//	templateUrl: '/Home/Details',
		//	controller: 'ErrorController'
		//})
		.otherwise({
			redirectTo: '/list'
		});
	$locationProvider.html5Mode(false).hashPrefix('!'); // This is for Hashbang Mode
});