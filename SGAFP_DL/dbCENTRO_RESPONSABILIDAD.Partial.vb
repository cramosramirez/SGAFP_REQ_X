Imports System.Text

Partial Public Class dbCENTRO_RESPONSABILIDAD

    Public Function ObtenerListaPorActivas(ByVal AgregarVacio As Boolean, Optional nombreVacio As String = "", Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCENTRO_RESPONSABILIDAD

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CR.* ")
        strSQL.Append("FROM CENTRO_RESPONSABILIDAD CR ")
        strSQL.Append("WHERE ")
        strSQL.Append("( ")
        strSQL.Append("SELECT COUNT(1) ")
        strSQL.Append("FROM CENTRO_RESPONSABILIDAD_UNIDAD CU, UNIDAD_ORGANIZATIVA U ")
        strSQL.Append("WHERE CU.ID_CENTRO_RESPONSABILIDAD = CR.ID_CENTRO_RESPONSABILIDAD ")
        strSQL.Append("AND CU.ID_UNIDAD_ORGANIZATIVA = U.ID_UNIDAD_ORGANIZATIVA ")
        strSQL.Append("AND U.ESTADO = 1 ")
        strSQL.Append(") > 0 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCENTRO_RESPONSABILIDAD

        Try
            Do While dr.Read()
                Dim mEntidad As New CENTRO_RESPONSABILIDAD
                dbAsignarEntidades.AsignarCENTRO_RESPONSABILIDAD(dr, mEntidad)
                mEntidad.NOMBRE_CENTRO_RESPONSABILIDAD = mEntidad.CODIGO_CENTRO_RESPONSABILIDAD.Trim + " " + mEntidad.NOMBRE_CENTRO_RESPONSABILIDAD.Trim
                lista.Add(mEntidad)
            Loop
            If AgregarVacio Then
                Dim lEntidad As New CENTRO_RESPONSABILIDAD
                lEntidad.ID_CENTRO_RESPONSABILIDAD = -1
                lEntidad.NOMBRE_CENTRO_RESPONSABILIDAD = nombreVacio
                lista.Insert(0, lEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function ObtenerListaPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal AgregarVacio As Boolean, Optional nombreVacio As String = "", Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCENTRO_RESPONSABILIDAD
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT CR.* ")
        strSQL.Append("FROM CENTRO_RESPONSABILIDAD CR ")
        strSQL.Append("WHERE ")
        strSQL.Append("( ")
        strSQL.Append("SELECT COUNT(1) ")
        strSQL.Append("FROM CENTRO_RESPONSABILIDAD_UNIDAD CU, UNIDAD_ORGANIZATIVA U ")
        strSQL.Append("WHERE CU.ID_CENTRO_RESPONSABILIDAD = CR.ID_CENTRO_RESPONSABILIDAD ")
        strSQL.Append("AND CU.ID_UNIDAD_ORGANIZATIVA = U.ID_UNIDAD_ORGANIZATIVA ")
        strSQL.Append("AND CU.ID_UNIDAD_ORGANIZATIVA = :ID_UNIDAD_ORGANIZATIVA ")
        strSQL.Append("AND U.ESTADO = 1 ")
        strSQL.Append(") > 0 ")

        op = New OracleParameter(":ID_UNIDAD_ORGANIZATIVA", OracleType.Number)
        op.Value = ID_UNIDAD_ORGANIZATIVA
        args.Add(op)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCENTRO_RESPONSABILIDAD

        Try
            Do While dr.Read()
                Dim mEntidad As New CENTRO_RESPONSABILIDAD
                dbAsignarEntidades.AsignarCENTRO_RESPONSABILIDAD(dr, mEntidad)
                mEntidad.NOMBRE_CENTRO_RESPONSABILIDAD = mEntidad.CODIGO_CENTRO_RESPONSABILIDAD.Trim + " " + mEntidad.NOMBRE_CENTRO_RESPONSABILIDAD.Trim
                lista.Add(mEntidad)
            Loop
            If AgregarVacio Then
                Dim lEntidad As New CENTRO_RESPONSABILIDAD
                lEntidad.ID_CENTRO_RESPONSABILIDAD = -1
                lEntidad.NOMBRE_CENTRO_RESPONSABILIDAD = nombreVacio
                lista.Insert(0, lEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function
End Class
