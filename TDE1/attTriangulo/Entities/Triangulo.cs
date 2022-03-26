namespace attTriangulo.Entities
{
    public class Triangulo
    {
        decimal Altura;
        decimal Base;
        decimal Area;

        public Triangulo(decimal Altura, decimal Base){
            this.Altura = Altura;
            this.Base = Base;
        }

        public decimal calculo(decimal Altura, decimal Base){
            return Area = (Altura * Base) / 2;
        }

        public decimal getAltura()
        {
            return this.Altura;
        }

        public decimal getBase()
        {
            return this.Base;
        }
    }
}