Module _2_4
    Sub main()
        'Se ingresan dos valores relativos a un producto en venta: 
        'cantidad y precio unitario. 
        'Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%
        'si es entre 51 y 250 el descuento es del 10% 
        'si es 251 o más el descuento es del 20%. 
        Dim cantidad, precio As UInteger

        Console.WriteLine("Ingrese la cantidad: ")
        cantidad = Console.ReadLine
        Console.WriteLine("Ingrese el precio unitario: ")
        precio = Console.ReadLine

        Dim subtotal As UInteger = cantidad * precio
        Dim descuento, total As UInteger
        Dim porcentaje As Byte

        If cantidad > 0 And cantidad < 10 Then
            porcentaje = 0
        End If
        If cantidad > 10 And cantidad < 50 Then
            porcentaje = 5
        ElseIf cantidad > 51 And cantidad < 250 Then
            porcentaje = 10
        Else
            porcentaje = 20
        End If

        descuento = (subtotal * porcentaje) / 100
        total = subtotal - descuento

        Console.WriteLine("El Subtotal es: $" & subtotal)
        Console.WriteLine("El descuento aplicado es del {0}% ", porcentaje)
        Console.WriteLine("El monto descontado es: $" & descuento)
        Console.WriteLine("El total es de: $" & total)
        Console.ReadKey()
    End Sub
End Module
