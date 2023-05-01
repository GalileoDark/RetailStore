using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Usuario
{
    private string usuario;
    private string contraseña;
    private string nombre;
    private string apellidos;
    private string telefono;
    private string dni;
    public List<Producto> WhisList { get; set; }


    public string hacerReseña()
    {
        return "";
    }

    public void AddToWhisList()
    {
        return;
    }
}
public class Pedido
{
    public int IDPedido;
    public Dictionary<Producto, int> Carrito;
    public DateTime FechaPedido;
    public float PrecioFinal;
    public Usuario Usuario;



    public float calcularPrecioFinal()
    {
        return 0;
    }

    public object addToCarrito(Producto producto, int cantidad)
    {
        return addToCarrito;
    }

    public float finalizarCompra()
    {
        return 0;
    }
}

public class Producto
{
    public int ID;
    public bool Visibilidad;
    public string Nombre;
    public string Marca;
    public string Imagen;
    public string Descripcion;
    public List<string> Etiquetas;
    public float PrecioBase;
    public string Categoria;
    public string SubCategoria;
    public float Descuento;
    public List<Valoracion> Valoraciones;

    public Producto(int id, bool visibilidad, string nombre, string marca, string imagen, string descripcion, List<string> etiquetas, float precioBase, string categoria, string subcategoria, float descuento, List<Valoracion> valoraciones)
    {
        ID = id;
        Visibilidad = visibilidad;
        Nombre = nombre;
        Marca = marca;
        Imagen = imagen;
        Descripcion = descripcion;
        Etiquetas = etiquetas;
        PrecioBase = precioBase;
        Categoria = categoria;
        SubCategoria = subcategoria;
        Descuento = descuento;
        Valoraciones = valoraciones;
    }

    public float CalcularPrecioDescuento()
    {
        return 0;
    }

    public float CalcularValoracion()
    {
        return 0;
    }

    public bool IndicarVisibilidad(bool visible)
    {
        return false;
    }
}

public class Valoracion
{
    public int Puntuacion;
    public string Reseña;
    public Usuario Usuario;
    public Pedido Pedido;


}
public class ProductoEspecializado : Producto
{
    public string SubSubCategoria;
    public ProductoEspecializado(int id, bool visibilidad, string nombre, string marca, string imagen, string descripcion,
                             List<string> etiquetas, float precioBase, string categoria, string subcategoria, float descuento,
                             List<Valoracion> valoraciones, string subSubCategoria) : base(id, visibilidad, nombre, marca, imagen, descripcion,
                                                                                             etiquetas, precioBase, categoria, subcategoria, descuento,
                                                                                             valoraciones)
    {
        SubSubCategoria = subSubCategoria;
    }



}
