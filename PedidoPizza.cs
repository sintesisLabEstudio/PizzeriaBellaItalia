using System;

namespace PizzeriaBellaItalia.Dominio;

public class PedidoPizza
{
    // Propiedades de la entidad del pedido
    public string Cliente { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string TamanoNombre { get; set; } = string.Empty;
    public int PrecioBaseTamano { get; set; }
    public string MasaNombre { get; set; } = string.Empty;
    public int RecargoMasa { get; set; }

    // Adicionales (Checkboxes)
    public bool QuesoExtra { get; set; }
    public bool Pepperoni { get; set; }
    public bool Champinones { get; set; }
    public bool Aceitunas { get; set; }
    public bool Tocino { get; set; }

    // Opciones de entrega y beneficio
    public bool EsDelivery { get; set; }
    public bool AplicaConvenioEstudiante { get; set; }

    // Constantes de negocio
    private const int PRECIO_INGREDIENTE_EXTRA = 800;
    private const int RECARGO_DELIVERY = 2000;
    private const double TASA_DESCUENTO = 0.10;
    private const double TASA_IVA = 0.19;

    // Métodos de cálculo en la Capa de Dominio
    public int ContarIngredientesExtra()
    {
        int total = 0;
        if (QuesoExtra) total++;
        if (Pepperoni) total++;
        if (Champinones) total++;
        if (Aceitunas) total++;
        if (Tocino) total++;
        return total;
    }

    public int CalcularCostoIngredientes()
    {
        return ContarIngredientesExtra() * PRECIO_INGREDIENTE_EXTRA;
    }

    public int CalcularSubtotalPizza()
    {
        // Subtotal Base = Precio del Tamaño (SelectedValue) + Recargo de Masa (SelectedValue) + Ingredientes
        return PrecioBaseTamano + RecargoMasa + CalcularCostoIngredientes();
    }

    public int CalcularMontoDescuento()
    {
        return AplicaConvenioEstudiante ? (int)(CalcularSubtotalPizza() * TASA_DESCUENTO) : 0;
    }

    public int CalcularCostoDelivery()
    {
        return EsDelivery ? RECARGO_DELIVERY : 0;
    }

    public int CalcularNetoAfecto()
    {
        return (CalcularSubtotalPizza() - CalcularMontoDescuento()) + CalcularCostoDelivery();
    }

    public int CalcularMontoIva()
    {
        return (int)(CalcularNetoAfecto() * TASA_IVA);
    }

    public int CalcularTotalPagar()
    {
        return CalcularNetoAfecto() + CalcularMontoIva();
    }

    public override string ToString()
    {
        return $"{Cliente} | {TamanoNombre} ({MasaNombre}) -> Total: $ {CalcularTotalPagar():N0} CLP";
    }
}
