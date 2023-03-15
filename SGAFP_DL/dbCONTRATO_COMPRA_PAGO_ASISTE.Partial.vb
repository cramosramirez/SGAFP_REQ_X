Partial Public Class dbCONTRATO_COMPRA_PAGO_ASISTE

    Public Function ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTENCIA As Decimal) As CONTRATO_COMPRA_PAGO_ASISTE
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_COMPRA_PAGO_ASISTE))
        strSQL.Append(" WHERE PORC_ASISTE_INI <= :PORC_ASISTENCIA AND PORC_ASISTE_FIN >= :PORC_ASISTENCIA ")
        strSQL.Append(" AND ID_MODALIDAD_FORMACION = :ID_MODALIDAD_FORMACION ")
        strSQL.Append(" AND ID_CONTRATO_COMPRA = :ID_CONTRATO_COMPRA ")

        Dim args(3) As OracleParameter
        args(0) = New OracleParameter(":ID_MODALIDAD_FORMACION", OracleType.Number)
        args(0).Value = ID_MODALIDAD_FORMACION

        args(1) = New OracleParameter(":PORC_ASISTENCIA", OracleType.Number)
        args(1).Value = PORC_ASISTENCIA

        args(2) = New OracleParameter(":ID_CONTRATO_COMPRA", OracleType.Number)
        args(2).Value = ID_CONTRATO_COMPRA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New CONTRATO_COMPRA_PAGO_ASISTE

        Try
            If dr.HasRows() Then
                dr.Read()
                dbAsignarEntidades.AsignarCONTRATO_COMPRA_PAGO_ASISTE(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    Public Function EliminarlistaCONTRATO_COMPRA_PAGO_ASISTE(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter
        Dim lResult As Integer

        strSQL.AppendLine("DELETE FROM CONTRATO_COMPRA_PAGO_ASISTE WHERE ID_CONTRATO_COMPRA = :ID_CONTRATO_COMPRA")

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
