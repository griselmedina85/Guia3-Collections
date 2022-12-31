// See https://aka.ms/new-console-template for more information
Console.WriteLine("GUIA DE EJERCICIOS 3");
Console.WriteLine("Medina Griselda");

#region Ejercicio1
//Console.WriteLine("**************** Ejercicio 1 : Promedio de notas ****************");
//int[] score = new int[10];
//for (int i = 0; i < score.Length; i++)
//{
//    Console.WriteLine("Ingrese nota "+(i+1)+": ");
//    var num = Console.ReadLine(); 
//    score[i] = Int32.Parse(num);
//}

//List<int> lista = new List<int>(score);
//var sum = 0;
//foreach (int item in lista)
//{
//    sum += item;
//    Console.WriteLine("Nota: " + item);
//}
//var prom = sum / lista.Count;
//Console.WriteLine("Promedio: " + prom);
#endregion

#region Ejercicio2
//Console.WriteLine("**************** Ejercicio 2 : Edades ****************");
//List<int> ages = new List<int>() { 24,13,25,43,10,12,14,18,19,28,33,66,87,79,25,63,33,45,20,3 };
//var mayAges = ages.Where(o => o >= 18).Select(item => item).Count();
//Console.WriteLine("Cantidad de personas mayores de edad: "+ mayAges);
//Console.WriteLine("Cantidad de personas menores de edad: " + (ages.Count - mayAges));
#endregion

#region Ejercicio3
//Console.WriteLine("**************** Ejercicio 3 : Nombres Estudiantes ****************");
//List<string> names = new List<string>();
//names.Add("Ada");
//names.Add("Nazarena");
//names.Add("Sara");
//names.Add("Santino");

//string largeName = names[0];
//string shortName = names[0];
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//    if(item.Length > largeName.Length)
//    {
//        largeName = item;
//    }
//    if( item.Length < shortName.Length)
//    {
//        shortName = item;
//    }
//}
//Console.WriteLine("Nombre con más letras: "+largeName);
//Console.WriteLine("Nombre con menos letras: "+shortName);

#endregion

#region Ejercicio5
//string[,] parimpar = new string[5, 5];
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if((i+j) % 2 == 0)
//        {
//            parimpar[i, j] = "P";
//        }
//        else
//        {
//            parimpar[i, j] = "I";
//        }
        
//    }
//}
//foreach (string item2 in parimpar)
//{
//    Console.WriteLine(item2);
//}
#endregion

#region Ejercicio6
int row = 5;
int col = 7;

int mon = 0;
int tue = 1;
int wed = 2;
int thu = 3;
int fri = 4;
int sat = 5;
int sun = 6;

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int[,] temperatures = new int[5,7];
int lim = 0;

//Cabecera
Console.WriteLine("MO TU WE TH FR SA SU");

//recorro las 5 semanas
for (int i = 0; i < row; i++)
{
    //Si es la ultima semana, recorro hasta el miercoles
    if(i == row)
    {
        lim = wed;
    }
    else
    {
        lim = sun;
    }
    //recorro los días
    for(int j = 0; j<= lim; j++)
    {
        temperatures[i,j] = new Random().Next(7, 38);
        if(temperatures[i,j] < 10)
        {
            Console.Write(" "+temperatures[i, j] + " ");
        }
        else
        {
            Console.Write(temperatures[i, j] + " ");
        }
        
    }
    Console.WriteLine();

}

//Variables para la temperatura mas alta del mes y su dia(numero y nombre del dia)
int maxTempMonth = temperatures[0,0];
int dayMaxTempMonth = 1;
int dayWeekMaxTempMonth = 0;

//recorro las 5 semanas
for (int i = 0; i < row; i++)
{
    //cada semana se reinicia 
    //variables para mayor y menor de la semana
    int maxTempWeek = temperatures[i,0] ;
    int dayMaxTempWeek = mon;

    int minTempWeek = temperatures[i, 0];
    int dayMinTempWeek = mon;

    int sumTemp = 0;

    //Si es la ultima semana, recorro hasta el miercoles
    if (i == row)
    {
        lim = wed;
    }
    else
    {
        lim = sun;
    }

    //Recorro los dias, segun el limite
    for (int j = 0; j <= lim; j++)
    {
        //Compruebo las temperaturas (mayor en la semana)
        if(temperatures[i,j] > maxTempWeek)
        {
            maxTempWeek = temperatures[i,j];
            dayMaxTempWeek = j;
        }
        //Compruebo las temperaturas (menor en la semana)
        if (temperatures[i,j] < minTempWeek)
        {
            minTempWeek = temperatures[i,j];
            dayMinTempWeek = j;
        }

        //Compruebo las temperaturas (mayor en el mes)
        if(temperatures[i,j] > maxTempMonth)
        {
            maxTempMonth = temperatures[i,j];
            dayWeekMaxTempMonth =j;
            //dia del mes en nro
            dayMaxTempMonth = (i + 1) * j;
        }

        //sumamos la temperatura
        sumTemp += temperatures[i,j];
    }
    //mostramos los datos de la semana
    Console.WriteLine("En la semana "+(i + 1)+" la mayor temperatura fue de "+ maxTempWeek+ " en el dia "+ days[dayMaxTempWeek]);
    Console.WriteLine("En la semana "+(i + 1)+" la menor temperatura fue de "+minTempWeek+" en el dia "+ days[dayMinTempWeek]);

    //calculo la media o promedio
    float media = sumTemp / col;
    Console.WriteLine("La media de la semana "+ (i + 1)+ "es de "+media);    

  }

//Mostramos los datos del mes
Console.WriteLine("La mayor temperatura del mes es de "+ maxTempMonth+ " en el dia "+ days[dayWeekMaxTempMonth]+ "("+ dayMaxTempMonth+ ")");


#endregion