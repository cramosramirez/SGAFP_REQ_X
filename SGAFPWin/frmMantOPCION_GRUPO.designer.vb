<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantOPCION_GRUPO
    Inherits SGAFP.frmMantPadre

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
        Me.UcMantOPCION_GRUPO1 = New SGAFP.ucMantOPCION_GRUPO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantOPCION_GRUPO1
        '
        Me.UcMantOPCION_GRUPO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantOPCION_GRUPO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantOPCION_GRUPO1.Name = "UcMantOPCION_GRUPO1"
        Me.UcMantOPCION_GRUPO1.sError = Nothing
        Me.UcMantOPCION_GRUPO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantOPCION_GRUPO1.TabIndex = 6
        '
        'frmMantOPCION_GRUPO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantOPCION_GRUPO1)
        Me.Name = "frmMantOPCION_GRUPO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantOPCION_GRUPO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantOPCION_GRUPO1 As SGAFP.ucMantOPCION_GRUPO

End Class

