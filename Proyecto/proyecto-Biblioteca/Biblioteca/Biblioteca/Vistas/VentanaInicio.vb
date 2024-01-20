Public Class VentanaInicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gestorBD As New GestorBD()

    End Sub

    Private Sub VentanaInicio_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        Dim tamFuente As Double = 9 * Me.Width / 210
        tamFuente = IIf(tamFuente < 9, 9, tamFuente)
        tamFuente = IIf(tamFuente > 24, 24, tamFuente)

        For Each control In tlpPrincipal.Controls
            control.Font = New System.Drawing.Font("Microsoft Sans Serif", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next

        Dim altoBoton As Double = 96 * Me.Height / 275
        Dim anchoBoton As Double = 154 * Me.Width / 210

        bVerBiblioteca.Height = altoBoton
        bVerBiblioteca.Width = anchoBoton
        bModificar.Height = altoBoton
        bModificar.Width = anchoBoton
    End Sub

    Private Sub bVerBiblioteca_Click(sender As Object, e As EventArgs) Handles bVerBiblioteca.Click
        VentanaVer.ShowDialog()
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        VentanaEditar.ShowDialog()
    End Sub
End Class
