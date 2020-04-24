Imports System

Module Program
    Sub Main(args As String())
        Dim A(9) As Integer
        Dim B(9) As Integer
        Dim C(9) As Integer
        'SE RECOGEN LOS DATOS DE LOS DOS VECTORES Y SE IMPRIMEN POR PANTALLA
        Console.WriteLine("Introduzca los 10 primeros numeros")
        For i = 0 To 9
            A(i) = Console.ReadLine()
        Next i

        Console.WriteLine("Introduzca los 10 segundos numeros")
        For i = 0 To 9
            B(i) = Console.ReadLine()
        Next i

        For i = 0 To 9
            C(i) = A(i) + B(i)
        Next i
        Console.WriteLine("El resultado es el siguiente")
        For i = 0 To 9
            Console.Write(C(i).ToString + ", ")
        Next i
    End Sub
End Module
