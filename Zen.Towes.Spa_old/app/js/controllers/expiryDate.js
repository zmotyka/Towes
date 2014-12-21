
app.controller('ExpiryDateCtrl', ['$scope', '$location', '$routeParams', 'ExpiryDateService', function ($scope, $location, $routeParams, ExpiryDateService) {
    'use strict';

    $scope.init = function () {
        console.log('init');
        ExpiryDateService.getAll().$promise
            .then(function (expiryDates) {
                console.log(expiryDates);

                $scope.expiryDates = expiryDates;
            });
    }

    $scope.init();
}]);



