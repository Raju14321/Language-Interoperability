
Public Class Class1
    Public Function SayHello(Name As String) As String
        Return "Hello" & Name
    End Function
    Public Sub AddNums(x As Integer, y As Integer)
        Console.WriteLine(x + y)

    End Sub
    Public Sub Math(a As Integer, b As Integer, ByRef c As Integer, ByRef d As Integer)
        c = a + b
        d = a * b

    End Sub
End Class
