Option Strict On
Public Class Loan
    Private _strLoanAccNo As String
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

    Friend Sub AddLoan(strCustName As String, strDateRelease As String, intPrincipal As Integer _
                       , intMonthLyRate As Integer, intProcFeeRate As Integer, intTerms As Integer _
                       , strCycleNo As String, strTypeOfLoan As String)

        _intTerms = intTerms
        _intPrincipal = intPrincipal
        _intMonthlyRate = intMonthLyRate
        TypeOfLoan = strTypeOfLoan
        NoOfCycle = strCycleNo
        Customer = strCustName

        _intRate = _intMonthlyRate * (_intTerms \ 4)
        _dblIntAmt = _intPrincipal * (_intRate / 100)
        _dblProcFeeAmt = _intPrincipal * (intProcFeeRate / 100)
        _dblPayableAmt = _intPrincipal + _dblIntAmt + _dblProcFeeAmt
        _dblAmort = _dblPayableAmt / _intTerms

        _dteDateRelease = CType(strDateRelease, Date)
        _dteMaturity = DateAdd("ww", 25, _dteDateRelease)
    End Sub

    Public Function ShowRate() As String
        Dim strRate As String
        strRate = CStr(_intMonthlyRate) & "%/month"
        Return strRate
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

    Public Property Release As String
        Set(value As String)
            _dteDateRelease = CDate(value)
        End Set
        Get
            Return CStr(_dteDateRelease)

        End Get
    End Property

    Public Property Customer As String
    Public Property TypeOfLoan As String
    Public Property NoOfCycle As String
End Class
