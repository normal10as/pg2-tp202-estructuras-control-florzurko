Module _2_3
    'Crear un programa que se ingresen 5 valores enteros e informar cual es
    'el mayor por su posición de ingreso, por ejemplo, dado los siguientes 
    'valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”
    Sub main()
        Dim valor1, valor2, valor3, valor4, valor5, primero, segundo, tercero, cuarto, quinto As Integer
        Console.WriteLine("Ingresar el primer valor: ")
        valor1 = Console.ReadLine
        primero = valor1
        Console.WriteLine("Ingresar el segundo valor: ")
        valor2 = Console.ReadLine
        segundo = valor2
        Console.WriteLine("Ingresar el tercer valor: ")
        valor3 = Console.ReadLine
        tercero = valor3
        Console.WriteLine("Ingresar el cuarto valor: ")
        valor4 = Console.ReadLine
        cuarto = valor4
        Console.WriteLine("Ingresar el quinto valor: ")
        valor5 = Console.ReadLine
        quinto = valor5

        If valor1 > valor2 And valor1 > valor3 And valor1 > valor4 And valor1 > valor5 Then
            Console.WriteLine("El primer numero es el mayor")
        ElseIf valor2 > valor3 And valor2 > valor4 And valor2 > valor5 Then
            Console.WriteLine("El segundo numero es el mayor")
        End If
        If valor3 > valor4 And valor3 > valor5 Then
            Console.WriteLine("El tercer numero es el mayor")
        ElseIf valor4 > valor5 Then
            Console.WriteLine("El cuarto numero es el mayor")
        Else
            Console.WriteLine("El quinto numero es el mayor")
        End If
        Console.ReadKey()



    End Sub
End Module
