import xmlrpc.client
import os
import xml.etree.ElementTree as ET

# Configuración de la conexión con Odoo
url = 'https://netcrew.odoo.com/'
db = 'netcrew'
username = 'ilopezir@uoc.edu'
password = '7a132266bd68756e03ec8eab756479b42737da88'

common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
uid = common.authenticate(db, username, password, {})
models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))

print("Authenticated succesfully. User ID: ", uid)

#Parsear el XML

tree = ET.parse('E:\\NETCREW\\HotelSol\\data\\XMLParaERP\\datosClientes.xml')
root = tree.getroot()

print("cliente parseado")

for cliente in root.findall('Cliente'):
    # Obtener datos del cliente del XML
    nombre = cliente.find('Nombre').text
    apellido1 = cliente.find('Apellido1').text
    apellido2 = cliente.find('Apellido2').text
    document_id = cliente.find('DocumentId').text
    telefono = cliente.find('Telefono').text
    mail = cliente.find('Mail').text
    nacionalidad = cliente.find('Nacionalidad').text
    #observaciones = cliente.find('Observaciones').text
    #tipo_cliente = cliente.find('TipoCliente').text
    num_tarjeta = cliente.find('numTarjeta').text
    direccion = cliente.find('Direccion')
    calle1 = direccion.find('Calle1').text
    calle2 = direccion.find('Calle2').text
    cp = direccion.find('CP').text
    localidad = direccion.find('Localidad').text
    pais = direccion.find('Pais').text
    
         
    # Crear un diccionario de datos del cliente
    cliente_data = {
        'name': nombre + ' ' + apellido1 + ' ' + apellido2,
        'x_studio_nif': document_id,
        'phone': telefono,
        'email': mail,
        'country_id': 68,
        #'comment': observaciones,
        #'category_id': tipo_cliente,
        'street': calle1,
        'street2': calle2,
        'city': localidad,
        'zip': cp,
    }
    # El argumento 6 indica que queremos reemplazar todas las relaciones existentes.
    # El argumento 0 indica que no se eliminarán registro existentes antes de agregar los nuevos.
    
    # Eliminar campos con valor None
    cliente_data = {k: v for k, v in cliente_data.items() if v is not None}
    
    # Crear un registro de cliente en Odoo
    cliente_id = models.execute_kw(db, uid, password, 'res.partner', 'create', [cliente_data])

    print("Cliente creado con ID:", cliente_id)
    
    # Crear un registro en res.partner.bank
    bank_data = {
        'acc_number': 'ES49 0000 ' + num_tarjeta,
        'partner_id': cliente_id,  # Establecer el ID del cliente como titular de la cuenta bancaria
    }
    bank_id = models.execute_kw(db, uid, password, 'res.partner.bank', 'create', [bank_data])

    print("Tarjeta creada con ID:", bank_id)
 
