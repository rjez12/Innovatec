using System;
using System.Collections.Generic;
using System.Text;
public class NodoOrganizacion
{
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    // Propiedad para mostrar en el TreeView
    public string TextoNodo => $"{Nombre} ({Cargo})";
    public List<NodoOrganizacion> Subordinados { get; set; }

    public NodoOrganizacion(string nombre, string cargo)
    {
        Nombre = nombre;
        Cargo = cargo;
        Subordinados = new List<NodoOrganizacion>();
    }
}

// Esta clase se encarga de manejar la logica del árbol
public class ArbolJerarquia
{
    public NodoOrganizacion Raiz { get; set; }

    //1. FUNCIÓN INSERTAR
    public bool AgregarEmpleado(string nombreJefe, string nombreNuevo, string cargoNuevo)
    {
        var nuevoNodo = new NodoOrganizacion(nombreNuevo, cargoNuevo);

        // Si el árbol está vacío, este es el primer nodo (la raíz)
        if (Raiz == null)
        {
            Raiz = nuevoNodo;
            return true;
        }

        // Buscar al jefe para agregarle el empleado
        NodoOrganizacion jefe = BuscarPrivado(Raiz, nombreJefe);
        if (jefe != null)
        {
            jefe.Subordinados.Add(nuevoNodo);
            return true;
        }

        return false; // No hay jefe
    }

    //2. FUNCIÓN BUSCAR
    public NodoOrganizacion Buscar(string nombre)
    {
        return BuscarPrivado(Raiz, nombre);
    }
    private NodoOrganizacion BuscarPrivado(NodoOrganizacion nodo, string nombre)
    {
        if (nodo == null) return null;

        // Compara ignorando mayúsculas/minúsculas
        if (nodo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
        {
            return nodo;
        }

        // Buscar en los hijos
        foreach (var hijo in nodo.Subordinados)
        {
            var encontrado = BuscarPrivado(hijo, nombre);
            if (encontrado != null) return encontrado;
        }
        return null;
    }

    // 3. FUNCIÓN CONTAR
    public int ContarEmpleados()
    {
        return ContarPrivado(Raiz);
    }

    // Función recursiva privada
    private int ContarPrivado(NodoOrganizacion nodo)
    {
        if (nodo == null) return 0;
        int count = 1; // Contarse a sí mismo
        foreach (var hijo in nodo.Subordinados)
        {
            count += ContarPrivado(hijo);
        }
        return count;
    }

    // 4. FUNCIÓN NIVELES
    // Función pública
    public int ObtenerNivel(string nombre)
    {
        // Llama a la función auxiliar recursiva, empezando en Nivel 1
        return EncontrarNivelPrivado(Raiz, nombre, 1);
    }

    private int EncontrarNivelPrivado(NodoOrganizacion nodo, string nombre, int nivelActual)
    {
        if (nodo == null) return -1; // No encontrado
        if (nodo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
        {
            return nivelActual; // Encontrado
        }

        foreach (var hijo in nodo.Subordinados)
        {
            int nivelEncontrado = EncontrarNivelPrivado(hijo, nombre, nivelActual + 1);
            if (nivelEncontrado != -1)
            {
                return nivelEncontrado; // Encontrado en una rama hija
            }
        }
        return -1; // No encontrado en esta rama
    }

    // 5. FUNCIÓN RECORRIDO
    public string ObtenerRecorridoPreOrden()
    {
        StringBuilder sb = new StringBuilder();
        RecorridoPreOrdenPrivado(Raiz, sb, 0);
        return sb.ToString();
    }

    private void RecorridoPreOrdenPrivado(NodoOrganizacion nodo, StringBuilder sb, int nivel)
    {
        if (nodo == null) return;

        // 1. Visita la Raíz (con indentación)
        sb.AppendLine($"{new string('-', nivel * 2)} {nodo.TextoNodo}");

        // 2. Recorre los hijos
        foreach (var hijo in nodo.Subordinados)
        {
            RecorridoPreOrdenPrivado(hijo, sb, nivel + 1);
        }
    }
}