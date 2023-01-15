using Microsoft.Data.SqlClient;

namespace MVCModelBinding.Models
{
	internal static class StudentDB
	{
		/// <summary>
		/// Adds a Student to the database
		/// </summary>
		/// <param name="stu">The Student to be added</param>
		public static void Add(Student stu)
		{
			SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ToBeNamedLater;Integrated Security=True");

			// prepare insert statement
			SqlCommand insertCmd = new(){
											Connection = con,
											CommandText = "INSERT INTO Student(FirstName, LastName, DateOfBirth, StudentEmail, PhoneNumber) " +
																			 "VALUES (@fName, @lName, @dob, @email, @phone)"
										};
			
			insertCmd.Parameters.AddWithValue("@fName", stu.FirstName);
			insertCmd.Parameters.AddWithValue("@lName", stu.LastName);
			insertCmd.Parameters.AddWithValue("@dob", stu.DateOfBirth);
			insertCmd.Parameters.AddWithValue("@email", stu.StudentEmail);
			insertCmd.Parameters.AddWithValue("@phone", stu.PhoneNumber);

			// open connection to the database
			con.Open();

			// execute insert query
			insertCmd.ExecuteNonQuery();

			// close connection to the database
			con.Close();
		}
	}
}
