Imports System.Data.SqlClient

'Option Strict On
Public Class Loan
    Public Property CustomerName As String
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

    'tblCollection
    Private _intCollTotalPaid As Double

    Friend Sub AddLoan(strCustAccNo As String, strCustName As String, strDateRelease As String _
                       , intPrincipal As Integer, intMonthLyRate As Integer, intProcFeeRate As Integer _
                       , intTerms As Integer, strCycleNo As String, strTypeOfLoan As String, strComaker As String _
                       , strCollateral As String)

        LoanAccNo = CreateLoanID()
        CustAccNo = strCustAccNo
        CustomerName = Split(strCustName, "(").First
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

        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "INSERT INTO loan_release VALUES(@loan_acc_no, @cust_id, @date_release, @principal, 
                  @int_rate, @proc_fee, @terms, @loan_type, @maturity, @co_maker, @collateral)"
            cmd1.CommandText = sql1

            cmd1.Parameters.AddWithValue("@loan_acc_no", LoanAccNo)
            cmd1.Parameters.AddWithValue("@cust_id", CustAccNo)
            cmd1.Parameters.AddWithValue("@date_release", _dteDateRelease)
            cmd1.Parameters.AddWithValue("@principal", _intPrincipal)
            cmd1.Parameters.AddWithValue("@int_rate", _intRate)
            cmd1.Parameters.AddWithValue("@proc_fee", intProcFeeRate)
            cmd1.Parameters.AddWithValue("@terms", _intTerms)
            cmd1.Parameters.AddWithValue("@loan_type", _TypeOfLoan)
            cmd1.Parameters.AddWithValue("@maturity", _dteMaturity)
            cmd1.Parameters.AddWithValue("@co_maker", strComaker)
            cmd1.Parameters.AddWithValue("@collateral", strCollateral)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message & "hi")
        Finally
            conn.Close()
        End Try

        Finalize()

    End Sub

    Public Function ShowRate() As String
        Dim strRate As String
        strRate = CStr(_intMonthlyRate) & "%/month"
        Return strRate
    End Function

    Public Function CreateLoanID()
        Dim intCustID As Integer

        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "SELECT loan_acc_no FROM loan_release WHERE loan_acc_no=(SELECT MAX(loan_acc_no) 
                    FROM loan_release)"
            cmd1.CommandText = sql1

            reader = cmd1.ExecuteReader
            If (reader.Read()) Then
                intCustID = reader("loan_acc_no") + 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Close()
        End Try

        Return intCustID
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

    Public Sub AddCollection(DatePaid As Date, intRefNo As Integer, intLoanRep As Integer, intInsurance As Integer _
                             , intRetFund As Integer, intSavings As Integer, intPenaltyPaid As Integer _
                             , intPenaltyAdd As Integer, strCollBy As String)

        _intPrincipal = intLoanRep / 1.4
        _dblIntAmt = _intPrincipal * 0.36
        _dblProcRep = _intPrincipal * 0.04
        _intCollTotalPaid = intLoanRep + _dblIntAmt + _dblProcRep + intInsurance + intRetFund + intSavings + intPenaltyPaid
        CustAccNo = 12345678
        LoanAccNo = 1000100

        Try
            dbconnection()
            sql = "INSERT INTO tblCollection VALUES(@RefNo, @TotalPaid, @Date, @CustId, @CollectedBy)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", intRefNo)
            cmd.Parameters.AddWithValue("@Date", DatePaid)
            cmd.Parameters.AddWithValue("@CustId", CustAccNo)
            cmd.Parameters.AddWithValue("@CollectedBy", strCollBy)
            cmd.Parameters.AddWithValue("@TotalPaid", _intCollTotalPaid)
            'cmd.ExecuteNonQuery()

            sql = "INSERT INTO tblCollectionLoan VALUES(@RefNo, @LoanAccNo, @PrincipalAmt, @IntAmt, @ProcFee, @PenaltyPaid)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@RefNo", intRefNo)
            cmd.Parameters.AddWithValue("@LoanAccNo", LoanAccNo)
            cmd.Parameters.AddWithValue("@PrincipalAmt", _intPrincipal)
            cmd.Parameters.AddWithValue("@IntAmt", _dblIntAmt)
            cmd.Parameters.AddWithValue("@ProcFee", _dblProcRep)
            cmd.Parameters.AddWithValue("@PenaltyPaid", intPenaltyPaid)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Payment added successfully!")
    End Sub

    Public Property CollTotalPaid As Double
        Set(value As Double)
            _intCollTotalPaid = (value)
        End Set
        Get
            Return _intCollTotalPaid

        End Get
    End Property

End Class
