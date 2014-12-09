app.service('ProductService', ['$rootScope', '$resource', function ($rootScope, $resource) {
    'use strict';

    this.getAll = getAll;

    function getAll() {
        return $resource('/data/productData.json').query();
    } 
}]); 