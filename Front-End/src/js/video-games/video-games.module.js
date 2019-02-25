'use strict';

import angular from 'angular';
import uiRouter from 'angular-ui-router';
import videoGameRoutes from './video-games.routes';
import videoGamesComponent from './video-games.component';
import videoGameComponent from './video-game.component';
import videoGamesService from '../services/video-games.service';
import genresService from '../services/genres.service';
import publishersService from '../services/publishers.service';

export default angular.module('app.videoGames', [uiRouter])
    .factory('videoGamesService', videoGamesService)
    .factory('genresService', genresService)
    .factory('publishersService', publishersService)
    .config(videoGameRoutes)
    .component('videoGames', videoGamesComponent)
    .component('videoGame', videoGameComponent);

