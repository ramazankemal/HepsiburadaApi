namespace Api.Model.Order
{
    public class ItemShippingAddressModel
    {
        public string AddressID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternatePhoneNumber { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Directions { get; set; }
        public string PostalCode { get; set; }

    }
}
