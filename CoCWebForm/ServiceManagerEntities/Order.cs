namespace CoCWebForm.ServiceManagerEntities
{
    public partial class DAT_ORDERS
    {
        public Guid ID { get; set; }
        public string REGION_ID { get; set; }
        public string PROJECT_ID { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string FACILITY_ID { get; set; }
        public string BILL_FACILITY_ID { get; set; }
        public short? ORDER_STATUS { get; set; }
        public string JOB_DESCRIPTION { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string REFERENCE { get; set; }
        public bool SEND_THANK_YOU { get; set; }
        public bool STATS_REPORT_NEEDED { get; set; }
        public string SCHD_NOTES { get; set; }
        public string TERMS { get; set; }
        public decimal FREIGHT_COSTS { get; set; }
        public decimal PORTAL_COSTS { get; set; }
        public string BILLING_STATUS { get; set; }
        public DateTime? BILLING_DATE { get; set; }
        public string BILLING_NOTES { get; set; }
        public string NOTES { get; set; }
        public long CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime LAST_UPDATED { get; set; }
        public int ROW_VERSION { get; set; }
        public string CLIENT_BILLING_NOTES { get; set; }
        public string TECH_NOTES { get; set; }
        public short DAYS_BETWEEN_TEST { get; set; }
        public DateTime? DUE_DATE { get; set; }
        public Guid FIRSTCONTACT_GUID { get; set; }
        public Guid? SECONDCONTACT_GUID { get; set; }
        public Guid rowguid { get; set; }
        public bool QC { get; set; }
        public string QC_BY { get; set; }
        public DateTime? QC_DATE { get; set; }
        public long? SALES_REP_USER_ID { get; set; }
        public string REPORT_TYPE { get; set; }
        public DateTime? REPORT_DUE_DATE { get; set; }
        public string MEET_CUSTOMER_REQUEST { get; set; }
        public string CUSTOMER_REQUIREMENTS_CHANGED { get; set; }
        public string CUSTOMER_REQUIREMENTS_TYPE { get; set; }
        public string CUSTOMER_AGREED { get; set; }
        public string CUSTOMER_CONFRIMED_VIA { get; set; }
        public string GPO { get; set; }
        public string EMLAB_PURCAHSE_ORDER { get; set; }
        public Guid? LAB_GUID { get; set; }
        public string VIABLE_SAMPLE_INCUBATION { get; set; }
        public string VIABLE_SAMPLE_MEDIA { get; set; }
        public bool? VIABLE_SAMPLE_AUTO_COLONY_ID { get; set; }
        public string VIABLE_SAMPLE_SPECIAL_INSTRUCTIONS { get; set; }
        public string INVOICE_RECIPENTS { get; set; }
        public int? VIABLE_SAMPLE_AIR_ALERT_LIMIT { get; set; }
        public int? VIABLE_SAMPLE_AIR_ACTION_LIMIT { get; set; }
        public int? VIABLE_SAMPLE_SURFACE_ALERT_LIMIT { get; set; }
        public int? VIABLE_SAMPLE_SURFACE_ACTION_LIMIT { get; set; }
        public bool? VIABLE_SAMPLE_GENUS_ID { get; set; }
        public bool? VIABLE_SAMPLE_SPECIES_ID { get; set; }
        public DateTime? VIABLE_SAMPLE_RECEIVED_DATE { get; set; }
        public DateTime? VIABLE_SAMPLE_ANALYZED_DATE { get; set; }
        public DateTime? VIABLE_SAMPLE_FINISHED_DATE { get; set; }
        public long? PROJECT_MANAGER_ID { get; set; }
        public bool? IS_OVERRIDE_MINIMUM_PRICE { get; set; }
        public Guid? PRICE_GUID { get; set; }

        //public virtual DAT_CONTACTS DAT_CONTACTS { get; set; }
        //public virtual DAT_CONTACTS DAT_CONTACTS1 { get; set; }
        //public virtual DAT_CUSTOMERS DAT_CUSTOMERS { get; set; }
    }
}
