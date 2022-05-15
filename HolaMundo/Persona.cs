namespace HolaMundo
{
    public class Persona
    {
        //Para propiedades usen PascalCase
        public string Nombre { get; set; }
        public short Edad { get; set; }
        public double Dinero { get; set; }
        public char Inicial { get; set; }

        //nombres de parametros en metodos van en camelCase
        public Persona(string nombre, short edad, double dinero)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
            //Parsing
            Inicial = char.Parse(Nombre.Substring(0,1));
        }

        public string SalirACaminar()
        {
            return $"{Nombre} está saliendo a caminar";
        }

        public string Comprar(double precio)
        {
            Dinero = Dinero - precio;
            return $"Has gastado {precio} pesos, eso te deja con {Dinero} pesos";
        }

        public string CreaMensajeCompleto()
        {
            return $"Hola Mundo soy {Nombre} y mi edad es de {Edad} años y mi fortuna es de {Dinero} " +
                    $"pesos y mi inicial es {Inicial}";
        }
    }
}
