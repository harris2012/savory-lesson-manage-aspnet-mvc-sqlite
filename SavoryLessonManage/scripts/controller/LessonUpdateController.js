//新建数据库
function LessonUpdateController($scope, $state, $stateParams, SavoryLessonManageService) {

    $scope.id = $stateParams.id;

    function lesson_editable_callback(response) {

        $scope.loaded = true;
        if (response.status != 1) {
            return;
        }

        $scope.item = response.item;
    }

    function lesson_update_callback(response) {
        if (response.status != 1) {
            swal(response.message);
            return;
        }

        $state.go('app.lesson-item', { id: $scope.id });
    }

    $scope.confirmUpdate = function () {

        $scope.waiting = true;
        $scope.message = null;

        var request = {};
        request.id = $scope.item.id;
        request.ename = $scope.item.ename;
        request.title = $scope.item.title;

        SavoryLessonManageService.lesson_update(request).then(lesson_update_callback)
    }

    {
        var request = {};
        request.id = $scope.id;

        SavoryLessonManageService.lesson_editable(request).then(lesson_editable_callback);
    }
}
