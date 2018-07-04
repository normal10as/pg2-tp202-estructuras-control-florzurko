Module _2_1
    Sub main()
        'crear un módulo en el cual se ingresan dos valores numéricos e informar
        'por pantalla cuál es la relación entre ambos: mayor, menor o igual.

        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Ingrese el primer valor: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor: ")
        b = Console.ReadLine()

        Dim relacion As Integer
        If a > b Then
            relacion = a
            Console.WriteLine("El numero mayor es: " & relacion)
        ElseIf b > a Then
            relacion = b
            Console.WriteLine("El numero mayor es: " & relacion)
        ElseIf b = a Then
            Console.WriteLine("Los numeros son iguales")
        End If
        Console.ReadKey()


    End Sub
End Module
