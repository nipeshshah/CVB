const cvtemplate = {
    getavailabletemplates: function getAvailableTemplates(callback) {
        get('template/api/active/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },
    getavailabletemplatesections: function getAvailableTemplates(templatename, callback) {
        get('template/api/activesections/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819" + '/' + templatename, callback);
    },
    submitNewResume: function submitNewResume(payLoad, callback) {
        post('template/api/submitresume/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", payLoad, callback);
    }
}