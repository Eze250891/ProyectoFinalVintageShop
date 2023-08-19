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
                .Property(x => x.IdTalle);

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Modelo)
               .IsRequired();

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Precio)
               .IsRequired();

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Imagen);

            //--------Talle--------

            modelBuilder.Entity<Talle>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Talle>()
                .Property(x => x.TalleNumero);

            //--------Pago--------

            modelBuilder.Entity<Pago>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Pago>()
                .Property(x => x.IdFormaDePago)
                .IsRequired();

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

        }
    }
}