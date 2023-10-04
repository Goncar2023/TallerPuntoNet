Sub Main()

    Dim numeros(,) As Integer = New Integer(2, 2) {}

    ' Obtener el número de filas
    Dim filas As Integer = numeros.GetLength(0)

    ' Obtener el número de columnas
    Dim columnas As Integer = numeros.GetLength(1)

    'AGREGAR ELEMENTOS A LA MATRIZ
    For fila As Integer = 0 To filas - 1
        For columna As Integer = 0 To columnas - 1
            Console.Write("Fila " & fila & " Columna " & columna & " ingresa un número: ")
            numeros(fila, columna) = Console.ReadLine()
        Next columna
    Next fila

    'ACCEDER Y MOSTRAR ELEMENTOS A LA MATRIZ
    For fila As Integer = 0 To filas - 1
        For columna As Integer = 0 To columnas - 1
            Console.Write(numeros(fila, columna) & " ")
        Next columna
        Console.WriteLine() ' Saltar a la siguiente línea después de cada fila
    Next fila


    'Para que no se abra y se cierre de inmediato la consola
    Console.WriteLine("Presiona una tecla para salir...")
    Console.ReadKey() 'El programa espera hasta que se presiona una tecla

End Sub