Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarSITIO_CAPACITACION
    Inherits ucBaseBusqueda

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.UcListaSITIO_CAPACITACION1 = New SGAFP.ucListaSITIO_CAPACITACION
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaSITIO_CAPACITACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaSITIO_CAPACITACION1
        '
        Me.UcListaSITIO_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSITIO_CAPACITACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaSITIO_CAPACITACION1.Name = "UcListaSITIO_CAPACITACION1"
        Me.UcListaSITIO_CAPACITACION1.PermitirAgregar = False
        Me.UcListaSITIO_CAPACITACION1.PermitirBuscarEntityType = Nothing
        Me.UcListaSITIO_CAPACITACION1.PermitirEliminar = False
        Me.UcListaSITIO_CAPACITACION1.PermitirFiltrar = True
        Me.UcListaSITIO_CAPACITACION1.PermitirGuardar = False
        Me.UcListaSITIO_CAPACITACION1.PermitirNavegacion = False
        Me.UcListaSITIO_CAPACITACION1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaSITIO_CAPACITACION1.sError = Nothing
        Me.UcListaSITIO_CAPACITACION1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaSITIO_CAPACITACION1.TabIndex = 1
        '
        'ucBuscarSITIO_CAPACITACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarSITIO_CAPACITACION"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(SITIO_CAPACITACION)
    End Sub
    Friend WithEvents UcListaSITIO_CAPACITACION1 As SGAFP.ucListaSITIO_CAPACITACION

End Class
