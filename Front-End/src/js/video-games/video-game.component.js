'use strict';

import VideoGameController from './video-game.controller';

export default {
    template: require('./video-game.html'),
    controller: VideoGameController,
    controllerAs: 'vm',
    bindings: { videoGame: '=', genres: '<', publishers: '<', onUpdate: '&' }
}