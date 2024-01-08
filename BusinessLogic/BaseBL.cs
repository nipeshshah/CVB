using Newtonsoft.Json;

namespace BusinessLogic
{
    public class BaseBL
    {
        public DBHandler.DBPersonalInformation personalInformation = null;
        public DBHandler.DBResumeTemplates resumeTemplate = null;
        public BaseBL()
        {
            personalInformation = new DBHandler.DBPersonalInformation();
            resumeTemplate = new DBHandler.DBResumeTemplates();
        }

        public string Serializer<T>(T result)
        {
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, MaxDepth = 1 };
            return JsonConvert.SerializeObject(result, Formatting.None, settings);
        }
    }
}
