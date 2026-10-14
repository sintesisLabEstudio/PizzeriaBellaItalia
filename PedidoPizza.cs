using System;

namespace PizzeriaBellaItalia.Dominio;



public class PedidoPizza
{
    // Propiedades auto-implementadas de la entidad
    public string Cliente { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string TamanoNombre { get; set; } = "Mediana";
    public int PrecioBaseTamano { get; set; } = 8500;
    public string MasaNombre { get; set; } = "Masa Tradicional";
    public int RecargoMasa { get; set; } = 0;

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
    private const double TASA_DESCUENTO = 0.10; // 10%
    private const double TASA_IVA = 0.19;        // 19% IVA chileno

    // --------------------------------------------------------------------
    // CONSTRUCTORES SOBRECARGADOS (OVERLOADING)
    // --------------------------------------------------------------------

    /// <summary>
    /// Constructor 1: Por defecto (sin parámetros).
    /// Permite inicializar la entidad vacía o utilizar sintaxis de inicializadores de objetos.
    /// </summary>
    public PedidoPizza()
    {
    }

    /// <summary>
    /// Constructor 2: Esencial.
    /// Recibe los datos obligatorios del cliente y las selecciones de tamaño y masa.
    /// </summary>
    public PedidoPizza(string cliente, string telefono, string tamanoNombre, int precioBaseTamano, string masaNombre, int recargoMasa)
    {
        Cliente = cliente;
        Telefono = telefono;
        TamanoNombre = tamanoNombre;
        PrecioBaseTamano = precioBaseTamano;
        MasaNombre = masaNombre;
        RecargoMasa = recargoMasa;
    }

    /// <summary>
    /// Constructor 3: Completo.
    /// Inicializa absolutamente todas las propiedades de la pizza en una única instrucción.
    /// </summary>
    public PedidoPizza(
        string cliente,
        string telefono,
        string tamanoNombre,
        int precioBaseTamano,
        string masaNombre,
        int recargoMasa,
        bool quesoExtra,
        bool pepperoni,
        bool champinones,
        bool aceitunas,
        bool tocino,
        bool esDelivery,
        bool aplicaConvenioEstudiante)
        : this(cliente, telefono, tamanoNombre, precioBaseTamano, masaNombre, recargoMasa)
    {
        QuesoExtra = quesoExtra;
        Pepperoni = pepperoni;
        Champinones = champinones;
        Aceitunas = aceitunas;
        Tocino = tocino;
        EsDelivery = esDelivery;
        AplicaConvenioEstudiante = aplicaConvenioEstudiante;
    }

    // --------------------------------------------------------------------
    // MÉTODOS DE CÁLCULO Y LÓGICA DE NEGOCIO
    // --------------------------------------------------------------------
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
