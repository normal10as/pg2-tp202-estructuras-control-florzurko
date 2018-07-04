Module _2_11
    Sub main()
        'Utilizando la estructura de repetición más adecuada elaborar un 
        'programa que se ingresen valores enteros hasta que se ingrese cero 
        '(descartar negativos). Luego informar cuantos son pares y cuantos
        'impares.Si todos son pares o todos son impares informar esta
        'situación particular en lugar de la consigna anterior.
        Dim valor, par, impar, x, y As UShort
        Do
            Console.WriteLine("Ingrese un numero: ")
            valor = Console.ReadLine
            x = x + 1
            If valor Mod 2 = 0 And valor > 0 Then
                par = par + 1
            ElseIf valor > 0 Then
                impar = impar + 1
            End If
        Loop While valor > 0
        x = x - 1
        If x = par Then
            Console.WriteLine("Todos los numeros son pares")
        ElseIf x = impar Then
            Console.WriteLine("Todos los numeros son impares")
        Else
            Console.WriteLine("Hay '{0}' numeros par y '{1}' numeros impar", par, impar)
        End If
        Console.ReadKey()
    End Sub
End Module
