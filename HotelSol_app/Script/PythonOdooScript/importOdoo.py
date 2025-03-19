import xmlrpc.client
import os
import xml.etree.ElementTree as ET
import sys

# Configuración de la conexión con Odoo
"""
url = 'https://netcrew.odoo.com/'
db = 'netcrew'
password = '84e174bb619a8179248dba904ab4b15faaff17c3'
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

model_name = 'product.product'
product = models.execute_kw(db, uid, password, model_name, 'search_read', [[]], {'fields' : ['id', 'name', 'description', 'list_price', 'qty_available', 'categ_id', 'sale_ok'] })

# construye el xml con la lista que ha llegado
root = ET.Element('products')
for item in product:
    if item["sale_ok"] :
        pr = ET.SubElement(root, 'product')
        ids = ET.SubElement(pr, "id")
        ids.text = str(item["id"])
        desc = ET.SubElement(pr, "description")
        desc.text = item["description"]
        name = ET.SubElement(pr, "name")
        name.text = item["name"]
        price = ET.SubElement(pr, "list_price")
        price.text = str(item["list_price"])    
        qty = ET.SubElement(pr, "qty_available")
        qty.text = str(item["qty_available"])    
        cat = ET.SubElement(pr, "categ_id")
        cat.text = str(item["categ_id"])


    
tree = ET.ElementTree(root)
tree.write('c:\\temp\\products.xml')
       
""" Imprimir resultados un archivo plano
sourceFile = open('c:\\temp\\products.txt', 'w')
print(product, file = sourceFile)
sourceFile.close()
 """
