using Microsoft.EntityFrameworkCore;
using VintageShop.Entidades;

namespace VintageShop.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Zapato> Zapatos { get; set; }
        public DbSet<Talle> Talles { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<FormaDePago> FormaDePagos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //--------Usuarios--------
            modelBuilder.Entity<Usuario>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Nombre)
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Apellido)
                .IsRequired();

            modelBuilder.Entity<Usuario>()
               .Property(x => x.Email)
               .IsRequired();


            //--------Zapato--------

            modelBuilder.Entity<Zapato>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Modelo)
               .IsRequired();

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Precio)
               .IsRequired();

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Imagen);

            modelBuilder.Entity<Zapato>()
                        .HasOne(x => x.Marca)
                        .WithMany(m => m.ZapatosList)
                        .HasForeignKey(x => x.IdMarca);

            //modelBuilder.Entity<Zapato>()
            //            .HasOne(x => x.TallesList)
            //            .WithMany(m => m)



            //--------Talle--------

            modelBuilder.Entity<Talle>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Talle>()
                .Property(x => x.TalleNumero);

            modelBuilder.Entity<Talle>()
                        .HasOne(x => x.Zapato)
                        .WithMany(m => m.TallesList)
                        .HasForeignKey(x => x.IdZapato);
                       

            //--------Pago--------

            modelBuilder.Entity<Pago>()
                        .HasKey(x => x.Id);

            modelBuilder.Entity<Pago>()
                        .Property(x => x.IdFormaDePago)
                        .IsRequired();

            modelBuilder.Entity<Pago>()
                        .HasOne(fp => fp.FormaDePagoUtilizada)
                        .WithMany(fp => fp.Pagos)
                        .HasForeignKey(x => x.IdFormaDePago);

            modelBuilder.Entity<Pago>()
                        .HasOne(z => z.ZapatoSeleccionado)
                        .WithMany(p => p.PagoUtilizado)
                        .HasForeignKey(x => x.IdPrecioZapato);



            //--------FormaDePago--------

            modelBuilder.Entity<FormaDePago>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<FormaDePago>()
                .Property(x => x.Descripcion)
                .IsRequired();

            //--------Marca--------

            modelBuilder.Entity<Marca>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Marca>()
                .Property(x => x.Nombre)
                .IsRequired();

            //--------Stock--------

            modelBuilder.Entity<Stock>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Stock>()
                .Property(x => x.IdZapato)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .Property(x => x.IdTalle)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .Property(x => x.Cantidad)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                        .HasOne(z => z.Zapato)
                        .WithMany(s => s.StocksList)
                        .HasForeignKey(t =>t.IdTalle);
                        




        }
    }
}