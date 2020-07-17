using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using OnlineStore.Model;
using System.Data;
using Microsoft.AspNetCore.Cors;

namespace OnlineStore.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        // GET: api/Products/5
        [HttpGet(Name ="GetAll")]
        public List<Product> Get()
        {
            SqlCommand command = null;
            SqlConnection conn = null;
            string query = string.Empty, firstCell = string.Empty;
            SqlDataReader sqlDataReader = null;
            Product product = null;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            System.Data.DataTable dataTable = new DataTable();

            List<Product> productslist = new List<Product>();

            try
            {

                using (conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=tcp:nextsql01.database.windows.net,1433;Initial Catalog=tramatix;Persist Security Info=False;User ID=next;Password=SQLcloud4411;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                    conn.Open();

                    query = "select * from products";
                     
                    command = new SqlCommand(query, conn);

                    sqlDataAdapter.SelectCommand = command;
                    sqlDataAdapter.Fill(dataTable);

                   

                    //sqlDataReader = command.ExecuteReader();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {

                        productslist = (from model in dataTable.AsEnumerable()
                                        select new Product()
                                        {
                                            Id = model.Field<int>("id"),
                                            Name = model.Field<string>("name"),
                                            Color = model.Field<string>("color"),
                                            Price = model.Field<decimal>("price"),
                                            Description = model.Field<string>("description"),
                                            CreatedDate = model.Field<DateTime>("createdDate"),
                                            ModelNumber = model.Field<int>("modelNumber"),
                                            Video = model.Field<string>("video"),
                                            Image1 = model.Field<string>("image2"),
                                            Image2 = model.Field<string>("image2"),
                                            Image3 = model.Field<string>("image3"),
                                            Image4 = model.Field<string>("image4"),
                                            Category = model.Field<string>("category"),
                                            CompanyName = model.Field<string>("companyName")


                                        }).ToList();

                    }



       
                    }



                


            }
            catch(Exception ex)
            {

            }


            return productslist;
        }

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
