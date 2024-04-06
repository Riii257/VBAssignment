Imports System.Console

Module Program
    ' Create class
    Public Class Student
        Public S_ID, Marks1, Marks2 As Integer
        Public Name As String
        ' Create constructor
        Public Sub GetDetails(ByVal id As Integer, ByVal nm As String, ByVal mks1 As Integer, ByVal mks2 As Integer)
            S_ID = id
            Name = nm
            Marks1 = mks1
            Marks2 = mks2
        End Sub
        ' Create functions
        Public Function Display()
            WriteLine("Student ID: " & S_ID)
            WriteLine("Student Name: " & Name)
            WriteLine("Marks 1: " & Marks1)
            WriteLine("Marks 2: " & Marks2)
        End Function
        Public Function Total()
            Return Marks1 + Marks2
        End Function
    End Class
    Sub Main()


       ' Create object
        Dim St1 As Student = New Student()
        Dim id, mks1, mks2 As Integer
        Dim nm As String

        Write("Enter Student ID: ")
        id = ReadLine()

        Write("Enter Student Name: ")
        nm = ReadLine()

        Write("Enter marks 1: ")
        mks1 = ReadLine()

        Write("Enter marks 2: ")
        mks2 = ReadLine()

        ' Calling Constructor
        St1.GetDetails(id, nm, mks1, mks2)


        ' Calling functions
        St1.Display()

        WriteLine("Sum of marks= " & St1.Total())

    End Sub
End Module
