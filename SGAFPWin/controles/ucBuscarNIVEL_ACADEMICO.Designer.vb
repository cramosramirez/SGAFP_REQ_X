Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarNIVEL_ACADEMICO
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
        Me.UcListaNIVEL_ACADEMICO1 = New SGAFP.ucListaNIVEL_ACADEMICO
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaNIVEL_ACADEMICO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaNIVEL_ACADEMICO1
        '
        Me.UcListaNIVEL_ACADEMICO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaNIVEL_ACADEMICO1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaNIVEL_ACADEMICO1.Name = "UcListaNIVEL_ACADEMICO1"
        Me.UcListaNIVEL_ACADEMICO1.PermitirAgregar = False
        Me.UcListaNIVEL_ACADEMICO1.PermitirBuscarEntityType = Nothing
        Me.UcListaNIVEL_ACADEMICO1.PermitirEliminar = False
        Me.UcListaNIVEL_ACADEMICO1.PermitirFiltrar = True
        Me.UcListaNIVEL_ACADEMICO1.PermitirGuardar = False
        Me.UcListaNIVEL_ACADEMICO1.PermitirNavegacion = False
        Me.UcListaNIVEL_ACADEMICO1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaNIVEL_ACADEMICO1.sError = Nothing
        Me.UcListaNIVEL_ACADEMICO1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaNIVEL_ACADEMICO1.TabIndex = 1
        '
        'ucBuscarNIVEL_ACADEMICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarNIVEL_ACADEMICO"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(NIVEL_ACADEMICO)
    End Sub
    Friend WithEvents UcListaNIVEL_ACADEMICO1 As SGAFP.ucListaNIVEL_ACADEMICO

End Class
