using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Survey.Concerns
{
    public class SurveyOption
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("SurveyQuestion")]
        public int QuestionId { get; set; }
        [Required]
        public string OptionValue { get; set; }
    }
}
