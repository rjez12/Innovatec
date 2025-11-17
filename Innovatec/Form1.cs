using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec
{
    public partial class Form1 : Form
    {
        private ArbolJerarquia arbol;
        private GrafoRutas grafo;
        public Form1()
        {
            InitializeComponent();

            arbol = new ArbolJerarquia();
            grafo = new GrafoRutas();

            // Mensaje inicial de ayuda
            lblResultadoJerarquia.Text = "Agregue la raíz (Director) para empezar.\nDeje 'Nombre del Jefe' vacío.";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string jefe = tbJefe.Text;
            string nombre = tbNuevoEmpleado.Text;
            string cargo = tbNuevoCargo.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Por favor, ingrese nombre y cargo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exito;
            if (arbol.Raiz == null && string.IsNullOrWhiteSpace(jefe))
            {
                // Es el primer empleado
                exito = arbol.AgregarEmpleado(null, nombre, cargo);
                lblResultadoJerarquia.Text = $"{nombre} agregado como la raíz.";
            }
            else
            {
                exito = arbol.AgregarEmpleado(jefe, nombre, cargo);
                if (exito)
                {
                    lblResultadoJerarquia.Text = $"{nombre} agregado bajo {jefe}.";
                }
                else
                {
                    if (arbol.Raiz == null)
                        MessageBox.Show($"Debe agregar la raíz primero (deje 'Nombre del Jefe' vacío).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show($"No se encontró al jefe '{jefe}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ActualizarTreeView();

            // Limpiar y preparar para el siguiente
            tbNuevoEmpleado.Clear();
            tbNuevoCargo.Clear();
            tbJefe.Text = nombre; // Sugerir al recién agregado como próximo jefe
            tbNuevoEmpleado.Focus(); // Poner el cursor listo para el siguiente nombre
        }
        private void ActualizarTreeView()
        {
            tvMostrar.Nodes.Clear();
            if (arbol.Raiz != null)
            {
                TreeNode nodoRaizVisual = new TreeNode(arbol.Raiz.TextoNodo);
                LlenarNodosTreeView(arbol.Raiz, nodoRaizVisual);
                tvMostrar.Nodes.Add(nodoRaizVisual);
                tvMostrar.ExpandAll(); // Mostrar todo el árbol
            }
        }

        // Función recursiva que construye el TreeView
        private void LlenarNodosTreeView(NodoOrganizacion nodoLogico, TreeNode nodoVisual)
        {
            foreach (var hijoLogico in nodoLogico.Subordinados)
            {
                TreeNode hijoVisual = new TreeNode(hijoLogico.TextoNodo);
                nodoVisual.Nodes.Add(hijoVisual);

                // Llamada recursiva para los empleados de este empleado
                LlenarNodosTreeView(hijoLogico, hijoVisual);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = tbEmpleados.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                lblResultadoJerarquia.Text = "Por favor, ingrese un nombre para buscar.";
                return;
            }

            NodoOrganizacion encontrado = arbol.Buscar(nombre);

            if (encontrado != null)
            {
                lblResultadoJerarquia.Text = $"Encontrado: {encontrado.Nombre} ({encontrado.Cargo})";
                // Opcional: Seleccionar el nodo en el TreeView
                SeleccionarNodoEnTreeView(tvMostrar.Nodes, encontrado.Nombre);
            }
            else
            {
                lblResultadoJerarquia.Text = $"Empleado '{nombre}' no encontrado.";
            }
        }

        // Función para seleccionar el nodo en el TreeView después de buscar
        private bool SeleccionarNodoEnTreeView(TreeNodeCollection nodos, string nombre)
        {
            foreach (TreeNode nodo in nodos)
            {
                // Extraemos el nombre del texto
                string nombreNodo = nodo.Text.Split('(')[0].Trim();
                if (nombreNodo.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    tvMostrar.SelectedNode = nodo;
                    nodo.EnsureVisible();
                    return true;
                }
                if (SeleccionarNodoEnTreeView(nodo.Nodes, nombre)) return true;
            }
            return false;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = arbol.ContarEmpleados();
            lblResultadoJerarquia.Text = $"Total de empleados: {total}";
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            string nombre = tbNivel.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                lblResultadoJerarquia.Text = "Por favor, ingrese un nombre para ver su nivel.";
                return;
            }

            int nivel = arbol.ObtenerNivel(nombre);

            if (nivel != -1)
            {
                lblResultadoJerarquia.Text = $"{nombre} está en el nivel: {nivel}";
            }
            else
            {
                lblResultadoJerarquia.Text = $"Empleado '{nombre}' no encontrado.";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                lblResultadoJerarquia.Text = "El árbol está vacío.";
                return;
            }
            lblResultadoJerarquia.Text = "Recorrido Pre-Orden:\n" + arbol.ObtenerRecorridoPreOrden();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string origen = tbOrigen.Text;
            string destino = tbDestino.Text;
            int distancia = (int)numDistancia.Value;

            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino) || distancia <= 0)
            {
                MessageBox.Show("Ingrese origen, destino y una distancia válida (> 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (origen.Equals(destino, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El origen y el destino no pueden ser el mismo edificio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grafo.AgregarRuta(origen, destino, distancia);
            lblRuta.Text = $"Ruta agregada: {origen} <-> {destino} ({distancia}m)";

            ActualizarCombosEdificios(); // Actualizar listas

            // Limpiar campos
            tbOrigen.Clear();
            tbDestino.Clear();
            numDistancia.Value = 10;
            tbOrigen.Focus();
        }

        // Esta función rellena los ComboBox con la lista de edificios
        private void ActualizarCombosEdificios()
        {
            List<string> edificios = grafo.ObtenerTodosLosEdificios();

            // Guardar selecciones actuales para no perderlas
            string selOrigen = (string)cbOrigen.SelectedItem;
            string selDestino = (string)cbDestino.SelectedItem;
            string selConexiones = (string)cbConexiones.SelectedItem;

            cbOrigen.Items.Clear();
            cbDestino.Items.Clear();
            cbConexiones.Items.Clear();

            foreach (var edificio in edificios)
            {
                cbOrigen.Items.Add(edificio);
                cbDestino.Items.Add(edificio);
                cbConexiones.Items.Add(edificio);
            }

            // Restaurar selecciones si aún existen en la lista
            if (edificios.Contains(selOrigen)) cbOrigen.SelectedItem = selOrigen;
            if (edificios.Contains(selDestino)) cbDestino.SelectedItem = selDestino;
            if (edificios.Contains(selConexiones)) cbConexiones.SelectedItem = selConexiones;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string origen = (string)cbOrigen.SelectedItem;
            string destino = (string)cbDestino.SelectedItem;

            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                MessageBox.Show("Seleccione un origen y un destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = grafo.ObtenerRutaMasCorta(origen, destino);
            lblRuta.Text = resultado;
        }

        private void btnConexiones_Click(object sender, EventArgs e)
        {
            string edificio = (string)cbConexiones.SelectedItem;
            if (string.IsNullOrWhiteSpace(edificio))
            {
                MessageBox.Show("Seleccione un edificio para ver sus conexiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRuta.Text = grafo.MostrarConexiones(edificio);
        }

        private void btnConexo_Click(object sender, EventArgs e)
        {
            if (grafo.ObtenerTodosLosEdificios().Count == 0)
            {
                lblRuta.Text = "El grafo está vacío.";
                return;
            }

            bool conexo = grafo.EsConexo();
            if (conexo)
            {
                lblRuta.Text = "El grafo SÍ es conexo.\n(Se puede llegar de cualquier edificio a cualquier otro).";
            }
            else
            {
                lblRuta.Text = "El grafo NO es conexo.\n(Hay edificios aislados o 'islas' de edificios).";
            }
        }
    }
}

