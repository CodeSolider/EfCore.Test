using EbayPlatform.DataBase.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EbayPlatform.DataBase
{
    public partial class EbayPlatformContext : DbContext
    {
        public EbayPlatformContext(DbContextOptions<EbayPlatformContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EbayAccount> EbayAccounts { get; set; }
        public virtual DbSet<EbayAccountDetail> EbayAccountDetails { get; set; }
        public virtual DbSet<EbayAddress> EbayAddresses { get; set; }
        public virtual DbSet<EbayCarModel> EbayCarModels { get; set; }
        public virtual DbSet<EbayCarModelHistoryGmv> EbayCarModelHistoryGmvs { get; set; }
        public virtual DbSet<EbayCategory> EbayCategories { get; set; }
        public virtual DbSet<EbayOrder> EbayOrders { get; set; }
        public virtual DbSet<EbayOrderDetail> EbayOrderDetails { get; set; }
        public virtual DbSet<EbayProduct> EbayProducts { get; set; }
        public virtual DbSet<EbayProductHistory> EbayProductHistories { get; set; }
        public virtual DbSet<EbaySiteMessage> EbaySiteMessages { get; set; }
        public virtual DbSet<EbaySkuCarModel> EbaySkuCarModels { get; set; }
        public virtual DbSet<EbaySkuCarModelDetail> EbaySkuCarModelDetails { get; set; }
        public virtual DbSet<SyncExceptionLog> SyncExceptionLogs { get; set; }
        public virtual DbSet<SyncJobConfig> SyncJobConfigs { get; set; }
        public virtual DbSet<SyncRecord> SyncRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<EbayAccount>(entity =>
            {
                entity.ToTable("Ebay_Account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountStateName).HasMaxLength(15);

                entity.Property(e => e.AdditionalAccountCurrency).HasMaxLength(10);

                entity.Property(e => e.AmountPastDueCurrency).HasMaxLength(10);

                entity.Property(e => e.ApiUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.BalanceCurrency).HasMaxLength(10);

                entity.Property(e => e.BankAccountInfo).HasMaxLength(4);

                entity.Property(e => e.BankModifyDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardExpiration).HasColumnType("datetime");

                entity.Property(e => e.CreditCardInfo).HasMaxLength(100);

                entity.Property(e => e.CreditCardModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.CurrentBalanceCurrency).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InvoiceBalanceCurrency).HasMaxLength(10);

                entity.Property(e => e.InvoiceCreditCurrency).HasMaxLength(10);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNewFeeCurrenycy).HasMaxLength(10);

                entity.Property(e => e.InvoicePaymentCurrenycy).HasMaxLength(10);

                entity.Property(e => e.LastAmountPaidCurrency).HasMaxLength(10);

                entity.Property(e => e.LastPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodName).HasMaxLength(50);

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EbayAccountDetail>(entity =>
            {
                entity.ToTable("Ebay_AccountDetail");

                entity.HasIndex(e => new { e.RefNumber, e.AccountDetailsType, e.ItemId, e.PostingDate }, "NonClusteredIndex-20201102-162454");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountDetailsName).HasMaxLength(50);

                entity.Property(e => e.ConversionRateCurrency).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EbayAccountId).HasColumnName("Ebay_AccountID");

                entity.Property(e => e.GrossDetailAmountCurrency).HasMaxLength(10);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.NetDetailAmountCurrency).HasMaxLength(10);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderLineItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderLineItemID");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.RefNumber).HasMaxLength(20);

                entity.Property(e => e.SyncCreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(300);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.Vatpercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATPercent");
            });

            modelBuilder.Entity<EbayAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__Ebay_Add__091C2A1BBE9F85AA");

                entity.ToTable("Ebay_Address");

                entity.Property(e => e.AddressId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AddressID");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.County).HasMaxLength(50);

                entity.Property(e => e.ExternalAddressId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExternalAddressID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.InternationalName).HasMaxLength(50);

                entity.Property(e => e.InternationalStateAndCity).HasMaxLength(50);

                entity.Property(e => e.InternationalStreet).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAreaOrCityCode).HasMaxLength(50);

                entity.Property(e => e.PhoneCountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCountryPrefix).HasMaxLength(50);

                entity.Property(e => e.PhoneLocalNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceID");

                entity.Property(e => e.StateOrProvince).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.Property(e => e.Street1).HasMaxLength(200);

                entity.Property(e => e.Street2).HasMaxLength(200);

                entity.Property(e => e.SyncCreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EbayCarModel>(entity =>
            {
                entity.HasKey(e => e.Epid)
                    .HasName("PK__Ebay_Car__28740BB8F6684EA3");

                entity.ToTable("Ebay_CarModel");

                entity.Property(e => e.Epid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPID");

                entity.Property(e => e.Aspiration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Body).HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CylinderTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.DriveType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Engine).HasMaxLength(500);

                entity.Property(e => e.EngineBlockType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EngineCc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EngineCC");

                entity.Property(e => e.EngineCid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EngineCID");

                entity.Property(e => e.EngineCylinders).HasMaxLength(50);

                entity.Property(e => e.EngineLiterDisplay)
                    .HasMaxLength(50)
                    .HasColumnName("EngineLiter_Display");

                entity.Property(e => e.FuelTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KbbModel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KBB_Model");

                entity.Property(e => e.Make).HasMaxLength(100);

                entity.Property(e => e.Model).HasMaxLength(500);

                entity.Property(e => e.NumDoors)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartsModel).HasMaxLength(500);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Submodel).HasMaxLength(500);

                entity.Property(e => e.Trim).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EbayCarModelHistoryGmv>(entity =>
            {
                entity.ToTable("Ebay_CarModelHistoryGMV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EbayGmvrank).HasColumnName("EbayGMVRank");

                entity.Property(e => e.EbaySirank).HasColumnName("EbaySIRank");

                entity.Property(e => e.Gmv).HasColumnName("GMV");

                entity.Property(e => e.Make)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.SiteCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EbayCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Ebay_Cat__19093A2BFF4AD6A1");

                entity.ToTable("Ebay_Category");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.CategoryParentId)
                    .HasMaxLength(50)
                    .HasColumnName("CategoryParentID");

                entity.Property(e => e.Keywords).HasMaxLength(200);

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EbayOrder>(entity =>
            {
                entity.HasKey(e => e.OrderNo)
                    .HasName("PK__Ebay_Ord__C3907C741B99E3EC");

                entity.ToTable("Ebay_Order");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AddressID");

                entity.Property(e => e.AdjustmentAmountCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentAmountValue).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AmountPaidCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPaidValue).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AmountSavedCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmountSavedValue).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ApiUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.BuyerCheckoutMessage).HasMaxLength(1000);

                entity.Property(e => e.BuyerUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BuyerUserID");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CheckoutStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExtendedOrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExtendedOrderID");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaidTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceIdtype)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceIDType");

                entity.Property(e => e.RefundAmountCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmountValue).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RefundStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SellerUserID");

                entity.Property(e => e.ShippedTime).HasColumnType("datetime");

                entity.Property(e => e.SyncCreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.TotalCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<EbayOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderLineItemId)
                    .HasName("PK__Ebay_Ord__6E480501109134A1");

                entity.ToTable("Ebay_OrderDetail");

                entity.Property(e => e.OrderLineItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderLineItemID");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyncCreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPriceCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceValue).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionPriceCurrenycy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionPriceValue).HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<EbayProduct>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Ebay_Pro__727E83EB166A1F32");

                entity.ToTable("Ebay_Product");

                entity.HasIndex(e => e.ParentSku, "NonClusteredIndex-20201225-174359");

                entity.HasIndex(e => e.Ycsku, "NonClusteredIndex-20201226-101938");

                entity.HasIndex(e => e.ListingStatus, "NonClusteredIndex-20201228-104958");

                entity.HasIndex(e => e.ApiUserId, "NonClusteredIndex-20201228-112742");

                entity.HasIndex(e => new { e.StartTime, e.EndTime, e.SyncCreateDate, e.SyncUpdateDate }, "NonClusteredIndex-20201228-135030");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ApiUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossWeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InternationalShippingDiscountProfileId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("InternationalShippingDiscountProfileID");

                entity.Property(e => e.ListingDuration).HasMaxLength(10);

                entity.Property(e => e.ListingStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfflineDate).HasColumnType("datetime");

                entity.Property(e => e.OfflineReason)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PackageHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageHeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PackageLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageLengthUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PackageWidth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageWidthUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ParentSku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ParentSKU");

                entity.Property(e => e.PayPalEmailAddress).HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductPriceCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductViewUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingDiscountProfileId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ShippingDiscountProfileID");

                entity.Property(e => e.ShippingService)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingServiceAdditionalCostCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingServiceAdditionalCostValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingServiceCostCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingServiceCostValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SiteCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SubTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Ycsku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YCSKU");
            });

            modelBuilder.Entity<EbayProductHistory>(entity =>
            {
                entity.ToTable("Ebay_ProductHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.BidCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.CurrentPriceCurrency).HasMaxLength(50);

                entity.Property(e => e.EbayNotes)
                    .HasMaxLength(500)
                    .HasColumnName("EBayNotes");

                entity.Property(e => e.EbayPlus).HasColumnName("EBayPlus");

                entity.Property(e => e.EbayPlusEligible).HasColumnName("EBayPlusEligible");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.HitCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.HitCounter)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ListingStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.TimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<EbaySiteMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__Ebay_Sit__C87C037CB7661DF4");

                entity.ToTable("Ebay_SiteMessage");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MessageID");

                entity.Property(e => e.ApiUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalMessageId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExternalMessageID");

                entity.Property(e => e.ItemEndTime).HasColumnType("datetime");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ItemTitle).HasMaxLength(500);

                entity.Property(e => e.QuestionType).HasMaxLength(50);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RecipientUserID");

                entity.Property(e => e.ResponseUrl)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ResponseURL");

                entity.Property(e => e.SendToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserResponseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EbaySkuCarModel>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .HasName("PK__Ebay_Sku__CA1ECF0C0FB1C252");

                entity.ToTable("Ebay_SkuCarModel");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EbaySkuCarModelDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK__Ebay_Sku__135C314DFE5C1C5D");

                entity.ToTable("Ebay_SkuCarModelDetail");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.CompRemark).HasMaxLength(1000);

                entity.Property(e => e.Engine)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Epid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPID");

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Trim)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyncExceptionLog>(entity =>
            {
                entity.HasKey(e => e.ExceptionId)
                    .HasName("PK__Exceptio__26981DA889091A25");

                entity.ToTable("SyncExceptionLog");

                entity.Property(e => e.ExceptionId).HasColumnName("ExceptionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.JobConfigId).HasColumnName("JobConfigID");
            });

            modelBuilder.Entity<SyncJobConfig>(entity =>
            {
                entity.ToTable("SyncJobConfig");

                entity.Property(e => e.ApiUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.AssemblyName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CronDescription).HasMaxLength(100);

                entity.Property(e => e.CronString)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JobDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.JobGroup)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextRunTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyncRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__SyncReco__FBDF78C9A56A68DD");

                entity.ToTable("SyncRecord");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ApiUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApiUserID");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SyncCreateDate).HasColumnType("datetime");

                entity.Property(e => e.SyncLastDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUpdateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
