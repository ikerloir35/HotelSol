import xmlrpc.client
import os
import xml.etree.ElementTree as ET
import sys
"""
url = 'https://netcrew.odoo.com/'
db = 'netcrew'
password = '84e174bb619a8179248dba904ab4b15faaff17c3'

url = 'http://localhost:8069'
db = 'odoodb'
password = '7c3b74d37a2c78d9a12c72e535c313bdcd182661'
username = 'afloresca@uoc.edu'
"""

url = 'http://localhost:8069'
db = 'NETCREW'
#password = '7c3b74d37a2c78d9a12c72e535c313bdcd182661'
password = 'a582778bde4b87f0d123c982353ecdcc8914981b'
username = 'dbelles@uoc.edu'


common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
uid = common.authenticate(db, username, password, {})
models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))

print("Authenticated succesfully. User ID: ", uid)

n = len(sys.argv)

print("Argumentos pasados: " + str(n));
print(sys.argv[0])
print(sys.argv[1])
print(sys.argv[2])
#Si tenemos más dos argumentos intentamos la actualización (el primero [0] es el nombre del script)
if n >= 2:    
    idProd = sys.argv[1]
    qty = sys.argv[2]

    product = models.execute_kw(db, uid, password, 'product.product', 'search_read', [[('id', '=', idProd )]], {'fields' : ['id', 'name', 'description', 'list_price', 'qty_available', 'categ_id'] })

    print("Producto: " + str(product[0]["id"]))
    # calculamos la nueva cantidad restando la vendida por la que hay
    q = str(int(product[0]["qty_available"])  - int(qty, base = 10));
    print(q)
    
    change_id = models.execute_kw(db, uid, password, 'stock.change.product.qty', 'create', [{
                    'product_id': product[0]["id"],
                    'product_tmpl_id': idProd,
                    'new_quantity': q,
                    }])
    # print("Change_id: " + str(change_id))
    rc = models.execute_kw(db, uid, password, 'stock.change.product.qty', 'change_product_qty', [change_id])
    

    
         
 
 
