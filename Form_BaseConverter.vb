Public Class Form_BaseConverter
    Dim numLetter As List(Of String) = New List(Of String) _
                  (New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                 "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                 "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                 "U", "V", "W", "X", "Y", "Z"})

    Public Function IsValidNumBase(ByVal str1 As String, ByVal base As Byte) As Boolean
        For x As Long = 0 To str1.Length - 1
            If Not (numLetter.Contains(str1.Substring(x, 1).ToUpper)) Or ((base - 1) < numLetter.IndexOf(str1.Substring(x, 1).ToUpper)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function Convert(ByVal base As Byte, ByVal convert_to As Byte, ByVal inputnumber As String) As String
        'if the base or convert_to base are less than 2 or greater than 36, return:
        If (base < 2 Or base > 36) Or (convert_to < 2 Or convert_to > 36) Then
            Return "Invalid base"
        End If

        'If the value is non alphanumeric or is incorrect for its base (ex "FF" for base 15 and under) then we'll return this error:
        If Not (IsValidNumBase(inputnumber, base)) Then
            Return "Invalid Input"
        End If

        'if the current base and the base to convert into are the same, return numtoconvert
        If base = convert_to Then
            Return inputnumber
        End If

        Dim decvaltoconvert As Long = 0
        'convert into a decimal value before working w/ it
        If (base = 10) Then
            decvaltoconvert = CType(inputnumber, Long)
        Else
            Dim place As Long = 0
            For x As Long = inputnumber.Length - 1 To 0 Step -1
                'only using integer because .substring will not accept a biginteger value, besides, if its over 2.4billion digits long, u don't want to use this program anyway.

                decvaltoconvert += CType((numLetter.IndexOf(inputnumber.Substring(x, 1).ToUpper) * (base ^ CInt(place))), Long)
                place += 1
            Next
        End If

        'if the output base is base 10, no need to work with it further
        If convert_to = 10 Then
            Return decvaltoconvert.ToString
        End If

        'convert into the desired base
        Dim returnstr As String = ""
        While decvaltoconvert > 0
            Dim tempval As Long = decvaltoconvert Mod CType(convert_to, Long) 'modulus division with the Biginteger class, sets tempval to the remainder
            'Note that if u put tempval = .Divrem(....) then it sets tempval equal to decvaltoconvert / convert base, which is useless for what we need.

            returnstr = String.Concat(returnstr, numLetter.Item(CType(tempval, Long)))

            decvaltoconvert = CType(decvaltoconvert / convert_to, Long)
        End While

        returnstr = StrReverse(returnstr)
        Return returnstr
    End Function

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        Dim input As String = NumberInput.Text
        Dim input_base As Long = BaseInput.Text
        Dim output_base As Long = BaseOutput.Text

        Label_Converted.Text = Convert(input_base, output_base, input)
    End Sub
End Class
