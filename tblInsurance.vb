'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblInsurance
    Public Property PolicyNo As String
    Public Property CustID As String
    Public Property InsuranceProd As String
    Public Property InceptionDate As Nullable(Of Date)
    Public Property ExpiryDate As Nullable(Of Date)
    Public Property GrossAmt As Nullable(Of Decimal)
    Public Property NetAmt As Nullable(Of Decimal)
    Public Property Coverage As String

    Public Overridable Property tblCustomer As tblCustomer

End Class