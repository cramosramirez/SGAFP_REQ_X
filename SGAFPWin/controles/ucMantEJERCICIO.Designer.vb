Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantEJERCICIO
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
        Me.UcListaEJERCICIO1 = New SGAFP.ucListaEJERCICIO
        Me.UcDetalleEJERCICIO1 = New SGAFP.ucDetalleEJERCICIO
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaEJERCICIO1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleEJERCICIO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaEJERCICIO1
        '
        Me.UcListaEJERCICIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaEJERCICIO1.Location = New System.Drawing.Point(0,0)
        Me.UcListaEJERCICIO1.Name = "UcListaEJERCICIO1"
        Me.UcListaEJERCICIO1.PermitirBuscarEntityType = GetType(EJERCICIO)
        Me.UcListaEJERCICIO1.sError = Nothing
        Me.UcListaEJERCICIO1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaEJERCICIO1.TabIndex = 1
        '
        'UcDetalleEJERCICIO1
        '
        Me.UcDetalleEJERCICIO1.AutoScroll = True
        Me.UcDetalleEJERCICIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleEJERCICIO1.EsNuevo = False
        Me.UcDetalleEJERCICIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleEJERCICIO1.Name = "UcDetalleEJERCICIO1"
        Me.UcDetalleEJERCICIO1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleEJERCICIO1.TabIndex = 0
        '
        'ucMantEJERCICIO
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantEJERCICIO"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaEJERCICIO1 As SGAFP.ucListaEJERCICIO
    Friend WithEvents UcDetalleEJERCICIO1 As SGAFP.UcDetalleEJERCICIO

End Class
