'use strict';

import VideoGamesController from './video-games.controller';

export default {
    template: require('./video-games.html'),
    controller: VideoGamesController,
    controllerAs: 'vm',
    bindings: { videoGames: '<' }
}