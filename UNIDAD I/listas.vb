Imports System.Collections.Generic 'Se debe importar

Sub Main()
    'Las listas dinámicas son estructuras de datos que pueden
    'crecer o reducirse de manera dinámica.

    'Declaración e inicialización de LISTAS
    Dim numeros As New List(Of Integer)()
    'Lista que puede contener valores de tipo Integer

    'Agregar elementos a una lista con Add
    numeros.Add(9)
    numeros.Add(8)
    numeros.Add(7)
    numeros.Add(6)
    numeros.Add(5)

    Dim longitud As Integer = numeros.Count ' Obtiene el número de elementos en la lista
    Console.WriteLine("LONGITUD: " & longitud)

    'Acceder a los elementos de la lista
    'Console.WriteLine("N° " & numeros(0))
    'Console.WriteLine("N° " & numeros(1))
    'Console.WriteLine("N° " & numeros(2))
    'Console.WriteLine("N° " & numeros(3))
    'Console.WriteLine("N° " & numeros(4))

    'Recorrer un lista con For Each
    For Each numero As Integer In numeros
        Console.WriteLine("N° " & numero)
    Next

    'Remover elementos de una lista
    Console.WriteLine("POSICIÓN 0 N° " & numeros(0))
    numeros.Remove(7) 'Remueve el primer 7 que aparezca en la lista
    numeros.RemoveAt(0) 'Remueve el elemento según índice
    Console.WriteLine("POSICIÓN 0 N° " & numeros(0))

    'Volver a contar elementos
    longitud = numeros.Count
    Console.WriteLine("LONGITUD: " & longitud)

    'Para que no se abra y se cierre de inmediato la consola
    Console.WriteLine("Presiona una tecla para salir...")
    Console.ReadKey() 'El programa espera hasta que se presiona una tecla

End Sub