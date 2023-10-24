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

    updateExperience: function createExperience(data, callback) {
        post('profile/api/createexperience', data, callback);
    },

    loadQualification: function loadQualification(callback) {
        get('profile/api/loadqualification/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateQualification: function createQualification(data, callback) {
        post('profile/api/createqualification', data, callback);
    },

    loadCourses: function loadCourses(callback) {
        get('profile/api/loadcourses/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateCourses: function createCourses(data, callback) {
        post('profile/api/createcourse', data, callback);
    },

    loadSkills: function loadSkills(callback) {
        get('profile/api/loadskills/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateSkills: function createSkills(data, callback) {
        post('profile/api/createskills', data, callback);
    },

    loadProjects: function loadProjects(callback) {
        get('profile/api/loadprojects/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateProjects: function createProjects(data, callback) {
        post('profile/api/createprojects', data, callback);
    },
    //-- Ahi thi baki
    updateAward: function createAward(data, callback) {
        post('profile/api/createaward', data, callback);
    },

    loadAwards: function loadAwards(callback) {
        get('profile/api/loadawards/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateCertification: function createCertification(data, callback) {
        post('profile/api/createcertification', data, callback);
    },

    loadCertifications: function loadCertifications(callback) {
        get('profile/api/loadcertifications/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateCopyRight: function createCopyRight(data, callback) {
        post('profile/api/createcopyRight', data, callback);
    },

    loadCopyRights: function loadCopyRights(callback) {
        get('profile/api/loadcopyrights/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },
    updatePatent: function createPatent(data, callback) {
        post('profile/api/createpatent', data, callback);
    },

    loadPatents: function loadPatents(callback) {
        get('profile/api/loadpatents/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updateHobbies: function createHobbies(data, callback) {
        post('profile/api/createhobbies', data, callback);
    },

    loadHobbies: function loadHobbies(callback) {
        get('profile/api/loadhobbies/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    updatePublicProfile: function createPublicProfile(data, callback) {   
        post('profile/api/createpublicprofile', data, callback);
    },

    loadPublicProfile: function loadPublicProfile(callback) {
        get('profile/api/loadpublicprofile/' + "4938f26b-4ed0-4a40-9c5e-d5934ff8c819", callback);
    },

    getProficiency: function (proficiency) {
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



