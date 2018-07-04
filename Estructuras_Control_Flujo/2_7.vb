Module _2_7
    Sub main()
        Dim angulo As Single
        Console.WriteLine("Ingrese el tamaño del angulo: ")
        angulo = Console.ReadLine
        Select Case angulo
            Case 0 To 89
                Console.WriteLine("El angulo es Agudo")
            Case 90
                Console.WriteLine("El angulo es Recto")
            Case 91 To 179
                Console.WriteLine("El angulo es Obtuso")
            Case 180
                Console.WriteLine("El angulo es Llano")
            Case 181 To 360
                Console.WriteLine("El angulo es Concavo")
            Case < 0
                Console.WriteLine("Error")
            Case > 360
                Console.WriteLine("Error")
        End Select
        Console.ReadKey()


    End Sub
End Module
