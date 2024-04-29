namespace FluentValidationApp.Web.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public string CreditCardNumber { get; set; }
        public DateTime CreditCardValidDate { get; set; }
    }
}
