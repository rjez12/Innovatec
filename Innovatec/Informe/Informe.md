Informe: Parque Tecnológico Innovatec

Introducción:

Este informe técnico presenta el desglose, en palabras sencillas, de cómo se desarrolló el proyecto del Parque Tecnológico Innovatec.

Se tenia que cumplir con estos dos objetivos:

Organizar Personas: Crear un sistema de jerarquía para saber quién reporta a quién. (Un Árbol).

Conectar Lugares: Encontrar la mejor ruta para ir de un edificio a otro. (Un Grafo).

Así es como se logró, separando el "cerebro" (la lógica) del "rostro" (el formulario de Windows Forms).

Parte A: El Árbol (La Jerarquía Organizativa)

1. Enfoque de Diseño

El problema era simple: un organigrama. En un organigrama siempre hay un solo jefe en la cima (la Raíz) y esa persona tiene subordinados, que a su vez tienen sus propios subordinados.

La Decisión Clave: No se utilizó un árbol binario. ¿Por qué? Porque un jefe (como un Gerente) no está limitado a tener solo dos empleados. Puede tener 1 o 50. Por eso, la clase NodoOrganizacion usa una List<NodoOrganizacion> llamada Subordinados. Es una lista que puede crecer tanto como sea necesario.

2. Funcionamiento de la Lógica (LogicaArbol.cs)

AgregarEmpleado: Esta función primero se asegura de que, si el árbol está vacío, el primer empleado sea la Raíz. Si ya hay una raíz, busca al jefe (usando la función BuscarPrivado) y simplemente añade al nuevo empleado a su lista de Subordinados.

BuscarPrivado: Esta es la magia de la recursividad. Es como si el Director le preguntara a sus Gerentes: "¿Alguno de ustedes es 'Pedro'?". Si ellos dicen "no", le preguntan a sus propios subordinados. El proceso se repite "hacia abajo" hasta que alguien lo encuentra o se acaba la gente.

ContarPrivado y EncontrarNivelPrivado: Usan la misma lógica recursiva. Para contar, cada nodo se suma a sí mismo (1) y luego le pide a sus hijos que se cuenten.

3. Interfaz de Usuario (Form1.cs)

Para la parte visual, se utilizó el control TreeView. Es la herramienta perfecta para esto. La función ActualizarTreeView es un "traductor" que lee el árbol lógico y lo "dibuja" en el TreeView del formulario, permitiendo al usuario expandir y colapsar las jerarquías visualmente.

Parte B: El Grafo (Las Rutas del Parque)

Esta fue una de las partes más desafiantes del proyecto.

1. Enfoque de Diseño

El reto era modelar un mapa como un Grafo No Dirigido y Ponderado.

No Dirigido: Si puedes ir de A a B, puedes ir de B a A.

Ponderado: El camino de A a B tiene un "peso" o costo (en este caso, metros de distancia).

La Decisión Clave (Lista de Adyacencia): No se utilizó una Matriz. ¿Por qué? Una matriz es un desperdicio de memoria si tienes 100 edificios y solo unas pocas conexiones.
Se implementó una Lista de Adyacencia. En C#, la forma más elegante de hacer esto es con un Diccionario de Diccionarios:

Dictionary<string, Dictionary<string, int>> adyacencia;

2. El Bug Inesperado (y su Solución)

Se detectó un problema: durante las pruebas, el programa trataba a "Cafeteria" y "cafeteria" como dos edificios completamente diferentes. Esto rompía todos los cálculos de rutas.

La Solución: Se aplicó una corrección crucial en LogicaGrafo.cs. Al crear los diccionarios, se configuró C# para que ignorara mayúsculas y minúsculas.

// Esta línea fue la clave del éxito:
new Dictionary<string, ...>(StringComparer.OrdinalIgnoreCase);


Después de esto, el grafo empezó a funcionar como se esperaba.

3. Funciones Clave (LogicaGrafo.cs)

EsConexo (El Detector de Islas): Esta función es clave. Utiliza un recorrido (BFS) para "caminar" por el grafo desde un punto de inicio. Si al final del recorrido, el número de edificios visitados es igual al total de edificios, ¡el parque está conectado! Si no, significa que hay "islas" (edificios o grupos de edificios) a los que no se puede llegar.

ObtenerRutaMasCorta (El Algoritmo de Dijkstra): Esta es la función principal del grafo. No solo busca rutas directas (las que se agregaron), sino que calcula la ruta óptima aunque no exista una conexión directa.

Ejemplo Práctico (El Ejemplo del Puente):

Se agrega la "Isla A": Area de Juegos <-> Estacionamiento (100m).

Se agrega la "Isla B": Callcenter <-> Oficina (50m).

En este punto, EsConexo diría "FALSO" y ObtenerRutaMasCorta de "Area de Juegos" a "Callcenter" fallaría.

Se agrega el "Puente": Estacionamiento <-> Oficina (20m).

Ahora, EsConexo dice "VERDADERO".

Cuando se pide la ruta de Area de Juegos a Callcenter, Dijkstra "piensa" y provee el camino óptimo:
Area de Juegos -> Estacionamiento -> Oficina -> Callcenter (Distancia total: 170m).

Conclusiones

Este proyecto constituyó un ejercicio práctico y completo. La separación de la lógica (los archivos .cs del "cerebro") y la presentación (el Form1.cs) fue fundamental. El desafío de las mayúsculas/minúsculas en el grafo demostró la importancia de manejar las entradas del usuario, y la implementación de Dijkstra demostró cómo un algoritmo puede encontrar soluciones "inteligentes" que no son obvias a simple vista.