<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaInicio
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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.bVerBiblioteca = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.tlpPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 1
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipal.Controls.Add(Me.bVerBiblioteca, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.bModificar, 0, 1)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 2
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(189, 220)
        Me.tlpPrincipal.TabIndex = 0
        '
        'bVerBiblioteca
        '
        Me.bVerBiblioteca.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bVerBiblioteca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVerBiblioteca.Location = New System.Drawing.Point(17, 18)
        Me.bVerBiblioteca.Margin = New System.Windows.Forms.Padding(10)
        Me.bVerBiblioteca.Name = "bVerBiblioteca"
        Me.bVerBiblioteca.Size = New System.Drawing.Size(154, 82)
        Me.bVerBiblioteca.TabIndex = 0
        Me.bVerBiblioteca.Text = "Ver biblioteca"
        Me.bVerBiblioteca.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.Location = New System.Drawing.Point(17, 120)
        Me.bModificar.Margin = New System.Windows.Forms.Padding(10)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(154, 82)
        Me.bModificar.TabIndex = 1
        Me.bModificar.Text = "Modificar datos"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'VentanaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 220)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.MinimumSize = New System.Drawing.Size(205, 259)
        Me.Name = "VentanaInicio"
        Me.Text = "Inicio"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents bVerBiblioteca As Button
    Friend WithEvents bModificar As Button
End Class
