<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaVer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pDatos
        '
        Me.pDatos.AutoScroll = True
        Me.pDatos.AutoSize = True
        Me.pDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDatos.Location = New System.Drawing.Point(0, 0)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(614, 296)
        Me.pDatos.TabIndex = 0
        '
        'VentanaVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(614, 296)
        Me.Controls.Add(Me.pDatos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(630, 4000)
        Me.MinimumSize = New System.Drawing.Size(630, 96)
        Me.Name = "VentanaVer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaVer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pDatos As Panel
End Class
