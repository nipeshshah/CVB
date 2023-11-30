using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
using BusinessLogic;

namespace CVB.Controllers
{
    [RoutePrefix("template")]
    public class templateapiController : BaseAPIController
    {
        [HttpGet]
        [Route("api/active/{UserId}")]
        public IHttpActionResult GetPersonalDetails(string UserId)
        {
            return Ok(blhandler.blResumeTemplates.GetActiveTemplates(UserId));
        }

        [HttpGet]
        [Route("api/activesections/{UserId}/{templatename}")]
        public IHttpActionResult GetPersonalDetails(string UserId, string templatename)
        {
            return Ok(blhandler.blResumeTemplates.GetActiveTemplateSections(templatename));
        }

        [HttpPost]
        [Route("api/submitresume/{UserId}")]
        public IHttpActionResult SubmitResume(string UserId, SubmitPayload submitPayload)
        {
            return Ok(content: blhandler.blResumeTemplates.SubmitResume(UserId, submitPayload));
        }

        [HttpGet]
        [Route("api/resumes/{UserId}")]
        public IHttpActionResult GetResumes(string UserId)
        {
            return Ok(content: blhandler.blResumeTemplates.GetResumes(UserId));
        }

        [HttpGet]
        [Route("api/publicresume/{templateid}/cv/{UserId}")]
        public IHttpActionResult GetPublicResumes(int templateId, string userId)
        {
            return Ok(content: blhandler.blResumeTemplates.GetPublicResumes(templateId, userId));
        }
    }
}
