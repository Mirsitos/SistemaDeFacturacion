CREATE DATABASE Facturacion;
USE Facturacion;

CREATE TABLE Clientes (
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    cedula VARCHAR(50),
    gmail VARCHAR(100),
    telefono VARCHAR(100),
    direccion VARCHAR(100),
    PRIMARY KEY (cedula)
);

CREATE TABLE Empleados (
    usuario VARCHAR(50),
    contraseña VARCHAR(50),
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    cedula VARCHAR(50),
    posicion VARCHAR(50),
    gmail VARCHAR(100),
    PRIMARY KEY (cedula)
);

CREATE TABLE Proveedores (
    nombre VARCHAR(50),
    direccion VARCHAR(100),
    telefono VARCHAR(50),
    gmail VARCHAR(100),
    PRIMARY KEY (nombre)
);

CREATE TABLE Marcas(
    Nombre VARCHAR(255),
    Items INT,
    PRIMARY KEY (Nombre)
);
 
CREATE TABLE Categorias(
    Nombre VARCHAR(255),
    CantidadProductos INT,
    PRIMARY KEY (Nombre)
);

CREATE TABLE Almacenes(
    Nombre VARCHAR(255),
    CantidadProductos INT,
    PRIMARY KEY (Nombre)
);



CREATE TABLE Productos (
    CodigoProducto INT,
    Nombre VARCHAR(255),
    Cantidad INT,
    categoria VARCHAR(255),
    marca VARCHAR(255),
    almacen VARCHAR(255),
    PRIMARY KEY (CodigoProducto),
    FOREIGN KEY (marca) REFERENCES Marcas(Nombre),
    FOREIGN KEY (categoria) REFERENCES Categorias(Nombre),
    FOREIGN KEY (almacen) REFERENCES Almacenes(Nombre)
);

-- agregar empleados para login (unica forma de agg al sistema)
insert into Empleados (usuario, contraseña, nombre, apellido, cedula, posicion, gmail) values ('admin','admin','Mateus','Velazquez','5181175', 'Administrador','velazquez@gmail.com');
insert into Empleados (usuario, contraseña, nombre, apellido, cedula, posicion, gmail) values ('user','user','Elias','Medina','5908655', 'Administrador','medinaelias@gmail.com');

-- agg marcas (unica forma de agg al sistema) cargar siempre Items como 0 si n
insert into Marcas (Nombre, Items) values ('HP', 0);
insert into Marcas (Nombre, Items) values ('Samsung', 0);
insert into Marcas (Nombre, Items) values ('Huawei', 0);
insert into Marcas (Nombre, Items) values ('Acer', 0);
insert into Marcas (Nombre, Items) values ('Xiaomi', 0);

-- agg Categorias (unica forma de agg al sistema)cargar siempre cantidadProductos como 0 si nuevo 
insert into Categorias (Nombre, CantidadProductos) values ('Telefonos',0);
insert into Categorias (Nombre, CantidadProductos) values ('Teclados',0);
insert into Categorias (Nombre, CantidadProductos) values ('Impresoras',0);
insert into Categorias (Nombre, CantidadProductos) values ('Laptops',0);
insert into Categorias (Nombre, CantidadProductos) values ('Auriculares',0);

-- agg Almacenes (unica forma de agg al sistema) cargar siempre cantidadProductos como 0 si es un nuevo almacen
insert into Almacenes (Nombre, CantidadProductos) values ('Almacen1',0);
insert into Almacenes (Nombre, CantidadProductos) values ('Almacen2',0);
insert into Almacenes (Nombre, CantidadProductos) values ('Almacen3',0);
insert into Almacenes (Nombre, CantidadProductos) values ('Almacen4',0);
insert into Almacenes (Nombre, CantidadProductos) values ('Almacen5',0);

-- agg clientes para probar DGV
insert into Clientes (nombre, apellido, cedula, gmail, telefono, direccion) values ('German','Lares','5876503','lares@mail.com','0995123654','Direccion123');

-- agg Productos, mejor hecho en la interfaz
-- Si se agrega de esta forma, los campos de cantidad en categoria marca y almacen no se cargaran bien.
--insert into Productos (CodigoProducto,Nombre, Cantidad,categoria,marca,almacen) values (101,'Samsung S22',2,'Telefonos','Samsung','Almacen1'); 
--insert into Productos (CodigoProducto,Nombre, Cantidad,categoria,marca,almacen) values (102,'Teclado HP',8,'Teclados','HP','Almacen2');

-- agg Proveedores, mejor hecho en la interfaz
insert into Proveedores (nombre, direccion, telefono, gmail) values ('Nissei','Av. Adrián Jara esquina Rgto. Piribebuy.','+595 994 902 000','nissei@mail.com');



insert into Productos (CodigoProducto,Nombre, Cantidad,categoria,marca,almacen) values (101,'Samsung S22',2,'Telefonos','Samsung','Almacen1');
insert into Productos (CodigoProducto,Nombre, Cantidad,categoria,marca,almacen) values (102,'Teclado HP',8,'Teclados','HP','Almacen2');


-- Comandos Seleccion
SELECT * FROM  Clientes;
SELECT * FROM Empleados;
SELECT * FROM  Proveedores;

SELECT * FROM Categorias;
SELECT * FROM  Marcas;
SELECT * FROM Almacenes;

SELECT * FROM Productos;


/*
	Otros comandos:
    
UPDATE Categorias SET CantidadProductos = 678 WHERE Nombre = 'Impresoras';
DROP table Marcas;
ALTER TABLE Marcas ADD COLUMN Items INT;
DELETE FROM Marcas WHERE Nombre = 'Acer';

OBS:
para ser usable, cambiar el codigo en la clase "Conexion"
para que quede de acuerdo con la configuracion que le haya dado a su instancia de la base de datos
*/