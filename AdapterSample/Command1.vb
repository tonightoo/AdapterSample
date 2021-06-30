Public Class Command1 : Implements ICommand

    Public Sub StartLog() Implements ICommand.StartLog
        Console.WriteLine("Start Command1")
    End Sub

    Public Sub CommandMain() Implements ICommand.CommandMain
        Console.WriteLine("Command1")
    End Sub

    Public Sub EndLog() Implements ICommand.EndLog
        Console.WriteLine("End Command1")
    End Sub
End Class
