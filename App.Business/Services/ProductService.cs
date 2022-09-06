using App.Data;
using App.Data.DBContext;

namespace App.Business.Services
{
    public class ProductService
    {
        private readonly AppDBContext _dBContext;

        public ProductService(AppDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public List<Product> GetProductList()
        {
            var productList = new List<Product> {
                    new Product
                    {
                        Id = 1,
                        Title = "Product1",
                        Src = "https://gw.alipayobjects.com/zos/rmsportal/JiqGstEfoWAOHiTxclqi.png"
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Product2",
                        Src = "https://gw.alipayobjects.com/zos/rmsportal/JiqGstEfoWAOHiTxclqi.png"
                    }
            };

            return productList;
        }
        //public void Add(Product product)
        //{
        //    Console.WriteLine(product.src + " eklendi.");
        //}

        //public void Update(Product product)
        //{
        //    Console.WriteLine(product.Id + " güncellendi.");
        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}