using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Survey.Concerns
{
    public class SurveyAnswer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("SurveyForm")]
        public int SurveyFormId { get; set; }
        [Required]
        [ForeignKey("SurveyQuestion")]
        public int SurveyQuestionId { get; set; }
        [Required]
        [ForeignKey("SurveyOption")]
        public int SurveyOptionId { get; set; }
        [Required]
        [ForeignKey("SurveyData")]
        public int SurveyDataId { get; set; }
    }
}
