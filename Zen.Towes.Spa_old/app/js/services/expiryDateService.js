app.service('ExpiryDateService', ['$rootScope', '$resource', function ($rootScope, $resource) {
    'use strict';

    this.getAll = function () {
        return $resource('/data/expiryDateData.json').query();
    }
}]); 