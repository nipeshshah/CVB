using System;

namespace BusinessLogic
{
    public class BLResumeTemplates : BaseBL
    {
        public object GetActiveTemplates(string userId)
        {
            return Serialize(resumeTemplate.GetActiveTemplates());
        }

        public object GetActiveTemplateSections(string templatename)
        {
            return Serialize(resumeTemplate.GetActiveTemplateSections(templatename));
        }

        public object SubmitResume(string userId, SubmitPayload submitPayload)
        {
            return Serialize(resumeTemplate.SubmitResume(userId, submitPayload.title, submitPayload.publicurl, submitPayload.template, submitPayload.sections, submitPayload.securitycode));
        }
    }


    public class SubmitPayload
    {
        public string title { get; set; }
        public string publicurl { get; set; }
        public string template { get; set; }
        public string[] sections { get; set; }
        public string securitycode { get; set; }
    }

}
