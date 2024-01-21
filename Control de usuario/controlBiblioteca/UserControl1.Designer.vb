<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpControl = New System.Windows.Forms.TableLayoutPanel()
        Me.lAutor = New System.Windows.Forms.Label()
        Me.lAlbum = New System.Windows.Forms.Label()
        Me.lFecha = New System.Windows.Forms.Label()
        Me.tbAutor = New System.Windows.Forms.TextBox()
        Me.tbAño = New System.Windows.Forms.TextBox()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.tbAlbum = New System.Windows.Forms.TextBox()
        Me.tlpControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpControl
        '
        Me.tlpControl.ColumnCount = 6
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpControl.Controls.Add(Me.lAutor, 0, 0)
        Me.tlpControl.Controls.Add(Me.lAlbum, 0, 1)
        Me.tlpControl.Controls.Add(Me.lFecha, 2, 0)
        Me.tlpControl.Controls.Add(Me.tbAutor, 1, 0)
        Me.tlpControl.Controls.Add(Me.tbAño, 3, 0)
        Me.tlpControl.Controls.Add(Me.bEditar, 4, 0)
        Me.tlpControl.Controls.Add(Me.bBorrar, 5, 0)
        Me.tlpControl.Controls.Add(Me.tbAlbum, 1, 1)
        Me.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControl.Location = New System.Drawing.Point(0, 0)
        Me.tlpControl.Name = "tlpControl"
        Me.tlpControl.RowCount = 2
        Me.tlpControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControl.Size = New System.Drawing.Size(583, 50)
        Me.tlpControl.TabIndex = 0
        '
        'lAutor
        '
        Me.lAutor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lAutor.AutoSize = True
        Me.lAutor.Location = New System.Drawing.Point(5, 6)
        Me.lAutor.MinimumSize = New System.Drawing.Size(35, 13)
        Me.lAutor.Name = "lAutor"
        Me.lAutor.Size = New System.Drawing.Size(35, 13)
        Me.lAutor.TabIndex = 0
        Me.lAutor.Text = "Autor:"
        '
        'lAlbum
        '
        Me.lAlbum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lAlbum.AutoSize = True
        Me.lAlbum.Location = New System.Drawing.Point(3, 31)
        Me.lAlbum.MinimumSize = New System.Drawing.Size(39, 13)
        Me.lAlbum.Name = "lAlbum"
        Me.lAlbum.Size = New System.Drawing.Size(39, 13)
        Me.lAlbum.TabIndex = 1
        Me.lAlbum.Text = "Album:"
        '
        'lFecha
        '
        Me.lFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lFecha.AutoSize = True
        Me.lFecha.Location = New System.Drawing.Point(304, 18)
        Me.lFecha.MinimumSize = New System.Drawing.Size(29, 13)
        Me.lFecha.Name = "lFecha"
        Me.tlpControl.SetRowSpan(Me.lFecha, 2)
        Me.lFecha.Size = New System.Drawing.Size(29, 13)
        Me.lFecha.TabIndex = 2
        Me.lFecha.Text = "Año:"
        '
        'tbAutor
        '
        Me.tbAutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAutor.Location = New System.Drawing.Point(48, 3)
        Me.tbAutor.MaxLength = 50
        Me.tbAutor.MinimumSize = New System.Drawing.Size(250, 20)
        Me.tbAutor.Name = "tbAutor"
        Me.tbAutor.ReadOnly = True
        Me.tbAutor.Size = New System.Drawing.Size(250, 20)
        Me.tbAutor.TabIndex = 3
        '
        'tbAño
        '
        Me.tbAño.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbAño.Location = New System.Drawing.Point(339, 15)
        Me.tbAño.MaxLength = 4
        Me.tbAño.MinimumSize = New System.Drawing.Size(51, 20)
        Me.tbAño.Name = "tbAño"
        Me.tbAño.ReadOnly = True
        Me.tlpControl.SetRowSpan(Me.tbAño, 2)
        Me.tbAño.Size = New System.Drawing.Size(51, 20)
        Me.tbAño.TabIndex = 5
        '
        'bEditar
        '
        Me.bEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEditar.Location = New System.Drawing.Point(403, 10)
        Me.bEditar.Margin = New System.Windows.Forms.Padding(10)
        Me.bEditar.MinimumSize = New System.Drawing.Size(75, 30)
        Me.bEditar.Name = "bEditar"
        Me.tlpControl.SetRowSpan(Me.bEditar, 2)
        Me.bEditar.Size = New System.Drawing.Size(75, 30)
        Me.bEditar.TabIndex = 6
        Me.bEditar.Text = "Editar"
        Me.bEditar.UseVisualStyleBackColor = True
        '
        'bBorrar
        '
        Me.bBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBorrar.Location = New System.Drawing.Point(498, 10)
        Me.bBorrar.Margin = New System.Windows.Forms.Padding(10)
        Me.bBorrar.MinimumSize = New System.Drawing.Size(75, 30)
        Me.bBorrar.Name = "bBorrar"
        Me.tlpControl.SetRowSpan(Me.bBorrar, 2)
        Me.bBorrar.Size = New System.Drawing.Size(75, 30)
        Me.bBorrar.TabIndex = 7
        Me.bBorrar.Text = "Borrar"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'tbAlbum
        '
        Me.tbAlbum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAlbum.Location = New System.Drawing.Point(48, 28)
        Me.tbAlbum.MinimumSize = New System.Drawing.Size(250, 20)
        Me.tbAlbum.Name = "tbAlbum"
        Me.tbAlbum.ReadOnly = True
        Me.tbAlbum.Size = New System.Drawing.Size(250, 20)
        Me.tbAlbum.TabIndex = 8
        '
        'controlUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpControl)
        Me.MaximumSize = New System.Drawing.Size(583, 50)
        Me.MinimumSize = New System.Drawing.Size(583, 50)
        Me.Name = "controlUsuario"
        Me.Size = New System.Drawing.Size(583, 50)
        Me.tlpControl.ResumeLayout(False)
        Me.tlpControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpControl As TableLayoutPanel
    Friend WithEvents lAutor As Label
    Friend WithEvents lAlbum As Label
    Friend WithEvents lFecha As Label
    Friend WithEvents tbAutor As TextBox
    Friend WithEvents tbAño As TextBox
    Friend WithEvents bEditar As Button
    Friend WithEvents bBorrar As Button
    Friend WithEvents tbAlbum As TextBox
End Class
