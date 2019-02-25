'use strict';

export default function videoGamesService($http) {

    var url = 'http://localhost:13538/api/videogames/';

    var service = {
        getAll: getAll,
        get: get,
        update: update
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
                    data.push({ id: response.data[i].Id, title: response.data[i].Title });
                }
            },
            function (error) {
            }
        );

        return data;

        //return [
        //    { id: 1, name: "testasdadasdasd", year: 2009 },
        //    { id: 2, name: "test11", year: 2010 },
        //    { id: 3, name: "test22", year: 2012 },
        //    { id: 4, name: "test3333", year: 2012 },
        //    { id: 5, name: "test test", year: 2017 },
        //    { id: 6, name: "test787669", year: 2018 },
        //    { id: 7, name: "test567", year: 2019 }
        //]
    }

    function get(id) {
        var data = {};
        $http({
            method: 'GET',
            url: url + id
        })
        .then(
            function (response) {
                data.Id = response.data.Id;
                data.Title = response.data.Title;
                data.Description = response.data.Description;
                data.Year = response.data.Year;
                data.PublisherId = response.data.PublisherId;
            },
            function (error) {
            }
        );

        return data;
    }

    function update(data) {
        $http({
            method: 'PUT',
            url: url + data.Id,
            data: data
        });
    }
}