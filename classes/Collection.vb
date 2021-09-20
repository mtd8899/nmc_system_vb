Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Collection
    Dim _dtDatePaid As Date
    Dim _intCustId As Integer
    Dim _intLoanAccNo As Integer
    Dim _intRefNo As Integer
    Dim _dblTotalPaid As Double
    Dim _strCollBy As String
    Dim _strCollNotes As String

    Dim _dblLoanAmort As Double
    Dim _dblPrincipalAmt As Double
    Dim _dblIntAmt As Double
    Dim _dblProcFee As Double
    Dim _dblSavings As Double
    Dim _dblPenaltyPaid As Double

    Dim _dblWithdrawSavings As Double
    Dim _dblSavingsDeposit As Double

    Dim _dblInsurance As Double
    Dim _dblRetFund As Double

    Dim _dblOtherPaymentAmt As Double
    Dim _strOtherPaymentDesc As String

    Dim _dblPenaltyAddAmt As Double
    Dim _dtPenaltyAddDate As Date
    Dim _strPenaltyNote As String

    Public Sub New(DatePaid As Date, intRefNo As Integer, intLoanRep As Integer, intInsurance As Integer _
                    , intRetFund As Integer, intSavings As Integer, intPenaltyPaid As Integer _
                    , intPenaltyAdd As Integer, intWithdrawSavings As Integer, strPenaltyNote As String _
                    , intOtherPayment As Integer, strOtherPaymentDesc As String, strCollBy As String)

        ' Set the property value.
        _dtDatePaid = DatePaid
        _intRefNo = intRefNo
        _dblLoanAmort = intLoanRep
        _strCollBy = strCollBy
        _strCollNotes = ""

        _dblInsurance = intInsurance
        _dblRetFund = intRetFund

        _dblSavingsDeposit = intSavings
        _dblWithdrawSavings = intWithdrawSavings

        _dblPenaltyPaid = intPenaltyPaid

        _dblPenaltyAddAmt = intPenaltyAdd
        _strPenaltyNote = strPenaltyNote
        _dtPenaltyAddDate = _dtDatePaid

        _dblOtherPaymentAmt = intOtherPayment
        _strOtherPaymentDesc = strOtherPaymentDesc

    End Sub
    Public Sub AddCollection_mysql()
        _intCustId = 12345678
        _dblTotalPaid = _dblPrincipalAmt + _dblIntAmt + _dblProcFee + _dblInsurance + _dblRetFund + _dblSavings +
                        _dblPenaltyPaid

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
            & "uid=root;" _
            & "pwd=MySQL@1988;" _
            & "database=nmc_database"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub AddCollection()
        _intCustId = 12345678
        _dblTotalPaid = _dblPrincipalAmt + _dblIntAmt + _dblProcFee + _dblInsurance + _dblRetFund + _dblSavings +
                        _dblPenaltyPaid

        Try
            dbconnection()
            sql = "INSERT INTO tblCollection VALUES(@RefNo, @TotalPaid, @Date, @CustId, @CollectedBy)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", _intRefNo)
            cmd.Parameters.AddWithValue("@Date", _dtDatePaid)
            cmd.Parameters.AddWithValue("@CustId", _intCustId)
            cmd.Parameters.AddWithValue("@TotalPaid", _dblTotalPaid)
            cmd.Parameters.AddWithValue("@CollectedBy", _strCollBy)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added tblCollection!")
    End Sub

    Public Sub AddCollectionLoan()
        _intLoanAccNo = 1000100

        _dblPrincipalAmt = _dblLoanAmort / 1.4
        _dblIntAmt = _dblPrincipalAmt * 0.36
        _dblProcFee = _dblPrincipalAmt * 0.04

        Try
            dbconnection()
            sql = "INSERT INTO tblCollectionLoan VALUES(@RefNo, @LoanAccNo, @PrincipalAmt, @IntAmt, @ProcFee, @PenaltyPaid)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", _intRefNo)
            cmd.Parameters.AddWithValue("@LoanAccNo", _intLoanAccNo)
            cmd.Parameters.AddWithValue("@PrincipalAmt", _dblPrincipalAmt)
            cmd.Parameters.AddWithValue("@IntAmt", _dblIntAmt)
            cmd.Parameters.AddWithValue("@ProcFee", _dblProcFee)
            cmd.Parameters.AddWithValue("@PenaltyPaid", _dblPenaltyPaid)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added to tblCollectionLoan!")
    End Sub

    Public Sub AddCollectionSavings()
        Dim intSavingsAccNo As Integer = 88888888

        Try
            dbconnection()
            sql = "INSERT INTO tblCollectionSavings VALUES(@RefNo, @SavingsAccNo, @WithdrawAmt, @DepositAmt)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", _intRefNo)
            cmd.Parameters.AddWithValue("@SavingsAccNo", intSavingsAccNo)
            cmd.Parameters.AddWithValue("@WithdrawAmt", _dblWithdrawSavings)
            cmd.Parameters.AddWithValue("@DepositAmt", _dblSavingsDeposit)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added to tblCollectionSavings!")
    End Sub

    Public Sub AddCollectionIns()

        Try
            dbconnection()
            sql = "INSERT INTO tblCollectionIns VALUES(@RefNo, @CustID, @Premium, @RetFund)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", _intRefNo)
            cmd.Parameters.AddWithValue("@CustID", _intCustId)
            cmd.Parameters.AddWithValue("@Premium", _dblInsurance)
            cmd.Parameters.AddWithValue("@RetFund", _dblRetFund)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added to tblCollectionIns!")
    End Sub

    Public Sub AddCollMisc()

        Try
            dbconnection()
            sql = "INSERT INTO tblCollMisc VALUES(@RefNo, @CustID, @Amount, @Description)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", _intRefNo)
            cmd.Parameters.AddWithValue("@CustID", _intCustId)
            cmd.Parameters.AddWithValue("@Amount", _dblOtherPaymentAmt)
            cmd.Parameters.AddWithValue("@Description", _strOtherPaymentDesc)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added to tblCollMisc!")
    End Sub

    Public Sub AddPenalty()

        Try
            dbconnection()
            sql = "INSERT INTO tblPenalty VALUES(@RefNo, @Amount, @DateAdded, @LoanAccNo, @Note)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", _intRefNo)
            cmd.Parameters.AddWithValue("@Amount", _dblPenaltyAddAmt)
            cmd.Parameters.AddWithValue("@DateAdded", _dtPenaltyAddDate)
            cmd.Parameters.AddWithValue("@Note", _strPenaltyNote)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added to tblCollMisc!")
    End Sub

End Class
