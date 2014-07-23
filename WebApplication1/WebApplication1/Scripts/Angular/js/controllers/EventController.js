'use strict';

eventsApp.controller("EventController",
    function EventController($scope) {
        $scope.event = {
            name: "something",
            time: new Date(),
            //img: "https://angularjs.org/img/AngularJS-large.png",
            items: [
                {
                    name: "Uno",
                    count: 0
                },
                {
                    name: "Dos",
                    count: 0
                },
                {
                    name: "Tres",
                    count: 0
                },
            ]
        };
        $scope.changeCount = function(item, amountToAdd) {
            item.count += amountToAdd;
        }
    });