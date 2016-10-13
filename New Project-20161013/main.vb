Module VBModule
 
    Sub Main()
        Console.WriteLine(convertLetter("V"))
    End Sub
    
    Function convertLetter (pv_phoneLetter As String) As String
        Dim lv_number As String
        
        Select Case pv_phoneLetter
            Case "A" To "C"
                lv_number = 2
            Case "D" To "F"
                lv_number = 3
            Case "G" To "I"
                lv_number = 4
            Case "J" To "L"
                lv_number = 5
            Case "M" To "O"
                lv_number = 6
            Case "P" To "S"
                lv_number = 7
            Case "T" To "V"
                lv_number = 8
            Case "W" To "Z"
                lv_number = 9    
        End Select
        
        Return lv_number
            
    End Function
  
End Module
