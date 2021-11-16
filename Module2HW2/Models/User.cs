namespace Module2HW2.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool SendSms { get; set; }

        public bool SendEMail { get; set; }

        public Currency Currency { get; set; }
    }
}
