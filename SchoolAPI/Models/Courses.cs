namespace SchoolAPI.Models
{
	public class Courses
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int PersonID { get; set; }
		public int ClassRoomID { get; set; }
		public int MaxStudentCount { get; set; }
		//Venteliste
		public int SubstituteID { get; set; }
	}
}
