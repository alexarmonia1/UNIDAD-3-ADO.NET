using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UNIDAD_3_ADO.NET.Models;

public partial class PrimeraactividadContext : DbContext
{
    public PrimeraactividadContext()
    {
    }

    public PrimeraactividadContext(DbContextOptions<PrimeraactividadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Detallescompra> Detallescompras { get; set; }

    public virtual DbSet<Detallesfactura> Detallesfacturas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=primeraactividad;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__categori__6378C02068AFB654");

            entity.ToTable("categorias");

            entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");
            entity.Property(e => e.Nombrecategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombrecategoria");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__clientes__C2FF24BD5FD8C51F");

            entity.ToTable("clientes");

            entity.Property(e => e.ClienteId).HasColumnName("clienteID");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correoElectronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombrecompleto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombrecompleto");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__compras__CE37B4094CA845D0");

            entity.ToTable("compras");

            entity.Property(e => e.CompraId).HasColumnName("compraID");
            entity.Property(e => e.Fechacompra).HasColumnName("fechacompra");
            entity.Property(e => e.ProveedorId).HasColumnName("proveedorID");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__compras__proveed__5BE2A6F2");
        });

        modelBuilder.Entity<Detallescompra>(entity =>
        {
            entity.HasKey(e => e.DetallecompraId).HasName("PK__detalles__548A12DAE17DC012");

            entity.ToTable("detallescompra");

            entity.Property(e => e.DetallecompraId).HasColumnName("detallecompraID");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CompraId).HasColumnName("compraID");
            entity.Property(e => e.Costounitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("costounitario");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.ProductoId).HasColumnName("productoID");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Compra).WithMany(p => p.Detallescompras)
                .HasForeignKey(d => d.CompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesc__compr__5EBF139D");

            entity.HasOne(d => d.Producto).WithMany(p => p.Detallescompras)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesc__produ__5FB337D6");
        });

        modelBuilder.Entity<Detallesfactura>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__detalles__4C49966DDA4E245A");

            entity.ToTable("detallesfactura");

            entity.Property(e => e.DetalleId).HasColumnName("detalleID");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FacturaId).HasColumnName("facturaID");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.ProductoId).HasColumnName("productoID");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Factura).WithMany(p => p.Detallesfacturas)
                .HasForeignKey(d => d.FacturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesf__factu__5629CD9C");

            entity.HasOne(d => d.Producto).WithMany(p => p.Detallesfacturas)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesf__produ__571DF1D5");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__facturas__AAF903C16E07A454");

            entity.ToTable("facturas");

            entity.Property(e => e.FacturaId).HasColumnName("facturaID");
            entity.Property(e => e.ClienteId).HasColumnName("clienteID");
            entity.Property(e => e.Fechafactura).HasColumnName("fechafactura");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__facturas__client__52593CB8");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__producto__69E6E0B4FE5DB7EB");

            entity.ToTable("productos");

            entity.Property(e => e.ProductoId).HasColumnName("productoID");
            entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombreproducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreproducto");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Stock).HasColumnName("stock");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__productos__categ__4D94879B");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.ProveedorId).HasName("PK__proveedo__825325BD5D84953C");

            entity.ToTable("proveedores");

            entity.Property(e => e.ProveedorId).HasColumnName("proveedorID");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombreproveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreproveedor");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
