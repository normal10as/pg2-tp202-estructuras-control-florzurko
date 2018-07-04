Module _2_9
    Sub main()
        Dim unidad, valor As UShort
        Console.WriteLine("Ingrese la unidad de medida que desa convertir: ")
        Console.WriteLine("     Metro = 1  .  Centimetros =2  .  Yardas = 3  .  Pies = 4  .  Pulgadas = 5")
        unidad = Console.ReadLine
        Console.WriteLine("Ingrese el valor a convertir: ")
        valor = Console.ReadLine
        Dim centimetros, pies, yardas, pulgadas, metros As Decimal

        Select Case unidad
            Case 1 'metro
                centimetros = valor * 100
                pies = valor * 3.28
                yardas = valor * 1.0936
                pulgadas = valor * 39.37
                metros = valor
            Case 2 'centimetro
                metros = valor / 100
                pies = valor * 0.032808
                yardas = valor * 0.0109361
                pulgadas = valor * 0.3937
                centimetros = valor
            Case 3 'yardas
                metros = valor / 1.0936
                pies = valor * 3
                centimetros = valor * 91.44
                pulgadas = valor * 36
                yardas = valor
            Case 4 'pies
                metros = valor / 3.2808
                pies = valor
                centimetros = valor * 30.48
                pulgadas = valor * 12
                yardas = valor * 0.333
            Case 5 'pulgadas
                metros = valor * 0.0254
                pies = valor * 0.833333
                centimetros = valor * 2.54
                pulgadas = valor
                yardas = valor * 0.0277778
        End Select

        Console.WriteLine("La unidad en Metros: " & metros)
        Console.WriteLine("La unidad en Centimetros: " & centimetros)
        Console.WriteLine("La unidad en Yardas: " & yardas)
        Console.WriteLine("La unidad en Pies: " & pies)
        Console.WriteLine("La unidad en Pulgadas: " & pulgadas)
        Console.ReadKey()
    End Sub
End Module