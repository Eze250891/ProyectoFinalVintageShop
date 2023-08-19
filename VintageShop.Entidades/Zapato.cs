namespace VintageShop.Entidades
{
    public class Zapato
    {
        public int Id { get; set; }
        public int IdTalle { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public string Imagen { get; set; }

        public HashSet<Talle> Talles { get; set; } = new HashSet<Talle>();

    }
}