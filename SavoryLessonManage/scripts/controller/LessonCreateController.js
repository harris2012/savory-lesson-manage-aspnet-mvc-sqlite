function LessonCreateController($scope, $state, $stateParams, SavoryLessonManageService) {

    function lesson_empty_callback(response) {

        if (response.status != 1) {
            swal(response.message);
            return;
        }

        $scope.item = response.item;
    }

    function lesson_create_callback(response) {

        $scope.waiting = false;

        if (response.status != 1) {
            $scope.message = response.message;
            return;
        }

        $state.go('app.lesson-list');
    }

    $scope.confirmCreate = function () {

        $scope.waiting = true;
        $scope.message = null;

        var request = {};
        request.id = $scope.item.id;
        request.ename = $scope.item.ename;
        request.title = $scope.item.title;

        SavoryLessonManageService.lesson_create(request).then(lesson_create_callback)
    }

    {
        SavoryLessonManageService.lesson_empty({}).then(lesson_empty_callback);
    }
}
