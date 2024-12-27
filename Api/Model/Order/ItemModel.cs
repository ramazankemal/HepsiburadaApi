using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Model.Order
{
    public class ItemModel
    {
        public string ID { get; set; }
        public string DueDate { get; set; }
        public string LastStatusUpdateDate { get; set; }
        public string Sku { get; set; }
        public string OrderID { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public int Quantity { get; set; }
        public string MerchantID { get; set; }
        public DiscountTotalPriceModel TotalPrice { get; set; }
        public DiscountUnitPriceModel UnitPrice { get; set; }
        public ItemHbDiscountModel HBDiscount { get; set; }
        public ItemMerchantDiscountModel MerchantDiscount { get; set; }
        public string Vat { get; set; }
        public string VatRate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerID { get; set; }
        public string Status { get; set; }
        public ItemShippingAddressModel ShippingAddress { get; set; }
        public ItemInvoiceModel Invoice { get; set; }
        public string SapNumber { get; set; }
        public int DispatchTime { get; set; }
        public ItemCommissionModel Commission { get; set; }
        public decimal CommissionRate { get; set; }
        public int PaymentTermInDays { get; set; }
        public int CommissionType { get; set; }
        public ItemCargoCompanyModel CargoCompanyModel { get; set; }
        public string CargoCompany { get; set; }
        public string CustomizedText01 { get; set; }
        public string CustomizedText02 { get; set; }
        public string CustomizedText03 { get; set; }
        public string CustomizedText04 { get; set; }
        public string CustomizedTextX { get; set; }
        public string CreditCardHolderName { get; set; }
        public bool IsCustomized { get; set; }
        public bool CanCreatePackage { get; set; }
        public bool IsCancellable { get; set; }
        public bool IsCancellableByHbAdmin { get; set; }
        public string DeliveryType { get; set; }
        public int DeliveryOptionID { get; set; }
        public string Slot { get; set; }
        public string PickUpTime { get; set; }
        public string MerchantSKU { get; set; }
        public ItemPurchasePriceModel PurchasePrice { get; set; }
        public bool IsCargoChangable { get; set; }
        public ItemWareHouseModel Warehouse { get; set; }
        public decimal DeptorDifferenceAmount { get; set; }
        public bool IsJetDelivery { get; set; }
        public int DiscountToBeBilledToHB { get; set; }
        public ItemBnplCommissionAmountModel BnpICommissionAmount { get; set; }
        public string ProductBarcode { get; set; }
        public string CreationReason { get; set; }
        public string PackageNumber { get; set; }
        public string Barcode { get; set; }
        public bool IsMicroExport { get; set; }
    }
}
