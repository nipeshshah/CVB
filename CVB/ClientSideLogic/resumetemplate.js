const cvtemplate = {
    getavailabletemplates: function getAvailableTemplates(callback) {
        get('template/api/active/' + sessionStorage["token"], callback);
    },
    getavailabletemplatesections: function getAvailableTemplates(templatename, callback) {
        debugger;
        get('template/api/activesections/' + sessionStorage["token"] + '/' + templatename, callback);
    },
    getavailabletemplatesectionspublic: function getAvailableTemplatesPublicUrl(templatename, publicUrl, callback) {
        debugger;
        get('template/api/activesections/public/' + publicUrl + '/' + templatename, callback);
    },
    submitNewResume: function submitNewResume(payLoad, callback) {
        post('template/api/submitresume/' + sessionStorage["token"], payLoad, callback);
    },
    getresumes: function getresumes(callback) {
        get('template/api/resumes/' + sessionStorage["token"], callback);
    },
    getTemplateName: function getTemplateName(templateId, callback) {
        get('template/api/template/' + templateId, callback);
    }
}