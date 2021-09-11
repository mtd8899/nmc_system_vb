Imports System.Data.SqlClient

'Option Strict On
Public Class Loan
    Public Property Customer As String
    Public Property TypeOfLoan As String
    Public Property NoOfCycle As String
    Property CustAccNo As Integer

    Public Property LoanAccNo As String

    Private _dblIntAmt As Double
    Private _dblProcFeeAmt As Double
    Private _dblPayableAmt As Double
    Private _dblAmort As Double
    Private _dteMaturity As Date
    Private _dteDateRelease As Date
    Private _intPrincipal As Integer
    Private _intTerms As Integer
    Private _intRate As Integer
    Private _intMonthlyRate As Integer


    Private _dblPrinRep As Double
    Private _dblIntRep As Double
    Private _dblProcRep As Double

    Friend Sub AddLoan(strCustAccNo As String, strCustName As String, strDateRelease As String, intPrincipal As Integer _
                       , intMonthLyRate As Integer, intProcFeeRate As Integer, intTerms As Integer _
                       , strCycleNo As String, strTypeOfLoan As String)

        LoanAccNo = 1000100
        CustAccNo = CInt(strCustAccNo)
        Customer = strCustName
        _intTerms = intTerms
        _intPrincipal = intPrincipal
        _intMonthlyRate = intMonthLyRate
        TypeOfLoan = strTypeOfLoan
        NoOfCycle = strCycleNo


        _intRate = _intMonthlyRate * (_intTerms \ 4)
        _dblIntAmt = _intPrincipal * (_intRate / 100)
        _dblProcFeeAmt = _intPrincipal * (intProcFeeRate / 100)
        _dblPayableAmt = _intPrincipal + _dblIntAmt + _dblProcFeeAmt
        _dblAmort = _dblPayableAmt / _intTerms

        _dteDateRelease = CType(strDateRelease, Date)
        _dteMaturity = DateAdd("ww", 25, _dteDateRelease)
        '_dteMaturity.ToString("MM/dd/yy")

        'Amortization data
        _dblPrinRep = _dblAmort / 1.4
        _dblIntRep = _dblPrinRep * 0.36
        _dblProcRep = _dblPrinRep * 0.04

        Try
            dbconnection()
            sql = "INSERT INTO tblLoanRelease VALUES(@LoanAccNo, @CustID, @DateRelease, @Principal, @Interest, @ProcFee, @Terms, @LoanType, @Maturity)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@LoanAccNo", LoanAccNo)
            cmd.Parameters.AddWithValue("@CustID", CustAccNo)
            cmd.Parameters.AddWithValue("@DateRelease", _dteDateRelease)
            cmd.Parameters.AddWithValue("@Principal", _intPrincipal)
            cmd.Parameters.AddWithValue("@Interest", _dblIntAmt)
            cmd.Parameters.AddWithValue("@ProcFee", _dblProcFeeAmt)
            cmd.Parameters.AddWithValue("@Terms", _intTerms)
            cmd.Parameters.AddWithValue("@LoanType", _TypeOfLoan)
            cmd.Parameters.AddWithValue("@Maturity", _dteMaturity)
            cmd.ExecuteNonQuery()

            'MsgBox("Customer added successfully!")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Loan added successfully!")

    End Sub

    Public Function ShowRate() As String
        Dim strRate As String
        strRate = CStr(_intMonthlyRate) & "%/month"
        Return strRate
    End Function

    Public Sub AdLoan()

        Try
            dbconnection()
            sql = "INSERT INTO tblLoanRelease VALUES(@LoanAccNo, @CustID, @DateRelease, @Principal, @Interest, @ProcFee, @Terms, @LoanType, @Maturity)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@LoanAccNo", LoanAccNo)
            cmd.Parameters.AddWithValue("@CustID", CustAccNo)
            cmd.Parameters.AddWithValue("@DateRelease", _dteDateRelease)
            cmd.Parameters.AddWithValue("@Principal", _intPrincipal)
            cmd.Parameters.AddWithValue("@Interest", _dblIntAmt)
            cmd.Parameters.AddWithValue("@ProcFee", _dblProcFeeAmt)
            cmd.Parameters.AddWithValue("@Terms", _intTerms)
            cmd.Parameters.AddWithValue("@LoanType", _TypeOfLoan)
            cmd.Parameters.AddWithValue("@Maturity", _dteMaturity)
            cmd.ExecuteNonQuery()

            'MsgBox("Customer added successfully!")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Loan added successfully!")
    End Sub

    Public Function CreateLoanID()
        Dim intCustID As Integer

        dbconnection()
        sql = "SELECT LoanAccNo FROM tblLoanRelease WHERE LoanAccNo=(SELECT MAX(LoanAccNo) FROM tblLoanRelease)"

        cmd = New SqlClient.SqlCommand(sql, con)

        dataReader = cmd.ExecuteReader
        If (dataReader.Read()) Then
            intCustID = dataReader("LoanAccNo") + 1
        End If

        Return intCustID
    End Function

    Public Function FillCboCustName() As Object
        Dim objFillCustName As Object = ""
        dbconnection()
        sql = "SELECT * FROM viewCustName"
        cmd = New SqlClient.SqlCommand(sql, con)

        dataAdapter = New SqlClient.SqlDataAdapter(cmd)
        Dim table As New DataTable()
        dataAdapter.Fill(table)
        objFillCustName.DataSource = table
        objFillCustName.DisplayMember = "CustName"
        objFillCustName.ValueMember = "CustID"

        Return objFillCustName
    End Function

    Public Property Amort As String
        Set(value As String)
            _dblAmort = CDbl(value)
        End Set
        Get
            Return CStr(_dblAmort)
        End Get
    End Property

    Public Property PrincipalAmt As String
        Set(value As String)
            _intPrincipal = CInt(value)
        End Set
        Get
            Return CStr(_intPrincipal)
        End Get
    End Property

    Public Property Maturity As String
        Set(value As String)
            _dteMaturity = CDate(value)
        End Set
        Get
            Return CStr(_dteMaturity)
        End Get
    End Property

    Public Property Terms As String
        Set(value As String)
            _intTerms = CInt(value)
        End Set
        Get
            Return CStr(_intTerms)
        End Get
    End Property

    Public Property Release As Date
        Set(value As Date)
            _dteDateRelease = CDate(value)
        End Set
        Get
            Return _dteDateRelease

        End Get
    End Property
    Public Property Interest As Double
        Set(value As Double)
            _dblIntAmt = (value)
        End Set
        Get
            Return _dblIntAmt

        End Get
    End Property

    Public Property ProcFee As Double
        Set(value As Double)
            _dblProcFeeAmt = (value)
        End Set
        Get
            Return _dblProcFeeAmt

        End Get
    End Property

    Public Property Payable As Double
        Set(value As Double)
            _dblPayableAmt = (value)
        End Set
        Get
            Return _dblPayableAmt

        End Get
    End Property

    Public Property RepPrin As Double
        Set(value As Double)
            _dblPrinRep = (value)
        End Set
        Get
            Return _dblPrinRep

        End Get
    End Property

    Public Property RepInt As Double
        Set(value As Double)
            _dblIntRep = (value)
        End Set
        Get
            Return _dblIntRep

        End Get
    End Property

    Public Property RepProcFee As Double
        Set(value As Double)
            _dblProcRep = (value)
        End Set
        Get
            Return _dblProcRep

        End Get
    End Property

End Class
