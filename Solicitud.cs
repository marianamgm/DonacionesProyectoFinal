using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

internal class Solicitud
{
    private int solicitud_id;
    private int usuario_id;
    private string nombre;
    private string categoria;
    private string telefono;
    private string email;
    private string domicilio;
    private string curp;
    private string descripcion;
    private int id_producto;
    private string nombre_producto;
    private int id_categoria;
    private string nombre_categoria;

    // Constructor vacío
    public Solicitud() { }

    // Constructor para nombre
    public Solicitud(string nombre)
    {
        this.nombre = nombre;
    }

    // Constructor para producto-categoría
    public Solicitud(int id_producto, string nombre_producto, int id_categoria, string nombre_categoria)
    {
        this.id_producto = id_producto;
        this.nombre_producto = nombre_producto;
        this.id_categoria = id_categoria;
        this.nombre_categoria = nombre_categoria;
    }

    // Constructor completo
    public Solicitud(int solicitud_id, int usuario_id, string nombre, string categoria, string telefono, string email, string domicilio, string curp, string descripcion)
    {
        this.solicitud_id = solicitud_id;
        this.usuario_id = usuario_id;
        this.nombre = nombre;
        this.categoria = categoria;
        this.telefono = telefono;
        this.email = email;
        this.domicilio = domicilio;
        this.curp = curp;
        this.descripcion = descripcion;
    }

    // Propiedades
    public int SolicitudId { get => solicitud_id; set => solicitud_id = value; }
    public int UsuarioId { get => usuario_id; set => usuario_id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Categoria { get => categoria; set => categoria = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Email { get => email; set => email = value; }
    public string Domicilio { get => domicilio; set => domicilio = value; }
    public string Curp { get => curp; set => curp = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
}
