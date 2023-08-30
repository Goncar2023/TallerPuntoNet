Module Module1
    ' COMENTAR CTRL + K - CTRL + C // DESCOMENTAR CTRL + K - CTRL + U
    Sub Main()
        ' Operadores de Comparación
        ' = Comprueba si dos valores son iguales.
        ' <>: Comprueba si dos valores no son iguales.
        ' >: Comprueba si el valor de la izquierda es mayor que el de la derecha.
        ' <: Comprueba si el valor de la izquierda es menor que el de la derecha.
        ' >=: Comprueba si el valor de la izquierda es mayor o igual que el de la derecha.
        ' <=: Comprueba si el valor de la izquierda es menor o igual que el de la derecha.

        Dim num1 As Integer = 10
        Dim num2 As Integer = 5
        Dim resultado As Boolean

        resultado = (num1 > num2) ' resultado = True

        'Operadores Lógicos:

        'And Devuelve verdadero si ambas condiciones son verdaderas.
        'Or: Devuelve verdadero si al menos una de las condiciones es verdadera.
        'Not: Niega una condición, convierte verdadero en falso y viceversa.

        Dim edad As Integer = 25
        Dim licencia As Boolean = True

        Dim puedeConducir As Boolean = edad >= 18 And licencia 
        MsgBox("¿Puede conducir? "&puedeConducir)

    End Sub

End Module
