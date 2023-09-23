using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVB.Framework
{
    public class general
    {
        public int GetProficiency(string proficiency)
        {
            int prof = 0;
            switch(proficiency.ToLower())
            {
                case "none":
                    prof = -1;
                    break;
                case "beginner": 
                    prof = 0;
                    break;
                case "intermediate":
                    prof = 0;
                    break;
                case "advanced":
                    prof = 1;
                    break;
                case "expert":
                    prof = 2;
                    break;
            }
            return prof;
        }
    }
}