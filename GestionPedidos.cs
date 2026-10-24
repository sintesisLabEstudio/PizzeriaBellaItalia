using System;
using System.Globalization;
namespace PizzeriaBellaItalia.Dominio;

public class GestionPedidos
{
    //LISTA DE PEDIDOS
    public List<PedidoPizza> pedidos = new List<PedidoPizza>(); //Instalacia clase con objeto PedidoPiza

    //METODO
    public void AgregarPedido(PedidoPizza pedido)
    {
        pedidos.Add(pedido);
    }

}
