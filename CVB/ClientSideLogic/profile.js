const userprofile = {
    personaldetails: function getPersonalDetails(callback) {
        get('profile/api/personaldetails/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },
    updatepersonaldetails: function postPersonalDetails(data, callback) {
        post('profile/api/personaldetails', data, callback);
    },

    loadLanguages: function loadLanguages(callback) {
        get('profile/api/loadlanguages/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateLanguage: function createNewLanguage(data, callback) {

        post('profile/api/createlanguage', data, callback);
    },

    loadExperience: function loadExperience(callback) {
        get('profile/api/loadexperience/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateExperience: function createExperience(callback) {
        post('profile/api/createexperience', callback);
    },

    loadQualification: function loadQualification(callback) {
        get('profile/api/loadqualification/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateQualification: function createQualification(callback) {
        post('profile/api/createqualification', callback);
    },

    loadCourses: function loadCourses(callback) {
        get('profile/api/loadcourses/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateCourses: function createCourses(callback) {
        post('profile/api/createcourse', callback);
    },

    loadSkills: function loadSkills(callback) {
        get('profile/api/loadskills/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateSkills: function createSkills(callback) {
        post('profile/api/createskills', callback);
    },

    getProficiency: function(proficiency) {
        var prof = '';
        switch (proficiency) {
            case -1:
                prof = "None";
                break;
            case 0:
                prof = "Beginner";
                break;
            case 1:
                prof = "Intermediate";
                break;
            case 2:
                prof = "Advanced";
                break;
            case 3:
                prof = "Expert";
                break;
        }
        return prof;
    }
}



