Module _2_14
    Sub main()
        'Se ingresan repetitivamente cantidad y precio unitario.
        'cantidad = 10 y 50  descuento de 5%
        'cantidad = 51 y 250 el descuento de 10% 
        'cantidad >= 251 o más el descuento es del 20%. 
        'Informar por cada producto subtotal 
        '(cantidad por precio unitario), 
        'porcentaje de descuento aplicado,
        'monto descontado y total(subtotal – monto descontado).
        'Al finalizar el ingreso, por cantidad igual a cero,
        'informar el total de pesos descontados y el total a cobrar.
        Dim cantidad, precio, descontado, cobrar As UInteger
        Dim porcentaje As Byte
        Do While True
            Console.WriteLine("Ingrese la cantidad: ")
            cantidad = Console.ReadLine
            If cantidad = 0 Then
                Exit Do
            Else
                Console.WriteLine("Ingrese el precio unitario: ")
                precio = Console.ReadLine
                If cantidad >= 1 And cantidad <= 50 Then
                    porcentaje = 5
                ElseIf cantidad >= 51 And cantidad <= 250 Then
                    porcentaje = 10
                ElseIf cantidad >= 251 Then
                    porcentaje = 20
                End If
            End If
            Dim subtotal As UInteger = cantidad * precio
            Dim descuento, total As UInteger
            descuento = (subtotal * porcentaje) / 100
            descontado = descontado + descuento
            total = subtotal - descuento
            cobrar = cobrar + total
            Console.WriteLine("El Subtotal es: $" & subtotal)
            Console.WriteLine("El descuento aplicado es del {0}% ", porcentaje)
            Console.WriteLine("El monto descontado es: $" & descuento)
            Console.WriteLine("El total es de: $" & total)
            Console.WriteLine("---------------------------")
            Console.WriteLine()
        Loop
        Console.WriteLine("---------------------------")
        Console.WriteLine()
        Console.WriteLine("Total de pesos descontados: " & descontado)
        Console.WriteLine("Total a cobrar: " & cobrar)

        Console.ReadKey()
    End Sub
End Module


