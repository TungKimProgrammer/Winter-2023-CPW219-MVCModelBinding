

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCModelBinding.Models
{
	public class Student
	{
		/// <summary>
		/// The legal first name
		/// </summary>
		[Required(ErrorMessage = "{0} is required.")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		/// <summary>
		/// The legal last name
		/// </summary>
		[Required(ErrorMessage = "{0} is required.")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		// [DisplayFormat(DataFormatString = "0:MM/DD/YYYY")] ??? Display text input box
		// [Range(typeof(DateOnly), "1900/01/01", "2023/01/15" , ErrorMessage = "{0} must be between {1:d} and {2:d}.")]
		// DateTime.Now.ToString("yyyy/MM/dd")
		// ??? How to make Range(typeof(DateOnly) dynamic with DateTime.Today/Now?
		// It seems impossible do make Range(typeof(DateOnly) dynamic, needs custom validation attribute, beyond current skill
		// or set min and max in Model
		[Required(ErrorMessage = "{0} is required.")]
		[Display(Name = "Date Of Birth")]
		[DataType(DataType.Date)] // display Date picker
		public DateOnly DateOfBirth { get; set; }

		/// <summary>
		/// The assigned school email address
		/// </summary>
		//[Required()]
		[Display(Name = "Student Email")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		public string? StudentEmail { get; set; }

		/// <summary>
		/// Student's preferred contact number
		/// </summary>
		//[Required()]
		[Display(Name = "Phone Number")]
		[DataType(DataType.PhoneNumber)]
		[Phone]
		public string? PhoneNumber { get; set; }




		/** Model validation in ASP.NET Core MVC and Razor Pages
		 * https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-7.0
		 */ 
	}
}
