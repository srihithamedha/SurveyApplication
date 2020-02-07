using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Survey.Concerns
{
    public class SurveyData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [ForeignKey("SurveyForm")]
        public int SurveyFromId { get; set; }
        public List<SurveyAnswer> Answers { get; set; }
    }
}
