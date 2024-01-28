'Alex Wheelock
'RCET0265
'Spring 2024
'Fortune Cookie
'https://github.com/AlexWheelock/FortuneCookie.git

Option Strict On
Option Explicit On

Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        randomNumber = getRandomNumber(5)
        If randomNumber = 1 Then
            Console.WriteLine("                                                                                               @@@@@@
                                                                                             @@@@@@@@@
                                                                                            @@@@@@@@@@@
                                                                                           @@@@@@@@@@@@
                                                                                          @@@@@@@@@@@@@
xxxxxxxxxx                       xxxxxxxxxxx                                              @@@@@@@@@@@@
x        xxxxxx             xxxxxx         xxxx                      xxxxxxxxxxxxx       @@@@@@@@@@@@
x   xxx       xxxxxxxxxxxxxxx      xxxxxx     xxxxx           xxxxxxxx           xx     @@@@@@@@@@@@
xx   xxxxxxxx          xxx                        xxxxxxxxxxxxx          xxxxx    x     @@@@@@@@@@@
 xx    xxx  xxxxxxxxxxxx      xxxxxxxxxxxxxxxxxx      xx       xxxxxxxxxxxxxxx    x    @@@@@@@@@@@
  xx     xxx         xx     xxx                xxxx     xxxxxxxx          xxxx   xx   @@@@@@@@@@@
   xxx     xxxx      x       xxxxxxx       xxxxxx        xx            xxxx    xxx    @@@@@@@@@@
     xxx      xxxxxxx      xxx     xxx   xxx    xxx       xx    xxxxxxxx    xxxx     @@@@@@@@@@
       xxx         xx      xxxxxx            xxxxxx        xxxxxx       xxxxx       @@@@@@@@@@@
         xxxxxxx   x       xxxxxx            xxxxxx         xx    xxxxxxx          @@@@@@@@@@@
               xxxxx         xxx      xx       xxx           xxxxx                 @@@@@@@@@@
                  x        x     x   xx  x   x    x          x                    @@@@@@@@@@
                  x        xxxxxxx  xx   xx  xxxxxx          x                   @@@@@@@@@@
                  x                 xxxxxxx                 xx                  @@@@@@@@@@@
                  x           xxxx            xxx          xx                   @@@@@@@@@@
                  xxx        xx     xxxxxxxx    xxx       xx                   @@@@@@@@@@
              xxxxx xxxx          xxxxxxxxxxxxx         xxx x                 @@@@@@@@@@
             xx        xxxxxxx                       xxxxxx x                 @@@@@@@@@@
             x    xxxxxx     xxxxxxxxxxxxxxxxxxxxxxxxx    xxx                @@@@@@@@@@
           xxx    xxxx xxxxxx     xx             x           xxx            @@@@@@@@@@
           xx    xxxx       xx    x             xx             xxxx        @@@@@@@@@@
             xxxxxxx         xx   xx            x                 xxx     @@@@@@@@@@@
                xx            x    x            x      xxxx         xx   @@@@@@@@@@@
                x       x  x  x    x            x     xx                xxxxx@@@@@@
               xx       xxxx xx   xx            x     x               xxx   xxxxx@
               x         xx  x  xxx             x     x   x           x         xx
               x          xx    x              xx     x   x xxxxxxxxxxx        xx
               xx          xxx xx              x          xxx        x     xx xxxx
                x            xxx               x    xxxxxxx         xx  xxxxxxxxxxx
                xx            xx               xxxxxx    xx      xxxxxxxx   x xxxxxx
                 x     x        xxxx         xxxx         xx               xxxxxxxxxx
                 xx    xx          xxxxxxxxxxx             xx           xxxx xxx    x
                  xx    xx                                  xx     xxxxxx   xxx     xx
                   xx    xxx                                 x     xx     xxxx       x
                    x      xxxx                              x      xxxxxxx  xxxx    x
                     x         xx                            x               xxx    xx
                    xxxx         xxxxx                     xx             xxxx     xx
                   xx  xxx           xxxxxx   xxxxxxxx     xxxxxxxxxxxxxxxx      xxx
                  xx      xxxx                             x   xx       xx    xxxx
                xxx      xx  xxxx                         xx  xx       xx xxxxx
              xxx       xx      xxxxxx                   xx   xxxxxxxxxx
            xxx       xxx            xxxxxxxxxxxxxxxxxxxxx
    xxxxxxxxx     xxxxxx      x               xx         xx
   xx      xxxxxxxx  xx      xx                x          xx
   xx               xx       x                 xx     xx   xxxxx
    x             xxx       xx                  xx     xx      xxxxxx
    x         xxxxx        xx                    xx     xxxx        xxx
   xxxxxxxxxxxx           xx                      xx       xxxxx     xxx
   xx        xx          xx                        xx                xx
            xx                                      xxxx           xxxxxxx
            xxxxxx                                     xxxxxxxxxxxx      xxxxxxx
                 xxxxxxxxxxx                               xxxxxxx           xxx
                  xxx      xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx          xxxxxxxxx x
                 xx              xx              x                  xxx
                xx                xx             xx       xxxx        xxxx
                x    xx            xx             xx     xx  xxxxx       xx
                x   xxxx   xx       xx             xx     xxx    xxxxxxx xxx
                xx xx  x   x xxxx   xx              xxx     xx         xxxxx
                 xxx   x   x    xxxxx                 xxxxxxxx
                  x    x   x     xxx                    xxxxx
                       xx  x
                        xxxx
                         xx



         Its not a bug, its an undocumented feature.")

        ElseIf randomNumber = 2 Then
            Console.WriteLine("When you look at the dark side, careful you must be..." & vbNewLine _
                              & "for the dark side looks back. -Master Yoda")

        ElseIf randomNumber = 3 Then
            Console.WriteLine("No! Try not. Do. Or do not. There is no try. -Master Yoda")

        ElseIf randomNumber = 4 Then
            Console.WriteLine("The greatest teacher, failure is. -Master Yoda")

        ElseIf randomNumber = 5 Then
            Console.WriteLine("To be jedi is to face the truth and choose." & vbNewLine _
                              & "Give off light, or darkness, Padawan." & vbNewLine _
                              & "Be a candle, or be the night. -Master Yoda")

        End If

        Console.Read()
    End Sub

    ''' <summary>
    ''' Returns a random number to decide the output "wisdom" message to the user
    ''' </summary>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Function getRandomNumber(max As Integer) As Integer
        Dim randomNumber As Integer
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Rnd() * max)

        Return randomNumber
    End Function

End Module
