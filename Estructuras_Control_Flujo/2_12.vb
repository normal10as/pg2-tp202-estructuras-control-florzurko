Module _2_12
    Sub main()
        'Utilizando la estructura de repetición más adecuada
        'elaborar Los números de Fibonacci. 
        'Constituyen una secuencia que empieza con 0 y 1;
        'el número que sigue a éstos se calcula sumando 
        'los dos anteriores y así sucesivamente.
        'Utilizando la estructura de repetición más 
        'adecuada elaborar un algoritmo que imprima los 20
        'primeros números de la secuencia.
        Dim actual, num, anterior, siguiente As Integer
        Dim fibonacci As String = ""
        anterior = 0
        siguiente = 1

        For num = 1 To 20
            actual = anterior
            fibonacci = fibonacci & " " & anterior
            anterior = siguiente + anterior
            siguiente = actual
        Next
        Console.WriteLine(fibonacci)
        Console.ReadKey()

    End Sub
End Module
