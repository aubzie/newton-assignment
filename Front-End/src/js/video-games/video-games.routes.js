'use strict';

//videoGamesRoutes.$inject = ['$stateProvider'];

export default function videoGamesRoutes($stateProvider) {

    var indexState = {
        name: 'index',
        url: '',
        component: 'videoGames',
        resolve: {
            videoGames: function (videoGamesService) {
                return videoGamesService.getAll();
            }
        }
    }

    var videoGameState = {
        name: 'video-game',
        url: '/video-games/{videoGameId}',
        component: 'videoGame',
        resolve: {
            videoGame: function (videoGamesService, $transition$) {
                return videoGamesService.get($transition$.params().videoGameId);
            },
            genres: function (genresService) {
                return genresService.getAll();
            },
            publishers: function (publishersService) {
                return publishersService.getAll();
            }
        }
    }

    $stateProvider.state(indexState);
    $stateProvider.state(videoGameState);
}

