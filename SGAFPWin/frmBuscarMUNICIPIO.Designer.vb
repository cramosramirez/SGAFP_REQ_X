Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarMUNICIPIO
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
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
        Me.UcBuscarMUNICIPIO1 = New SGAFP.ucBuscarMUNICIPIO
        Me.SuspendLayout()
        '
        'UcBuscarMUNICIPIO1
        '
        Me.UcBuscarMUNICIPIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarMUNICIPIO1.EntityType = GetType(MUNICIPIO)
        Me.UcBuscarMUNICIPIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarMUNICIPIO1.Name = "UcBuscarMUNICIPIO1"
        Me.UcBuscarMUNICIPIO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarMUNICIPIO1.TabIndex = 0
        '
        'frmBuscarMUNICIPIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarMUNICIPIO1)
        Me.Name = "frmBuscarMUNICIPIO"
        Me.Text = "Buscar MUNICIPIO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarMUNICIPIO1 As SGAFP.ucBuscarMUNICIPIO
End Class
