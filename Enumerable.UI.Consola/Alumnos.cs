namespace Enumerable.UI.Consola
{
    public class Alumnos
    {
        public int Matricula {  get; set; }
        public String? Nombre {  get; set; }
        public decimal Precio {  get; set; }


        public override string ToString()
        {
            return $"{Matricula}\t{Nombre}\t{Precio:c2}";
        }
    }
}
