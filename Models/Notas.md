-No se si sea necesario tener un id para historia clinica, ya que una mascota tiene una unica historia clinica(no se si puede tener varias.)
- En la tabla de historia clinica no es posible almacenar otras tablas, hay dos formas:
1- ahorrar espacio pero perder en velocidad de obtencion de datos, lo que se haria es crear tablas independientes para consultas ,alergias,traumatismos,transfusiones y operacios,
de esta forma, para obtener esos datos de una  mascota habria que ir a esas tablas y buscarlos por su id.
2- mas rapido para obtener los datos, pero se gasta mucho espacio, lo que se haria es crear para cada mascota las tablas de 
alergias,traumatismos,transfusiones y operacios, cada una con un id unico, y para cada mascota solo habria que buscar en su tabla,y como solo tienes los datos
de una mascota es mas rapido, pero se gasta mucho espacio.

por ahora me decidi por la opcion 1 y asumi que se puede tener varias historias clinicas asi que uso el id de historia clinica, que esto 
tambien me sirve para la proedad de navegacion, para hacer mas facil las consultas de las tablas.

como una historia clinica solo esta relacionada con una mascota, entonces uso el id de la historia clinica en vez del de la mascota,
no me acuerdo mucho de teoria en bd, por favor corrijanme cualquier cosa. le agregue una llave foranea a la historia clinica del id de la mascota,
asi que si tengo la historia clinica,tengo la mascota

