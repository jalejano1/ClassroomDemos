using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class DDLCLASS
    {
        public int ValueField { get; set; }
        public string DisplayField { get; set; }
        public DDLCLASS()
        {

        }
        public DDLCLASS(int valuefield, string displayfield)
        {
            ValueField = valuefield;
            DisplayField = displayfield;
        }
    }
}