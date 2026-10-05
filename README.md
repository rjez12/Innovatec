# Parque Tecnológico Innovatec

Aplicación de escritorio para representar la organización de un parque tecnológico y las rutas entre sus edificios. El proyecto separa la lógica de árboles y grafos de la interfaz de Windows Forms.

## Funciones

- Construye una jerarquía organizativa con un árbol general: agrega personas bajo un jefe, busca nombres, cuenta integrantes, calcula niveles y muestra un recorrido en preorden.
- Representa las rutas como un grafo no dirigido y ponderado mediante listas de adyacencia.
- Muestra conexiones, verifica la conectividad con BFS y calcula rutas mínimas con Dijkstra.
- Compara nombres de edificios y personas sin distinguir mayúsculas de minúsculas.

## Tecnología y ejecución

- C# y Windows Forms sobre .NET Framework 4.7.2.
- Requiere Windows y Visual Studio 2022 con soporte para .NET Framework 4.7.2.
- Abre `Innovatec.sln`, compila y ejecuta el proyecto desde Visual Studio.

## Estructura

| Archivo | Responsabilidad |
| --- | --- |
| `Innovatec/Clases/LogicaArbol.cs` | Modelo de nodos y operaciones recursivas del árbol. |
| `Innovatec/Clases/LogicaGrafos.cs` | Lista de adyacencia, conectividad y ruta mínima. |
| `Innovatec/Form1.cs` | Eventos de la interfaz y presentación de resultados. |
| `Innovatec/Informe/Informe.md` | Explicación del diseño y ejemplos del proyecto. |

## Alcance y límites

Los datos se mantienen en memoria mientras la aplicación está abierta; el proyecto no persiste cambios en una base de datos o archivo. Dijkstra presupone distancias no negativas, pero la lógica actual no valida ese requisito al agregar rutas. El repositorio incluye un informe técnico con un ejemplo de camino entre edificios.
