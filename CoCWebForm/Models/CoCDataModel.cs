﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoCWebForm.Models
{
    public class CoCDataModel
    {
        public LoginModel LoginModel { get; set; }
        public Guid Id { get; set; }
        [DisplayName("Project Id")]
        public string ServiceOrder { get; set; }
        public TestCode TestCode { get; set; }
        public string SpecialInstructions { get; set; }
        public string TssOffice { get; set; }
        public List<Sample> Samples { get; set; }
        public DateTime SampleCollectionDate { get; set; }
        public string ViableSampler { get; set; }
        public string TechnicianName { get; set; }
        public DateTime SignatureTimeStamp { get; set; }
        public string TrackingNumber { get; set; }
    }

    public enum TestCode
    {
        // TestCodes go here for drop-down
    }

    public class Sample
    {
        public string SampleId { get; set; }
        public string MediaType { get; set; }
        public string IsoClass { get; set; }
        public string SampleType { get; set; }
        public int MediaLotNumber { get; set; }
        public string SampleVol { get; set; }
    }
}
