const userprofile = {
    personaldetails: function getPersonalDetails(callback) {
        get('profile/api/personaldetails/' + sessionStorage["token"], callback);
    },
    updatepersonaldetails: function postPersonalDetails(data, callback) {
        post('profile/api/personaldetails', data, callback);
    },

    loadLanguages: function loadLanguages(callback) {
        get('profile/api/loadlanguages/' + sessionStorage["token"], callback);
    },

    updateLanguage: function createNewLanguage(data, callback) {

        post('profile/api/createlanguage/' + sessionStorage["token"], data, callback);
    },

    loadExperience: function loadExperience(callback) {
        get('profile/api/loadexperience/' + sessionStorage["token"], callback);
    },

    updateExperience: function createExperience(data, callback) {
        post('profile/api/createexperience', data, callback);
    },

    loadQualification: function loadQualification(callback) {
        get('profile/api/loadqualification/' + sessionStorage["token"], callback);
    },

    updateQualification: function createQualification(data, callback) {
        post('profile/api/createqualification', data, callback);
    },

    loadCourses: function loadCourses(callback) {
        get('profile/api/loadcourses/' + sessionStorage["token"], callback);
    },

    updateCourses: function createCourses(data, callback) {
        post('profile/api/createcourse', data, callback);
    },

    loadSkills: function loadSkills(callback) {
        get('profile/api/loadskills/' + sessionStorage["token"], callback);
    },

    updateSkills: function createSkills(data, callback) {
        post('profile/api/createskills', data, callback);
    },

    loadProjects: function loadProjects(callback) {
        get('profile/api/loadprojects/' + sessionStorage["token"], callback);
    },

    updateProjects: function createProjects(data, callback) {
        post('profile/api/createprojects', data, callback);
    },
    //-- Ahi thi baki
    updateAward: function createAward(data, callback) {
        post('profile/api/createaward', data, callback);
    },

    loadAwards: function loadAwards(callback) {
        get('profile/api/loadawards/' + sessionStorage["token"], callback);
    },

    updateCertification: function createCertification(data, callback) {
        post('profile/api/createcertification', data, callback);
    },

    loadCertifications: function loadCertifications(callback) {
        get('profile/api/loadcertifications/' + sessionStorage["token"], callback);
    },

    updateCopyRight: function createCopyRight(data, callback) {
        post('profile/api/createcopyRight', data, callback);
    },

    loadCopyRights: function loadCopyRights(callback) {
        get('profile/api/loadcopyrights/' + sessionStorage["token"], callback);
    },
    updatePatent: function createPatent(data, callback) {
        post('profile/api/createpatent', data, callback);
    },

    loadPatents: function loadPatents(callback) {
        get('profile/api/loadpatents/' + sessionStorage["token"], callback);
    },

    updateHobbies: function createHobbies(data, callback) {
        post('profile/api/createhobbies', data, callback);
    },

    loadHobbies: function loadHobbies(callback) {
        get('profile/api/loadhobbies/' + sessionStorage["token"], callback);
    },

    updatePublicProfile: function createPublicProfile(data, callback) {   
        post('profile/api/createpublicprofile', data, callback);
    },

    loadPublicProfile: function loadPublicProfile(callback) {
        get('profile/api/loadpublicprofile/' + sessionStorage["token"], callback);
    },

    checkUniqueUrl: function checkUniqueUrl(url, callback) {
        get('profile/api/checkUniqueUrl/' + url, callback);
    },

    getUserId(providerkey, callback) {
        get('profile/api/fetchuserbykey/' + providerkey, callback);
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



