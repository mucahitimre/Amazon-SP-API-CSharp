/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// A single order item.
    /// </summary>
    [DataContract]
    public partial class OrderItem : IEquatable<OrderItem>, IValidatableObject
    {
        /// <summary>
        /// The category of deemed reseller. This applies to selling partners that are not based in the EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK.
        /// </summary>
        /// <value>The category of deemed reseller. This applies to selling partners that are not based in the EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeemedResellerCategoryEnum
        {

            /// <summary>
            /// Enum IOSS for value: IOSS
            /// </summary>
            [EnumMember(Value = "IOSS")]
            IOSS = 1,

            /// <summary>
            /// Enum UOSS for value: UOSS
            /// </summary>
            [EnumMember(Value = "UOSS")]
            UOSS = 2
        }

        /// <summary>
        /// The category of deemed reseller. This applies to selling partners that are not based in the EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK.
        /// </summary>
        /// <value>The category of deemed reseller. This applies to selling partners that are not based in the EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK.</value>
        [DataMember(Name = "DeemedResellerCategory", EmitDefaultValue = false)]
        public DeemedResellerCategoryEnum? DeemedResellerCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        /// <param name="ASIN">The Amazon Standard Identification Number (ASIN) of the item. (required).</param>
        /// <param name="SellerSKU">The seller stock keeping unit (SKU) of the item..</param>
        /// <param name="OrderItemId">An Amazon-defined order item identifier. (required).</param>
        /// <param name="Title">The name of the item..</param>
        /// <param name="QuantityOrdered">The number of items in the order.  (required).</param>
        /// <param name="QuantityShipped">The number of items shipped..</param>
        /// <param name="ProductInfo">Product information for the item..</param>
        /// <param name="PointsGranted">The number and value of Amazon Points granted with the purchase of an item..</param>
        /// <param name="ItemPrice">The selling price of the order item. Note that an order item is an item and a quantity. This means that the value of ItemPrice is equal to the selling price of the item multiplied by the quantity ordered. Note that ItemPrice excludes ShippingPrice and GiftWrapPrice..</param>
        /// <param name="ShippingPrice">The shipping price of the item..</param>
        /// <param name="ItemTax">The tax on the item price..</param>
        /// <param name="ShippingTax">The tax on the shipping price..</param>
        /// <param name="ShippingDiscount">The discount on the shipping price..</param>
        /// <param name="ShippingDiscountTax">The tax on the discount on the shipping price..</param>
        /// <param name="PromotionDiscount">The total of all promotional discounts in the offer..</param>
        /// <param name="PromotionDiscountTax">The tax on the total of all promotional discounts in the offer..</param>
        /// <param name="PromotionIds">PromotionIds.</param>
        /// <param name="CODFee">The fee charged for COD service..</param>
        /// <param name="CODFeeDiscount">The discount on the COD fee..</param>
        /// <param name="IsGift">When true, the item is a gift..</param>
        /// <param name="ConditionNote">The condition of the item as described by the seller..</param>
        /// <param name="ConditionId">The condition of the item.  Possible values: New, Used, Collectible, Refurbished, Preorder, Club..</param>
        /// <param name="ConditionSubtypeId">The subcondition of the item.  Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, Any, Other..</param>
        /// <param name="ScheduledDeliveryStartDate">The start date of the scheduled delivery window in the time zone of the order destination. In ISO 8601 date time format..</param>
        /// <param name="ScheduledDeliveryEndDate">The end date of the scheduled delivery window in the time zone of the order destination. In ISO 8601 date time format..</param>
        /// <param name="PriceDesignation">Indicates that the selling price is a special price that is available only for Amazon Business orders. For more information about the Amazon Business Seller Program, see the [Amazon Business website](https://www.amazon.com/b2b/info/amazon-business).   Possible values: BusinessPrice - A special price that is available only for Amazon Business orders..</param>
        /// <param name="TaxCollection">Information about withheld taxes..</param>
        /// <param name="SerialNumberRequired">When true, the product type for this item has a serial number.  Returned only for Amazon Easy Ship orders..</param>
        /// <param name="IsTransparency">When true, transparency codes are required..</param>
        /// <param name="IossNumber">The IOSS number of the seller. Sellers selling in the EU will be assigned a unique IOSS number that must be listed on all packages sent to the EU..</param>
        /// <param name="DeemedResellerCategory">The category of deemed reseller. This applies to selling partners that are not based in the EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK..</param>
        public OrderItem(string ASIN = default(string), string SellerSKU = default(string), string OrderItemId = default(string), string Title = default(string), int? QuantityOrdered = default(int?), int? QuantityShipped = default(int?), ProductInfoDetail ProductInfo = default(ProductInfoDetail), PointsGrantedDetail PointsGranted = default(PointsGrantedDetail), Money ItemPrice = default(Money), Money ShippingPrice = default(Money), Money ItemTax = default(Money), Money ShippingTax = default(Money), Money ShippingDiscount = default(Money), Money ShippingDiscountTax = default(Money), Money PromotionDiscount = default(Money), Money PromotionDiscountTax = default(Money), PromotionIdList PromotionIds = default(PromotionIdList), Money CODFee = default(Money), Money CODFeeDiscount = default(Money), bool? IsGift = default(bool?), string ConditionNote = default(string), string ConditionId = default(string), string ConditionSubtypeId = default(string), string ScheduledDeliveryStartDate = default(string), string ScheduledDeliveryEndDate = default(string), string PriceDesignation = default(string), TaxCollection TaxCollection = default(TaxCollection), bool? SerialNumberRequired = default(bool?), bool? IsTransparency = default(bool?), string IossNumber = default(string), DeemedResellerCategoryEnum? DeemedResellerCategory = default(DeemedResellerCategoryEnum?))
        {
            // to ensure "ASIN" is required (not null)
            if (ASIN == null)
            {
                throw new InvalidDataException("ASIN is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.ASIN = ASIN;
            }
            // to ensure "OrderItemId" is required (not null)
            if (OrderItemId == null)
            {
                throw new InvalidDataException("OrderItemId is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.OrderItemId = OrderItemId;
            }
            // to ensure "QuantityOrdered" is required (not null)
            if (QuantityOrdered == null)
            {
                throw new InvalidDataException("QuantityOrdered is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.QuantityOrdered = QuantityOrdered;
            }
            this.SellerSKU = SellerSKU;
            this.Title = Title;
            this.QuantityShipped = QuantityShipped;
            this.ProductInfo = ProductInfo;
            this.PointsGranted = PointsGranted;
            this.ItemPrice = ItemPrice;
            this.ShippingPrice = ShippingPrice;
            this.ItemTax = ItemTax;
            this.ShippingTax = ShippingTax;
            this.ShippingDiscount = ShippingDiscount;
            this.ShippingDiscountTax = ShippingDiscountTax;
            this.PromotionDiscount = PromotionDiscount;
            this.PromotionDiscountTax = PromotionDiscountTax;
            this.PromotionIds = PromotionIds;
            this.CODFee = CODFee;
            this.CODFeeDiscount = CODFeeDiscount;
            this.IsGift = IsGift;
            this.ConditionNote = ConditionNote;
            this.ConditionId = ConditionId;
            this.ConditionSubtypeId = ConditionSubtypeId;
            this.ScheduledDeliveryStartDate = ScheduledDeliveryStartDate;
            this.ScheduledDeliveryEndDate = ScheduledDeliveryEndDate;
            this.PriceDesignation = PriceDesignation;
            this.TaxCollection = TaxCollection;
            this.SerialNumberRequired = SerialNumberRequired;
            this.IsTransparency = IsTransparency;
            this.IossNumber = IossNumber;
            this.DeemedResellerCategory = DeemedResellerCategory;
        }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }

        /// <summary>
        /// The seller stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// An Amazon-defined order item identifier.
        /// </summary>
        /// <value>An Amazon-defined order item identifier.</value>
        [DataMember(Name = "OrderItemId", EmitDefaultValue = false)]
        public string OrderItemId { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        [DataMember(Name = "Title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The number of items in the order. 
        /// </summary>
        /// <value>The number of items in the order. </value>
        [DataMember(Name = "QuantityOrdered", EmitDefaultValue = false)]
        public int? QuantityOrdered { get; set; }

        /// <summary>
        /// The number of items shipped.
        /// </summary>
        /// <value>The number of items shipped.</value>
        [DataMember(Name = "QuantityShipped", EmitDefaultValue = false)]
        public int? QuantityShipped { get; set; }

        /// <summary>
        /// Product information for the item.
        /// </summary>
        /// <value>Product information for the item.</value>
        [DataMember(Name = "ProductInfo", EmitDefaultValue = false)]
        public ProductInfoDetail ProductInfo { get; set; }

        /// <summary>
        /// The number and value of Amazon Points granted with the purchase of an item.
        /// </summary>
        /// <value>The number and value of Amazon Points granted with the purchase of an item.</value>
        [DataMember(Name = "PointsGranted", EmitDefaultValue = false)]
        public PointsGrantedDetail PointsGranted { get; set; }

        /// <summary>
        /// The selling price of the order item. Note that an order item is an item and a quantity. This means that the value of ItemPrice is equal to the selling price of the item multiplied by the quantity ordered. Note that ItemPrice excludes ShippingPrice and GiftWrapPrice.
        /// </summary>
        /// <value>The selling price of the order item. Note that an order item is an item and a quantity. This means that the value of ItemPrice is equal to the selling price of the item multiplied by the quantity ordered. Note that ItemPrice excludes ShippingPrice and GiftWrapPrice.</value>
        [DataMember(Name = "ItemPrice", EmitDefaultValue = false)]
        public Money ItemPrice { get; set; }

        /// <summary>
        /// The shipping price of the item.
        /// </summary>
        /// <value>The shipping price of the item.</value>
        [DataMember(Name = "ShippingPrice", EmitDefaultValue = false)]
        public Money ShippingPrice { get; set; }

        /// <summary>
        /// The tax on the item price.
        /// </summary>
        /// <value>The tax on the item price.</value>
        [DataMember(Name = "ItemTax", EmitDefaultValue = false)]
        public Money ItemTax { get; set; }

        /// <summary>
        /// The tax on the shipping price.
        /// </summary>
        /// <value>The tax on the shipping price.</value>
        [DataMember(Name = "ShippingTax", EmitDefaultValue = false)]
        public Money ShippingTax { get; set; }

        /// <summary>
        /// The discount on the shipping price.
        /// </summary>
        /// <value>The discount on the shipping price.</value>
        [DataMember(Name = "ShippingDiscount", EmitDefaultValue = false)]
        public Money ShippingDiscount { get; set; }

        /// <summary>
        /// The tax on the discount on the shipping price.
        /// </summary>
        /// <value>The tax on the discount on the shipping price.</value>
        [DataMember(Name = "ShippingDiscountTax", EmitDefaultValue = false)]
        public Money ShippingDiscountTax { get; set; }

        /// <summary>
        /// The total of all promotional discounts in the offer.
        /// </summary>
        /// <value>The total of all promotional discounts in the offer.</value>
        [DataMember(Name = "PromotionDiscount", EmitDefaultValue = false)]
        public Money PromotionDiscount { get; set; }

        /// <summary>
        /// The tax on the total of all promotional discounts in the offer.
        /// </summary>
        /// <value>The tax on the total of all promotional discounts in the offer.</value>
        [DataMember(Name = "PromotionDiscountTax", EmitDefaultValue = false)]
        public Money PromotionDiscountTax { get; set; }

        /// <summary>
        /// Gets or Sets PromotionIds
        /// </summary>
        [DataMember(Name = "PromotionIds", EmitDefaultValue = false)]
        public PromotionIdList PromotionIds { get; set; }

        /// <summary>
        /// The fee charged for COD service.
        /// </summary>
        /// <value>The fee charged for COD service.</value>
        [DataMember(Name = "CODFee", EmitDefaultValue = false)]
        public Money CODFee { get; set; }

        /// <summary>
        /// The discount on the COD fee.
        /// </summary>
        /// <value>The discount on the COD fee.</value>
        [DataMember(Name = "CODFeeDiscount", EmitDefaultValue = false)]
        public Money CODFeeDiscount { get; set; }

        /// <summary>
        /// When true, the item is a gift.
        /// </summary>
        /// <value>When true, the item is a gift.</value>
        [DataMember(Name = "IsGift", EmitDefaultValue = false)]
        public bool? IsGift { get; set; }

        /// <summary>
        /// The condition of the item as described by the seller.
        /// </summary>
        /// <value>The condition of the item as described by the seller.</value>
        [DataMember(Name = "ConditionNote", EmitDefaultValue = false)]
        public string ConditionNote { get; set; }

        /// <summary>
        /// The condition of the item.  Possible values: New, Used, Collectible, Refurbished, Preorder, Club.
        /// </summary>
        /// <value>The condition of the item.  Possible values: New, Used, Collectible, Refurbished, Preorder, Club.</value>
        [DataMember(Name = "ConditionId", EmitDefaultValue = false)]
        public string ConditionId { get; set; }

        /// <summary>
        /// The subcondition of the item.  Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, Any, Other.
        /// </summary>
        /// <value>The subcondition of the item.  Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, Any, Other.</value>
        [DataMember(Name = "ConditionSubtypeId", EmitDefaultValue = false)]
        public string ConditionSubtypeId { get; set; }

        /// <summary>
        /// The start date of the scheduled delivery window in the time zone of the order destination. In ISO 8601 date time format.
        /// </summary>
        /// <value>The start date of the scheduled delivery window in the time zone of the order destination. In ISO 8601 date time format.</value>
        [DataMember(Name = "ScheduledDeliveryStartDate", EmitDefaultValue = false)]
        public string ScheduledDeliveryStartDate { get; set; }

        /// <summary>
        /// The end date of the scheduled delivery window in the time zone of the order destination. In ISO 8601 date time format.
        /// </summary>
        /// <value>The end date of the scheduled delivery window in the time zone of the order destination. In ISO 8601 date time format.</value>
        [DataMember(Name = "ScheduledDeliveryEndDate", EmitDefaultValue = false)]
        public string ScheduledDeliveryEndDate { get; set; }

        /// <summary>
        /// Indicates that the selling price is a special price that is available only for Amazon Business orders. For more information about the Amazon Business Seller Program, see the [Amazon Business website](https://www.amazon.com/b2b/info/amazon-business).   Possible values: BusinessPrice - A special price that is available only for Amazon Business orders.
        /// </summary>
        /// <value>Indicates that the selling price is a special price that is available only for Amazon Business orders. For more information about the Amazon Business Seller Program, see the [Amazon Business website](https://www.amazon.com/b2b/info/amazon-business).   Possible values: BusinessPrice - A special price that is available only for Amazon Business orders.</value>
        [DataMember(Name = "PriceDesignation", EmitDefaultValue = false)]
        public string PriceDesignation { get; set; }

        /// <summary>
        /// Information about withheld taxes.
        /// </summary>
        /// <value>Information about withheld taxes.</value>
        [DataMember(Name = "TaxCollection", EmitDefaultValue = false)]
        public TaxCollection TaxCollection { get; set; }

        /// <summary>
        /// When true, the product type for this item has a serial number.  Returned only for Amazon Easy Ship orders.
        /// </summary>
        /// <value>When true, the product type for this item has a serial number.  Returned only for Amazon Easy Ship orders.</value>
        [DataMember(Name = "SerialNumberRequired", EmitDefaultValue = false)]
        public bool? SerialNumberRequired { get; set; }

        /// <summary>
        /// When true, transparency codes are required.
        /// </summary>
        /// <value>When true, transparency codes are required.</value>
        [DataMember(Name = "IsTransparency", EmitDefaultValue = false)]
        public bool? IsTransparency { get; set; }

        /// <summary>
        /// The IOSS number of the seller. Sellers selling in the EU will be assigned a unique IOSS number that must be listed on all packages sent to the EU.
        /// </summary>
        /// <value>The IOSS number of the seller. Sellers selling in the EU will be assigned a unique IOSS number that must be listed on all packages sent to the EU.</value>
        [DataMember(Name = "IossNumber", EmitDefaultValue = false)]
        public string IossNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItem {\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  QuantityShipped: ").Append(QuantityShipped).Append("\n");
            sb.Append("  ProductInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  PointsGranted: ").Append(PointsGranted).Append("\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
            sb.Append("  ShippingPrice: ").Append(ShippingPrice).Append("\n");
            sb.Append("  ItemTax: ").Append(ItemTax).Append("\n");
            sb.Append("  ShippingTax: ").Append(ShippingTax).Append("\n");
            sb.Append("  ShippingDiscount: ").Append(ShippingDiscount).Append("\n");
            sb.Append("  ShippingDiscountTax: ").Append(ShippingDiscountTax).Append("\n");
            sb.Append("  PromotionDiscount: ").Append(PromotionDiscount).Append("\n");
            sb.Append("  PromotionDiscountTax: ").Append(PromotionDiscountTax).Append("\n");
            sb.Append("  PromotionIds: ").Append(PromotionIds).Append("\n");
            sb.Append("  CODFee: ").Append(CODFee).Append("\n");
            sb.Append("  CODFeeDiscount: ").Append(CODFeeDiscount).Append("\n");
            sb.Append("  IsGift: ").Append(IsGift).Append("\n");
            sb.Append("  ConditionNote: ").Append(ConditionNote).Append("\n");
            sb.Append("  ConditionId: ").Append(ConditionId).Append("\n");
            sb.Append("  ConditionSubtypeId: ").Append(ConditionSubtypeId).Append("\n");
            sb.Append("  ScheduledDeliveryStartDate: ").Append(ScheduledDeliveryStartDate).Append("\n");
            sb.Append("  ScheduledDeliveryEndDate: ").Append(ScheduledDeliveryEndDate).Append("\n");
            sb.Append("  PriceDesignation: ").Append(PriceDesignation).Append("\n");
            sb.Append("  TaxCollection: ").Append(TaxCollection).Append("\n");
            sb.Append("  SerialNumberRequired: ").Append(SerialNumberRequired).Append("\n");
            sb.Append("  IsTransparency: ").Append(IsTransparency).Append("\n");
            sb.Append("  IossNumber: ").Append(IossNumber).Append("\n");
            sb.Append("  DeemedResellerCategory: ").Append(DeemedResellerCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderItem);
        }

        /// <summary>
        /// Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ASIN == input.ASIN ||
                    (this.ASIN != null &&
                    this.ASIN.Equals(input.ASIN))
                ) &&
                (
                    this.SellerSKU == input.SellerSKU ||
                    (this.SellerSKU != null &&
                    this.SellerSKU.Equals(input.SellerSKU))
                ) &&
                (
                    this.OrderItemId == input.OrderItemId ||
                    (this.OrderItemId != null &&
                    this.OrderItemId.Equals(input.OrderItemId))
                ) &&
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.QuantityOrdered == input.QuantityOrdered ||
                    (this.QuantityOrdered != null &&
                    this.QuantityOrdered.Equals(input.QuantityOrdered))
                ) &&
                (
                    this.QuantityShipped == input.QuantityShipped ||
                    (this.QuantityShipped != null &&
                    this.QuantityShipped.Equals(input.QuantityShipped))
                ) &&
                (
                    this.ProductInfo == input.ProductInfo ||
                    (this.ProductInfo != null &&
                    this.ProductInfo.Equals(input.ProductInfo))
                ) &&
                (
                    this.PointsGranted == input.PointsGranted ||
                    (this.PointsGranted != null &&
                    this.PointsGranted.Equals(input.PointsGranted))
                ) &&
                (
                    this.ItemPrice == input.ItemPrice ||
                    (this.ItemPrice != null &&
                    this.ItemPrice.Equals(input.ItemPrice))
                ) &&
                (
                    this.ShippingPrice == input.ShippingPrice ||
                    (this.ShippingPrice != null &&
                    this.ShippingPrice.Equals(input.ShippingPrice))
                ) &&
                (
                    this.ItemTax == input.ItemTax ||
                    (this.ItemTax != null &&
                    this.ItemTax.Equals(input.ItemTax))
                ) &&
                (
                    this.ShippingTax == input.ShippingTax ||
                    (this.ShippingTax != null &&
                    this.ShippingTax.Equals(input.ShippingTax))
                ) &&
                (
                    this.ShippingDiscount == input.ShippingDiscount ||
                    (this.ShippingDiscount != null &&
                    this.ShippingDiscount.Equals(input.ShippingDiscount))
                ) &&
                (
                    this.ShippingDiscountTax == input.ShippingDiscountTax ||
                    (this.ShippingDiscountTax != null &&
                    this.ShippingDiscountTax.Equals(input.ShippingDiscountTax))
                ) &&
                (
                    this.PromotionDiscount == input.PromotionDiscount ||
                    (this.PromotionDiscount != null &&
                    this.PromotionDiscount.Equals(input.PromotionDiscount))
                ) &&
                (
                    this.PromotionDiscountTax == input.PromotionDiscountTax ||
                    (this.PromotionDiscountTax != null &&
                    this.PromotionDiscountTax.Equals(input.PromotionDiscountTax))
                ) &&
                (
                    this.PromotionIds == input.PromotionIds ||
                    (this.PromotionIds != null &&
                    this.PromotionIds.Equals(input.PromotionIds))
                ) &&
                (
                    this.CODFee == input.CODFee ||
                    (this.CODFee != null &&
                    this.CODFee.Equals(input.CODFee))
                ) &&
                (
                    this.CODFeeDiscount == input.CODFeeDiscount ||
                    (this.CODFeeDiscount != null &&
                    this.CODFeeDiscount.Equals(input.CODFeeDiscount))
                ) &&
                (
                    this.IsGift == input.IsGift ||
                    (this.IsGift != null &&
                    this.IsGift.Equals(input.IsGift))
                ) &&
                (
                    this.ConditionNote == input.ConditionNote ||
                    (this.ConditionNote != null &&
                    this.ConditionNote.Equals(input.ConditionNote))
                ) &&
                (
                    this.ConditionId == input.ConditionId ||
                    (this.ConditionId != null &&
                    this.ConditionId.Equals(input.ConditionId))
                ) &&
                (
                    this.ConditionSubtypeId == input.ConditionSubtypeId ||
                    (this.ConditionSubtypeId != null &&
                    this.ConditionSubtypeId.Equals(input.ConditionSubtypeId))
                ) &&
                (
                    this.ScheduledDeliveryStartDate == input.ScheduledDeliveryStartDate ||
                    (this.ScheduledDeliveryStartDate != null &&
                    this.ScheduledDeliveryStartDate.Equals(input.ScheduledDeliveryStartDate))
                ) &&
                (
                    this.ScheduledDeliveryEndDate == input.ScheduledDeliveryEndDate ||
                    (this.ScheduledDeliveryEndDate != null &&
                    this.ScheduledDeliveryEndDate.Equals(input.ScheduledDeliveryEndDate))
                ) &&
                (
                    this.PriceDesignation == input.PriceDesignation ||
                    (this.PriceDesignation != null &&
                    this.PriceDesignation.Equals(input.PriceDesignation))
                ) &&
                (
                    this.TaxCollection == input.TaxCollection ||
                    (this.TaxCollection != null &&
                    this.TaxCollection.Equals(input.TaxCollection))
                ) &&
                (
                    this.SerialNumberRequired == input.SerialNumberRequired ||
                    (this.SerialNumberRequired != null &&
                    this.SerialNumberRequired.Equals(input.SerialNumberRequired))
                ) &&
                (
                    this.IsTransparency == input.IsTransparency ||
                    (this.IsTransparency != null &&
                    this.IsTransparency.Equals(input.IsTransparency))
                ) &&
                (
                    this.IossNumber == input.IossNumber ||
                    (this.IossNumber != null &&
                    this.IossNumber.Equals(input.IossNumber))
                ) &&
                (
                    this.DeemedResellerCategory == input.DeemedResellerCategory ||
                    (this.DeemedResellerCategory != null &&
                    this.DeemedResellerCategory.Equals(input.DeemedResellerCategory))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ASIN != null)
                    hashCode = hashCode * 59 + this.ASIN.GetHashCode();
                if (this.SellerSKU != null)
                    hashCode = hashCode * 59 + this.SellerSKU.GetHashCode();
                if (this.OrderItemId != null)
                    hashCode = hashCode * 59 + this.OrderItemId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.QuantityOrdered != null)
                    hashCode = hashCode * 59 + this.QuantityOrdered.GetHashCode();
                if (this.QuantityShipped != null)
                    hashCode = hashCode * 59 + this.QuantityShipped.GetHashCode();
                if (this.ProductInfo != null)
                    hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.PointsGranted != null)
                    hashCode = hashCode * 59 + this.PointsGranted.GetHashCode();
                if (this.ItemPrice != null)
                    hashCode = hashCode * 59 + this.ItemPrice.GetHashCode();
                if (this.ShippingPrice != null)
                    hashCode = hashCode * 59 + this.ShippingPrice.GetHashCode();
                if (this.ItemTax != null)
                    hashCode = hashCode * 59 + this.ItemTax.GetHashCode();
                if (this.ShippingTax != null)
                    hashCode = hashCode * 59 + this.ShippingTax.GetHashCode();
                if (this.ShippingDiscount != null)
                    hashCode = hashCode * 59 + this.ShippingDiscount.GetHashCode();
                if (this.ShippingDiscountTax != null)
                    hashCode = hashCode * 59 + this.ShippingDiscountTax.GetHashCode();
                if (this.PromotionDiscount != null)
                    hashCode = hashCode * 59 + this.PromotionDiscount.GetHashCode();
                if (this.PromotionDiscountTax != null)
                    hashCode = hashCode * 59 + this.PromotionDiscountTax.GetHashCode();
                if (this.PromotionIds != null)
                    hashCode = hashCode * 59 + this.PromotionIds.GetHashCode();
                if (this.CODFee != null)
                    hashCode = hashCode * 59 + this.CODFee.GetHashCode();
                if (this.CODFeeDiscount != null)
                    hashCode = hashCode * 59 + this.CODFeeDiscount.GetHashCode();
                if (this.IsGift != null)
                    hashCode = hashCode * 59 + this.IsGift.GetHashCode();
                if (this.ConditionNote != null)
                    hashCode = hashCode * 59 + this.ConditionNote.GetHashCode();
                if (this.ConditionId != null)
                    hashCode = hashCode * 59 + this.ConditionId.GetHashCode();
                if (this.ConditionSubtypeId != null)
                    hashCode = hashCode * 59 + this.ConditionSubtypeId.GetHashCode();
                if (this.ScheduledDeliveryStartDate != null)
                    hashCode = hashCode * 59 + this.ScheduledDeliveryStartDate.GetHashCode();
                if (this.ScheduledDeliveryEndDate != null)
                    hashCode = hashCode * 59 + this.ScheduledDeliveryEndDate.GetHashCode();
                if (this.PriceDesignation != null)
                    hashCode = hashCode * 59 + this.PriceDesignation.GetHashCode();
                if (this.TaxCollection != null)
                    hashCode = hashCode * 59 + this.TaxCollection.GetHashCode();
                if (this.SerialNumberRequired != null)
                    hashCode = hashCode * 59 + this.SerialNumberRequired.GetHashCode();
                if (this.IsTransparency != null)
                    hashCode = hashCode * 59 + this.IsTransparency.GetHashCode();
                if (this.IossNumber != null)
                    hashCode = hashCode * 59 + this.IossNumber.GetHashCode();
                if (this.DeemedResellerCategory != null)
                    hashCode = hashCode * 59 + this.DeemedResellerCategory.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}