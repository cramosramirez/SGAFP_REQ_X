Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSOLIC_EMPLEO_ACTUAL
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
        Me.UcListaSOLIC_EMPLEO_ACTUAL1 = New SGAFP.ucListaSOLIC_EMPLEO_ACTUAL
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1 = New SGAFP.ucDetalleSOLIC_EMPLEO_ACTUAL
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaSOLIC_EMPLEO_ACTUAL1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleSOLIC_EMPLEO_ACTUAL1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaSOLIC_EMPLEO_ACTUAL1
        '
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.Location = New System.Drawing.Point(0,0)
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.Name = "UcListaSOLIC_EMPLEO_ACTUAL1"
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.PermitirBuscarEntityType = GetType(SOLIC_EMPLEO_ACTUAL)
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.sError = Nothing
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.TabIndex = 1
        '
        'UcDetalleSOLIC_EMPLEO_ACTUAL1
        '
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.AutoScroll = True
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.EsNuevo = False
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.Name = "UcDetalleSOLIC_EMPLEO_ACTUAL1"
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.TabIndex = 0
        '
        'ucMantSOLIC_EMPLEO_ACTUAL
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantSOLIC_EMPLEO_ACTUAL"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaSOLIC_EMPLEO_ACTUAL1 As SGAFP.ucListaSOLIC_EMPLEO_ACTUAL
    Friend WithEvents UcDetalleSOLIC_EMPLEO_ACTUAL1 As SGAFP.UcDetalleSOLIC_EMPLEO_ACTUAL

End Class
