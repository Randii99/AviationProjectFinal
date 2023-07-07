Imports System.Data.SqlClient

Public Class DatabaseConnection

    Public Shared ReadOnly Property ConnectionString As String
        Get

            Return "User Id=sa; Password=cpt@109; Database=aviationProject_DB; Data Source=192.168.100.70"

        End Get
    End Property

End Class
