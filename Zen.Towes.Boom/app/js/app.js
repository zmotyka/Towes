
/*================================================================
=>                  App = towes
==================================================================*/
/*global angular*/

var app = angular.module('towes', ["ngCookies", "ngResource", "ngSanitize", "ngRoute", "ngAnimate", "ui.utils", "ui.bootstrap", "ui.router", "ngGrid"]);


app.config(['$routeProvider', '$locationProvider', '$httpProvider', function ($routeProvider, $locationProvider, $httpProvider) {
	'use strict';

	$routeProvider
		.when('/products', {
			templateUrl: 'templates/products.html'
		})
        .when('/expiryDates', {
            templateUrl: 'templates/expiryDates.html'
        })
		.otherwise({
			redirectTo: '/products'
		});

	$locationProvider.hashPrefix('!');

	// This is required for Browser Sync to work poperly
	$httpProvider.defaults.headers.common['X-Requested-With'] = 'XMLHttpRequest';
}]);


/*================================================================
=>                  towes App Run()  
==================================================================*/

app.run(['$rootScope', function ($rootScope) {
	
	'use strict';

	console.log('Angular.js run() function...');
}]);




/* ---> Do not delete this comment (Values) <--- */

/* ---> Do not delete this comment (Constants) <--- */