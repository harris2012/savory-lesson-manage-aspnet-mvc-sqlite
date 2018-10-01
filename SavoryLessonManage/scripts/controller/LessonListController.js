function LessonListController($scope, $state, $stateParams, SavoryLessonManageService) {

    function lesson_items_callback(response) {

        $scope.items_loaded = true;

        if (response.status !== 1) {
            $scope.items_message = response.message;
            return;
        }

        $scope.items = response.items;
    }

    function lesson_count_callback(response) {

        $scope.count_loaded = true;
        if (response.status !== 1) {
            $scope.count_message = response.message;
            return;
        }

        $scope.totalCount = response.totalCount;
    }

    //分页
    $scope.pageChanged = function () {

        $scope.items_loaded = false;
        $scope.items_message = null;

        var request = {};

        request.pageIndex = $scope.currentPage;

        SavoryLessonManageService.lesson_items(request).then(lesson_items_callback);
    };

    {
        $scope.maxSize = 10;
        $scope.currentPage = 1;
        $scope.pageSize = 20;

        SavoryLessonManageService.lesson_count({}).then(lesson_count_callback);
        SavoryLessonManageService.lesson_items({pageIndex: $scope.currentPage}).then(lesson_items_callback);
    }

}
