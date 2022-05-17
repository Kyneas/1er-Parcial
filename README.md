## Flujo de programa

El programa tiene harcodeados tanto Alimentos, como usuarios y mesas para poder ser utilizados en su primer uso. Al momento de hacer la carga de un pedido se hacen copias tanto de las listas del sistema como de la posición para que puedan ser modificadas sin alterar los valores originales. Estos cambios solo se aplican al momento de confirmar el pedido o cerrar la mesa.
Solo los administradores pueden borrar elementos de una mesa abierta.
Además de eso pueden reponer stock, modificar precio, ver una lista de las ventas y guardarlas en un archivo txt, y agregar nuevos usuarios o borrar. El programa no permite que se borre un usuario de administrador si es el ultimo en el sistema.

## Temas utilizados

### Herencia
Las clases de alimento comparten atributos tales como el nombre y precio. Luego sus derivadas tienen compartimentos únicos, Comida y Bebida.

### Sobrecarga de constructores y métodos

El método para poder agregar elementos a las ListView fue sobrecargado ya que varia en base a la cantidad de elementos que quieran mostrarse.

### Propiedades

El el caso de las comidas se genero la propieda NombreCompleto que retorna en un string si es del tipo vegano o no.

### Colecciones

Todas las listas del sistema son del tipo Diccionario, por ejemplo con los usuario la key es un int que indica el DNI e impide que se repita.
Al momento de cargar una venta se crea una Lista de tipo Alimento que agrega los alimentos que la mesa pidió.

### Enumerados

En el caso de las bebidas se genero un enumerado que indica la presentación en la cual se presenta, en el caso de que sea lata o botella y la capacidad.

### Formularios modal.

Al momento de cerrar las ventas se abre un formulario modal en el que solo se puede confirmar o cancelar la operación.

### Clases estáticas

Todas las clases dentro de Sistema son estáticas, acá es donde se guardan los usuarios, la comida disponible, las mesas y las ventas.

### Polimorfismo

En la clase Alimento fue aplicado.
