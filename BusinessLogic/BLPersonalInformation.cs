using DBHandler.Database;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace BusinessLogic
{

    public class BLPersonalInformation : BaseBL
    {
        public string GetPersonalInformation(string UserId)
        {
            return Serialize(personalInformation.GetPersonalInformationFromId(UserId));
        }

        public string UpdatePersonalDetails(string UserId, object data)
        {
            return Serialize(personalInformation.UpdatePersonalDetails(UserId, data));
        }

        public object GetLanguages(string UserId)
        {
            return Serialize(personalInformation.LoadLanguages(UserId));
            
        }

        public object CreateOrUpdateLanguage(string UserId, object data)
        {
            return Serialize(personalInformation.CreateOrUpdateLanguage(UserId, data));
        }

        public object GetExperiences(string UserId)
        {
            return Serialize(personalInformation.LoadExperiences(UserId));
        }

        public object CreateOrUpdateExperience(string UserId, object data)
        {
            return Serialize(personalInformation.CreateOrUpdateExperience(UserId, data));
        }

        public object GetQualification(string UserId)
        {
            return Serialize(personalInformation.LoadQualification(UserId));
        }

        public object CreateOrUpdateQualification(string UserId, object data)
        {
            return Serialize(personalInformation.CreateOrUpdateQualification(UserId, data));
        }

        public object GetCourses(string userId)
        {
            return Serialize(personalInformation.GetCourses(userId));
        }

        public object CreateOrUpdateCourse(string userId, object data)
        {
            return Serialize(personalInformation.CreateOrUpdateCourse(userId, data));
        }

        public object GetSkills(string userId)
        {
            return Serialize(personalInformation.LoadSkills(userId));
        }

        public object CreateOrUpdateSkill(string userId, object data)
        {
            return Serialize(personalInformation.CreateOrUpdateSkills(userId, data));
        }

        public object GetProjects(string userId)
        {
            return Serialize(personalInformation.LoadProjects(userId));
        }

        public object CreateOrUpdateProjects(string userId, object data)
        {
            return Serialize(personalInformation.CreateOrUpdateProjects(userId, data));
        }

        public object GetAwards(string userId)
        {
            throw new NotImplementedException();
        }

        public object GetCertifications(string userId)
        {
            throw new NotImplementedException();
        }

        public object CreateOrUpdateAwards(string v, object data)
        {
            throw new NotImplementedException();
        }

        public object CreateOrUpdateCertifications(string v, object data)
        {
            throw new NotImplementedException();
        }

        public object GetCopyRight(string userId)
        {
            throw new NotImplementedException();
        }

        public object CreateOrUpdateCopyRights(string v, object data)
        {
            throw new NotImplementedException();
        }

        public object GetPatents(string userId)
        {
            throw new NotImplementedException();
        }

        public object CreateOrUpdatePatents(string v, object data)
        {
            throw new NotImplementedException();
        }

        public object GetHobbies(string userId)
        {
            throw new NotImplementedException();
        }

        public object CreateOrUpdateHobbies(string v, object data)
        {
            throw new NotImplementedException();
        }

        public object GetPublicProfileDetails(string userId)
        {
            throw new NotImplementedException();
        }

        public object CreateOrUpdatePublicProfileDetails(string v, object data)
        {
            throw new NotImplementedException();
        }
    }
}
