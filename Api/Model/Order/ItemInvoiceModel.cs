namespace Api.Model.Order
{
    public class ItemInvoiceModel
    {
        public string TurkishIdentityNumber { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public InvoiceAddressModel Address { get; set; }
    }
}
