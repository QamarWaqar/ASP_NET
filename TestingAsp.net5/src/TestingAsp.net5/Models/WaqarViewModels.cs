using System;
using System.ComponentModel.DataAnnotations;

namespace TestingAsp.net5.Models
{
    public class WaqarViewModels
    {
        public class IndexViewModel
        {
            [Display(Name="Text Box 1")]
            [Required()]
            public string textbox1 { get; set; }

            [Display(Name="Text Box 2")]
            [Required()]
            public string textbox2 { get; set; }

            [Display(Name ="Radio Button 1")]
            public bool radioButton1 { get; set; }
            [Display(Name ="Radio Button 2")]
            public bool radioButton2 { get; set; }
        }

        public class WaqarViewModel
        {

        }
    }
}