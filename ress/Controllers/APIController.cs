using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace res.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        // GET: api/<APIController>
        [HttpGet]
        public IActionResult Get()
        {
            var data = new List<Dictionary<string, object>>
{
    new Dictionary<string, object>
    {
        ["Test ID (case_id)"] = "TC_001",
        ["Source ID (sourceId)"] = "DOC_123",
        ["Source Doc (sourceDoc)"] = "Login Spec",
        ["Test Input (query)"] = "ผู้ใช้กรอก username/password ถูกต้อง",
        ["Expected Output (expected)"] = "ระบบเข้าสู่หน้า Dashboard",
        ["Category (category)"] = "Functional",
        ["Difficulty (difficulty)        RAG Params (JSON)"] = "Easy",
        ["Status (NEW/RUN/DONE)"] = "DONE",
        ["Run ID"] = "RUN_2025_11_12_01",
        ["Created At"] = "2025-11-12 9:45"
    },
    new Dictionary<string, object>
    {
        ["Test ID (case_id)"] = "TC_002",
        ["Source ID (sourceId)"] = "DOC_123",
        ["Source Doc (sourceDoc)"] = "Login Spec",
        ["Test Input (query)"] = "ผู้ใช้กรอก password ผิด 3 ครั้ง",
        ["Expected Output (expected)"] = "ระบบแสดงข้อความ “บัญชีถูกล็อก”",
        ["Category (category)"] = "Security",
        ["Difficulty (difficulty)        RAG Params (JSON)"] = "Medium",
        ["Status (NEW/RUN/DONE)"] = "NEW",
        ["Run ID"] = "–",
        ["Created At"] = "2025-11-12 9:46"
    },
    new Dictionary<string, object>
    {
        ["Test ID (case_id)"] = "TC_003",
        ["Source ID (sourceId)"] = "DOC_456",
        ["Source Doc (sourceDoc)"] = "Payment Spec",
        ["Test Input (query)"] = "ชำระเงินด้วยบัตรหมดอายุ",
        ["Expected Output (expected)"] = "ระบบแจ้งเตือน “บัตรหมดอายุ”",
        ["Category (category)"] = "Validation",
        ["Difficulty (difficulty)        RAG Params (JSON)"] = "Hard",
        ["Status (NEW/RUN/DONE)"] = "RUN",
        ["Run ID"] = "RUN_2025_11_12_02",
        ["Created At"] = "2025-11-12 9:50"
    }
};


            return Ok(data);
        }


    }
}
