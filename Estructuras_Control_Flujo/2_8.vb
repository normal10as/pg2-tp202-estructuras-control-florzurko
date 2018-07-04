Module _2_8
    Enum meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum
    Sub main()
        Dim mes As meses
        Dim numero As Byte
        Dim multiplo As UShort
        Console.WriteLine("Ingrese el numero del Mes: ")
        numero = Console.ReadLine
        mes = numero
        Select Case mes
            Case 1
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
            Case 2
                Console.WriteLine("Ingrese el año: ")
                multiplo = Console.ReadLine
                If multiplo Mod 4 = 0 Then
                    Console.WriteLine("El año es bisiesto. {0} tiene 29 dias", mes.ToString)
                Else
                    Console.WriteLine("{0} tiene 28 dias", mes.ToString)
                End If
            Case 3
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
            Case 4
                Console.WriteLine("{0} tiene 30 dias", mes.ToString)
            Case 5
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
            Case 6
                Console.WriteLine("{0} tiene 30 dias", mes.ToString)
            Case 7
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
            Case 8
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
            Case 9
                Console.WriteLine("{0} tiene 30 dias", mes.ToString)
            Case 10
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
            Case 11
                Console.WriteLine("{0} tiene 30 dias", mes.ToString)
            Case 12
                Console.WriteLine("{0} tiene 31 dias", mes.ToString)
        End Select
        Console.ReadKey()

    End Sub
End Module
