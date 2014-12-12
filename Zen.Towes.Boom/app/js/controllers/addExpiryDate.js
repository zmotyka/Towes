
app.controller('AddExpiryDateCtrl', ['$scope', '$location', '$routeParams', 'ExpiryDateService', 'ProductService', function ($scope, $location, $routeParams, ExpiryDateService, ProductService) {
    'use strict';

    var redirectRoute = '/products';
    var defaultDate = '1/1/2015';

    $scope.date = defaultDate;

    $scope.init = function () {
        ProductService.get($routeParams.ProductId).$promise
        .then(function (product) {
            $scope.product = product
        });
    }

    $scope.init();

    $scope.cancel = function () {
        $location.path(redirectRoute);
    }

    $scope.add = function (productId, date) {
        // TODO: call service method to add

        $location.path(redirectRoute);
    }
}]);



