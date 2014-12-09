app.service('ExpiryDateService', ['$rootScope', '$resource', function ($rootScope, $resource) {
    'use strict';

    this.getAll = getAll;

    function getAll() {
        return $resource('/data/expiryDateData.json').query();
    } 
}]); 