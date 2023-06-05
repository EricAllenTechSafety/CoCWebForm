using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using CoCWebForm.ServiceManagerEntities.ServiceManagerModels;

namespace CoCWebForm.ServiceManagerEntities
{
    public partial class ServiceManagerContext : DbContext
    {
        public ServiceManagerContext()
            : base("Data Source=BRK1DWDEVX001;Initial Catalog=ServiceManager;Integrated Security=True")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        //public virtual DbSet<DAT_ALERTS> DAT_ALERTS { get; set; }
        //public virtual DbSet<DAT_AUDIT_TRAILS> DAT_AUDIT_TRAILS { get; set; }
        public virtual DbSet<DAT_CONTACTS> DAT_CONTACTS { get; set; }
        //public virtual DbSet<DAT_CUSTOMERS> DAT_CUSTOMERS { get; set; }
        //public virtual DbSet<DAT_FEEDBACK_ACTION_ITEMS> DAT_FEEDBACK_ACTION_ITEMS { get; set; }
        //public virtual DbSet<DAT_FEEDBACK_MEETING_ROSTERS> DAT_FEEDBACK_MEETING_ROSTERS { get; set; }
        //public virtual DbSet<DAT_FEEDBACKS> DAT_FEEDBACKS { get; set; }
        //public virtual DbSet<DAT_HOOD_ATTACHMENTS> DAT_HOOD_ATTACHMENTS { get; set; }
        //public virtual DbSet<DAT_HOOD_AUDIT_TRAILS> DAT_HOOD_AUDIT_TRAILS { get; set; }
        //public virtual DbSet<DAT_HOOD_DEFAULTS> DAT_HOOD_DEFAULTS { get; set; }
        //public virtual DbSet<DAT_HOOD_HEPAFILTERS> DAT_HOOD_HEPAFILTERS { get; set; }
        //public virtual DbSet<DAT_HOOD_QUALITY_CONTROL> DAT_HOOD_QUALITY_CONTROL { get; set; }
        //public virtual DbSet<DAT_HOODS> DAT_HOODS { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_ATTACHMENTS> DAT_MICROLAB_PROJECT_ATTACHMENTS { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_COMMENTS> DAT_MICROLAB_PROJECT_COMMENTS { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_EQUIPMENT_USED> DAT_MICROLAB_PROJECT_EQUIPMENT_USED { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_ESIGNATURES> DAT_MICROLAB_PROJECT_ESIGNATURES { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_LIMITS> DAT_MICROLAB_PROJECT_LIMITS { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_SAMPLE_INCUBATION> DAT_MICROLAB_PROJECT_SAMPLE_INCUBATION { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_SAMPLE_INCUBATION_ORGANISMS> DAT_MICROLAB_PROJECT_SAMPLE_INCUBATION_ORGANISMS { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECT_SAMPLES> DAT_MICROLAB_PROJECT_SAMPLES { get; set; }
        //public virtual DbSet<DAT_MICROLAB_PROJECTS> DAT_MICROLAB_PROJECTS { get; set; }
        public virtual DbSet<DAT_ORDERS> DAT_ORDERS { get; set; }
        //public virtual DbSet<DAT_ORDERS_ATTACHMENTS> DAT_ORDERS_ATTACHMENTS { get; set; }
        //public virtual DbSet<DAT_ORDERS_AUDIT_TRAILS> DAT_ORDERS_AUDIT_TRAILS { get; set; }
        //public virtual DbSet<DAT_ORDERS_DUE> DAT_ORDERS_DUE { get; set; }
        //public virtual DbSet<DAT_ORDERS_HOODS> DAT_ORDERS_HOODS { get; set; }
        //public virtual DbSet<DAT_ORDERS_PARTS> DAT_ORDERS_PARTS { get; set; }
        //public virtual DbSet<DAT_ORDERS_PARTS_UNITS> DAT_ORDERS_PARTS_UNITS { get; set; }
        //public virtual DbSet<DAT_ORDERS_SCHEDULE> DAT_ORDERS_SCHEDULE { get; set; }
        //public virtual DbSet<DAT_ORDERS_STATUS> DAT_ORDERS_STATUS { get; set; }
        //public virtual DbSet<DAT_ORDERS_TASKS> DAT_ORDERS_TASKS { get; set; }
        //public virtual DbSet<DAT_ORDERS_TASKS_UNITS> DAT_ORDERS_TASKS_UNITS { get; set; }
        //public virtual DbSet<DAT_ORDERS_TECH_REPORTS> DAT_ORDERS_TECH_REPORTS { get; set; }
        //public virtual DbSet<DAT_ORDERS_TECH_REPORTS_TIMELOGS> DAT_ORDERS_TECH_REPORTS_TIMELOGS { get; set; }
        //public virtual DbSet<DAT_ORDERS_TECHNICIANS> DAT_ORDERS_TECHNICIANS { get; set; }
        //public virtual DbSet<DAT_PARTS_INVENTORY> DAT_PARTS_INVENTORY { get; set; }
        //public virtual DbSet<DAT_PARTS_INVENTORY_HISTORY> DAT_PARTS_INVENTORY_HISTORY { get; set; }
        //public virtual DbSet<DAT_PLAN_SCHEDULE_NEW> DAT_PLAN_SCHEDULE_NEW { get; set; }
        //public virtual DbSet<DAT_PRICES> DAT_PRICES { get; set; }
        //public virtual DbSet<DAT_PRICES_TASKS> DAT_PRICES_TASKS { get; set; }
        //public virtual DbSet<DAT_PURCHASE_ORDER_DETAILS> DAT_PURCHASE_ORDER_DETAILS { get; set; }
        //public virtual DbSet<DAT_PURCHASE_ORDERS> DAT_PURCHASE_ORDERS { get; set; }
        //public virtual DbSet<DAT_REPORTS> DAT_REPORTS { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE> DAT_SALES_PIPELINE { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE_ATTACHMENTS> DAT_SALES_PIPELINE_ATTACHMENTS { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE_CORRESPONDENCES> DAT_SALES_PIPELINE_CORRESPONDENCES { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE_ORDERS> DAT_SALES_PIPELINE_ORDERS { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE_PARTS> DAT_SALES_PIPELINE_PARTS { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE_TASKS> DAT_SALES_PIPELINE_TASKS { get; set; }
        //public virtual DbSet<DAT_SALES_PIPELINE_TASKS_UNITS> DAT_SALES_PIPELINE_TASKS_UNITS { get; set; }
        //public virtual DbSet<DAT_SOP> DAT_SOP { get; set; }
        //public virtual DbSet<DAT_TASKS> DAT_TASKS { get; set; }
        //public virtual DbSet<DAT_TASKS_CHECKLISTS> DAT_TASKS_CHECKLISTS { get; set; }
        //public virtual DbSet<DAT_TECHS_TIME_OFF> DAT_TECHS_TIME_OFF { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT> DAT_TEST_EQUIPMENT { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT_AUDIT_TRAILS> DAT_TEST_EQUIPMENT_AUDIT_TRAILS { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT_CERTS> DAT_TEST_EQUIPMENT_CERTS { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT_KIT> DAT_TEST_EQUIPMENT_KIT { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT_LOG> DAT_TEST_EQUIPMENT_LOG { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT_PHOTOS> DAT_TEST_EQUIPMENT_PHOTOS { get; set; }
        //public virtual DbSet<DAT_TEST_EQUIPMENT_SCHEDULE> DAT_TEST_EQUIPMENT_SCHEDULE { get; set; }
        //public virtual DbSet<DAT_TEST_SPECS> DAT_TEST_SPECS { get; set; }
        //public virtual DbSet<DAT_TESTING_BIOSAFETY_CABINETS> DAT_TESTING_BIOSAFETY_CABINETS { get; set; }
        //public virtual DbSet<DAT_TESTING_CALIBRATION> DAT_TESTING_CALIBRATION { get; set; }
        //public virtual DbSet<DAT_TESTING_CALIBRATION_DATA> DAT_TESTING_CALIBRATION_DATA { get; set; }
        //public virtual DbSet<DAT_TESTING_CLEANBENCHES> DAT_TESTING_CLEANBENCHES { get; set; }
        //public virtual DbSet<DAT_TESTING_COMPRESSED_GAS> DAT_TESTING_COMPRESSED_GAS { get; set; }
        //public virtual DbSet<DAT_TESTING_CONSUMABLES> DAT_TESTING_CONSUMABLES { get; set; }
        //public virtual DbSet<DAT_TESTING_ERRORS> DAT_TESTING_ERRORS { get; set; }
        //public virtual DbSet<DAT_TESTING_ESIGNATURES> DAT_TESTING_ESIGNATURES { get; set; }
        //public virtual DbSet<DAT_TESTING_FUMEHOODS> DAT_TESTING_FUMEHOODS { get; set; }
        //public virtual DbSet<DAT_TESTING_GAS_CABINETS> DAT_TESTING_GAS_CABINETS { get; set; }
        //public virtual DbSet<DAT_TESTING_GROSSING> DAT_TESTING_GROSSING { get; set; }
        //public virtual DbSet<DAT_TESTING_GUS> DAT_TESTING_GUS { get; set; }
        //public virtual DbSet<DAT_TESTING_ISOLATORS> DAT_TESTING_ISOLATORS { get; set; }
        //public virtual DbSet<DAT_TESTING_PARTICLE_COUNT> DAT_TESTING_PARTICLE_COUNT { get; set; }
        //public virtual DbSet<DAT_TESTING_PARTICLE_COUNT_LOC_A> DAT_TESTING_PARTICLE_COUNT_LOC_A { get; set; }
        //public virtual DbSet<DAT_TESTING_PARTICLE_COUNT_LOC_B> DAT_TESTING_PARTICLE_COUNT_LOC_B { get; set; }
        //public virtual DbSet<DAT_TESTING_PREVENTATIVE_MAINTENANCE> DAT_TESTING_PREVENTATIVE_MAINTENANCE { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_ASSESSMENTS> DAT_TESTING_SUM_ASSESSMENTS { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_ATTACHMENTS> DAT_TESTING_SUM_ATTACHMENTS { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_AUDIT_TRAILS> DAT_TESTING_SUM_AUDIT_TRAILS { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_DECONTAMINATION> DAT_TESTING_SUM_DECONTAMINATION { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_EQUIPMENT_USED> DAT_TESTING_SUM_EQUIPMENT_USED { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_HEPAFILTERS> DAT_TESTING_SUM_HEPAFILTERS { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_NEW> DAT_TESTING_SUM_NEW { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_PRESSURES> DAT_TESTING_SUM_PRESSURES { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_QUALITY_CONTROL> DAT_TESTING_SUM_QUALITY_CONTROL { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_VIABLE_SAMPLE_INCUBATION> DAT_TESTING_SUM_VIABLE_SAMPLE_INCUBATION { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_VIABLE_SAMPLE_INCUBATION_ORGANISMS> DAT_TESTING_SUM_VIABLE_SAMPLE_INCUBATION_ORGANISMS { get; set; }
        //public virtual DbSet<DAT_TESTING_SUM_VIABLE_SAMPLES> DAT_TESTING_SUM_VIABLE_SAMPLES { get; set; }
        //public virtual DbSet<DAT_TESTING_ULTRAPURE_WATER> DAT_TESTING_ULTRAPURE_WATER { get; set; }
        //public virtual DbSet<DAT_TIMESHEET> DAT_TIMESHEET { get; set; }
        //public virtual DbSet<DAT_TRAINING_EVENTS> DAT_TRAINING_EVENTS { get; set; }
        //public virtual DbSet<DAT_TRAINING_EVENTS_SOPS> DAT_TRAINING_EVENTS_SOPS { get; set; }
        //public virtual DbSet<DAT_TRAINING_MODULE_EXAM_QUESTION_CHOICES> DAT_TRAINING_MODULE_EXAM_QUESTION_CHOICES { get; set; }
        //public virtual DbSet<DAT_TRAINING_MODULE_EXAM_QUESTIONS> DAT_TRAINING_MODULE_EXAM_QUESTIONS { get; set; }
        //public virtual DbSet<DAT_TRAINING_MODULE_PREREQUISITES> DAT_TRAINING_MODULE_PREREQUISITES { get; set; }
        //public virtual DbSet<DAT_TRAINING_MODULE_RESOURCES> DAT_TRAINING_MODULE_RESOURCES { get; set; }
        //public virtual DbSet<DAT_TRAINING_MODULES> DAT_TRAINING_MODULES { get; set; }
        //public virtual DbSet<DAT_TRAINING_ROSTER_EXAM_QUESTIONS> DAT_TRAINING_ROSTER_EXAM_QUESTIONS { get; set; }
        //public virtual DbSet<DAT_TRAINING_ROSTER_EXAMS> DAT_TRAINING_ROSTER_EXAMS { get; set; }
        //public virtual DbSet<DAT_TRAINING_ROSTERS> DAT_TRAINING_ROSTERS { get; set; }
        //public virtual DbSet<DAT_VEHICLE_INSPECTION_DETAILS> DAT_VEHICLE_INSPECTION_DETAILS { get; set; }
        //public virtual DbSet<DAT_VEHICLE_INSPECTIONS> DAT_VEHICLE_INSPECTIONS { get; set; }
        //public virtual DbSet<DAT_VENDORS> DAT_VENDORS { get; set; }
        //public virtual DbSet<lk1_ActiveStatus> lk1_ActiveStatus { get; set; }
        //public virtual DbSet<lk1_Aerosols> lk1_Aerosols { get; set; }
        //public virtual DbSet<lk1_Alert_Users> lk1_Alert_Users { get; set; }
        //public virtual DbSet<lk1_Calibration_Units> lk1_Calibration_Units { get; set; }
        //public virtual DbSet<lk1_Can_Text> lk1_Can_Text { get; set; }
        //public virtual DbSet<lk1_Customer_Contacts> lk1_Customer_Contacts { get; set; }
        //public virtual DbSet<lk1_Equipment_Types> lk1_Equipment_Types { get; set; }
        //public virtual DbSet<lk1_HepaFilterType> lk1_HepaFilterType { get; set; }
        //public virtual DbSet<lk1_Hood_Makers> lk1_Hood_Makers { get; set; }
        //public virtual DbSet<lk1_Hood_Model_Parts> lk1_Hood_Model_Parts { get; set; }
        //public virtual DbSet<lk1_Hood_Models> lk1_Hood_Models { get; set; }
        //public virtual DbSet<lk1_Hood_Parts> lk1_Hood_Parts { get; set; }
        //public virtual DbSet<lk1_Inactive_Reasons> lk1_Inactive_Reasons { get; set; }
        //public virtual DbSet<lk1_Laboratories> lk1_Laboratories { get; set; }
        //public virtual DbSet<lk1_OrderPart_Status> lk1_OrderPart_Status { get; set; }
        //public virtual DbSet<lk1_PC_Reference> lk1_PC_Reference { get; set; }
        //public virtual DbSet<lk1_Positions> lk1_Positions { get; set; }
        //public virtual DbSet<lk1_Report_Type> lk1_Report_Type { get; set; }
        //public virtual DbSet<lk1_Schedule_Events> lk1_Schedule_Events { get; set; }
        //public virtual DbSet<lk1_SOP_Content> lk1_SOP_Content { get; set; }
        //public virtual DbSet<lk1_TaskTypeCode> lk1_TaskTypeCode { get; set; }
        //public virtual DbSet<lk1_Test_Standards> lk1_Test_Standards { get; set; }
        //public virtual DbSet<lk1_Testing_Error_Types> lk1_Testing_Error_Types { get; set; }
        //public virtual DbSet<lk2_Contract_Terms> lk2_Contract_Terms { get; set; }
        //public virtual DbSet<lk2_Group_Codes> lk2_Group_Codes { get; set; }
        //public virtual DbSet<lk2_Hood_Classes_Types> lk2_Hood_Classes_Types { get; set; }
        //public virtual DbSet<lk2_Project_Categories> lk2_Project_Categories { get; set; }
        //public virtual DbSet<lk2_States> lk2_States { get; set; }
        //public virtual DbSet<lk3_Date_Formats> lk3_Date_Formats { get; set; }
        //public virtual DbSet<lk3_Microlab_Project_Dual_Samples> lk3_Microlab_Project_Dual_Samples { get; set; }
        //public virtual DbSet<lk3_Microlab_Test_Codes> lk3_Microlab_Test_Codes { get; set; }
        //public virtual DbSet<lk3_Microorganisms> lk3_Microorganisms { get; set; }
        //public virtual DbSet<lk3_Rate_Factors> lk3_Rate_Factors { get; set; }
        //public virtual DbSet<lk3_Rate_Types> lk3_Rate_Types { get; set; }
        //public virtual DbSet<lk3_Regions> lk3_Regions { get; set; }
        //public virtual DbSet<lk3_SOP_User_Matrix> lk3_SOP_User_Matrix { get; set; }
        //public virtual DbSet<lk3_Training_SOP_Matrix> lk3_Training_SOP_Matrix { get; set; }
        //public virtual DbSet<lk3_Training_Task_Matrix> lk3_Training_Task_Matrix { get; set; }
        //public virtual DbSet<lk3_Training_User_Matrix> lk3_Training_User_Matrix { get; set; }
        //public virtual DbSet<sys_OCI_Log> sys_OCI_Log { get; set; }
        //public virtual DbSet<sys_OCI_Payments> sys_OCI_Payments { get; set; }
        //public virtual DbSet<sys_OCI_Users> sys_OCI_Users { get; set; }
        //public virtual DbSet<sys_Order_Statuses> sys_Order_Statuses { get; set; }
        //public virtual DbSet<sys_Users> sys_Users { get; set; }
        //public virtual DbSet<sys_Users_Info> sys_Users_Info { get; set; }
        //public virtual DbSet<sys_Users_Log> sys_Users_Log { get; set; }
        //public virtual DbSet<sys_Users_Password_History> sys_Users_Password_History { get; set; }
        //public virtual DbSet<sys_Users_Regions> sys_Users_Regions { get; set; }
        //public virtual DbSet<sys_Users_Roles> sys_Users_Roles { get; set; }
        //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        //public virtual DbSet<DAT_NEXT_ID> DAT_NEXT_ID { get; set; }
    }
}
