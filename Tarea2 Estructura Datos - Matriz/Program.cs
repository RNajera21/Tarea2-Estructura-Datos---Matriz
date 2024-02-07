//Tarea E.D - Semana 3
//Matriz con valores. Suma de esquinas de los valores en la matriz y suma de las diagonmales. 

// Matriz
int[,] matriz = new int[3, 3]; 

//variables
int valor = 1;
int totalesquinas = 0;
int totaldiagonal1 = 0;
int totaldiagonal2 = 0;
int totaldiagonales = 0;

//recorrido de la matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        //Valorizacion de los índices
        matriz[i, j] = valor++;

        //Operaciones
        totalesquinas = matriz[0, 0] + matriz[0, 2] + matriz[2, 0] + matriz[2, 2];
        totaldiagonal1 = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
        totaldiagonal2 = matriz[2, 0] + matriz[1, 1] + matriz[0, 2];
        totaldiagonales = totaldiagonal1 + totaldiagonal2;
    }
}
//Salidas
Console.WriteLine("la suma de las esquinas de la matriz es: " + totalesquinas);
Console.WriteLine("La suma de la diag1 es: " + totaldiagonal1);
Console.WriteLine("La suma de la diag2 es: " + totaldiagonal2);
Console.WriteLine("La suma de las dos diagonales es: " + totaldiagonales);
