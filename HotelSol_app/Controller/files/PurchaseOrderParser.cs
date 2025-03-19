using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelSol.Controller.files
{
    public class PurchaseOrderParser
    {
        String purchaseOrderFilepath = "C:\\Users\\cesar\\SoftDev\\uoc\\dotnet\\HotelSol\\data\\PurchaseOrder.xml";
        //String purchaseOrderFilepath = "C:\\Users\\cesar\\SoftDev\\uoc\\dotnet\\HotelSol\\data\\PurchaseOrderMAL.xml";
        Boolean Error = false;
        String DescError = "";
        public PurchaseOrderParser() { }
        public PurchaseOrderParser(string path) {
            purchaseOrderFilepath = path;
        }

        /*
         * Devuelve el PartNumber de la PurchaseOrder
         */
        public List<string>? GetPartNumber()
        {
            IEnumerable<string>? partNos;
            List<string>? partNumList = null;
            try
            {
                XElement purchaseOrder = XElement.Load(purchaseOrderFilepath);
                partNos = from item in purchaseOrder.Descendants("Item")
                          select (string)item.Attribute("PartNumber");
                partNumList = partNos.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Error = true;
                DescError = ex.Message;
                partNos = null;
            }

            return partNumList;
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
