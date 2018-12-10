function SavoryLessonManageService($resource, $q) {

    var resource = $resource('api/search-support', {}, {

        lesson_items: { method: 'POST', url: 'api/lesson/items' },
        lesson_item: { method: 'POST', url: 'api/lesson/item' },
        lesson_count: { method: 'POST', url: 'api/lesson/count' },
        lesson_update: { method: 'POST', url: 'api/lesson/update' },
        lesson_enable: { method: 'POST', url: 'api/lesson/enable' },
        lesson_disable: { method: 'POST', url: 'api/lesson/disable' },
        lesson_create: { method: 'POST', url: 'api/lesson/create' },
        lesson_editable: { method: 'POST', url: 'api/lesson/editable' },
        lesson_empty: { method: 'POST', url: 'api/lesson/empty' },

        user_profile: { method: 'POST', url: 'api/user/profile' }
    });

    return {

        lesson_items: function (request) { var d = $q.defer(); resource.lesson_items({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_item: function (request) { var d = $q.defer(); resource.lesson_item({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_update: function (request) { var d = $q.defer(); resource.lesson_update({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_count: function (request) { var d = $q.defer(); resource.lesson_count({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_enable: function (request) { var d = $q.defer(); resource.lesson_enable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_disable: function (request) { var d = $q.defer(); resource.lesson_disable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_create: function (request) { var d = $q.defer(); resource.lesson_create({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_editable: function (request) { var d = $q.defer(); resource.lesson_editable({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },
        lesson_empty: function (request) { var d = $q.defer(); resource.lesson_empty({}, request, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; },

        user_profile: function () { var d = $q.defer(); resource.user_profile({}, function (result) { d.resolve(result); }, function (result) { d.reject(result); }); return d.promise; }
    }
}
