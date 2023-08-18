namespace CoCWebForm.Models
{
    public class TestCodeBank
    {
        public readonly List<string> CATEGORY = new List<string> {
            "USP <797>",
            "USP <1116>",
            "USP <61>",
            "USP <1231>",
            "USP <85>",
            "USP <643>",
            "USP <645>",
            "USP <55>",
            "USP <825>"
        };

        public readonly List<ushort> TEST_CODE = new List<ushort> {
            100,101,110,111,200,201,202,210,211,212,300,213,400,112,113,500,  0,  1,505,510,501,  2,214,215,
            216,217,218,219,220,221,222,223,224,225,502,503,504,506,507,600,601,602,114,115,116,117,118,119,
            120,727,726,725,724,723,722,720,508,719,718,717,716,715,714,713,712,711,710,709,708,707,706,705,
            704,703,702,702,701,700,148,147,146,145,144,143,142,141,140,139,138,137,136,135,134,133,132,131,
            130,129,128,127,126,125,124,121,122,123
        };

        public readonly List<string> DESCRIPTION = new List<string> {
            "Single Media Dual Incubation",
            "Single Media Dual Incubation w/ ID",
            "Single Media Dual Incubation w/ no IDs",
            "Single Media Dual Incubation w/ ID 3-5 CFUs",
            "Single Media Dual Incubation w/ ID All CFUs",
            "Single Media Dual Incubation w/ Over Action/Alert Limits",
            "Single Media Dual Incubation w/ trending top 5 IDs",
            "Single Media Dual Incubation w/ over limit IDs",

            "Single Media Single Incubation",
            "Single Media Single Incubation w/ no IDs",
            "Single Media Single Incubation w/ ID 3-5 CFUs",
            "Single Media Single Incubation w/ ID All CFUs",
            "Single Media Single Incubation w/ Over Action/Alert Limits",

            "Dual Media Single Incubation",
            "Dual Media Single Incubation w/ ID",
            "Dual Media Single Incubation w/ ID 3-5 CFUs",
            "Dual Media Single Incubation w/ ID All CFUs",
            "Dual Media Single Incubation w/ Over Action/Alert Limits",
            "Dual Media Single Incubation w/ no IDs",
            "Dual Media Single Incubation w/ trending top 5 IDs",
            "Dual Media Single Incubation w/ over limit IDs",

            "Bioburden Single Media, Single Incubation",
            "Bioburden Single Media, Single Incubation w/ no IDs",
            "Bioburden Single Media, Single Incubation w/ ID 3-5 CFUs",
            "Bioburden Single Media, Single Incubation w/ ID All CFUs",
            "Bioburden Single Media, Single Incubation w/ Over Action/Alert Limits",

            "Biological Indicator Testing",
            "Total Organic Carbon Testing",
            "Conductivity Testing",
            "Total Organic Carbon and Conductivity Testing",
            "Species Identification",
            "Media Fill",
            "Endotoxin",
            "TOC/Conductivity",

            "2008 - Dual Media Single Incubation w/ ID",
            "2008 - Single Media Dual Incubation w/ ID",
            "2008 - Single Media Single Incubation w/ ID",
            "2008 - Media Fill",

            "2008 Special - Dual Media Single Incubation w/ ID",
            "2008 Special - Single Media Dual Incubation w/ ID",
            "2008 Special - Single Media Single Incubation w/ ID",

            "Special - Single Media Single Incubation ID All Growth",
            "Special - Single Media Single Incubation ID All Growth Over Limit",
            "Special - Single Media Single Incubation ID All Growth Plus Pathogenicity",
            "Special - Single Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",
            "Special - Single Media Dual Incubation ID All Growth",
            "Special - Single Media Dual Incubation ID All Growth Over Limit",
            "Special - Single Media Dual Incubation ID All Growth Plus Pathogenicity",

            "Special - Dual Media Single Incubation ID All Growth",
            "Special - Dual Media Single Incubation ID All Growth Over Limit",
            "Special - Dual Media Single Incubation ID All Growth Plus Pathogenicity",
            "Special - Dual Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",

            "Single Media Single Incubation ID All Growth",
            "Single Media Single Incubation ID All Growth Over Limit",
            "Single Media Single Incubation ID All Growth Plus Pathogenicity",
            "Single Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",
            "Single Media Dual Incubation ID All Growth",
            "Single Media Dual Incubation ID All Growth Over Limit",
            "Single Media Dual Incubation ID All Growth Plus Pathogenicity",
            "Single Media Dual Incubation ID All Growth Over Limit  Plus Pathogenicity",

            "Media Fill ID All Growth",
            "Media Fill ID All Growth Over Limit",
            "Media Fill ID All Growth Plus Pathogenicity",
            "Media Fill ID All Growth Over Limit Plus Pathogenicity",

            "Dual Media Single Incubation ID All Growth",
            "Dual Media Single Incubation ID All Growth Over Limit",
            "Dual Media Single Incubation ID All Growth Plus Pathogenicity",
            "Dual Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",

            "2023 Special - Single Media Single Incubation ID All Growth",
            "2023 Special - Single Media Single Incubation ID All Growth Over Limit",
            "2023 Special - Single Media Single Incubation ID All Growth Plus Pathogenicity",
            "2023 Special - Single Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",
            "2023 Special - Single Media Dual Incubation ID All Growth",
            "2023 Special - Single Media Dual Incubation ID All Growth Over Limit",
            "2023 Special - Single Media Dual Incubation ID All Growth Plus Pathogenicity",

            "2023 Special - Dual Media Single Incubation ID All Growth",
            "2023 Special - Dual Media Single Incubation ID All Growth Over Limit",
            "2023 Special - Dual Media Single Incubation ID All Growth Plus Pathogenicity",
            "2023 Special - Dual Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",

            "2023 - Single Media Single Incubation ID All Growth",
            "2023 - Single Media Single Incubation ID All Growth Over Limit",
            "2023 - Single Media Single Incubation ID All Growth Plus Pathogenicity",
            "2023 - Single Media Single Incubation ID All Growth Over Limit Plus Pathogenicity",
            "2023 - Single Media Dual Incubation ID All Growth",
            "2023 - Single Media Dual Incubation ID All Growth Over Limit",
            "2023 - Single Media Dual Incubation ID All Growth Plus Pathogenicity",
            "2023 - Single Media Dual Incubation ID All Growth Over Limit  Plus Pathogenicity",

            "2023 - Media Fill ID All Growth",
            "2023 - Media Fill ID All Growth Over Limit",
            "2023 - Media Fill ID All Growth Plus Pathogenicity",
            "2023 - Media Fill ID All Growth Over Limit Plus Pathogenicity",

            "2023 - Dual Media Single Incubation ID All Growth",
            "2023 - Dual Media Single Incubation ID All Growth Over Limit",
            "2023 - Dual Media Single Incubation ID All Growth Plus Pathogenicity",
            "2023 - Dual Media Single Incubation ID All Growth Over Limit Plus Pathogenicity"
        };
    }
}
