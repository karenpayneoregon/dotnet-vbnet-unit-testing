Imports System.Runtime.CompilerServices

Namespace LanguageExtensions
    Public Module StringExtensions
        <Extension> _
        Public Function EqualsIgnoreCase(ByVal first As String, ByVal second As String) As Boolean
            Return String.Equals(first, second, StringComparison.OrdinalIgnoreCase)
        End Function

    End Module
End NameSpace