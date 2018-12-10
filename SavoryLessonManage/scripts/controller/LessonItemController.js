function LessonItemController($scope, $state, $stateParams, SavoryLessonManageService) {

    $scope.id = $stateParams.id;

    function lesson_item_callback(response) {

        $scope.loaded = true;
        if (response.status != 1) {
            return;
        }

        $scope.item = response.item;
    }

    {
        var request = {};
        request.id = $scope.id;

        SavoryLessonManageService.lesson_item(request).then(lesson_item_callback);
    }
}
