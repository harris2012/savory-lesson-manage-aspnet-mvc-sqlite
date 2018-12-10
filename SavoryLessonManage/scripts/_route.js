var route = function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.when('', '/welcome').when('/', '/welcome');

    $stateProvider.state('app', {
        url: '/',
        views: {
            'header': { templateUrl: 'scripts/view/view_header.html?v=' + window.releaseNo, controller: HeaderController },
            'main-menu': { templateUrl: 'scripts/view/view_menu.html?v=' + window.releaseNo},
            'main-body': { template: '<div ui-view></div>' }
        }
    });

    $stateProvider.state('app.welcome', { url: 'welcome', templateUrl: 'scripts/view/view_welcome.html?v=' + window.releaseNo });

    $stateProvider.state('app.lesson-list', { url: 'lesson-list', templateUrl: 'scripts/view/view_lesson_list.html?v=' + window.releaseNo, controller: LessonListController });
    $stateProvider.state('app.lesson-item', { url: 'lesson-item/:id', templateUrl: 'scripts/view/view_lesson_item.html?v=' + window.releaseNo, controller: LessonItemController });
    $stateProvider.state('app.lesson-create', { url: 'lesson-create', templateUrl: 'scripts/view/view_lesson_create.html?v=' + window.releaseNo, controller: LessonCreateController });
    $stateProvider.state('app.lesson-update', { url: 'lesson-update/:id', templateUrl: 'scripts/view/view_lesson_update.html?v=' + window.releaseNo, controller: LessonUpdateController });

    $stateProvider.state('app.otherwise', {
        url: '*path',
        templateUrl: 'views/view_404.html?v=' + window.releaseNo
    });
}