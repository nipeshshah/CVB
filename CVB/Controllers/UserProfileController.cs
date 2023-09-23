using CVB.Database;
using CVB.Framework;
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

namespace CVB.Controllers
{
    [RoutePrefix("profile")]
    public class UserProfileController : ApiController
    {
        [HttpGet]
        [Route("api/personaldetails/{UserId}")]
        public IHttpActionResult GetPersonalDetails(string UserId)
        {
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            PersonalInformation pi = entities.PersonalInformations.Where(t => t.MemberId == UserId).FirstOrDefault();
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return Ok(JsonConvert.SerializeObject(pi, Formatting.None, settings));
        }

        [HttpPost]
        [Route("api/personaldetails")]
        public IHttpActionResult UpdatePersonalDetails(object data)
        {
            JObject pairs = JObject.Parse(data.ToString());
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();

            PersonalInformation pi = entities.PersonalInformations.Where(t => t.MemberId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            if (pi == null)
            {
                pi = new PersonalInformation();
                entities.PersonalInformations.Add(pi);
                pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
            }
            pi.FirstName = pairs["firstname"]?.ToString();
            pi.MiddleName = pairs["middlename"]?.ToString();
            pi.LastName = pairs["lastname"]?.ToString();
            pi.City = pairs["city"]?.ToString();
            pi.Country = pairs["country"]?.ToString();
            pi.Email = pairs["email"]?.ToString();
            pi.Phone = pairs["phone"]?.ToString();
            pi.Pincode = pairs["pincode"]?.ToString();
            pi.PreferredName = pairs["prefname"]?.ToString();
            pi.State = pairs["state"]?.ToString();
            
            entities.SaveChanges();

            return Ok(pi);
        }
    
        [HttpGet]
        [Route("api/loadLanguages/{UserId}")]
        public IHttpActionResult LoadLanguages(string UserId)
        {
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            List<Language> pi = entities.Languages.Where(t => t.MemberId == UserId).ToList();
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return Ok(JsonConvert.SerializeObject(pi, Formatting.None, settings));
        }

        [HttpPost]
        [Route("api/createlanguage")]
        public IHttpActionResult CreateLanguage(object data)
        {
            fw fw = new fw();
            JObject pairs = JObject.Parse(data.ToString());
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            string language = pairs["language"].ToString();
            Language pi = entities.Languages.Where(t => t.MemberId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819" && t.Language1 == language).FirstOrDefault();
            if (pi == null)
            {
                pi = new Language();
                entities.Languages.Add(pi);
                pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
                pi.Language1 = pairs["language"].ToString();
            }
            pi.ReadProficiency = fw.general.GetProficiency(pairs["readProficiency"]?.ToString());
            pi.WriteProficiency = fw.general.GetProficiency(pairs["writeProficiency"]?.ToString());
            pi.SpeakProficiency = fw.general.GetProficiency(pairs["speakProficiency"]?.ToString());
            
            entities.SaveChanges();

            return Ok(pi);
        }


        [HttpGet]
        [Route("api/loadexperience/{UserId}")]
        public IHttpActionResult LoadExperience(string UserId)
        {
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            List<Experience> pi = entities.Experiences.Where(t => t.MemberId == UserId).ToList();
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return Ok(JsonConvert.SerializeObject(pi, Formatting.None, settings));
        }

        [HttpPost]
        [Route("api/createexperience")]
        public IHttpActionResult CreateExperience(object data)
        {
            fw fw = new fw();
            JObject pairs = JObject.Parse(data.ToString());
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            Experience pi = new Experience();// entities.Experiences.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            //if (pi == null)
            //{
                pi = new Experience();
                entities.Experiences.Add(pi);
                pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
            //}
            pi.JobTItle = pairs["jobTitle"]?.ToString();
            pi.Employer = pairs["employer"]?.ToString();
            pi.CIty = pairs["city"]?.ToString();
            pi.State = pairs["state"]?.ToString();
            pi.Country = pairs["country"]?.ToString();
            pi.StartDate = pairs["startDate"] != null && pairs["startDate"]?.ToString() != "" ? Convert.ToDateTime(pairs["startDate"]?.ToString()) : SqlDateTime.MinValue.Value;
            pi.EndTime = pairs["endDate"] != null && pairs["endDate"]?.ToString() != "" ? Convert.ToDateTime(pairs["endDate"]?.ToString()) : SqlDateTime.MinValue.Value;
            pi.IsCurrent = pairs["isCurrent"]?.ToString() == "on" ? 1 : 0;
            pi.Description = pairs["description"]?.ToString();

            entities.SaveChanges();

            return Ok(pi);
        }

        [HttpGet]
        [Route("api/loadqualification/{UserId}")]
        public IHttpActionResult LoadQualification(string UserId)
        {
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            List<Education> pi = entities.Educations.Where(t => t.MemberId == UserId).ToList();
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return Ok(JsonConvert.SerializeObject(pi, Formatting.None, settings));
        }

        [HttpPost]
        [Route("api/createqualification")]
        public IHttpActionResult CreateQualification(object data)
        {
            fw fw = new fw();
            JObject pairs = JObject.Parse(data.ToString());
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            Education pi = new Education();// entities.Educations.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            //if (pi == null)
            //{
            pi = new Education();
            entities.Educations.Add(pi);
            pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
            //}

            pi.NameOfSchoolCollege = pairs["schoolName"]?.ToString();
            pi.Qualification = pairs["qualification"]?.ToString();
            pi.Location = pairs["schoolLocation"]?.ToString();
            pi.EducationBoard = pairs["educationBoard"]?.ToString();
            pi.StartDate = pairs["startDate"] != null && pairs["startDate"]?.ToString() != "" ? Convert.ToDateTime(pairs["startDate"]?.ToString()) : SqlDateTime.MinValue.Value;
            pi.EndTime = pairs["completedDate"] != null && pairs["completedDate"]?.ToString() != "" ? Convert.ToDateTime(pairs["completedDate"]?.ToString()) : SqlDateTime.MinValue.Value;

            entities.SaveChanges();

            return Ok(pi);
        }

        [HttpGet]
        [Route("api/loadcourses/{UserId}")]
        public IHttpActionResult LoadCourses(string UserId)
        {
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            List<Cours> pi = entities.Courses.Where(t => t.MemberId == UserId).ToList();
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return Ok(JsonConvert.SerializeObject(pi, Formatting.None, settings));
        }

        [HttpPost]
        [Route("api/createcourse")]
        public IHttpActionResult CreateCourse(object data)
        {
            fw fw = new fw();
            JObject pairs = JObject.Parse(data.ToString());
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            Cours pi = new Cours(); // entities.Courses.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            //if (pi == null)
            //{
            //pi = new Cours();
            entities.Courses.Add(pi);
            pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
            //}

            pi.CourseTitle = pairs["course"]?.ToString();
            pi.Institute = pairs["institute"]?.ToString();
            pi.PersuedIn = pairs["peruseIn"]?.ToString();
            pi.Tenure = pairs["tenure"]?.ToString();
            pi.Address = pairs["address"]?.ToString();

            //    .NameOfSchoolCollege = pairs["schoolName"]?.ToString();
            //pi.Qualification = pairs["qualification"]?.ToString();
            //pi.Location = pairs["schoolLocation"]?.ToString();
            //pi.EducationBoard = pairs["educationBoard"]?.ToString();
            //pi.StartDate = pairs["startDate"] != null && pairs["startDate"]?.ToString() != "" ? Convert.ToDateTime(pairs["startDate"]?.ToString()) : SqlDateTime.MinValue.Value;
            //pi.EndTime = pairs["completedDate"] != null && pairs["completedDate"]?.ToString() != "" ? Convert.ToDateTime(pairs["completedDate"]?.ToString()) : SqlDateTime.MinValue.Value;

            entities.SaveChanges();

            return Ok(pi);
        }

        [HttpGet]
        [Route("api/loadskills/{UserId}")]
        public IHttpActionResult LoadSkill(string UserId)
        {
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            List<Skill> pi = entities.Skills.Where(t => t.MemberId == UserId).ToList();
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return Ok(JsonConvert.SerializeObject(pi, Formatting.None, settings));
        }

        [HttpPost]
        [Route("api/createskills")]
        public IHttpActionResult CreateSkill(object data)
        {
            fw fw = new fw();
            JObject pairs = JObject.Parse(data.ToString());
            CVB.Database.dbresumebuilderEntities entities = new Database.dbresumebuilderEntities();
            Skill pi = new Skill(); // entities.Courses.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            //if (pi == null)
            //{
            //pi = new Cours();
            entities.Skills.Add(pi);
            pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
            //}

            pi.Skill1 = pairs["skill"]?.ToString();
            pi.Proficiency = fw.general.GetProficiency(pairs["proficiency"]?.ToString());
            pi.Certifications = pairs["certifications"]?.ToString();
            
            entities.SaveChanges();

            return Ok(pi);
        }

    }
}
