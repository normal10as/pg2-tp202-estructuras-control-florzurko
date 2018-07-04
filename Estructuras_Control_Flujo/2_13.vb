Module _2_13
    Sub main()
        Dim comprobacion As Boolean = True
        Dim primos As UShort
        'comprueba los numeros
        For num As Integer = 1 To 1000
            comprobacion = True
            'comprueba que sean verdaderos
            For i As Integer = 2 To num - 1
                If num Mod i = 0 Then
                    comprobacion = False
                End If
            Next
            If comprobacion = True Then
                Console.WriteLine(num)
                primos = primos + 1
            End If
        Next
        Console.WriteLine("Hay {0} numeros primos", primos)
        Console.ReadKey()
    End Sub
End Module
