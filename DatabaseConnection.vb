Imports System.Data.SqlClient

Public Class DatabaseConnection

    Public Shared ReadOnly Property ConnectionString As String
        Get

            ' Return "User Id=sa; Password=cpt@109; Database=aviationProject_DB; Data Source=192.168.100.70"
            ' Return "Data Source=DESKTOP-8S284IC;Initial Catalog=db_TTProject;User ID=sa;Password=BSvu6ZDj;"
            Return "User Id=sa; Password=BSvu6ZDj; Database=aviationprojectDB; Data Source=DESKTOP-8S284IC"


        End Get
    End Property

End Class
