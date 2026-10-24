using System;
using System.Globalization;
namespace PizzeriaBellaItalia.Dominio;  
public class PedidoPizza
{
    // 1 -------------------------------------------------------------------- INPUTS
    //CLIENTE
    public string Cliente { get; set; } = string.Empty; //VALORES POR DEFECTO
    public string Telefono { get; set; } = string.Empty; // Propiedades auto-implementadas de la entidad
    //TAMAÑO
    public string TamanoNombre { get; set; } = "Mediana";
    public int PrecioBaseTamano { get; set; } = 8500;
    //MASA
    public string MasaNombre { get; set; } = "Masa Tradicional";
    public int RecargoMasa { get; set; } = 0;
    //ADICIONALES (Checkboxes)
    public bool QuesoExtra { get; set; } = false;
    public bool Pepperoni { get; set; }=false;
    public bool Champinones { get; set; } = false;
    public bool Aceitunas { get; set; } = false;
    public bool Tocino { get; set; } = false;
    //RECEPCION entrega
    public bool EsDelivery { get; set; }
    public bool AplicaConvenioEstudiante { get; set; }
    // 2 --------------------------------------------------------------------- CONSTANTES
    // CONSTANTES
    private const int PRECIO_INGREDIENTE_EXTRA = 800;  // Constantes de negocio
    private const int RECARGO_DELIVERY = 2000;
    private const double TASA_DESCUENTO = 0.10; // 10%
    private const double TASA_IVA = 0.19;        // 19% IVA chileno
    // 3 ---------------------------------------------------------------------- MÉTODOS 
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
