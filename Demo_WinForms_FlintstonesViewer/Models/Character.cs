﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer
{
    public class Character
    {
        public enum GenderType { Male, Female }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string ImageFileName { get; set; }
        public string Description { get; set; }

        public string FullName()
        {
            return FirstName + (Occupation != null ? ": " + Occupation : "") ;
        }
    }
}
