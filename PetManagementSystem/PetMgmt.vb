Imports System.Data.SqlClient
Imports System.Drawing.Printing ' Add this import for printing
Imports System.Text


Public Class PetMgmt
    Dim connectionString As String = "Data Source=DESKTOP-D5V36F0\SQLEXPRESS;Initial Catalog=PetMgmt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"  ' Use correct server name

    Private Sub UpdatePetForNullServices(PetNumbers As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Number = @Number WHERE Number IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Number", PetNumbers)
                command.ExecuteNonQuery() ' Execute the update
            End Using
        End Using
    End Sub
    Private Sub UpdatePetBreed(Pet As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Breed = @Breed WHERE Breed IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Breed", Pet)
                command.ExecuteNonQuery() ' Execute the update
            End Using
        End Using
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UpdatePetForNullServices("1") ' Pass the barber's name
        PNLPET.Visible = True
        PNLNUMBER.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdatePetForNullServices("2") ' Pass the barber's name
        PNLPET.Visible = True
        PNLNUMBER.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UpdatePetForNullServices("3") ' Pass the barber's name
        PNLPET.Visible = True
        PNLNUMBER.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UpdatePetForNullServices("4") ' Pass the barber's name
        PNLPET.Visible = True
        PNLNUMBER.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UpdatePetForNullServices("5") ' Pass the barber's name
        PNLPET.Visible = True
        PNLNUMBER.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UpdatePetForNullServices("6") ' Pass the barber's name
        PNLPET.Visible = True
        PNLNUMBER.Visible = False
    End Sub

    Private Sub InsertServiceNameIntoDatabase(serviceName As String, price As Decimal)
        Dim customerID As Integer = 1 ' Replace with actual customer ID or retrieval logic
        Dim selectedDate As DateTime = DateTime.Now

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Corrected SQL query to include price
            Dim query As String = "INSERT INTO PetMgmtSystem( ServiceName, Price ) VALUES ( @ServiceName, @Price )"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ServiceName", serviceName)
                command.Parameters.AddWithValue("@Price", price)
                command.ExecuteNonQuery() ' Execute the insert

                MessageBox.Show("Selected: " & serviceName & vbCrLf & "Price: " & price.ToString("C") & vbCrLf & "Added to your selections!")
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim serviceName = "PET GROOM"
        Dim price As Decimal = 499

        InsertServiceNameIntoDatabase(serviceName, price)
        PNLNUMBER.Visible = True
        PNLMAIN.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim serviceName = "WALKING SERVICE"
        Dim price As Decimal = 199

        InsertServiceNameIntoDatabase(serviceName, price)
        PNLNUMBER.Visible = True
        PNLMAIN.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim serviceName = "ANIMAL CARE"
        Dim price As Decimal = 399

        InsertServiceNameIntoDatabase(serviceName, price)
        PNLNUMBER.Visible = True
        PNLMAIN.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim serviceName = "HOME CARE"
        Dim price As Decimal = 299
        InsertServiceNameIntoDatabase(serviceName, price)
        PNLNUMBER.Visible = True
        PNLMAIN.Visible = False

    End Sub
    Private Sub UpdatePetType(PetSystem As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Pet = @Pet WHERE Pet IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Pet", PetSystem)
                command.ExecuteNonQuery() ' Execute the update
            End Using
        End Using
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        UpdatePetType("DOG")
        PNLPET.Visible = False
        PNLBREED.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        UpdatePetType("CAT")
        PNLPET.Visible = False
        PNLBREED.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        UpdatePetType("BIRD")
        PNLPET.Visible = False
        PNLBREED.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UpdatePetType("RABBIT")
        PNLPET.Visible = False
        PNLBREED.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UpdatePetBreed(TextBox1.Text) ' Pass the barber's name
        PNLBREED.Visible = False
        PNLWEIGHT.Visible = True
    End Sub
    Private Sub UpdatePetWeight(PetSystem As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Weight = @Weight WHERE Weight IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Weight", PetSystem)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdatePetSitter(PetSystem As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Sitter = @Sitter WHERE Sitter IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Sitter", PetSystem)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        UpdatePetSitter(Sitter.Text)
        PNLSITTER.Visible = False
        PNLSCHEDULE.Visible = True
    End Sub

    Private Sub loading()
        PNLNIGHTS.Visible = True
        PNLSCHEDULE.Visible = False
    End Sub
    Private Sub UpdatePetNights(PetSystem As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Nights = @Nights WHERE Nights IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nights", PetSystem)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        UpdatePetNights(nights.Text)
        PNLNIGHTS.Visible = False
        PNLPICKUP.Visible = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub updateDate(time As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Find the first NULL slot in ServiceTime
            Dim query As String = "SELECT TOP 1 ReservationID FROM PetMgmtSystem WHERE Time IS NULL"
            Using command As New SqlCommand(query, connection)
                Dim serviceIDToUpdate As Integer? = command.ExecuteScalar()

                ' Update the ServiceTime if a NULL slot is found
                If serviceIDToUpdate.HasValue Then
                    query = "UPDATE PetMgmtSystem SET Time = @Time WHERE ReservationID = @ReservationID"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@Time", time)
                        updateCommand.Parameters.AddWithValue("@ReservationID", serviceIDToUpdate)
                        updateCommand.ExecuteNonQuery()
                    End Using
                Else
                End If
            End Using
        End Using
    End Sub

    Private Sub updateDate2(dateValue As Date)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Find the first NULL slot in ServiceDate
            Dim query As String = "SELECT TOP 1 ReservationID FROM PetMgmtSystem WHERE Date IS NULL"
            Using command As New SqlCommand(query, connection)
                Dim serviceIDToUpdate As Integer? = command.ExecuteScalar()

                ' Update the ServiceDate if a NULL slot is found
                If serviceIDToUpdate.HasValue Then
                    query = "UPDATE PetMgmtSystem SET Date = @Date WHERE ReservationID = @ReservationID"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@Date", dateValue)
                        updateCommand.Parameters.AddWithValue("@ReservationID", serviceIDToUpdate)
                        updateCommand.ExecuteNonQuery()
                    End Using



                Else
                    MessageBox.Show("No available date slots.")  ' Or handle differently (e.g., insert a new row)
                End If
            End Using
        End Using
    End Sub
    Private Sub btn7am_Click(sender As Object, e As EventArgs) Handles btn7am.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "7:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub
    Private Sub UpdatePetPICKUP(PetSystem As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE PetMgmtSystem SET Pickup = @Pickup WHERE Pickup IS NULL"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Pickup", PetSystem)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs)
        PICKUP.Text = "YES"
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs)
        PICKUP.Text = "NO"

    End Sub

    Private Sub btn8am_Click(sender As Object, e As EventArgs) Handles btn8am.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "8:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn9am_Click(sender As Object, e As EventArgs) Handles btn9am.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "9:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn10am_Click(sender As Object, e As EventArgs) Handles btn10am.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "10:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn11am_Click(sender As Object, e As EventArgs) Handles btn11am.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "11:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn1pm_Click(sender As Object, e As EventArgs) Handles btn1pm.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "1:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn2pm_Click(sender As Object, e As EventArgs) Handles btn2pm.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "2:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn3pm_Click(sender As Object, e As EventArgs) Handles btn3pm.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "3:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub

    Private Sub btn4pm_Click(sender As Object, e As EventArgs) Handles btn4pm.Click
        Dim selectedDate As Date = dtpdate.Value.Date
        Dim selectedTime As String = "4:00 :00"

        ' Check for existing appointment at the same date and time
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT ReservationID FROM PetMgmtSystem WHERE  Date = @Date AND  Time = @Time "
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@Date", selectedDate)
                checkCommand.Parameters.AddWithValue("@Time", selectedTime)
                Dim existingServiceID As Integer? = checkCommand.ExecuteScalar()

                If existingServiceID.HasValue Then
                    MessageBox.Show("An appointment already exists at this time.")
                Else
                    updateDate(selectedTime)
                    updateDate2(selectedDate)
                    loading()
                End If
            End Using
        End Using
    End Sub
    Private Function GetLatestServiceID() As Integer
        Dim latestServiceID As Integer = 0

        Dim query As String = "SELECT MAX(ReservationID) FROM PetMgmtSystem"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    latestServiceID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return latestServiceID
    End Function
    Private Sub UpdateLatestPetService()
        ' Check if any of the required text boxes are empty
        If String.IsNullOrWhiteSpace(TXTNAME.Text) OrElse
       String.IsNullOrWhiteSpace(TXTPHONE.Text) OrElse
       String.IsNullOrWhiteSpace(TXTADDRESS.Text) OrElse
       String.IsNullOrWhiteSpace(TXTAGE.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Exit Sub
        End If

        ' Proceed with the update if all fields are filled
        Dim latestServiceID As Integer = GetLatestServiceID()

        If latestServiceID > 0 Then
            Dim query As String = "UPDATE PetMgmtSystem SET CustomerName = @CustomerName, Phone = @Phone, Address = @Address, Age = @Age WHERE ReservationID = @ReservationID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using updateCommand As New SqlCommand(query, connection)
                    ' Add parameters to the SqlCommand
                    updateCommand.Parameters.AddWithValue("@CustomerName", TXTNAME.Text)
                    updateCommand.Parameters.AddWithValue("@Phone", TXTPHONE.Text)
                    updateCommand.Parameters.AddWithValue("@Address", TXTADDRESS.Text)

                    ' Convert age to integer
                    Dim age As Integer
                    If Integer.TryParse(TXTAGE.Text, age) Then
                        updateCommand.Parameters.AddWithValue("@Age", age)
                        PNLPAYMENT.Visible = True
                        PNLINFO.Visible = False
                    Else
                        MessageBox.Show("Please enter a valid age.")
                        Exit Sub
                    End If

                    updateCommand.Parameters.AddWithValue("@ReservationID", latestServiceID)

                    ' Execute the update command
                    updateCommand.ExecuteNonQuery()


                End Using
            End Using
        Else
            MessageBox.Show("No records found to update.")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        GetLatestServiceID()
        UpdateLatestPetService()
        txtTotal.Text = nights.Text
    End Sub

    Private Sub PNLAGAIN_Paint(sender As Object, e As PaintEventArgs) Handles PNLAGAIN.Paint

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ClearFormFields()
        nights.Text = ""
        Sitter.Text = ""
        PICKUP.Text = ""
        WEIGHT.Text = ""
        TextBox1.Text = ""
        TXTADDRESS.Text = ""
        TXTAGE.Text = ""
        TXTNAME.Text = ""
        TXTPHONE.Text = ""
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim sql As String = "DELETE FROM PetMgmtSystem WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using

        ' Optional: Display a message
        PNLMAIN.Visible = True
        PNLNUMBER.Visible = False
        MessageBox.Show("The latest reservation has been restarted. Please Select Your Service!")

    End Sub

    Private Sub PNLMAIN_Paint(sender As Object, e As PaintEventArgs) Handles PNLMAIN.Paint

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        PNLAGAIN.Visible = False
        PNLMAIN.Visible = True
        ClearFormFields()

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        PNLAGAIN.Visible = False
        PNLMAIN.Visible = True
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        PICKUP.Text = "YES"
        UpdatePetPICKUP(PICKUP.Text)
        PNLPICKUP.Visible = False
        PNLINFO.Visible = True
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        PICKUP.Text = "NO"
        UpdatePetPICKUP(PICKUP.Text)
        PNLPICKUP.Visible = False
        PNLINFO.Visible = True
    End Sub

    ' Assuming you have a button named "btnFetchData" and 
    ' labels named "lblNumCustomers", "lblTotalRevenue", "lblMostOrderedCustomer"

    Private Sub FETCHDATA()

        ' 1. Establish database connection (replace with your actual details)
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        ' 2. Execute SQL queries to fetch summary data

        ' 2.1 Number of Customers (assuming each distinct "Pet" represents a customer)
        Dim commandNumCustomers As New SqlCommand("SELECT COUNT(DISTINCT CustomerName) FROM PetMgmtSystem", connection)
        Dim numCustomers As Integer = Convert.ToInt32(commandNumCustomers.ExecuteScalar())
        lblNumberOfCustomers.Text = numCustomers.ToString()

        ' 2.2 Total Revenue (assuming "Price" can be converted to a numeric type)
        Dim commandTotalRevenue As New SqlCommand("SELECT SUM(CONVERT(decimal(18,2), Price)) FROM PetMgmtSystem", connection)
        Dim totalRevenue As Decimal = Convert.ToDecimal(commandTotalRevenue.ExecuteScalar())
        lblTotalRevenue.Text = totalRevenue.ToString("C") ' Format as currency

        ' 2.3 Most Ordered Customer (assuming the customer with most reservations)
        Dim commandMostOrdered As New SqlCommand("SELECT TOP 1 CustomerName, COUNT(*) AS ReservationCount FROM PetMgmtSystem GROUP BY CustomerName ORDER BY ReservationCount DESC", connection)
        Dim reader As SqlDataReader = commandMostOrdered.ExecuteReader()
        If reader.Read() Then
            lblMostOrderedCustomer.Text = reader("CustomerName").ToString()
        Else
            lblMostOrderedCustomer.Text = "  N/A" ' Handle no data case
        End If
        reader.Close()

        ' 3. Close connection
        connection.Close()

    End Sub
    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        'USER
        If TXTPASSWORD.Text = "PASSWORD" And TXTUSERNAME.Text = "USER" Then
            PNLMAIN.Visible = True
            PNLLOGIN.Visible = False
            MessageBox.Show("LOGIN SUCCESSFULL")
            TXTPASSWORD.Text = ""
            TXTUSERNAME.Text = ""
            'ADMIN
        ElseIf TXTPASSWORD.Text = "PASSWORD" And TXTUSERNAME.Text = "ADMIN" Then
            PNLADMIN.Visible = True
            PNLLOGIN.Visible = False
            MessageBox.Show("LOGIN SUCCESSFULL")
            TXTPASSWORD.Text = ""
            TXTUSERNAME.Text = ""
            FETCHDATA()
        Else
            MessageBox.Show("WRONG INPUT")
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Number = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLNUMBER.Visible = True
        PNLPET.Visible = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Pet = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLPET.Visible = True
        PNLBREED.Visible = False
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Breed = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLBREED.Visible = True
        PNLWEIGHT.Visible = False
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Weight = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using

        ' Optional: Display a message
        PNLWEIGHT.Visible = True
        PNLSITTER.Visible = False
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Sitter = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLSITTER.Visible = True
        PNLSCHEDULE.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Date = NULL,Time = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLNIGHTS.Visible = False
        PNLSCHEDULE.Visible = True
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Nights = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLNIGHTS.Visible = True
        PNLPICKUP.Visible = False
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim sql As String = "UPDATE PetMgmtSystem SET Pickup = NULL WHERE ReservationID = (SELECT MAX(ReservationID) FROM PetMgmtSystem)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()

            End Using
        End Using
        PNLPICKUP.Visible = True
        PNLINFO.Visible = False
    End Sub
    Private Sub Pnlclose()
        UpdatePetWeight(WEIGHT.Text)
        PNLWEIGHT.Visible = False
        PNLSITTER.Visible = True
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        WEIGHT.Text = "1-5KG"
        Pnlclose()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        WEIGHT.Text = "6-10KG"
        Pnlclose()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        WEIGHT.Text = "11-20KG"
        Pnlclose()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        WEIGHT.Text = "21-40KG"
        Pnlclose()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        WEIGHT.Text = "40+KG"
        Pnlclose()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PRINT()

        Dim conn As New SqlConnection("Data Source=DESKTOP-D5V36F0\SQLEXPRESS;Initial Catalog=PetMgmt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        conn.Open()

        Dim cmd As New SqlCommand("SELECT * FROM PetMgmtSystem WHERE CustomerName = @CustomerName", conn)
        cmd.Parameters.AddWithValue("@CustomerName", TXTNAME.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        dt.Clear()
        da.Fill(dt)
        conn.Close()

        Dim report As New CrystalReport1
        report.SetDataSource(dt)
        FormPrint.CrystalReportViewer2.ReportSource = report
        FormPrint.CrystalReportViewer2.Refresh()

        FormPrint.Show()


    End Sub

    Private Sub Button27_Click_1(sender As Object, e As EventArgs) Handles Button27.Click
        ' Establish database connection
        Dim connectionString As String = "Data Source=DESKTOP-D5V36F0\SQLEXPRESS;Initial Catalog=PetMgmt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()  ' Open the connection

        ' Prepare the SQL statement to select all columns from the table
        Dim sql As String = "SELECT * FROM PetMgmtSystem"
        Dim command As New SqlCommand(sql, connection)

        ' Create a data adapter and fill a DataTable with the retrieved data
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        dataTable.Clear()
        adapter.Fill(dataTable)

        ' Close the database connection
        connection.Close()

        ' Create a Crystal Report instance and set its data source
        Dim crystalReport As New CrystalReport1
        crystalReport.SetDataSource(dataTable)

        'Set the report source And refresh the Crystal Report Viewer on FormPrint
        FormPrint.CrystalReportViewer2.ReportSource = crystalReport
        FormPrint.CrystalReportViewer2.Refresh()

        ' Show FormPrint
        FormPrint.Show()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If ResID.Text = "" Then
            MessageBox.Show("Put the reservationID on the textbox below first to proceed")

        Else
            ' Establish database connection
            Dim connection As New SqlConnection(connectionString)
            connection.Open()  ' Open the connection

            ' Prepare the SQL statement with a parameter for the ReservationID
            Dim sql As String = "DELETE FROM PetMgmtSystem WHERE ReservationID = @ReservationID"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ReservationID", ResID.Text)

            ' Execute the deletion command
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            ' Close the database connection
            connection.Close()

            Dim message As String = ""

            ' Check if any rows were affected (deleted)
            If rowsAffected > 0 Then
                message = "Reservation with ID " & ResID.Text & " has been deleted successfully."
            Else
                message = "No reservation found with ID " & ResID.Text & "."
            End If

            ' Display message box based on the outcome
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' No need to show the FormPrint since we're deleting data
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click

        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            PNLLOGIN.Visible = True ' Make PNLLOGIN panel visible
            PNLAGAIN.Visible = False ' Make PNLLOGIN panel visible

        Else
            ' Do nothing if the user selects No or closes the message box
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            PNLLOGIN.Visible = True ' Make PNLLOGIN panel visible
            PNLMAIN.Visible = False ' Make PNLLOGIN panel visible

        Else
            ' Do nothing if the user selects No or closes the message box
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            PNLLOGIN.Visible = True ' Make PNLLOGIN panel visible
            PNLADMIN.Visible = False ' Make PNLLOGIN panel visible

        Else
            ' Do nothing if the user selects No or closes the message box
        End If
    End Sub

    Private Sub Panel33_Paint(sender As Object, e As PaintEventArgs) Handles Panel33.Paint

    End Sub

    Private Sub pnlLOGININSIDE_Paint(sender As Object, e As PaintEventArgs) Handles pnlLOGININSIDE.Paint

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub
    Private Sub UpdateLatestPayment()
        ' Check if any of the required text boxes are empty
        If String.IsNullOrWhiteSpace(txtTotal.Text) OrElse
       String.IsNullOrWhiteSpace(txtDiscount.Text) OrElse
       String.IsNullOrWhiteSpace(txtPayment.Text) OrElse
       String.IsNullOrWhiteSpace(txtChange.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Exit Sub
        End If

        ' Proceed with the update if all fields are filled
        Dim latestServiceID As Integer = GetLatestServiceID()

        If latestServiceID > 0 Then
            Dim query As String = "UPDATE PetMgmtSystem SET Total = @Total, Payment = @Payment, Change = @Change, Discount = @Discount WHERE ReservationID = @ReservationID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using updateCommand As New SqlCommand(query, connection)
                    ' Add parameters to the SqlCommand
                    updateCommand.Parameters.AddWithValue("@Total", txtTotal.Text)
                    updateCommand.Parameters.AddWithValue("@Discount", txtDiscount.Text)
                    updateCommand.Parameters.AddWithValue("@Change", txtChange.Text)

                    ' Convert age to integer
                    Dim age As Integer
                    If Integer.TryParse(txtPayment.Text, age) Then
                        updateCommand.Parameters.AddWithValue("@Payment", age)
                        PNLAGAIN.Visible = True
                        PNLPAYMENT.Visible = False
                    Else
                        MessageBox.Show("Please enter a valid age.")
                        Exit Sub
                    End If

                    updateCommand.Parameters.AddWithValue("@ReservationID", latestServiceID)

                    ' Execute the update command
                    updateCommand.ExecuteNonQuery()


                End Using
            End Using
        Else
            MessageBox.Show("No records found to update.")
        End If
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        GetLatestServiceID()

        UpdateLatestPayment()
        PRINT()

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        PNLPAYMENT.Visible = False
        PNLINFO.Visible = True
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged

    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged

    End Sub
End Class
