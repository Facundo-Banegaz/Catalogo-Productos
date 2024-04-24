# Presentacion del Catálogo de Productos
#Se creo un programa en Windows Forms en C# con una base de datos que permita realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) en un catálogo es una aplicación común en el desarrollo de software. A continuación, te proporcionaré una descripción general de cómo podrías implementar este programa:

#Nombre del programa: Catálogo de Productos

Descripción general:

El programa "Catálogo de Productos" es una aplicación de Windows Forms desarrollada en C# que permite a los usuarios gestionar un catálogo de productos, realizar operaciones CRUD en la base de datos y visualizar la información de los productos almacenados.

Características clave:

Pantalla principal:

Una interfaz de usuario con ventanas y formularios diseñados con Windows Forms para una experiencia de usuario amigable.
Conexión a la base de datos:

El programa se conecta a una base de datos SQL Server o SQLite, donde se almacenan los detalles de los productos. La conexión se establece utilizando ADO.NET.
Operaciones CRUD:

Crear (C): Los usuarios pueden agregar nuevos productos al catálogo proporcionando información como nombre, descripción, precio, y cantidad en stock. Al hacer clic en un botón "Agregar", se inserta un nuevo registro en la base de datos.

Leer (R): El catálogo se muestra en una cuadrícula o una lista, lo que permite a los usuarios buscar y visualizar los productos existentes. Los usuarios pueden hacer clic en un producto para ver más detalles.

Actualizar (U): Los usuarios pueden editar la información de los productos seleccionados y guardar los cambios en la base de datos. Los campos editables incluyen nombre, descripción, precio y cantidad en stock.

Eliminar (D): Los usuarios pueden eliminar productos del catálogo seleccionando un producto y haciendo clic en un botón "Eliminar".

Búsqueda y filtrado:

El programa permite a los usuarios buscar productos por nombre o filtrar productos por categorías.
Validación de datos:

Se implementa una validación de datos en formularios para garantizar que los campos requeridos estén completos y que los datos sean correctos antes de realizar operaciones de creación o actualización.
Notificaciones y mensajes de error:

Se proporcionan mensajes de notificación y error para informar a los usuarios sobre el éxito o el fracaso de las operaciones CRUD.


#Inicio de la aplicacion.


<img width="513" alt="inicio" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/2538b9e8-30d4-40d0-8baa-ce5e5a7cbba1">


#Pantalla principal en donde se encuentran contenidas las demas pantallas.
<img width="959" alt="catalogo" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/c1975e33-91c3-4fad-996e-e3ddf2e29251">


#La pantalla Articulo cuenta con  las operaciones CRUD (Crear, Leer, Actualizar y Eliminar)  cuales  son botones que contienen pantallas secundarias.

<img width="955" alt="pantalla-articulo" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/d6a4a14a-aae6-4ca4-b747-99b7faa119bf">

<img width="524" alt="img32" src="https://github.com/Facundo-Banegaz/Catalogo-Productos/assets/130815244/7c8c39d1-cad4-46b7-bdcf-63b87f5e41b0">
<img width="526" alt="im33" src="https://github.com/Facundo-Banegaz/Catalogo-Productos/assets/130815244/52fc51e2-f5ea-4b26-8d23-a65cd61fb4ff">

#Pantalla de Detalles.

<img width="683" alt="detalle" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/69a43bfc-9604-4fa7-80d4-2c765944c688">


#Filtro para facilitar la busquedas.
<img width="817" alt="filtro" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/34129669-b7eb-4c89-b99d-8f093c65584d">

#Pantalla Categoria cuenta con  las operaciones CRUD (Crear, Leer, Actualizar y Eliminar)  cuales  son botones que contienen pantallas secundarias.

<img width="960" alt="categoria" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/63c77687-8086-4008-8d79-03a0c1ff6532">




#Las pantallas de Marcas y Categorias tambien cuenta con  las operaciones CRUD (Crear, Leer, Actualizar y Eliminar)  cuales  son botones que contienen pantallas secundarias
<img width="959" alt="cargar-cat" src="https://github.com/Facundo-Banegaz/TP-Final-Nivel-2/assets/130815244/22e2a933-ec1e-4b8e-83a7-dddeb1110db4">



