Public Class Encrypt
    Public Class HillCipher
        Private Function MatMul(block As Integer(), mat2 As Integer(,)) As Integer(,)
            Dim result As Integer(,)

            If Not block.Length = mat2.Length Then
                Return Nothing
            End If

            result = New Integer(,) {}

            For Each i In mat2
                Dim total As Integer

                For Each j In block
                    total += mat2(i, j) * block(j)

                    result.SetValue(total, i, j)
                Next
            Next
            Return result
        End Function



    End Class


End Class
