app.service('ProductService', ['$rootScope', '$resource', function ($rootScope, $resource) {
    'use strict';

    this.get = function (productId) {
        // todo: use productId to query the data
        return $resource('/data/singleProductData.json').get();
    }

    this.getAll = function () {
        return $resource('/data/productData.json').query();
    } 
}]); 