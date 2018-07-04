Module _2_6
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
        Select Case cantidad
            Case 0 To 10
                porcentaje = 0
            Case 11 To 50
                porcentaje = 5
            Case 51 To 250
                porcentaje = 10
            Case Is > 251
                porcentaje = 20
        End Select
        descuento = (subtotal * porcentaje) / 100
        total = subtotal - descuento
        Console.WriteLine("El Subtotal es: $" & subtotal)
        Console.WriteLine("El descuento aplicado es del {0}% ", porcentaje)
        Console.WriteLine("El monto descontado es: $" & descuento)
        Console.WriteLine("El total es de: $" & total)
        Console.ReadKey()
    End Sub
End Module
