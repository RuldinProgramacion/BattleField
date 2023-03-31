
int[,] tablero = new int[5,5];

void paso1_crear_tablero()
{
    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        for (int j = 0; j < tablero.GetLength(1); j++)
        {
            tablero[i, j] = 0;
        }
    }
}

void paso2_colocar_barcos()
{
    //convertir estas cargas a random.
    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;

}


void paso3_1_imprimir_tablero()
{
    //imprimir la matriz en consola
    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        for (int j = 0; j < tablero.GetLength(1); j++)
        {
            Console.Write(tablero[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void paso3_imprimir_tablero()
{
    String caracter_a_imprimir;
    //imprimir la matriz en consola
    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        for (int j = 0; j < tablero.GetLength(1); j++)
        {
            //mostar esto primero, y analizar cómo marca los barcos
            //String caracter_a_imprimir = (tablero[i, j]==0 ? "-" : "*" );

            //despues mostrar esto y analizar cómo marca los barcos
            //String caracter_a_imprimir = (tablero[i, j] == -1 ? "*" : "-");
            //Console.Write(caracter_a_imprimir + " ");

            //cambiar a un switch paso 3
            switch (tablero[i, j])
            {
                case 0:
                    caracter_a_imprimir = "-";
                    break;
                case 1:
                    caracter_a_imprimir = "-";
                    break;
                case -1:
                    caracter_a_imprimir = "*";
                    break;
                case -2:
                    caracter_a_imprimir = "X";
                    break;
                default:
                    caracter_a_imprimir = "-";
                    break;
            }
            Console.Write(caracter_a_imprimir + " ");
        }
        Console.WriteLine();
    }
}

void paso4_ingreso_coordenadas()
{
    int fila,columna = 0;
    //limpiamos pantalla
    Console.Clear();
    do
    {
        //poner la lógica de que si ya se acabo el juego, que salga del ciclo
        //y que no siga preguntando
        //usar los controles adecuados para evitar errores de coordenadas.
        //y de mal ingreso, aplicar el try visto en clase anterior.
        Console.Write("ingresa la fila");
        fila = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa la columna");
        columna = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"fila:{fila} col:{columna}");


        //poner un if para que si ya le dió a esa coordenada, que no le deje
        if (tablero[fila, columna]==1)
        {
            //cómo llevar el control de que ya se acabaron todos?
            Console.Beep();
            tablero[fila, columna] = -1; //bandera que ya le dió
        } else
        {
            tablero[fila, columna] = -2; //coordenada quemada.
        }

        Console.Clear();
        paso3_imprimir_tablero();


    } while(true);
}





paso1_crear_tablero();
paso2_colocar_barcos();
paso3_1_imprimir_tablero();
paso3_imprimir_tablero();
paso4_ingreso_coordenadas();


