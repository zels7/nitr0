Module Module1

    Sub Main()

        Console.Title = "nitr0.exe"

        Dim getprocessname() As Process

        getprocessname = Process.GetProcessesByName("Minecraft.Windows")
        If getprocessname.Count > 0 Then

            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.WriteLine("Locating process...")
            Threading.Thread.Sleep(1500)
            Console.WriteLine("Process ID: 3692")
            Threading.Thread.Sleep(700)
            Console.WriteLine("Found Minecraft Windows 10")
            Threading.Thread.Sleep(800)
            Console.Clear()
            Console.WriteLine("Injection successful!")
            Threading.Thread.Sleep(900)
            Console.Clear()
            Console.WriteLine("Process ID: 3692")
            Console.WriteLine("")
            Console.WriteLine("
  _   _ _ _             
 | \ | (_) |            
 |  \| |_| |_ _ __ ___  
 | . ` | | __| '__/ _ \ 
 | |\  | | |_| | | (_) |
 |_| \_|_|\__|_|  \___/ 
                        
                        ")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("Press enter to eject")
            Console.Read()

        Else

            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.WriteLine("Locating process...")
            Threading.Thread.Sleep(1500)
            Console.WriteLine("Minecraft Windows 10 not found")
            Threading.Thread.Sleep(20000)
            Return


        End If

    End Sub

End Module
