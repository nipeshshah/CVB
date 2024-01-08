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
            return resume.ResumeId;
        }

        public object GetPublicResumes(int templateId, string userId)
        {
            throw new NotImplementedException();
        }

        public Template GetTemplateName(int templateId)
        {
            Template templatename = entities.Templates.Where(t => t.TemplateId == templateId).FirstOrDefault();
            return templatename;
        }

        public object GetResumes(string userId)
        {
            return entities.Resumes.Where(t => t.MemberId == userId).OrderByDescending(t => t.CreatedOn).Select(t => new {
                Title = t.Title,
                CreatedDate = t.CreatedOn,
                PublicUrl = t.PublicUrl,
                Code = t.SecurityCode,
                Downloads = t.DownloadCount,
                User = t.Member.Name,
                TemplateId =  t.TemplateId,
                TemplateTitle = t.Template.Title
            }).ToList();
        }

        public List<Template> GetActiveTemplates()
        {
            List<Template> pi = entities.Templates.Select(t => new TemplateDTO{ t. }).ToList();
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

        public object CheckUniqueUrl(string publicurl)
        {
            return entities.Members.Count(t => t.PublicUrl.ToLower() == publicurl.ToLower()) == 0;
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

        public object GetUserIdFromKey(string providerkey)
        {
            AspNetUserLogin userLogin = entities.AspNetUserLogins.Where(t => t.ProviderKey == providerkey).FirstOrDefault();
            if(userLogin != null)
            {
                return "{ \"UserId\":\"" + userLogin.UserId + "\" }";
            }
            return "";
        }

        public object CreateOrUpdateSkills(string userId, object data)
        {
            JObject pairs = JObject.Parse(data.ToString());
            Skill pi = new Skill();
            pi.MemberId = userId;
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
            Project pi = new Project();
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

            Cours pi = new Cours();
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

        public List<Certification> LoadCertifications(string userId)
        {
            List<Certification> certifications = entities.Certifications.Where(t => t.MemberId == userId).ToList();
            return certifications;
        }

        public Certification CreateOrUpdateCertifications(string userId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            Certification certification = entities.Certifications.Where(
                t => t.MemberId == userId && t.CertificateTitle == helper.json.String(pairs, "certificationTitle")).FirstOrDefault();
            if (certification == null)
            {
                certification = new Certification();
                entities.Certifications.Add(certification);
                certification.MemberId = userId;
                certification.CertificateTitle = helper.json.String(pairs, "certificationTitle");
            }
            certification.DateOfCertification = helper.json.Date(pairs, "dateOfCertification");
            certification.Organization = helper.json.String(pairs, "organization");
            certification.AreaOfExpertise = helper.json.String(pairs, "areaOfExpertise");

            entities.SaveChanges();

            return certification;
        }

        public List<Patent> LoadPatents(string UserId)
        {
            List<Patent> patents = entities.Patents.Where(t => t.MemberId == UserId).ToList();
            return patents;
        }

        public Patent CreateOrUpdatePatents(string UserId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            Patent patent = entities.Patents.Where(t => t.MemberId == UserId && t.PatentTitle == helper.json.String(pairs, "patentTitle")).FirstOrDefault();
            if (patent == null)
            {
                patent = new Patent();
                entities.Patents.Add(patent);
                patent.MemberId = UserId;
                patent.PatentTitle = helper.json.String(pairs, "patentTitle");
            }
            patent.PatentDescription = helper.json.String(pairs, "patentDescription");
            patent.PatentDate = helper.json.Date(pairs, "patentDate");
            
            entities.SaveChanges();

            return patent;
        }

        public List<PublicProfile> LoadPublicProfile(string UserId)
        {
            List<PublicProfile> publicProfile = entities.PublicProfiles.Where(t => t.MemberId == UserId).ToList();
            return publicProfile;
        }

        public PublicProfile CreateOrUpdatePublicProfile(string UserId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            PublicProfile publicProfile = entities.PublicProfiles.Where(t => t.MemberId == UserId && t.Title == helper.json.String(pairs, "title")).FirstOrDefault();
            if (publicProfile == null)
            {
                publicProfile = new PublicProfile();
                entities.PublicProfiles.Add(publicProfile);
                publicProfile.MemberId = UserId;
                publicProfile.Title = helper.json.String(pairs, "profileTitle");
            }
            publicProfile.Link = helper.json.String(pairs, "profileUrl");

            entities.SaveChanges();

            return publicProfile;
        }

        public List<Award> LoadAwards(string UserId)
        {
            List<Award> awards = entities.Awards.Where(t => t.MemberId == UserId).ToList();
            return awards;
        }

        public Award CreateOrUpdateAwards(string UserId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            Award award = entities.Awards.Where(t => t.MemberId == UserId && t.AwardTitle == helper.json.String(pairs, "awardTitle")).FirstOrDefault();
            if (award == null)
            {
                award = new Award();
                entities.Awards.Add(award);
                award.MemberId = UserId;
                award.AwardTitle = helper.json.String(pairs, "awardTitle");
            }
            award.AreaCompititionTitle = helper.json.String(pairs, "areaCompititionTitle");
            award.ReceivedOn = helper.json.Date(pairs, "receivedOn");
            award.Description = helper.json.String(pairs, "description");

            entities.SaveChanges();

            return award;
        }

        public List<Copyright> LoadCopyRight(string UserId)
        {
            List<Copyright> copyRights =
                entities.Copyrights.Where(t => t.MemberId == UserId).ToList();
            return copyRights;
        }

        public Copyright CreateOrUpdateCopyRights(string UserId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            Copyright copyright = entities.Copyrights.Where(t => t.MemberId == UserId
                           && t.CRTitle == helper.json.String(pairs, "copyRightTitle")).FirstOrDefault();
            if (copyright == null)
            {
                copyright = new Copyright();
                entities.Copyrights.Add(copyright);
                copyright.CRTitle = helper.json.String(pairs, "copyRightTitle");
            }

            copyright.CRDate = helper.json.Date(pairs, "copyRightDate");
            copyright.CRDescription = helper.json.String(pairs, "copyRightDescription");

            entities.SaveChanges();

            return copyright;

            //string copyRightTitle = helper.json.String(pairs, "copyRightTitle");
            //string copyRightUrl = helper.json.String(pairs, "copyRightUrl");
            //string copyRightDate = helper.json.String(pairs, "copyRightDate");
            //string copyRightId = helper.json.String(pairs, "copyRightId");
            //string copyRightDescription = helper.json.String(pairs, "copyRightDescription");
            //string copyRightHolder = helper.json.String(pairs, "copyRightHolder");
            //string copyRightType = helper.json.String(pairs, "copyRightType");
            //string copyRightStatus = helper.json.String(pairs, "copyRightStatus");
            //string copyRightRegistrationDate = helper.json.String(pairs, "copyRightRegistrationDate");
            //string copyRightRegistrationNumber = helper.json.String(pairs, "copyRightRegistrationNumber");
            //string copyRightPublicationDate = helper.json.String(pairs, "copyRightPublicationDate");
            //string copyRightPublicationNumber = helper.json.String(pairs, "copyRightPublicationNumber");
            //string copyRightApplicationNumber = helper.json.String(pairs, "copyRightApplicationNumber");
            //string copyRightApplicationDate = helper.json.String(pairs, "copyRightApplicationDate");
            //string copyRightClass = helper.json.String(pairs, "copyRightClass");
            //string copyRightSubClass = helper.json.String(pairs, "copyRightSubClass");
            //string copyRightWorkType = helper.json.String(pairs, "copyRightWorkType");
            //string copyRightWorkNature = helper.json.String(pairs, "copyRightWorkNature");
            //string copyRightWorkDescription = helper.json.String(pairs, "copyRightWorkDescription");
            //string copyRightWorkLanguage = helper.json.String(pairs, "copyRightWorkLanguage");
            //string copyRightWorkPublication = helper.json.String(pairs, "copyRightWorkPublication");

            //string copyRightWorkPublicationCountry = helper.json.String(pairs, "copyRightWorkPublicationCountry");




        }

        public List<Hobby> LoadHobbies(string UserId)
        {
            List<Hobby> hobbies = entities.Hobbies.Where(t => t.MemberId == UserId).ToList();
            return hobbies;
        }

        public Hobby CreateOrUpdateHobbies(string UserId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            Hobby hobby = entities.Hobbies.Where(t => t.MemberId == UserId
                                      && t.Hobby1 == helper.json.String(pairs, "hobbyTitle")).FirstOrDefault();

            if (hobby == null)
            {
                hobby = new Hobby();
                entities.Hobbies.Add(hobby);
                hobby.MemberId = UserId;
                hobby.Hobby1 = helper.json.String(pairs, "hobbyTitle");
            }

            entities.SaveChanges();

            return hobby;
        }

        public List<PublicProfile> GetPublicProfileDetails(string UserId)
        {
            List<PublicProfile> publicProfile = entities.PublicProfiles.Where(t => t.MemberId == UserId).ToList();
            return publicProfile;
        }

        public PublicProfile CreateOrUpdatePublicProfileDetails(string UserId, object data)
        {
            Helper helper = new Helper();
            JObject pairs = JObject.Parse(data.ToString());
            PublicProfile publicProfile = entities.PublicProfiles.Where(t => t.MemberId == UserId
                                                 && t.Title == helper.json.String(pairs, "profileTitle")).FirstOrDefault();

            if (publicProfile == null)
            {
                publicProfile = new PublicProfile();
                entities.PublicProfiles.Add(publicProfile);
                publicProfile.MemberId = UserId;
                publicProfile.Title = helper.json.String(pairs, "profileTitle");
            }
            publicProfile.Link = helper.json.String(pairs, "link");

            entities.SaveChanges();

            return publicProfile;
        }



        //public object GetActiveTemplates()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
