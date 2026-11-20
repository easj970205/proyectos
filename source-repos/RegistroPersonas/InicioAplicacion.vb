Imports System.Windows.Forms

Friend Module InicioAplicacion
    <STAThread>
    Public Sub Main()
        ' Iniciamos Windows Forms y abrimos el formulario principal.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FormularioPersonas())
    End Sub
End Module
