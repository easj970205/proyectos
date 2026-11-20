Imports System.Windows.Forms

Namespace RegistroEscuela
    ' En este módulo se agrupan las configuraciones iniciales de la aplicación.
    Friend Module ApplicationConfiguration
        Friend Sub Initialize()
            ' Activa los estilos visuales actuales de Windows.
            Application.EnableVisualStyles()
            ' Hace que los textos de los controles se dibujen de forma compatible.
            Application.SetCompatibleTextRenderingDefault(False)
        End Sub
    End Module
End Namespace
