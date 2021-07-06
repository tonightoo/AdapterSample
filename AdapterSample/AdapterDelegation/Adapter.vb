Namespace AdapterDelegation
    Public Class Adapter : Implements ICommand

        Private adaptee As New Adaptee()

        Public Sub StartLog() Implements ICommand.StartLog
            Console.WriteLine("処理を開始します！")
        End Sub

        Public Sub CommandMain() Implements ICommand.CommandMain
            adaptee.WriteHelloWorld()
        End Sub

        Public Sub EndLog() Implements ICommand.EndLog
            Console.WriteLine("処理を終了します！")
        End Sub
    End Class
End Namespace
