using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers
{
    public class ProductsController : ApiController
    {

        //Services for Product service API

        //GET: ProductsAPI/GetProducts
       // [Route=("ProductsAPI/GetProducts")]
        public HttpResponseMessage GetProducts()
        {
            var employees = Productdetailrepository.GetAllProducts();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        // GET: ProductsAPI/GetProdbyId/5
        [Route("ProductsAPI/GetProdbyId/1001")]
        public HttpResponseMessage GetProdbyId(int id)
        {
            var employees = Productdetailrepository.GetProduct(id);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        

        // PUT: api/Products/5
        [Route("ProductsAPI/Updatedetailst/")]
        public HttpResponseMessage Updatedetailst(ProductforItem e)
        {
            var employees = Productdetailrepository.UpdateProducts(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        
    }
}
