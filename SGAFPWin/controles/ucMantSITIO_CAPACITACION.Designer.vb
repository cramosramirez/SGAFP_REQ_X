Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSITIO_CAPACITACION
    Inherits SGAFP.ucBaseMant

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UcListaSITIO_CAPACITACION1 = New SGAFP.ucListaSITIO_CAPACITACION
        Me.UcDetalleSITIO_CAPACITACION1 = New SGAFP.ucDetalleSITIO_CAPACITACION
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaSITIO_CAPACITACION1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleSITIO_CAPACITACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaSITIO_CAPACITACION1
        '
        Me.UcListaSITIO_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSITIO_CAPACITACION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaSITIO_CAPACITACION1.Name = "UcListaSITIO_CAPACITACION1"
        Me.UcListaSITIO_CAPACITACION1.PermitirBuscarEntityType = GetType(SITIO_CAPACITACION)
        Me.UcListaSITIO_CAPACITACION1.sError = Nothing
        Me.UcListaSITIO_CAPACITACION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaSITIO_CAPACITACION1.TabIndex = 1
        '
        'UcDetalleSITIO_CAPACITACION1
        '
        Me.UcDetalleSITIO_CAPACITACION1.AutoScroll = True
        Me.UcDetalleSITIO_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleSITIO_CAPACITACION1.EsNuevo = False
        Me.UcDetalleSITIO_CAPACITACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleSITIO_CAPACITACION1.Name = "UcDetalleSITIO_CAPACITACION1"
        Me.UcDetalleSITIO_CAPACITACION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleSITIO_CAPACITACION1.TabIndex = 0
        '
        'ucMantSITIO_CAPACITACION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantSITIO_CAPACITACION"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaSITIO_CAPACITACION1 As SGAFP.ucListaSITIO_CAPACITACION
    Friend WithEvents UcDetalleSITIO_CAPACITACION1 As SGAFP.UcDetalleSITIO_CAPACITACION

End Class
