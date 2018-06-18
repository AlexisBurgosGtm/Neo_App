Imports DevExpress.XtraSplashScreen

Public Class view_login

    Dim objLogin As New modelLogin

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If Me.txtUsuario.Text <> "" Then
            If Me.txtPass.Text <> "" Then

                If objLogin.fcn_Login(Me.txtUsuario.Text, Me.txtPass.Text) = True Then
                    SplashScreenManager.ShowForm(Me.ParentForm, GetType(GlobalWaitForm), True, True, ParentFormState.Locked)

                    Call index.CargarInterfaz(True)

                    SplashScreenManager.CloseForm()

                Else
                    Call fcn_Mensaje("Usuario o Contraseña Incorrecta", Me.ParentForm)
                End If

            Else
                Call fcn_Mensaje("Escriba la contraseña de Usuario", Me.ParentForm)
            End If

        Else
            Call fcn_Mensaje("Escriba el nombre de Usuario", Me.ParentForm)
        End If



    End Sub
End Class
