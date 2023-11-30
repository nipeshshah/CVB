const publicprofile = {
    getUserPublicResume: function (templateid, userid, callback) {
        get('api/publicresume/' + templateid + '/cv/' + userid, callback);
    }
}