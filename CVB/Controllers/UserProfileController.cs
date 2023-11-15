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
        [Route("api/personaldetails")]
        public IHttpActionResult UpdatePersonalDetails(object data)
        {
            return Ok(blhandler.blPersonalInformation.UpdatePersonalDetails("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }
    
        [HttpGet]
        [Route("api/loadLanguages/{UserId}")]
        public IHttpActionResult LoadLanguages(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetLanguages("4938f26b-4ed0-4a40-9c5e-d5934ff8c819"));
        }

        [HttpPost]
        [Route("api/createlanguage")]
        public IHttpActionResult CreateLanguage(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateLanguage("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }


        [HttpGet]
        [Route("api/loadexperience/{UserId}")]
        public IHttpActionResult LoadExperience(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetExperiences("4938f26b-4ed0-4a40-9c5e-d5934ff8c819"));
        }

        [HttpPost]
        [Route("api/createexperience")]
        public IHttpActionResult CreateExperience(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateExperience("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadqualification/{UserId}")]
        public IHttpActionResult LoadQualification(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetQualification("4938f26b-4ed0-4a40-9c5e-d5934ff8c819"));
        }

        [HttpPost]
        [Route("api/createqualification")]
        public IHttpActionResult CreateQualification(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateQualification("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadcourses/{UserId}")]
        public IHttpActionResult LoadCourses(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetCourses(UserId));
        }

        [HttpPost]
        [Route("api/createcourse")]
        public IHttpActionResult CreateCourse(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateCourse("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));

        }

        [HttpGet]
        [Route("api/loadskills/{UserId}")]
        public IHttpActionResult LoadSkill(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetSkills(UserId));
        }

        [HttpPost]
        [Route("api/createskills")]
        public IHttpActionResult CreateSkill(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateSkill("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadprojects/{UserId}")]
        public IHttpActionResult LoadProjects(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetProjects(UserId));
        }

        [HttpPost]
        [Route("api/createprojects")]
        public IHttpActionResult CreateProjects(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateProjects("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadprojects/{UserId}")]
        public IHttpActionResult LoadPublicProfile(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetProjects(UserId));
        }

        [HttpPost]
        [Route("api/createprojects")]
        public IHttpActionResult CreatePublicProfile(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateProjects("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadawards/{UserId}")]
        public IHttpActionResult LoadAwards(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetAwards(UserId));
        }

        [HttpPost]
        [Route("api/createaward")]
        public IHttpActionResult CreateAward(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateAwards("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadcertifications/{UserId}")]
        public IHttpActionResult LoadCertifications(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetCertifications(UserId));
        }

        [HttpPost]
        [Route("api/createcertification")]
        public IHttpActionResult CreateCertification(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateCertifications("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadcopyrights/{UserId}")]
        public IHttpActionResult LoadCopyRights(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetCopyRight(UserId));
        }

        [HttpPost]
        [Route("api/createcopyRight")]
        public IHttpActionResult CreateCopyRight(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateCopyRights("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadpatents/{UserId}")]
        public IHttpActionResult LoadPatents(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetPatents(UserId));
        }

        [HttpPost]
        [Route("api/createpatent")]
        public IHttpActionResult CreatePatent(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdatePatents("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadhobbies/{UserId}")]
        public IHttpActionResult LoadHobbies(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetHobbies(UserId));
        }

        [HttpPost]
        [Route("api/createhobby")]
        public IHttpActionResult CreateHobby(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdateHobbies("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/loadpublicprofile/{UserId}")]
        public IHttpActionResult LoadPublicProfileDetails(string UserId)
        {
            return Ok(blhandler.blPersonalInformation.GetPublicProfileDetails(UserId));
        }

        [HttpPost]
        [Route("api/createpublicprofile")]
        public IHttpActionResult CreatePublicProfileDetails(object data)
        {
            return Ok(blhandler.blPersonalInformation.CreateOrUpdatePublicProfileDetails("4938f26b-4ed0-4a40-9c5e-d5934ff8c819", data));
        }

        [HttpGet]
        [Route("api/checkUniqueUrl/{publicurl}")]
        public IHttpActionResult CheckUniqueUrl(string publicurl)
        {
            return Ok(blhandler.blPersonalInformation.CheckUniqueUrl(publicurl));
        }
    }
}
