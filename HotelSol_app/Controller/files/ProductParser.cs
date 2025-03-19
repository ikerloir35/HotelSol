using HotelSol.Model;
using System.Configuration;
using System.Xml.Linq;

namespace HotelSol.Controller.files
{
    public class ProductParser
    {
        String productFilepath = ConfigurationManager.AppSettings["rutaXML"] + "\\" + ConfigurationManager.AppSettings["productFile"];
        Boolean Error = false;
        String DescError = "";

        public ProductParser() { }
        public ProductParser(string path) {
            productFilepath = path;
        }

        /*
         * Devuelve el PartNumber de la PurchaseOrder
         */
        public List<Producto>? GetProductList()
        {
            List<Producto> productList = new List<Producto>();

            try
            {
                XDocument product = XDocument.Load(productFilepath);
                
                foreach (var item in product.Descendants("product"))
                {
                    Producto pr = new Producto();
                    try
                    {
                        pr.idOdoo = Int32.Parse(item.Element("id").Value);
                        pr.list_price = Double.Parse(item.Element("list_price").Value.Replace('.', ','));
                        pr.qty_available = Double.Parse(item.Element("qty_available").Value.Replace('.',','));
                        pr.description = item.Element("description").Value;
                        pr.name = item.Element("name").Value;
                        productList.Add(pr);
                    }
                    catch {
                        pr.idOdoo = 0;
                        pr.list_price = 0;
                        pr.qty_available = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Error = true;
                DescError = ex.Message;
            }

            return productList;
        }

        public Boolean errorEnLectura()
        {
            return Error;
        }

        public String getDescripcionError()
        {
            return DescError;
        }

    }
}
