using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Survey.Concerns
{
    public class SurveyQuestion
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Question{ get; set; }
        [Required]
        public OptionType Type { get; set; }
        [Required]
        [ForeignKey("SurveyForm")]
        public int SurveyFormId { get; set; }

        public List<SurveyOption> Options { get; set; }
    }
    public enum OptionType
    {
        Multiple=1,
        OnlyOne
    }
}
