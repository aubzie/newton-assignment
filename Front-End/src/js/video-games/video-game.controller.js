'use strict';

VideoGameController.$inject = ['videoGamesService']

export default function VideoGameController(videoGamesService) {
    var vm = this;
    vm.update = updateVideoGame;

    function updateVideoGame() {
        videoGamesService.update(vm.videoGame);
        console.log("clicked");
    }
}
