Partial Public Class dbCONTRATO_COMPRA_MODALIDAD

    Public Function EliminarlistaCONTRATO_COMPRA_MODALIDAD(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter
        Dim lResult As Integer

        strSQL.AppendLine("DELETE FROM CONTRATO_COMPRA_MODALIDAD WHERE ID_CONTRATO_COMPRA = :ID_CONTRATO_COMPRA")

        op = New OracleParameter(":ID_CONTRATO_COMPRA", OracleType.Number)
        op.Value = ID_CONTRATO_COMPRA
        args.Add(op)

        Try
            lResult = OracleHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return lResult

        Catch ex As Exception
            Throw ex
        End Try

        Return -1

    End Function
End Class
