Module _2_15
    Sub main()
        Const intanual As Single = 36   'interes anual
        Dim intmensual As UShort = (intanual / 12)  'interes mensual
        Dim meses As UShort     'cantidad de mes
        Dim capinicial,         'anterior
            capital,            '
            saldo,              'saldotal + interes 
            intmes,             'interes ganados por mes
            intprimer,          'primer interes           
        intganados As Single ' interes ganados en total  
        Dim muestro As String = ""
        Console.WriteLine(" Ingrese el capital inicial: ")
        capinicial = Console.ReadLine
        Console.WriteLine(" Ingrese la cantidad de meses: ")
        meses = Console.ReadLine
        Console.WriteLine(vbTab & "MES" & vbTab & vbTab & "CAPITAL" & vbTab & vbTab & "INTERES" & vbTab & vbTab & "SALDO")
        saldo = capinicial
        For mes As UShort = 1 To meses
            capital = saldo
            intmes = mes * intmensual
            intprimer = Math.Round(saldo * intmensual / 100, 2)
            saldo = intprimer + saldo
            muestro = capital & vbTab & vbTab & intprimer & vbTab & vbTab & saldo
            intprimer = capital
            Console.WriteLine(vbTab & " " & mes & vbTab & vbTab & muestro)
        Next
        intganados = Math.Round(capital - capinicial, 2)
        Console.WriteLine("")
        Console.WriteLine("TOTAL INTERESES GANADOS: $" & intganados)
        Console.ReadKey()


    End Sub
End Module
