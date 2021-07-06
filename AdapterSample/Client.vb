Imports AdapterSample.AdapterDelegation
Module Client

    Sub Main(ByVal args As String())
        If args.Length = 0 Then
            Exit Sub
        End If

        Dim command As ICommand

        Select Case args(0)
            Case 1
                command = New Command1()
            Case 2
                command = New Command2()
            Case 3
                command = New Command3()
            Case 4
                command = New Adapter()
            Case Else
                Exit Sub
        End Select

        'テスト


        command.StartLog()
        command.CommandMain()
        command.EndLog()

    End Sub

End Module
