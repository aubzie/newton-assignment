'use strict';

//videoGamesService.$inject = ['$http'];

export default function genresService($http) {

    var url = 'http://localhost:13538/api/genres/';

    var service = {
        getAll: getAll
    }

    return service;

    function getAll() {
        var data = [];
        $http({
            method: 'GET',
            url: url
        })
        .then(
            function (response) {
                for (var i = 0; i < response.data.length; ++i) {
                    data.push({ Id: response.data[i].Id, Mame: response.data[i].Name });
                }
            },
            function (error) {
            }
        );

        return data;
    }

}