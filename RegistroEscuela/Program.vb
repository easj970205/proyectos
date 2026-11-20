Imports System
Imports System.Windows.Forms

Namespace RegistroEscuela
    ' Esta clase contiene el punto de inicio de la aplicación.
    Public Class Program
        ' STAThread permite que Windows Forms trabaje correctamente con la interfaz gráfica.
        <STAThread>
        Public Shared Sub Main()
            ' Primero configuramos los estilos visuales de Windows Forms.
            ApplicationConfiguration.Initialize()
            ' Después abrimos el formulario principal del sistema.
            Application.Run(New MainForm())
        End Sub
    End Class
End Namespace
