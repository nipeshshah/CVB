using DBHandler.Database;
using Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    public class DBResumeTemplates
    {
        dbresumebuilderEntities entities;
        Helper helper;
        public DBResumeTemplates()
        {
            entities = new dbresumebuilderEntities();
            helper = new Helper();
        }

        public object GetActiveTemplateSections(string templatename)
        {
            List<TemplateSection> sections = entities.TemplateSections.Where(t => t.Template.Title == templatename).ToList();
            return sections;
        }

        public object SubmitResume(string userId, string title, string publicurl, string template, string[] sections, string securitycode)
        {
            Resume resume = entities.Resumes.Add(new Resume()
            {
                MemberId = userId,
                CreatedOn = DateTime.UtcNow,
                DownloadCount = 0,
                IsDeleted = false,
                PublicUrl = publicurl,
                SecurityCode = securitycode,
                Template = entities.Templates.Where(t => t.Title == template).First(),
                Title = title,
                ViewCount = 0
            });

            foreach (string item in sections)
            {
                entities.ResumeSections.Add(new ResumeSection()
                {
                    TemplateSection = entities.TemplateSections.Where(t => t.Template.Title == template && t.SectionName == item).FirstOrDefault(),
                    ResumeId = resume.ResumeId
                });
            }

            entities.SaveChanges();
            return resume;
        }

        public List<Template> GetActiveTemplates()
        {
            List<Template> pi = entities.Templates.ToList();
            return pi;
        }
    }

    public class DBPersonalInformation
    {
        dbresumebuilderEntities entities;
        Helper helper;
        public DBPersonalInformation()
        {
            entities = new dbresumebuilderEntities();
            helper = new Helper();
        }

        public PersonalInformation GetPersonalInformationFromId(string userId)
        {
            PersonalInformation pi = entities.PersonalInformations.Where(t => t.MemberId == userId).FirstOrDefault();
            return pi;
        }

        public PersonalInformation UpdatePersonalDetails(string userId, object data)
        {
            JObject pairs = JObject.Parse(data.ToString());
            PersonalInformation pi = GetPersonalInformationFromId(userId);
            if (pi == null)
            {
                pi = new PersonalInformation();
                entities.PersonalInformations.Add(pi);
                pi.MemberId = userId;
            }
            pi.FirstName = helper.json.String(pairs, "firstname");
            pi.MiddleName = helper.json.String(pairs, "middlename");
            pi.LastName = helper.json.String(pairs, "lastname");
            pi.City = helper.json.String(pairs, "city");
            pi.Country = helper.json.String(pairs, "country");
            pi.Email = helper.json.String(pairs, "email");
            pi.Phone = helper.json.String(pairs, "phone");
            pi.Pincode = helper.json.String(pairs, "pincode");
            pi.PreferredName = helper.json.String(pairs, "prefname");
            pi.State = helper.json.String(pairs, "state");

            entities.SaveChanges();

            return pi;
        }

        public object CreateOrUpdateExperience(string userId, object data)
        {
            JObject pairs = JObject.Parse(data.ToString());

            Experience pi = new Experience();
            entities.Experiences.Add(pi);
            pi.MemberId = userId;
            pi.JobTItle = helper.json.String(pairs, "jobTitle");
            pi.Employer = helper.json.String(pairs, "employer");
            pi.CIty = helper.json.String(pairs, "city");
            pi.State = helper.json.String(pairs, "state");
            pi.Country = helper.json.String(pairs, "country");
            pi.StartDate = helper.json.Date(pairs, "startDate");
            pi.EndTime = helper.json.Date(pairs, "endDate");
            pi.IsCurrent = helper.json.Boolean(pairs, "isCurrent");
            pi.Description = helper.json.String(pairs, "description");

            entities.SaveChanges();

            return pi;
        }

        public object CreateOrUpdateSkills(string userId, object data)
        {
            JObject pairs = JObject.Parse(data.ToString());
            Skill pi = new Skill(); // entities.Courses.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            pi.MemberId = "4938f26b-4ed0-4a40-9c5e-d5934ff8c819";
            entities.Skills.Add(pi);

            pi.Skill1 = helper.json.String(pairs, "skill");
            pi.Proficiency = helper.general.GetProficiency(helper.json.String(pairs, "proficiency"));
            pi.Certifications = helper.json.String(pairs, "certifications");

            entities.SaveChanges();

            return pi;
        }

        public object CreateOrUpdateProjects(string userId, object data)
        {
            JObject pairs = JObject.Parse(data.ToString());
            Project pi = new Project(); // entities.Courses.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            pi.MemberId = userId;
            entities.Projects.Add(pi);

            pi.LongDescription = helper.json.String(pairs, "longdescription");
            pi.MemberId = userId;
            pi.Ownerr = helper.json.String(pairs, "owner");
            pi.ProjectTitle = helper.json.String(pairs, "title");
            pi.Role = helper.json.String(pairs, "role");
            pi.ShortDescription = helper.json.String(pairs, "shortdescription");
            pi.TeamSIze = helper.json.String(pairs, "teamsize");
            pi.Technologies = helper.json.String(pairs, "technologies");
            pi.Tools = helper.json.String(pairs, "tools");

            //pi.Skill1 = helper.json.String(pairs, "skill");
            //pi.Proficiency = helper.general.GetProficiency(helper.json.String(pairs, "proficiency"));
            //pi.Certifications = helper.json.String(pairs, "certifications");

            entities.SaveChanges();

            return pi;
        }

        public object LoadProjects(string userId)
        {
            List<Project> pi = entities.Projects.Where(t => t.MemberId == userId).ToList();
            return pi;
        }

        public object LoadSkills(string userId)
        {
            List<Skill> pi = entities.Skills.Where(t => t.MemberId == userId).ToList();
            return pi;
        }

        public object CreateOrUpdateCourse(string userId, object data)
        {
            Helper fw = new Helper();
            JObject pairs = JObject.Parse(data.ToString());

            Cours pi = new Cours(); // entities.Courses.Where(t => t.UserId == "4938f26b-4ed0-4a40-9c5e-d5934ff8c819").FirstOrDefault();
            //if (pi == null)
            //{
            //pi = new Cours();
            entities.Courses.Add(pi);
            pi.MemberId = userId;
            //}

            pi.CourseTitle = helper.json.String(pairs, "course");
            pi.Institute = helper.json.String(pairs, "institute");
            pi.PersuedIn = helper.json.String(pairs, "peruseIn");
            pi.Tenure = helper.json.String(pairs, "tenure");
            pi.Address = helper.json.String(pairs, "address");

            //    .NameOfSchoolCollege = pairs["schoolName");
            //pi.Qualification = pairs["qualification");
            //pi.Location = pairs["schoolLocation");
            //pi.EducationBoard = pairs["educationBoard");
            //pi.StartDate = pairs["startDate"] != null && pairs["startDate") != "" ? Convert.ToDateTime(pairs["startDate")) : SqlDateTime.MinValue.Value;
            //pi.EndTime = pairs["completedDate"] != null && pairs["completedDate") != "" ? Convert.ToDateTime(pairs["completedDate")) : SqlDateTime.MinValue.Value;

            entities.SaveChanges();

            return pi;
        }

        public object GetCourses(string userId)
        {
            List<Cours> pi = entities.Courses.Where(t => t.MemberId == userId).ToList();
            return pi;
        }

        public object CreateOrUpdateQualification(string userId, object data)
        {
            Helper fw = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            Education pi = new Education();
            entities.Educations.Add(pi);
            pi.MemberId = userId;

            pi.NameOfSchoolCollege = helper.json.String(pairs, "schoolName");
            pi.Qualification = helper.json.String(pairs, "qualification");
            pi.Location = helper.json.String(pairs, "schoolLocation");
            pi.EducationBoard = helper.json.String(pairs, "educationBoard");
            pi.StartDate = helper.json.Date(pairs, "startDate");
            pi.EndTime = helper.json.Date(pairs, "completedDate");

            entities.SaveChanges();

            return pi;

        }

        public object LoadQualification(string userId)
        {
            List<Education> pi = entities.Educations.Where(t => t.MemberId == userId).ToList();
            return pi;
        }

        public object LoadExperiences(string userId)
        {
            List<Experience> pi = entities.Experiences.Where(t => t.MemberId == userId).ToList();
            return pi;
        }

        public object CreateOrUpdateLanguage(string userId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            string language = helper.json.String(pairs, "language");
            Language pi = entities.Languages.Where(t => t.MemberId == userId && t.Language1 == language).FirstOrDefault();
            if (pi == null)
            {
                pi = new Language();
                entities.Languages.Add(pi);
                pi.MemberId = userId;
                pi.Language1 = helper.json.String(pairs, "language");
            }
            pi.ReadProficiency = helper.general.GetProficiency(helper.json.String(pairs, "readProficiency"));
            pi.WriteProficiency = helper.general.GetProficiency(helper.json.String(pairs, "writeProficiency"));
            pi.SpeakProficiency = helper.general.GetProficiency(helper.json.String(pairs, "speakProficiency"));

            entities.SaveChanges();

            return pi;
        }

        public List<Language> LoadLanguages(string userId)
        {
            List<Language> pi = entities.Languages.Where(t => t.MemberId == userId).ToList();
            return pi;
        }

        public object GetActiveTemplates()
        {
            throw new NotImplementedException();
        }
    }
}
