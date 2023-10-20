using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers
{
    public class Helper
    {
        public json _json;
        public json json
        {
            get
            {
                if (_json == null)
                    _json = new json();
                return _json;
            }
            set
            {
                _json = value;
            }
        }

        private general _general;
        public general general
        {
            get
            {
                if (_general == null)
                    _general = new general();
                return _general;
            }
            set
            {
                _general = value;
            }
        }

        private security _security;
        public security security
        {
            get
            {
                if (_security == null)
                    _security = new security();
                return _security;
            }
            set
            {
                _security = value;
            }
        }
    }
}