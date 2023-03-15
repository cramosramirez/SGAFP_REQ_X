Partial Public Class dbTERMINO_PAGO_PENALIZACION

    Public Function ObtenerRANGO_PORC_PENA_PorDIAS(ByVal ID_TERMINO_PARAM As Decimal, ByVal DIAS_TRANSCURRIDOS As Integer, ByVal ID_TIPO_PENA As Decimal) As TERMINO_PAGO_PENALIZACION
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TERMINO_PAGO_PENALIZACION))
        strSQL.Append(" WHERE RANGO_INI <= :DIAS_TRANSCURRIDOS AND RANGO_FIN >= :DIAS_TRANSCURRIDOS ")
        strSQL.Append(" AND ID_TIPO_PENA = :ID_TIPO_PENA AND ID_TERMINO_PARAM = :ID_TERMINO_PARAM")

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":DIAS_TRANSCURRIDOS", OracleType.Number)
        args(0).Value = DIAS_TRANSCURRIDOS

        args(1) = New OracleParameter(":ID_TIPO_PENA", OracleType.Number)
        args(1).Value = ID_TIPO_PENA

        args(2) = New OracleParameter(":ID_TERMINO_PARAM", OracleType.Number)
        args(2).Value = ID_TERMINO_PARAM

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New TERMINO_PAGO_PENALIZACION

        Try
            If dr.HasRows() Then
                dr.Read()
                dbAsignarEntidades.AsignarTERMINO_PAGO_PENALIZACION(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    Public Function EliminarlistaTERMINO_PAGO_PENALIZACION(ByVal ID_TERMINO_PARAM As Decimal) As Integer

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter
        Dim lResult As Integer

        strSQL.AppendLine("DELETE FROM TERMINO_PAGO_PENALIZACION WHERE ID_TERMINO_PARAM = :ID_TERMINO_PARAM")

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
