using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Survey.Concerns
{
    public class SurveyForm
    {
        [Required]
        public int SurveyFormId { get; set; }
        [Required] 
        public string Title { get; set; }
        public List<SurveyQuestion> Questions { get; set; }
    }
}
