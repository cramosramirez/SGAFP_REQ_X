Partial Public Class dbTERMINO_PARAMETROS_PAGO

    Public Function ObtenerListaPorCriterios(ByVal TDR As String, _
                                             ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, _
                                             ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, _
                                             ByVal ID_REFERENTE As Decimal, _
                                             ByVal ID_MODALIDAD_FORMACION As Decimal, _
                                             Optional ByVal asColumnaOrden As String = "ID_TERMINO_PARAM", _
                                             Optional ByVal asTipoOrden As String = "DESC") As listaTERMINO_PARAMETROS_PAGO

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim op As OracleParameter

        strSQL.AppendLine(" SELECT T.* ")
        strSQL.AppendLine(" FROM TERMINO_PARAMETROS_PAGO T ")
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If Not String.IsNullOrEmpty(TDR.Trim) Then
            AgregarCondicion(strSQLCondicion, " T.TDR = :TDR ")
            op = New OracleParameter(":TDR", OracleType.VarChar)
            op.Value = TDR
            args.Add(op)
        End If
        If ID_UNIDAD_ORGANIZATIVA <> -1 Then
            AgregarCondicion(strSQLCondicion, " T.ID_UNIDAD_ORGANIZATIVA = :ID_UNIDAD_ORGANIZATIVA ")
            op = New OracleParameter(":ID_UNIDAD_ORGANIZATIVA", OracleType.Number)
            op.Value = ID_UNIDAD_ORGANIZATIVA
            args.Add(op)
        End If
        If ID_CENTRO_RESPONSABILIDAD <> -1 Then
            AgregarCondicion(strSQLCondicion, " T.ID_CENTRO_RESPONSABILIDAD = :ID_CENTRO_RESPONSABILIDAD ")
            op = New OracleParameter(":ID_CENTRO_RESPONSABILIDAD", OracleType.Number)
            op.Value = ID_CENTRO_RESPONSABILIDAD
            args.Add(op)
        End If
        If ID_REFERENTE <> -1 Then
            AgregarCondicion(strSQLCondicion, " T.ID_REFERENTE = :ID_REFERENTE ")
            op = New OracleParameter(":ID_REFERENTE", OracleType.Number)
            op.Value = ID_REFERENTE
            args.Add(op)
        End If
        If ID_MODALIDAD_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " (SELECT COUNT(1) FROM TERMINO_PAGO_MODALIDAD M WHERE M.ID_TERMINO_PARAM = T.ID_TERMINO_PARAM AND M.ID_MODALIDAD_FORMACION = :ID_MODALIDAD_FORMACION) > 0 ")
            op = New OracleParameter(":ID_MODALIDAD_FORMACION", OracleType.Number)
            op.Value = ID_MODALIDAD_FORMACION
            args.Add(op)
        End If
        AgregarCondicion(strSQLCondicion, " T.ACTIVO = :ACTIVO ")
        op = New OracleParameter(":ACTIVO", OracleType.Number)
        op.Value = 1
        args.Add(op)

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaTERMINO_PARAMETROS_PAGO

        Try
            Do While dr.Read()
                Dim lEntidad As New TERMINO_PARAMETROS_PAGO
                AsignarTERMINO_PARAMETROS_PAGO(dr, lEntidad)
                lista.Add(lEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDatos_SOLICITUD_Y_TDR(ByVal ID_ACCION_FORMATIVA As Decimal) As DataSet
        Dim ds As DataSet

        Try
            Dim arg As OracleParameter
            Dim args As New List(Of OracleParameter)
            Dim strSQL As New StringBuilder
            strSQL.AppendLine("SELECT G.ID_MODALIDAD_FORMACION, RTRIM(T.TDR) AS TDR, ")
            strSQL.AppendLine("S.ID_UNIDAD_ORGANIZATIVA, S.ID_CENTRO_RESPONSABILIDAD, S.ID_REFERENTE ")
            strSQL.AppendLine("FROM TERMINO_REFERENCIA_AF T, GRUPO_SOLICITUD G, SOLICITUD_CAPACITACION S ")
            strSQL.AppendLine("WHERE T.TDR = G.TDR ")
            strSQL.AppendLine("AND T.CORRELATIVO_GRUPO = G.CORRELATIVO_GRUPO ")
            strSQL.AppendLine("AND G.ID_SOLICITUD = S.ID_SOLICITUD ")
            strSQL.AppendLine("AND T.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")

            arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
            arg.Value = ID_ACCION_FORMATIVA
            args.Add(arg)

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
End Class
