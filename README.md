#Presentacion

=Componentes Principales=
Si bien ya existen demasiadas librerias e implementaciones propias por parte de la misma MS. para la API de persistencia de datos, con este proyecto se intenta:
  # unificar la interaccion con distintos SGBD, y tambien
  # ser totalmente manipulable y adaptable por cualquier persona con conocimientos basicos de programacion en .NET.-


= Detalles =

La libreria tiene como pilares principales las siguientes clases:
  * Una clase de utileria para cada _SGBD_, en la que se centralizan las operaciones propias que se realizan contra una base de datos, las clases _*`*`Utiles*.-
  * Una clase base para definicion de Estructura de Tablas que  a su vez hace de _"VO"_ (o _DTO_) _*OTDbase*_, y
  * Una clase base para Administrar la interaccion con las Tablas, la clase _*ADMbase*_, que hace de _"DAO"_.

= Bâsico =
La libreria como tal en su version actual (v3) fue desarrollada pensando en facilitar y unificar las tareas de acceso a los datos de los diferentes motores de bases de datos con los que trabajamos en la empresa para la cual trabajo, tomando como referencias los ORM's de otros lenguajes de programacion, como Hibernate/JPA de Java y SQL Alchemy de Python.-

Aun esta en etapa de desarrollo, pues quedan por resolver muchas cuestiones como las relaciones entre tablas por medio de los accesores sin necesidad de ejecutas las llamadas a los metodos de los administradores de las tablas relacionadas, o el hecho de poder realizar referencias a los campos a traves de las propiedades de las clases VO's para asi poder escribir sentencias tipo Linq o HQL.
