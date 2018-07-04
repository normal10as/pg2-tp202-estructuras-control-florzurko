Module _2_2

    Sub main()
        'crear un módulo en el cual se ingresan dos valores numéricos e informar
        'por pantalla cuál es la relación entre ambos: mayor, menor o igual.

        Dim a, b, c As Integer


        Console.WriteLine("Ingrese el primer valor: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor: ")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer valor: ")
        c = Console.ReadLine()

        Dim menor As Integer
        If a > c And b > c Then
            menor = c
        ElseIf a > b Then
            menor = b
        Else
            menor = a
        End If
        Console.WriteLine("El numero menor es: " & menor)
        Console.ReadKey()


        End Sub


End Module
