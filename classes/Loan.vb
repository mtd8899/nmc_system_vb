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

    Private _dblCollTotalPaid As Double

    Public Sub AddLoan(strCustAccNo As String, strCustName As String, strDateRelease As String _
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
                  @interest_amt, @proc_fee_amt, @terms, @loan_type, @maturity, @co_maker, @collateral, @loan_cycle)"
            cmd1.CommandText = sql1

            cmd1.Parameters.AddWithValue("@loan_acc_no", LoanAccNo)
            cmd1.Parameters.AddWithValue("@cust_id", CustAccNo)
            cmd1.Parameters.AddWithValue("@date_release", _dteDateRelease)
            cmd1.Parameters.AddWithValue("@principal", _intPrincipal)
            cmd1.Parameters.AddWithValue("@interest_amt", _dblIntAmt)
            cmd1.Parameters.AddWithValue("@proc_fee_amt", _dblProcFeeAmt)
            cmd1.Parameters.AddWithValue("@terms", _intTerms)
            cmd1.Parameters.AddWithValue("@loan_type", _TypeOfLoan)
            cmd1.Parameters.AddWithValue("@maturity", _dteMaturity)
            cmd1.Parameters.AddWithValue("@co_maker", strComaker)
            cmd1.Parameters.AddWithValue("@collateral", strCollateral)
            cmd1.Parameters.AddWithValue("@loan_cycle", strCycleNo)
            cmd1.ExecuteNonQuery()
            cmd1.Parameters.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub AddPayment(intLoanAccNo As Integer, intCustID As Integer, DatePaid As Date _
                    , intLoanRep As Integer, intInsurance As Integer, intRefNo As Integer _
                    , intRetFund As Integer, intSavingsDep As Integer, intSavingsWid As Integer _
                    , intPenaltyPaid As Integer, intOtherPayment As Integer, strOtherPaymentDesc As String _
                    , dblPenaltyAddAmt As Double, strPenaltyAddNote As String, strCollBy As String)

        Dim intPrincipal, intNo As Integer
        Dim dblInterestAmt, dblProcFeeAmt, dblTotalPayment As Double

        'If IsNothing(intLoanRep) = True Then
        'intLoanRep = 0

        'ElseIf IsNothing(intSavingsDep) = True Then
        'intSavingsDep = 0

        'ElseIf IsNothing(intRetFund) = True Then
        'intRetFund = 0

        'ElseIf IsNothing(intInsurance) = True Then
        'intInsurance = 0

        'ElseIf IsNothing(intPenaltyPaid) = True Then
        'intPenaltyPaid = 0

        'ElseIf IsNothing(intOtherPayment) = True Then
        'intOtherPayment = 0

        'End If
        Try


            intPrincipal = intLoanRep / 1.4
            dblInterestAmt = intPrincipal * 0.36
            dblProcFeeAmt = intPrincipal * 0.04
            dblTotalPayment = intLoanRep + intSavingsDep + intRetFund + intInsurance + intPenaltyPaid + intOtherPayment

            intNo = CreatePaymentNo()

            openCon()
            Try
                cmd1.Connection = conn
                sql1 = "INSERT INTO tbl_collections VALUES(@no, @ref_no, @cust_id, @payment_date, @loan_acc_no, @principal_amt,
                                                    @interest_amt, @proc_fee_amt, @penalty_paid, @savings_dep, @savings_wid,
                                                    @premium, @ret_fund, @other_payment, @other_payment_desc, @total_payment,
                                                    @penaltyAddAmt, @penaltyAddNote, @collected_by)"
                cmd1.CommandText = sql1

                cmd1.Parameters.AddWithValue("@no", intNo)
                cmd1.Parameters.AddWithValue("@ref_no", intRefNo)
                cmd1.Parameters.AddWithValue("@cust_id", intCustID)
                cmd1.Parameters.AddWithValue("@payment_date", DatePaid)
                cmd1.Parameters.AddWithValue("@loan_acc_no", intLoanAccNo)
                cmd1.Parameters.AddWithValue("@principal_amt", intPrincipal)
                cmd1.Parameters.AddWithValue("@interest_amt", dblInterestAmt)
                cmd1.Parameters.AddWithValue("@proc_fee_amt", dblProcFeeAmt)
                cmd1.Parameters.AddWithValue("@penalty_paid", intPenaltyPaid)
                'cmd1.Parameters.AddWithValue("@savings_acc_no", _strSavingsAccNo)
                cmd1.Parameters.AddWithValue("@savings_dep", intSavingsDep)
                cmd1.Parameters.AddWithValue("@savings_wid", intSavingsWid)
                cmd1.Parameters.AddWithValue("@premium", intInsurance)
                cmd1.Parameters.AddWithValue("@ret_fund", intRetFund)
                cmd1.Parameters.AddWithValue("@other_payment", intOtherPayment)
                cmd1.Parameters.AddWithValue("@other_payment_desc", strOtherPaymentDesc)
                cmd1.Parameters.AddWithValue("@total_payment", dblTotalPayment)
                cmd1.Parameters.AddWithValue("@penaltyAddAmt", dblPenaltyAddAmt)
                cmd1.Parameters.AddWithValue("@penaltyAddNote", strPenaltyAddNote)
                cmd1.Parameters.AddWithValue("@collected_by", strCollBy)
                cmd1.ExecuteNonQuery()
                cmd1.Parameters.Clear()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MsgBox("Added.")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function ShowRate() As String
        Dim strRate As String
        strRate = CStr(_intMonthlyRate) & "%/month"
        Return strRate
    End Function

    Public Function CreatePaymentNo()
        Dim intNo As Integer

        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "SELECT no FROM tbl_collections WHERE no=(SELECT MAX(no) 
                    FROM tbl_collections)"
            cmd1.CommandText = sql1

            reader = cmd1.ExecuteReader
            If (reader.Read()) Then
                intNo = reader("no") + 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Close()
        End Try

        Return intNo
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

    Public Property CollTotalPaid As Double
        Set(value As Double)
            _dblCollTotalPaid = (value)
        End Set
        Get
            Return _dblCollTotalPaid

        End Get
    End Property

End Class
