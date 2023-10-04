Module Module1

    Sub Main()
        ' Estructura If-Else:
        ' El condicional If-Else se utiliza para tomar decisiones en el programa en función de una condición. 
        Dim edad As Integer = 20

        If edad >= 18 Then
            Console.WriteLine("Eres mayor de edad.")
        Else
            Console.WriteLine("Eres menor de edad.")
        End If

        ' Estructura Switch:
        ' La estructura Switch (Select Case en VB) se utiliza para realizar múltiples comparaciones en base a un valor. 
        ' Se compara el valor de una variable con varios casos y se ejecuta el bloque de código del caso que coincida

        Dim diaSemana As Integer = 3
        Dim diaPalabra As String

        Select Case diaSemana
            Case 1
                diaPalabra = "Lunes"
            Case 2
                diaPalabra = "Martes"
            Case 3
                diaPalabra = "Miércoles"
            Case 4
                diaPalabra = "Jueves"
            Case 5
                diaPalabra = "Viernes"
            Case 6
                diaPalabra = "Sabado"
            Case 7
                diaPalabra = "Domingo"
            Case Else
                diaPalabra = "Día inválido"
        End Select

        MsgBox("El día es " & diaPalabra)

        'Número RANDOM
        Dim random As New Random()
        Dim aleatorio As Integer = random.Next(1, 4)
        'Genera un número aleatorio entre el 1 y el 3
        MsgBox("El N° aleatorio es: " & aleatorio & " ")

        ' Estructuras de Control de Bucles
        ' El bucle "For" se utiliza para ejecutar un bloque de código un número específico de veces. 

        'For:
        For z As Integer = 1 To 5
            Console.WriteLine("Iteración " & z)
        Next z

        ' Bucle While:
        ' El bucle "While" se utiliza para repetir un bloque de código MIENTRAS una condición sea verdadera. 
        ' La condición se verifica antes de ejecutar el bloque.

        Dim contador As Integer = 0

        While contador < 5
            Console.WriteLine("Contador: " & contador)
            contador += 1
        End While

        'Ejercicios:
        '1. Estructura de Control:
        'Escribe un programa que solicite al usuario ingresar un número y luego determine
        'si ese número es positivo, negativo o cero.

        '2. Bucle For:
        'Escribe un programa que calcule la suma de todos los números pares del 1 al 50.

        '3. Bucle While:
        'Escribe un programa que solicite al usuario adivinar un número
        'secreto entre 1 y 100. El programa debe dar pistas si el número ingresado es mayor o
        'menor que el número secreto, y mostrar cuántos intentos tomó adivinar.
        '
        Dim numero As Integer

        Do
            Console.Write("Ingresa un número positivo: ")
            numero = Integer.Parse(Console.ReadLine())
        Loop While numero <= 0
    End Sub

End Module
