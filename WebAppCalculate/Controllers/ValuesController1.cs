//using Microsoft.AspNetCore.Mvc;
//using WebAppCalculate.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace WebAppCalculate.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController : ControllerBase
//    {
//        // GET: api/<ValuesController>
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<ValuesController>/5
//        [HttpGet("{id}")]
//        public IActionResult Get(int id)
//        {
//            try
//            {
//                //ConnectDB connDB = new ConnectDB();
//                //String sqlStr = "SELECT * FROM user WHERE id =" + id.ToString();
//                //DataTable dTable = connDB.Query(sqlStr);

//                DataTable dTable = new DataTable();
//                dTable.Columns.Add("Name", typeof(String));
//                dTable.Columns.Add("Email", typeof(String));

//                DataRow dRow = dTable.NewRow();
//                dRow["Name"] = "Nuttha";
//                dRow["Email"] = "Nuttha@gmail.com";
//                dTable.Rows.Add(dRow);

//                dRow = dTable.NewRow();
//                dRow["Name"] = "Nuttha2";
//                dRow["Email"] = "Nuttha222@gmail.com";
//                dTable.Rows.Add(dRow);

//                // Convert DataTable to JSON - friendly structure
//                var jsonResult = DataTableToList(dTable);

//                //return Ok(jsonResult);  // Return JSON result
//                return new JsonResult(new { fullName = "test", nickName = "testnickname" });
//            }
//            catch (Exception ex)
//            {

//                return StatusCode(500, ex.Message);
//            }

//        }

//        // POST api/<ValuesController>
//        //[HttpPost]
//        //public void Post([FromBody] string value)
//        //{

//        //}

//        [HttpPost]
//        public IActionResult Post([FromBody] PersonModel value)
//        {
//            return Ok(new { fullName = value.Name });
//        }

//        // PUT api/<ValuesController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {

//        }

//        // DELETE api/<ValuesController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }

//        // GET api/<ValuesController>/getuniqueid/5
//        [HttpGet("getuniqueid/{id}")]
//        public IActionResult GetUnique(int id)
//        {
//            return Ok(new { fullName = "UniqueBig", data = id });
//        }

//        // Helper method to convert DataTable to List<Dictionary<string, object>>
//        private List<Dictionary<string, object>> DataTableToList(DataTable dt)
//        {
//            var list = new List<Dictionary<string, object>>();

//            foreach (DataRow row in dt.Rows)
//            {
//                var dict = new Dictionary<string, object>();
//                foreach (DataColumn col in dt.Columns)
//                {
//                    using Microsoft.AspNetCore.Mvc;
//                    using MyAPI.Models;
//                    using System;
//                    using System.Collections.Generic;
//                    using System.Data;
//                    using System.Linq;
//                    using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace MyAPI.Controllers
//    {
//        [Route("api/[controller]")]
//        [ApiController]
//        public class ValuesController : ControllerBase
//        {
//            // GET: api/<ValuesController>
//            [HttpGet]
//            public IEnumerable<string> Get()
//            {
//                return new string[] { "value1", "value2" };
//            }

//            // GET api/<ValuesController>/5
//            [HttpGet("{id}")]
//            public IActionResult Get(int id)
//            {
//                try
//                {
//                    //ConnectDB connDB = new ConnectDB();
//                    //String sqlStr = "SELECT * FROM user WHERE id =" + id.ToString();
//                    //DataTable dTable = connDB.Query(sqlStr);

//                    DataTable dTable = new DataTable();
//                    dTable.Columns.Add("Name", typeof(String));
//                    dTable.Columns.Add("Email", typeof(String));

//                    DataRow dRow = dTable.NewRow();
//                    dRow["Name"] = "Nuttha";
//                    dRow["Email"] = "Nuttha@gmail.com";
//                    dTable.Rows.Add(dRow);

//                    dRow = dTable.NewRow();
//                    dRow["Name"] = "Nuttha2";
//                    dRow["Email"] = "Nuttha222@gmail.com";
//                    dTable.Rows.Add(dRow);

//                    // Convert DataTable to JSON - friendly structure
//                    var jsonResult = DataTableToList(dTable);

//                    //return Ok(jsonResult);  // Return JSON result
//                    return new JsonResult(new { fullName = "test", nickName = "testnickname" });
//                }
//                catch (Exception ex)
//                {

//                    return StatusCode(500, ex.Message);
//                }

//            }

//            // POST api/<ValuesController>
//            //[HttpPost]
//            //public void Post([FromBody] string value)
//            //{

//            //}

//            [HttpPost]
//            public IActionResult Post([FromBody] PersonModel value)
//            {
//                return Ok(new { fullName = value.Name });
//            }

//            // PUT api/<ValuesController>/5
//            [HttpPut("{id}")]
//            public void Put(int id, [FromBody] string value)
//            {

//            }

//            // DELETE api/<ValuesController>/5
//            [HttpDelete("{id}")]
//            public void Delete(int id)
//            {
//            }

//            // GET api/<ValuesController>/getuniqueid/5
//            [HttpGet("getuniqueid/{id}")]
//            public IActionResult GetUnique(int id)
//            {
//                return Ok(new { fullName = "UniqueBig", data = id });
//            }

//            // Helper method to convert DataTable to List<Dictionary<string, object>>
//            private List<Dictionary<string, object>> DataTableToList(DataTable dt)
//            {
//                var list = new List<Dictionary<string, object>>();

//                foreach (DataRow row in dt.Rows)
//                {
//                    var dict = new Dictionary<string, object>();
//                    foreach (DataColumn col in dt.Columns)
//                    {
//                        dict[col.ColumnName] = row[col];
//                    }
//                    list.Add(dict);
//                }

//                return list;
//            }
//        }
//    }

//    dict[col.ColumnName] = row[col];
//                }
//                list.Add(dict);
//            }

//            return list;
//        }
//    }
//}
