using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        //public int StudentId { get; set; }

        //[Display(Name = "Name")]
        //public string StudentName { get; set; }

        //public int Age { get; set; }
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Range(10,20)]
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
      //  public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel>> htmlHelper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes);

    }
    //public class Student
    //{
    //    public int StudentId { get; set; }
    //    public string StudentName { get; set; }
    //    public int Age { get; set; }
    //    public Standard standard { get; set; }
    //}

    //public class Standard
    //{
    //    public int StandardId { get; set; }
    //    public string StandardName { get; set; }
    //}
}