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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.bRetro = New System.Windows.Forms.Button()
        Me.bAvant = New System.Windows.Forms.Button()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.ControlUsuario1 = New controlBiblioteca.controlUsuario()
        Me.tlpPrincipal.SuspendLayout()
        Me.pDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 2
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.Controls.Add(Me.bRetro, 0, 1)
        Me.tlpPrincipal.Controls.Add(Me.bAvant, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.pDatos, 0, 0)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 2
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.Size = New System.Drawing.Size(588, 296)
        Me.tlpPrincipal.TabIndex = 0
        '
        'bRetro
        '
        Me.bRetro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRetro.Location = New System.Drawing.Point(256, 258)
        Me.bRetro.Name = "bRetro"
        Me.bRetro.Size = New System.Drawing.Size(35, 35)
        Me.bRetro.TabIndex = 0
        Me.bRetro.Text = "<"
        Me.bRetro.UseVisualStyleBackColor = True
        '
        'bAvant
        '
        Me.bAvant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAvant.Location = New System.Drawing.Point(297, 258)
        Me.bAvant.Name = "bAvant"
        Me.bAvant.Size = New System.Drawing.Size(35, 35)
        Me.bAvant.TabIndex = 1
        Me.bAvant.Text = ">"
        Me.bAvant.UseVisualStyleBackColor = True
        '
        'pDatos
        '
        Me.tlpPrincipal.SetColumnSpan(Me.pDatos, 2)
        Me.pDatos.Controls.Add(Me.ControlUsuario1)
        Me.pDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDatos.Location = New System.Drawing.Point(3, 3)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(582, 249)
        Me.pDatos.TabIndex = 2
        '
        'ControlUsuario1
        '
        Me.ControlUsuario1.año = 0
        Me.ControlUsuario1.autor = Nothing
        Me.ControlUsuario1.Location = New System.Drawing.Point(0, 0)
        Me.ControlUsuario1.MaximumSize = New System.Drawing.Size(583, 50)
        Me.ControlUsuario1.MinimumSize = New System.Drawing.Size(583, 50)
        Me.ControlUsuario1.minimunSize = New System.Drawing.Size(0, 0)
        Me.ControlUsuario1.Name = "ControlUsuario1"
        Me.ControlUsuario1.Size = New System.Drawing.Size(583, 50)
        Me.ControlUsuario1.TabIndex = 0
        Me.ControlUsuario1.titulo = Nothing
        '
        'VentanaVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 296)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(604, 4000)
        Me.MinimumSize = New System.Drawing.Size(604, 96)
        Me.Name = "VentanaVer"
        Me.Text = "VentanaVer"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.pDatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents bRetro As Button
    Friend WithEvents bAvant As Button
    Friend WithEvents pDatos As Panel
    Friend WithEvents ControlUsuario1 As controlBiblioteca.controlUsuario
End Class
