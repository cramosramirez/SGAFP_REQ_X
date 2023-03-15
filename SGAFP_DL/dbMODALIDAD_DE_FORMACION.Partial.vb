Partial Public Class dbMODALIDAD_DE_FORMACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "ID_MODALIDAD_FORMACION", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaMODALIDAD_DE_FORMACION

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT M.* FROM MODALIDAD_DE_FORMACION M ")


        strSQL.AppendLine(" WHERE ")
        strSQL.AppendLine(" ( ")
        strSQL.AppendLine("   SELECT COUNT(1) FROM CONTRATO_COMPRA_MODALIDAD C ")
        strSQL.AppendLine("   WHERE C.ID_CONTRATO_COMPRA = :ID_CONTRATO_COMPRA AND C.ID_MODALIDAD_FORMACION = M.ID_MODALIDAD_FORMACION ")
        strSQL.AppendLine(" ) > 0 ")
        Dim op As OracleParameter = New OracleParameter(":ID_CONTRATO_COMPRA", OracleType.Number)
        op.Value = ID_CONTRATO_COMPRA
        args.Add(op)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaMODALIDAD_DE_FORMACION

        Try
            Do While dr.Read()
                Dim mEntidad As New MODALIDAD_DE_FORMACION
                AsignarMODALIDAD_DE_FORMACION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
End Class
