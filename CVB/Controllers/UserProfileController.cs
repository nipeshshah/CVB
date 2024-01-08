using DBHandler.Database;
using Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBHandler.Database;
namespace CVB.Controllers
{
    [RoutePrefix("profile")]
    public class UserProfileController : BaseAPIController
    {
        [HttpGet]
        [Route("api/personaldetails/{UserId}")]
        public IHttpActionResult GetPersonalDetails(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetPersonalInformation(UserId));
        }

        [HttpPost]
        [Route("api/personaldetails/{UserId}")]
        public IHttpActionResult UpdatePersonalDetails(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.UpdatePersonalDetails(UserId, data));
        }
    
        [HttpGet]
        [Route("api/loadLanguages/{UserId}")]
        public IHttpActionResult LoadLanguages(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetLanguages(UserId));
        }

        [HttpPost]
        [Route("api/createlanguage/{UserId}")]
        public IHttpActionResult CreateLanguage(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateLanguage(UserId, data));
        }


        [HttpGet]
        [Route("api/loadexperience/{UserId}")]
        public IHttpActionResult LoadExperience(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetExperiences(UserId));
        }

        [HttpPost]
        [Route("api/createexperience/{UserId}")]
        public IHttpActionResult CreateExperience(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateExperience(UserId, data));
        }

        [HttpGet]
        [Route("api/loadqualification/{UserId}")]
        public IHttpActionResult LoadQualification(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetQualification(UserId));
        }

        [HttpPost]
        [Route("api/createqualification/{UserId}")]
        public IHttpActionResult CreateQualification(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateQualification(UserId, data));
        }

        [HttpGet]
        [Route("api/loadcourses/{UserId}")]
        public IHttpActionResult LoadCourses(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetCourses(UserId));
        }

        [HttpPost]
        [Route("api/createcourse/{UserId}")]
        public IHttpActionResult CreateCourse(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateCourse(UserId, data));

        }

        [HttpGet]
        [Route("api/loadskills/{UserId}")]
        public IHttpActionResult LoadSkill(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetSkills(UserId));
        }

        [HttpPost]
        [Route("api/createskills/{UserId}")]
        public IHttpActionResult CreateSkill(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateSkill(UserId, data));
        }

        [HttpGet]
        [Route("api/loadprojects/{UserId}")]
        public IHttpActionResult LoadProjects(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetProjects(UserId));
        }

        [HttpPost]
        [Route("api/createprojects/{UserId}")]
        public IHttpActionResult CreateProjects(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateProjects(UserId, data));
        }

        [HttpGet]
        [Route("api/loadprojects/{UserId}")]
        public IHttpActionResult LoadPublicProfile(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetProjects(UserId));
        }

        [HttpPost]
        [Route("api/createprojects/{UserId}")]
        public IHttpActionResult CreatePublicProfile(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateProjects(UserId, data));
        }

        [HttpGet]
        [Route("api/loadawards/{UserId}")]
        public IHttpActionResult LoadAwards(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetAwards(UserId));
        }

        [HttpPost]
        [Route("api/createaward/{UserId}")]
        public IHttpActionResult CreateAward(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateAwards(UserId, data));
        }

        [HttpGet]
        [Route("api/loadcertifications/{UserId}")]
        public IHttpActionResult LoadCertifications(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetCertifications(UserId));
        }

        [HttpPost]
        [Route("api/createcertification/{UserId}")]
        public IHttpActionResult CreateCertification(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateCertifications(UserId, data));
        }

        [HttpGet]
        [Route("api/loadcopyrights/{UserId}")]
        public IHttpActionResult LoadCopyRights(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetCopyRight(UserId));
        }

        [HttpPost]
        [Route("api/createcopyRight/{UserId}")]
        public IHttpActionResult CreateCopyRight(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateCopyRights(UserId, data));
        }

        [HttpGet]
        [Route("api/loadpatents/{UserId}")]
        public IHttpActionResult LoadPatents(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetPatents(UserId));
        }

        [HttpPost]
        [Route("api/createpatent/{UserId}")]
        public IHttpActionResult CreatePatent(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdatePatents(UserId, data));
        }

        [HttpGet]
        [Route("api/loadhobbies/{UserId}")]
        public IHttpActionResult LoadHobbies(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetHobbies(UserId));
        }

        [HttpPost]
        [Route("api/createhobby/{UserId}")]
        public IHttpActionResult CreateHobby(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateHobbies(UserId, data));
        }

        [HttpGet]
        [Route("api/loadpublicprofile/{UserId}")]
        public IHttpActionResult LoadPublicProfileDetails(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetPublicProfileDetails(UserId));
        }

        [HttpPost]
        [Route("api/createpublicprofile/{UserId}")]
        public IHttpActionResult CreatePublicProfileDetails(string UserId, object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdatePublicProfileDetails(UserId, data));
        }

        [HttpGet]
        [Route("api/checkUniqueUrl/{publicurl}")]
        public IHttpActionResult CheckUniqueUrl(string publicurl)
        {
            return Ok(blhandler.blPersonalInformation.CheckUniqueUrl(publicurl));
        }

        [HttpGet]
        [Route("api/fetchuserbykey/{providerkey}")]
        public IHttpActionResult GetUserIdFromKey(string providerkey)
        {
            return Ok(blhandler.blPersonalInformation.GetUserIdFromKey(providerkey));
        }
    }
}
