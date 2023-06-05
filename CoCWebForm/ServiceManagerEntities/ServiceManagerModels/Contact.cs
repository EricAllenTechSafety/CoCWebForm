using System.ComponentModel.DataAnnotations;

namespace CoCWebForm.ServiceManagerEntities.ServiceManagerModels
{
    public partial class DAT_CONTACTS
    {
        [Key]
        public System.Guid CONTACT_GUID { get; set; }
        public string CONTACT_ID { get; set; }
        public string REGION_ID { get; set; }
        public string FACILITY_ID { get; set; }
        public string CONTACT_PREFIX { get; set; }
        public string CONTACT_FIRST_NAME { get; set; }
        public string CONTACT_LAST_NAME { get; set; }
        public string CONTACT_DEPT { get; set; }
        public string CONTACT_POSITION { get; set; }
        public bool CONTACT_STATUS { get; set; }
        public string ADDRESS { get; set; }
        public string ADDRESS_2 { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string POSTCODE { get; set; }
        public string POSTEXT { get; set; }
        public string OFFICE_PHONE { get; set; }
        public string EXTENSION { get; set; }
        public string FAX_NUMBER { get; set; }
        public string PAGER { get; set; }
        public string CELLULAR { get; set; }
        public string VOICE_MAIL { get; set; }
        public string HOME_PHONE { get; set; }
        public string E_MAIL { get; set; }
        public string NOTES { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public System.DateTime LAST_UPDATED { get; set; }
        public System.Guid rowguid { get; set; }
    }
}
