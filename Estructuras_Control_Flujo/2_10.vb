Module _2_10
    Sub main()
        'For y Do Loop. Crear un módulo para resolver el siguiente
        'problema: con dos valores numéricos enteros cualquiera, el 
        'primero menor al segundo, calcular cuantos números
        'múltiplos de cinco hay entre ellos e informar. 
        'Repetir esta solución en el mismo módulo con las diferentes
        '      alternativas las estructuras de repetición 
        '“do while … loop”, “do until … loop”, “do … loop
        ' While ”, “do … loop until y “for”
        Dim num1, num2, multiplo, x, y As Integer
        Console.WriteLine("Ingrese el primer numero: ")
        num1 = Console.ReadLine
        x = num1
        Console.WriteLine("Ingrese el segundo numero: ")
        num2 = Console.ReadLine
        Console.WriteLine("---- DO WHILE... LOOP ----")
        Do While num1 <= num2
            If num1 Mod 5 = 0 Then
                multiplo = multiplo + 1
                Console.WriteLine(num1)
            End If
            num1 = num1 + 1
        Loop
        Console.WriteLine("Entre '{0}' y '{1}', hay {2} multiplos de 5 ", x, num2, multiplo)
        Console.WriteLine("---- DO UNTIL... LOOP ----")
        Do Until num1 > num2
            If num1 Mod 5 = 0 Then
                multiplo = multiplo + 1
            End If
            num1 = num1 + 1
        Loop
        Console.WriteLine("Entre '{0}' y '{1}', hay {2} multiplos de 5 ", x, num2, multiplo)
        Console.WriteLine("---- DO... LOOP WHILE ----")
        Do
            If num1 Mod 5 = 0 Then
                multiplo = multiplo + 1
            End If
            num1 = num1 + 1
        Loop While num1 <= num2
        Console.WriteLine("Entre '{0}' y '{1}', hay {2} multiplos de 5 ", x, num2, multiplo)
        Console.WriteLine("---- DO... LOOP UNTIL ----")
        Do
            If num1 Mod 5 = 0 Then
                multiplo = multiplo + 1
            End If
            num1 = num1 + 1
        Loop Until num1 > num2
        Console.WriteLine("Entre '{0}' y '{1}', hay {2} multiplos de 5 ", x, num2, multiplo)
        Console.WriteLine("---- FOR... NEXT ----")
        For y = num1 To num2 Step +1
            If num1 Mod 5 = 0 Then
                multiplo = multiplo + 1
            End If
            num1 = num1 + 1
        Next
        Console.WriteLine("Entre '{0}' y '{1}', hay {2} multiplos de 5 ", x, num2, multiplo)
        Console.ReadKey()


    End Sub
End Module
