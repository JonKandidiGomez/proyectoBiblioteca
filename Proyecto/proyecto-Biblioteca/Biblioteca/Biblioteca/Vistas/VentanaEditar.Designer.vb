<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaEditar
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
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.lAutor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.bGuardarNuevo = New System.Windows.Forms.Button()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.tlpPrincipal.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 6
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipal.Controls.Add(Me.lTitulo, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.lAutor, 1, 2)
        Me.tlpPrincipal.Controls.Add(Me.Label3, 1, 3)
        Me.tlpPrincipal.Controls.Add(Me.TextBox1, 2, 1)
        Me.tlpPrincipal.Controls.Add(Me.TextBox2, 2, 2)
        Me.tlpPrincipal.Controls.Add(Me.NumericUpDown1, 2, 3)
        Me.tlpPrincipal.Controls.Add(Me.bGuardarNuevo, 4, 4)
        Me.tlpPrincipal.Controls.Add(Me.bEditar, 3, 4)
        Me.tlpPrincipal.Controls.Add(Me.bVolver, 3, 5)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 6
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(461, 354)
        Me.tlpPrincipal.TabIndex = 0
        '
        'lTitulo
        '
        Me.lTitulo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Location = New System.Drawing.Point(23, 118)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(36, 13)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "Titulo:"
        '
        'lAutor
        '
        Me.lAutor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lAutor.AutoSize = True
        Me.lAutor.Location = New System.Drawing.Point(24, 144)
        Me.lAutor.Name = "lAutor"
        Me.lAutor.Size = New System.Drawing.Size(35, 13)
        Me.lAutor.TabIndex = 1
        Me.lAutor.Text = "Autor:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Año:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpPrincipal.SetColumnSpan(Me.TextBox1, 3)
        Me.TextBox1.Location = New System.Drawing.Point(65, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpPrincipal.SetColumnSpan(Me.TextBox2, 3)
        Me.TextBox2.Location = New System.Drawing.Point(65, 141)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(373, 20)
        Me.TextBox2.TabIndex = 4
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown1.Location = New System.Drawing.Point(65, 167)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'bGuardarNuevo
        '
        Me.bGuardarNuevo.Location = New System.Drawing.Point(363, 193)
        Me.bGuardarNuevo.Name = "bGuardarNuevo"
        Me.bGuardarNuevo.Size = New System.Drawing.Size(75, 45)
        Me.bGuardarNuevo.TabIndex = 6
        Me.bGuardarNuevo.Text = "Guardar nuevo"
        Me.bGuardarNuevo.UseVisualStyleBackColor = True
        '
        'bEditar
        '
        Me.bEditar.Location = New System.Drawing.Point(282, 193)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(75, 45)
        Me.bEditar.TabIndex = 7
        Me.bEditar.Text = "Editar"
        Me.bEditar.UseVisualStyleBackColor = True
        '
        'bVolver
        '
        Me.bVolver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpPrincipal.SetColumnSpan(Me.bVolver, 2)
        Me.bVolver.Location = New System.Drawing.Point(282, 244)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(156, 33)
        Me.bVolver.TabIndex = 8
        Me.bVolver.Text = "Volver"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'VentanaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 354)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "VentanaEditar"
        Me.Text = "VentanaEditar"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents lTitulo As Label
    Friend WithEvents lAutor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents bEditar As Button
    Friend WithEvents bGuardarNuevo As Button
    Friend WithEvents bVolver As Button
End Class
