﻿Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarACCION_FORMATIVA
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
        Me.UcListaACCION_FORMATIVA1 = New SGAFP.ucListaACCION_FORMATIVA
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaACCION_FORMATIVA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaACCION_FORMATIVA1
        '
        Me.UcListaACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaACCION_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaACCION_FORMATIVA1.Name = "UcListaACCION_FORMATIVA1"
        Me.UcListaACCION_FORMATIVA1.PermitirAgregar = False
        Me.UcListaACCION_FORMATIVA1.PermitirBuscarEntityType = Nothing
        Me.UcListaACCION_FORMATIVA1.PermitirEliminar = False
        Me.UcListaACCION_FORMATIVA1.PermitirFiltrar = True
        Me.UcListaACCION_FORMATIVA1.PermitirGuardar = False
        Me.UcListaACCION_FORMATIVA1.PermitirNavegacion = False
        Me.UcListaACCION_FORMATIVA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaACCION_FORMATIVA1.sError = Nothing
        Me.UcListaACCION_FORMATIVA1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaACCION_FORMATIVA1.TabIndex = 1
        '
        'ucBuscarACCION_FORMATIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarACCION_FORMATIVA"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(ACCION_FORMATIVA)
    End Sub
    Friend WithEvents UcListaACCION_FORMATIVA1 As SGAFP.ucListaACCION_FORMATIVA

End Class
