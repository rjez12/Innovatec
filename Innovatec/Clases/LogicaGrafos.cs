
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 

public class GrafoRutas
{
    // se usó Listas de Adyacencia
    // Diccionario: NombreEdificio -> Diccionario de conexiones (Destino, Distancia)
    private Dictionary<string, Dictionary<string, int>> adyacencia =
        new Dictionary<string, Dictionary<string, int>>();

    // Función auxiliar para añadir un edificio si no existe
    private void AgregarEdificio(string nombre)
    {
        // Compara ignorando mayúsculas/minúsculas al agregar
        string nombreNormalizado = nombre.Trim();
        if (!adyacencia.Keys.Any(k => k.Equals(nombreNormalizado, StringComparison.OrdinalIgnoreCase)))
        {
            adyacencia[nombreNormalizado] = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        }
    }

    // Función auxiliar para obtener el nombre "oficial" (con mayúsculas correctas)
    private string ObtenerNombreOficial(string nombre)
    {
        string nombreNormalizado = nombre.Trim();
        return adyacencia.Keys.FirstOrDefault(k => k.Equals(nombreNormalizado, StringComparison.OrdinalIgnoreCase)) ?? nombreNormalizado;
    }


    // 1. FUNCIÓN AGREGAR ARISTAS
    public void AgregarRuta(string origen, string destino, int distancia)
    {
        // Normalizar nombres para evitar duplicados como "Edificio A" y "edificio a"
        string origenOficial = ObtenerNombreOficial(origen);
        string destinoOficial = ObtenerNombreOficial(destino);

        AgregarEdificio(origenOficial);
        AgregarEdificio(destinoOficial);

       
        adyacencia[origenOficial][destinoOficial] = distancia;
        adyacencia[destinoOficial][origenOficial] = distancia;
    }

    // Función auxiliar para que el formulario llene los ComboBox
    public List<string> ObtenerTodosLosEdificios()
    {
        return new List<string>(adyacencia.Keys);
    }

    // 2. FUNCIÓN MOSTRAR CONEXIONES
    public string MostrarConexiones(string edificio)
    {
        string edificioOficial = ObtenerNombreOficial(edificio);
        if (!adyacencia.ContainsKey(edificioOficial))
        {
            return $"El edificio '{edificio}' no existe.";
        }
        if (adyacencia[edificioOficial].Count == 0)
        {
            return $"El edificio '{edificio}' no tiene conexiones.";
        }

        var sb = new StringBuilder();
        sb.AppendLine($"Conexiones de {edificioOficial}:");
        foreach (var conexion in adyacencia[edificioOficial])
        {
            // conexion.Key es el destino, conexion.Value es la distancia
            sb.AppendLine($" - {conexion.Key} (Distancia: {conexion.Value}m)");
        }
        return sb.ToString();
    }

    // 3. FUNCIÓN VALIDAR CONEXIDAD
    public bool EsConexo()
    {
        if (adyacencia.Count == 0) return true; // Un grafo vacío se considera conexo

        var visitados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var cola = new Queue<string>();

        // Empezar el recorrido desde el primer edificio
        string nodoInicial = adyacencia.Keys.First();
        cola.Enqueue(nodoInicial);
        visitados.Add(nodoInicial);

        while (cola.Count > 0)
        {
            string actual = cola.Dequeue();
            foreach (var vecino in adyacencia[actual])
            {
                if (!visitados.Contains(vecino.Key))
                {
                    visitados.Add(vecino.Key);
                    cola.Enqueue(vecino.Key);
                }
            }
        }

        // Si el número de nodos visitados es igual al total de nodos, es conexo
        return visitados.Count == adyacencia.Count;
    }


    // 4. FUNCIÓN RUTA MÁS CORTA (Dijkstra)
    public string ObtenerRutaMasCorta(string inicio, string fin)
    {
        string inicioOficial = ObtenerNombreOficial(inicio);
        string finOficial = ObtenerNombreOficial(fin);

        var distancias = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var previo = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var nodosNoVisitados = new List<string>();
        var sbResultado = new StringBuilder();

        foreach (var edificio in adyacencia.Keys)
        {
            distancias[edificio] = int.MaxValue; // Distancia "infinita"
            previo[edificio] = null;
            nodosNoVisitados.Add(edificio);
        }

        // La distancia al punto de partida es 0
        if (distancias.ContainsKey(inicioOficial))
            distancias[inicioOficial] = 0;
        else
            return $"El edificio de inicio '{inicio}' no existe."; // Validación

        while (nodosNoVisitados.Count > 0)
        {
            // Encontrar el nodo no visitado con menor distancia
            nodosNoVisitados.Sort((a, b) => distancias[a].CompareTo(distancias[b]));
            string actual = nodosNoVisitados[0];
            nodosNoVisitados.RemoveAt(0);

            // Si llegamos al destino, terminamos
            if (actual.Equals(finOficial, StringComparison.OrdinalIgnoreCase)) break;

            // Si el nodo más cercano sigue siendo "infinito", no hay ruta
            if (distancias[actual] == int.MaxValue) break;

            // Revisar vecinos
            foreach (var vecino in adyacencia[actual])
            {
                int distanciaAlternativa = distancias[actual] + vecino.Value;
                if (distanciaAlternativa < distancias[vecino.Key])
                {
                    distancias[vecino.Key] = distanciaAlternativa;
                    previo[vecino.Key] = actual;
                }
            }
        }

        // --- Reconstruir camino ---
        if (!distancias.ContainsKey(finOficial) || distancias[finOficial] == int.MaxValue)
        {
            return $"No hay ruta disponible de {inicio} a {fin}.";
        }

        var camino = new List<string>();
        string paso = finOficial;
        while (paso != null)
        {
            camino.Add(paso);
            previo.TryGetValue(paso, out paso); // Ir al nodo "previo"
        }
        camino.Reverse(); // Invertir para mostrarlo desde el inicio

        sbResultado.AppendLine($"Ruta más corta de {inicioOficial} a {finOficial}:");
        sbResultado.AppendLine(string.Join(" -> ", camino));
        sbResultado.AppendLine($"Distancia total: {distancias[finOficial]}m");

        return sbResultado.ToString();
    }
}