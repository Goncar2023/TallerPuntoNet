Sub Main()
    'Los arreglos son estructuras de datos que permiten almacenar multiples valores
    'del mismo tipo en un solo lugar.

    'DECLARACIÓN DE ARREGLOS
    'Dim nombreArreglo(Longitud) as TipoDato

    'Declaración y creación de un arreglo ENTERO
    Dim numeros(4) As Integer 'Arreglo con 5 elementos (n-1)

    'Inicialización
    numeros(0) = 1
    numeros(1) = 2
    numeros(2) = 3
    numeros(3) = 4
    numeros(4) = 5

    'Mostrar elementos
    Console.WriteLine(numeros(0))
    Console.WriteLine(numeros(1))
    Console.WriteLine(numeros(2))
    Console.WriteLine(numeros(3))
    Console.WriteLine(numeros(4))

    'Arreglos dinámicos: Si no se conoce el tamaño del arreglo o si
    'se requiere cambiar se pueden utilizar arreglos dinámicos
    Dim numbers() As Integer
    ReDim numbers(5)

    'Para redimensionar el arreglo en tiempo de ejecución
    ReDim Preserve numbers(9)
    'Asegura o preserva los valores actuales del arreglo mientras
    'aumenta su tamaño a 10

    'Para que no se abra y se cierre de inmediato la consola
    Console.WriteLine("Presiona una tecla para salir...")
    Console.ReadKey() 'El programa espera hasta que se presiona una tecla

End Sub