Partial Public Class dbTERMINO_PAGO_MODALIDAD

    Public Function EliminarlistaTERMINO_PAGO_MODALIDAD(ByVal ID_TERMINO_PARAM As Decimal) As Integer

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter
        Dim lResult As Integer

        strSQL.AppendLine("DELETE FROM TERMINO_PAGO_MODALIDAD WHERE ID_TERMINO_PARAM = :ID_TERMINO_PARAM")

        op = New OracleParameter(":ID_TERMINO_PARAM", OracleType.Number)
        op.Value = ID_TERMINO_PARAM
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
