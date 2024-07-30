Imports System
Module Program
    Dim choice As String
    Dim StList As New List(Of Student)
    Sub Main(args As String())
        Do
            Console.WriteLine("1. Add a student")
            Console.WriteLine("2. Add a student")
            Console.WriteLine("3. Search a student")
            Console.WriteLine("4. Remove a student")
            Console.WriteLine("5. Exist")
            Console.Write("Enter your choice")
            choice = Console.ReadLine()
            Select Case choice
                Case "1"
                    AddStudent()
                Case "2"
                    DisplayStudent()
                Case "3"
                    SearchStudent()
                Case "4"
                    RemoveStudent()
                Case "5"
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid option...")
            End Select
        Loop
    End Sub

    Private Sub DisplayStudent()
        'codes
    End Sub


    Private Sub RemoveStudent()
        'codes
    End Sub

    Private Sub SearchStudent()
        'codes
    End Sub

    Private Sub AddStudent()
    End Sub
End Module
Class Student
    Public Property StNames As String
    Public Property StDep As String
    Public Property OOP As Double
    Public Property CPP As Double

    Public Sub New(ByVal StNames As String, ByVal StDep As String, ByVal OOP As Double, ByVal CPP As Double)
        Me.StDep = StDep
        Me.StNames = StNames
        Me.OOP = OOP
        Me.CPP = CPP
    End Sub
End Class