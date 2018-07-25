using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ProductsAPI.Repositories
{
    public class Productdetailrepository
    {
        private static DataEntities dataContext = new DataEntities();

        public static List<ProductforItem> GetAllProducts()
        {
            var query = (from ProductforItems in dataContext.ProductforItems
                        select ProductforItems).ToList();

            // IQueryable<object> q = query.ToList();
            // List<object> l = new List<object>(query);
            //  return l;
            //return List<obj>1=new List<query>
            return query;

        }

        public static ProductforItem GetProduct(int productid)
        {
            var query = (from product in dataContext.ProductforItems
                         where product.Productid == productid &&
                        product.Active=="Y"
                        select product).SingleOrDefault();
           return query;
        }

        public static List<ProductforItem> UpdateProducts(ProductforItem e)
        {
            var pro = (from product in dataContext.ProductforItems
                       where product.Productid == e.Productid
                       select product).SingleOrDefault();
            pro.ProductName = e.ProductName;
            pro.ProductDesc=e.ProductDesc;
            pro.Quantity= e.Quantity;
            pro.UnitPrice = e.UnitPrice;
            //pro.Active = e.Active;
            dataContext.SaveChanges();
            return GetAllProducts();
        }

    }
}