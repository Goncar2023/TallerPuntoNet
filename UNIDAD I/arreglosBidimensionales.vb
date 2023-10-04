Sub Main()

    'Los arreglos bidimensionales permiten almacenar datos en
    'dos dimensiones, es decir, en FILAS y COLUMNAS

    'Declaración
    Dim usuarios(2, 2) As String 'Crea una matriz de 3X3
    'Tres filas y tres columnas

    'Declaración e Inicialización
    Dim numeros(,) As Integer = New Integer(2, 2) {}
    'La estructura (,) indica que será un arreglo BIDIMENSIONAL
    '(2, 2) {} Inicializa el arreglo bidimensional
    'Crea un arreglo con 3 filas y 3 columnas
    'Las llaves {} indican que el arreglo está siendo inicializado con ceros

    Dim nombres(,) As String = New String(4, 4) {}

    Dim notas(,) As Single = {{1.1F, 2.2F, 3.3F}, {4.4F, 5.5F, 6.6F}, {7.7F, 8.8F, 9.9F}}
    Dim estados(,) As Boolean = {{True, False, True}, {False, True, False}, {True, True, False}}
    Dim objetos(,) As Object = {{1, "Hola", 3.14}, {True, "Mundo", 42}, {"Incio", 3.5, DateTime.Now}}


    'Para que no se abra y se cierre de inmediato la consola
    Console.WriteLine("Presiona una tecla para salir...")
    Console.ReadKey() 'El programa espera hasta que se presiona una tecla


End Sub