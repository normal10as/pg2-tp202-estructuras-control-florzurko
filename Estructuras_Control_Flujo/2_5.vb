Module _2_5
    Sub main()
        'Crear un programa con una enumeración para los meses del año.
        'Ingresar un valor numérico y mostrar a que mes corresponde. 
        'Si el valor es inválido mostrar el mensaje correspondiente.
        Dim valor As Short
        Console.WriteLine("Ingrese un numero del 1 al 12: ")
        valor = Console.ReadLine()
        Select Case valor
            Case < 0
                Console.WriteLine("El numero es invalido")
            Case 1
                Console.WriteLine("El mes es: Enero")
            Case 2
                Console.WriteLine("El mes es: Febrero")
            Case 3
                Console.WriteLine("El mes es: Marzo")
            Case 4
                Console.WriteLine("El mes es: Abril")
            Case 5
                Console.WriteLine("El mes es: Mayo")
            Case 6
                Console.WriteLine("El mes es: Junio")
            Case 7
                Console.WriteLine("El mes es: Julio")
            Case 8
                Console.WriteLine("El mes es: Agosto")
            Case 9
                Console.WriteLine("El mes es: Septiembre")
            Case 10
                Console.WriteLine("El mes es: Octubre")
            Case 11
                Console.WriteLine("El mes es: Noviembre")
            Case 12
                Console.WriteLine("El mes es: Diciembre")
            Case Is > 13
                Console.WriteLine("El numero es invalido")
        End Select
        Console.ReadKey()
    End Sub
End Module
