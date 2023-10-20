using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CVB.Controllers
{
    public class BaseAPIController : ApiController
    {
        
        private BLHandler _blhandler;

        public BLHandler blhandler
        {
            get
            {
                if (_blhandler == null)
                    _blhandler = new BLHandler();
                return _blhandler;
            }
            set
            {
                _blhandler = value;
            }
        }
    }
}