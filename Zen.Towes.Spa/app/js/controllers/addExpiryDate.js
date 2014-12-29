
app.controller('AddExpiryDateCtrl', ['$scope', '$location', '$routeParams', 'ExpiryDateService', 'ProductService', 'ProductExpiryDateService', 'ProductListRoute', function ($scope, $location, $routeParams, ExpiryDateService, ProductService, ProductExpiryDateService, ProductListRoute) {
    'use strict';

    var baseExpiryDate = {
        productId: $routeParams.ProductId,
        dueDate: new Date()
    }

    $scope.expiryDate = baseExpiryDate;
    $scope.currentExpiryDates = [];

    $scope.init = function (productId) {
        ProductService.get(productId).$promise
            .then(function (product) {
                $scope.product = product;
            });

        ProductExpiryDateService.getForProduct(productId).$promise
            .then(function (productExpiryDates) {
                $scope.currentExpiryDates = productExpiryDates;
            });
    }

    $scope.init(baseExpiryDate.productId);

    $scope.cancel = function () {
        $location.path(ProductListRoute);
    }

    $scope.save = function (expiryDate) {
        ExpiryDateService.save(expiryDate).$promise
            .then(function () {
                $location.path(ProductListRoute);
            })
    }
}]);



