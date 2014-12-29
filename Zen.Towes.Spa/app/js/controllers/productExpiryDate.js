
app.controller('ProductExpiryDateCtrl', ['$scope', '$location', '$routeParams', 'ProductExpiryDateService', function ($scope, $location, $routeParams, ProductExpiryDateService) {
    'use strict';

    $scope.init = function () {
        ProductExpiryDateService.getAll().$promise
            .then(function (expiryDates) {
                $scope.expiryDates = expiryDates;
            });
    }

    $scope.init();
}]);



