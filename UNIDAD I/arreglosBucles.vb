Sub Main()

    Dim numeros(4) As Integer
    ' Usar un bucle For para leer los valores del arreglo
    For i As Integer = 0 To numeros.Length - 1
        ' INGRESAR VALORES
        Console.Write($"INGRESE EL N° {i} :")
        numeros(i) = Console.ReadLine
    Next i

    For i As Integer = 0 To numeros.Length - 1
        ' Mostrar el valor del elemento en la posición actual
        Console.WriteLine("Elemento en la posición " & i & ": " & numeros(i))
    Next i

    'Para que no se abra y se cierre de inmediato la consola
    Console.WriteLine("Presiona una tecla para salir...")
    Console.ReadKey() 'El programa espera hasta que se presiona una tecla

End Sub