Public Class Command3 : Implements ICommand

    Public Sub StartLog() Implements ICommand.StartLog
        Console.WriteLine("Start Command3")
    End Sub

    Public Sub CommandMain() Implements ICommand.CommandMain
        Console.WriteLine("Command3")
    End Sub

    Public Sub EndLog() Implements ICommand.EndLog
        Console.WriteLine("End Command3")
    End Sub
End Class
