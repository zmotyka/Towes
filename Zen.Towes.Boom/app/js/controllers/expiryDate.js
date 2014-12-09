
app.controller('ExpiryDateCtrl', ['$scope', '$location', '$routeParams', 'ExpiryDateService', function ($scope, $location, $routeParams, ExpiryDateService) {
    'use strict';

    ExpiryDateService.getAll().$promise
        .then(function (expiryDates) {
            $scope.expiryDates = expiryDates;
        }); 
}]);



