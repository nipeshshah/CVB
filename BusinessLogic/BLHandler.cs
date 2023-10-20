using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLHandler
    {
        private BLPersonalInformation _PersonalInformation;

        public BLPersonalInformation blPersonalInformation
        {
            get
            {
                if (_PersonalInformation == null)
                    _PersonalInformation = new BLPersonalInformation();
                return _PersonalInformation;
            }
            set
            {
                _PersonalInformation = value;
            }
        }

        private BLResumeTemplates _blResumeTemplates;

        public BLResumeTemplates blResumeTemplates
        {
            get
            {
                if (_blResumeTemplates == null)
                    _blResumeTemplates = new BLResumeTemplates();
                return _blResumeTemplates;
            }
            set
            {
                _blResumeTemplates = value;
            }
        }
    }
}
