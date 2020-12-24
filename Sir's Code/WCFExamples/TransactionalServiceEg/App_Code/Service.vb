' NOTE: If you change the class name "Service" here, you must also update the reference to "Service" in Web.config and in the associated .svc file.
Public Class Service
    Implements IService

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IService.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService.GetDataUsingDataContract
        If composite.BoolValue Then
            composite.StringValue = (composite.StringValue & "Suffix")
        End If
        Return composite
    End Function

End Class
