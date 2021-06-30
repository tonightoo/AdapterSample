Public Class Command2 : Implements ICommand

    Public Sub StartLog() Implements ICommand.StartLog
        Console.WriteLine("Start Command2")
    End Sub

    Public Sub CommandMain() Implements ICommand.CommandMain
        Console.WriteLine("Command2")
    End Sub

    Public Sub EndLog() Implements ICommand.EndLog
        Console.WriteLine("End Command2")
    End Sub
End Class
