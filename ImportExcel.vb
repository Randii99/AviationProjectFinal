Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports OleDbConnection = System.Data.OleDb.OleDbConnection


Public Class ImportExcel

    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)


    Private Sub btnpath_Click(sender As Object, e As EventArgs) Handles btnpath.Click
        Try
            ' Create a new instance of the OpenFileDialog control.
            Dim openFileDialog1 As New OpenFileDialog()

            ' Set the default file extension filter and title.
            openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
            openFileDialog1.Title = "Select an Excel File"

            ' Display the OpenFileDialog control and get the selected file's full path.
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path.
                Dim filePath As String = openFileDialog1.FileName

                ' Set the file path to the tbpath textbox.
                tbpath.Text = filePath
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub btnExcell_Click(sender As Object, e As EventArgs) Handles btnExcell.Click
        Try
            ' Check if a file has been selected
            If String.IsNullOrEmpty(tbpath.Text) Then
                MessageBox.Show("Please select an Excel file first.")
                Return
            End If

            ' Create the connection string and open the connection
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & tbpath.Text & ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'"
            Using conn As New OleDbConnection(connString)
                Try
                    conn.Open()

                    ' Retrieve the data from the sheet into a DataTable
                    Dim sheetName As String = "Sheet1$" ' Change this to your sheet name
                    Dim cmd As New OleDbCommand("SELECT * FROM [" & sheetName & "]", conn)
                    Dim da As New OleDbDataAdapter(cmd)
                    Dim dt As New System.Data.DataTable()
                    da.Fill(dt)

                    ' Bind the DataTable to the DataGridView
                    dgvExcell.DataSource = dt

                    ' Set the format for the "S.T.D," "Departure time," and "E.T.A" columns
                    dgvExcell.Columns("STD").DefaultCellStyle.Format = "HH:mm:ss"
                    dgvExcell.Columns("Dipature time").DefaultCellStyle.Format = "HH:mm:ss"
                    dgvExcell.Columns("ETA").DefaultCellStyle.Format = "HH:mm:ss"

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while importing data: " & ex.Message)
        End Try
    End Sub


    'export excel sheet data

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            ' Check if DataGridView has data to export
            If dgvExcell.Rows.Count = 0 Then
                MessageBox.Show("No data to export.")
                Return
            End If

            ' Show the confirmation message box
            Dim result As DialogResult = MessageBox.Show("Do you want to export the data?", "Export Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then

                Try
                    connsql.Open()

                    ' Clear existing data in the database table before exporting (optional)
                    Dim clearQuery As String = "TRUNCATE TABLE EXPORT_EXCEL_TABLE" ' Replace with the appropriate query to clear data if needed
                    Dim cmdClear As New SqlCommand(clearQuery, connsql)
                    cmdClear.ExecuteNonQuery()

                    ' Loop through all rows in the DataGridView to export the data
                    For Each row As DataGridViewRow In dgvExcell.Rows
                        If Not row.IsNewRow Then
                            ' Check if the cell value is not null before accessing it
                            Dim flightNumber As String = If(row.Cells("Flight number").Value IsNot Nothing, Convert.ToString(row.Cells("Flight number").Value), "")
                            Dim airlineCategory As String = If(row.Cells("Airline Category").Value IsNot Nothing, row.Cells("Airline Category").Value.ToString(), "")
                            Dim std As String = If(row.Cells("STD").Value IsNot Nothing, row.Cells("STD").Value.ToString(), "")
                            Dim departureTime As String = If(row.Cells("Dipature time").Value IsNot Nothing, row.Cells("Dipature time").Value.ToString(), "")
                            Dim [date] As String = If(row.Cells("Date").Value IsNot Nothing, row.Cells("Date").Value.ToString(), "")
                            Dim eta As String = If(row.Cells("ETA").Value IsNot Nothing, row.Cells("ETA").Value.ToString(), "")

                            ' Create and execute the insertion query
                            Dim insertQuery As String = "INSERT INTO EXPORT_EXCEL_TABLE (FLIGHT_NO, AIRLINE_CODE, STD, DIP_TIME, DATE, ETA) VALUES (@FlightNumber, @AirlineCategory, @STD, @DepartureTime, @Date, @ETA)"
                            Dim cmdInsert As New SqlCommand(insertQuery, connsql)
                            cmdInsert.Parameters.AddWithValue("@FlightNumber", flightNumber)
                            cmdInsert.Parameters.AddWithValue("@AirlineCategory", airlineCategory)
                            cmdInsert.Parameters.AddWithValue("@STD", std)
                            cmdInsert.Parameters.AddWithValue("@DepartureTime", departureTime)
                            cmdInsert.Parameters.AddWithValue("@Date", [date])
                            cmdInsert.Parameters.AddWithValue("@ETA", eta)
                            cmdInsert.ExecuteNonQuery()
                        End If
                    Next

                    MessageBox.Show("Data successfully exported to the database.")

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connsql.Close()
                End Try
                'End Using
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while exporting data: " & ex.Message)
        End Try
    End Sub


    Private Sub ImportExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each frm As Form In System.Windows.Forms.Application.OpenForms
            If frm IsNot Me Then
                frm.Enabled = False
            End If
        Next
    End Sub

    Private Sub ImportExcel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Loop through all the open forms in the application
        For Each form As Form In System.Windows.Forms.Application.OpenForms
            If form IsNot Me AndAlso Not form.Enabled Then
                form.Enabled = True
            End If
        Next
    End Sub

    Private Sub tbpath_TextChanged(sender As Object, e As EventArgs) Handles tbpath.TextChanged

    End Sub
End Class