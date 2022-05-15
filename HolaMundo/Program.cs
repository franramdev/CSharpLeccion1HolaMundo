// See https://aka.ms/new-console-template for more information
using HolaMundo;


//string es para guardar texto

string Nombre = "Francisco";
//el string permite hacer substrings que son pedazos del texto
string primerosTresCaracteres = Nombre.Substring(0, 3);

//short es para numeros chiquitos, int para medianos, y long para grandes
short edadenshort = 28;
int edad = 28;
long dinero = 9000000000000000000;

//char es para guardar un único caracter
char primeraLetra = 'F';

//double es para guardar numeros con decimales y decimal es para lo mismo, pero permite más exactitud
double dineroConDecimalesChiquito = 12500.4234324324324234324342;
decimal dineroConDecimales = 12500.53123132132132132123132131321321321231156165156M;

//El booleano solo nos permite guardar si es falso o verdadero
bool miBooleano = true;

DateTime ahora = DateTime.Now;
DateTime hoy = DateTime.Now.Date;
int year = ahora.Year;
int month = ahora.Month;
int day = ahora.Day;

Persona yo = new Persona("Francisco",28,543235.12);
Persona joe = new Persona("Joe",31,110000000000.5);



//Esta instruccion nos permite imprimir en la consola
Console.WriteLine(joe.CreaMensajeCompleto());
Console.WriteLine(yo.CreaMensajeCompleto());

//Console.WriteLine(yo.SalirACaminar());
//Console.WriteLine(yo.Comprar(5000));

