namespace DB_Layer_API.Models
{
    public class Student
    {
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        //Enum?
        public DateTime CreationDate { get; set; }
        public string Note { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public int GuardianID { get; set; }
        public bool PhotoPermission { get; set; }
        public string School { get; set; }
        public string ClassLevel { get; set; }
        public bool Payment { get; set; }
    }
}
