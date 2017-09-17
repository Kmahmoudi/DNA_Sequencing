Public Class MainForm

    Dim DeBruijnGraph As New List(Of vertex)
    Dim sample As New List(Of String)
    Dim reads As New List(Of String)
    Dim setinputseq As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sample.Clear()
        reads.Clear()
        Output.Clear()
        GenerateDNA(Val(DnaLength.Text))
    End Sub


    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Public Sub echo(ByVal msg As String)
        Output.AppendText(vbNewLine + msg)
        Output.ScrollToCaret()
    End Sub
    Private Sub GenerateDNA(ByVal Length As Integer)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = Val(DnaLength.Text)
        echo("Generating DNA sequence... ")
        Dim seq As String = ""
        Dim L As Long = Val(DnaLength.Text)
        Dim A As Integer = Val(Apercent.Text) / 100 * L
        Dim T As Integer = Val(Tpercent.Text) / 100 * L
        Dim C As Integer = Val(Cpercent.Text) / 100 * L
        Dim G As Integer = Val(Gpercent.Text) / 100 * L
        Dim RepeatedSeq As New Stack(Of String)
        For Each line As String In Repeats.Lines
            Dim rpt As String = line.Substring(0, line.IndexOf(","))
            Dim cnt As Integer = Val(line.Substring(line.IndexOf(",") + 1))
            For i = 1 To cnt
                RepeatedSeq.Push(rpt)
            Next i
            A = A - (CountCharacter(rpt, "A") * cnt)
            C = C - (CountCharacter(rpt, "C") * cnt)
            T = T - (CountCharacter(rpt, "T") * cnt)
            G = G - (CountCharacter(rpt, "G") * cnt)
        Next
        Dim Sum = A + T + C + G
        If Sum < 0 Then
            MsgBox("Error DNA Length not sufficient")
            Exit Sub
        End If
        If Val(Apercent.Text) + Val(Cpercent.Text) + Val(Tpercent.Text) + Val(Gpercent.Text) > 100 Then
            MsgBox("Invalid percentage (>100) !")
            Exit Sub
        End If

        While (L > 0)
            My.Application.DoEvents()
            Dim choose As Integer = randomN(1, 5)
            If A <= 0 And C <= 0 And T <= 0 And G <= 0 Then
                If (RepeatedSeq.Count > 0) Then
                    choose = 5
                Else
                    Dim r = randomN(1, 4)
                    Select Case r
                        Case 1
                            seq += "A"
                            L -= 1
                            A -= 1
                        Case 2
                            seq += "C"
                            L -= 1
                            C -= 1
                        Case 3
                            seq += "T"
                            L -= 1
                            T -= 1
                        Case 4
                            seq += "G"
                            L -= 1
                            G -= 1
                    End Select
                End If
            End If
            Select Case choose
                Case 1
                    If A <= 0 Then
                        Continue While
                    End If
                    seq += "A"
                    A -= 1
                    L -= 1
                Case 2
                    If T <= 0 Then
                        Continue While
                    End If
                    seq += "T"
                    T -= 1
                    L -= 1
                Case 3
                    If C <= 0 Then
                        Continue While
                    End If
                    seq += "C"
                    C -= 1
                    L -= 1
                Case 4
                    If G <= 0 Then
                        Continue While
                    End If
                    seq += "G"
                    G -= 1
                    L -= 1
                Case 5
                    If (RepeatedSeq.Count > 0) Then
                        Dim x = RepeatedSeq.Pop()
                        seq += x
                        L -= x.Length
                    End If
            End Select
            If (Val(DnaLength.Text) - L < ProgressBar1.Maximum) Then
                ProgressBar1.Value = Val(DnaLength.Text) - L
            End If
            My.Application.DoEvents()
        End While
        echo("DNA generation done.")
        'seq = "ZABCDABEFABY"
        'seq = "AAABBBA"
        If (setinputseq) Then
            seq = InputSeq.Text
        End If
        sample.Add(seq)
        echo("DNA: " + vbNewLine + seq)
        echo("Creating DNA duplicates ...")
        For i = 1 To Val(NumOfDuplicates.Text)
            sample.Add(seq)
        Next
        echo("Duplication progress done.")
        ProgressBar1.Value = 0
    End Sub
    Private Function randomN(ByVal lowerbound As Integer, ByVal upperbound As Integer) As Integer
        Return CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    End Function

    Public Sub addnode(ByVal name As String)
        Dim found = False
        For Each v As vertex In DeBruijnGraph
            If (v.name = name) Then
                found = True
            End If
        Next
        If (found = False) Then
            Dim vr As New vertex
            vr.name = name
            DeBruijnGraph.Add(vr)
        End If
    End Sub

    Public Sub relate(ByVal v1 As vertex, ByVal v2 As vertex, ByVal label As String)
        For Each v As vertex In DeBruijnGraph
            If v.name = v1.name Then
                v.add_edge(v2, label)
            End If
        Next
    End Sub
    Public Sub kgram()
        clearDB()
        Dim graphid As String = Now.ToBinary.ToString
        echo("creating k-grams ...")
        Dim k = 3
        Dim k3grams As New List(Of String)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = reads.Count
        For Each r As String In reads
            For i = 0 To r.Length - k
                Dim kg = r.Substring(i, k)
                k3grams.Add(kg)
            Next
            ProgressBar1.Value += 1
        Next
        echo("creating De Bruijn graph ...")
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = k3grams.Count
        For Each node As String In k3grams
            Dim left2gram = node.Substring(0, 2)
            Dim right2gram = node.Substring(1, 2)
            CreateNode(left2gram, "value", left2gram)
            CreateNode(right2gram, "value", right2gram)
            addnode(left2gram)
            addnode(right2gram)
            Dim v1 As New vertex
            Dim v2 As New vertex
            v1.name = left2gram
            v2.name = right2gram
            Dim lblc = left2gram + right2gram(1)
            relate(v1, v2, lblc)
            Relation(lblc, left2gram, right2gram, "value", left2gram, "value", right2gram)
            ProgressBar1.Value += 1
        Next

        echo("De Bruijn graph created.")


        For Each v As vertex In DeBruijnGraph
            For Each e As edge In v.edges
                addinbound(e._to)
            Next
        Next

        For Each v As vertex In DeBruijnGraph
            echo("vertex :" + v.name + "inbound: " + v.inbound.ToString + "outbound:" + v.edges.Count.ToString)
            For Each e As edge In v.edges
                echo(v.name + "-- " + e.label + " -->" + e._to.name)
            Next
        Next

        EulerianPath()

    End Sub

    Public Sub addinbound(ByVal v As vertex)
        For Each vv As vertex In DeBruijnGraph
            If vv.name = v.name Then
                vv.inbound += 1
            End If
        Next
    End Sub

    Public Sub EulerianPath()
        Dim unbalanced = 0
        Dim first As New vertex
        Dim last As New vertex
        Dim current As New vertex
        Dim path As New List(Of vertex)
        Dim stack As New Stack(Of vertex)

        For Each v As vertex In DeBruijnGraph
            My.Application.DoEvents()
            If v.inbound <> v.edges.Count Then
                unbalanced += 1
                If (v.inbound < v.edges.Count) Then
                    first = v
                ElseIf v.inbound > v.edges.Count Then
                    last = v
                End If
            End If
        Next

        If (unbalanced <> 2 And unbalanced <> 0) Then
            echo("cannot find eulerian path but will try to find a path...")
            GoTo els
        Else
            If (unbalanced = 2) Then
                'echo("first: " + first.name)
                current = first
                Do Until current.name = last.name
                    My.Application.DoEvents()

                    For Each v As vertex In DeBruijnGraph
                        My.Application.DoEvents()

                        If v.name = current.edges(0)._to.name Then
                            current.edges.Remove(current.edges(0))
                            path.Add(current)
                            stack.Push(current)
                            current = v
                        End If
                    Next

                Loop
                echo("Euler path:")
                Dim path2 = ""
                For Each v As vertex In path
                    path2 += v.name + " "
                Next
                echo(path2)
                echo("Corresponding sequence for the path :")
                Dim seq = ""
                For Each v As vertex In path
                    seq += v.name(0)
                Next
                seq += last.name
                echo(seq)
                Dim similarity As Single = GetSimilarity(sample(0), seq)
                If (sample(0) = seq) Then
                    similarity = 1
                End If
                similarity = similarity * 100
                echo("Similarity of original dna and the predicted sequence is : " + similarity.ToString + " %")
            Else
els:
                ' start with any path
                'echo("first: " + first.name)
                current = DeBruijnGraph(0)
                Do Until current.name = last.name
                    My.Application.DoEvents()

                    For Each v As vertex In DeBruijnGraph
                        If v.name = current.edges(0)._to.name Then
                            current.edges.Remove(current.edges(0))
                            path.Add(current)
                            stack.Push(current)
                            current = v
                        End If
                    Next

                Loop
                echo("Euler path:")
                Dim path2 = ""
                For Each v As vertex In path
                    path2 += v.name + " "
                Next
                echo(path2)
                echo("Corresponding sequence for the path :")
                Dim seq = ""
                For Each v As vertex In path
                    seq += v.name(0)
                Next
                seq += last.name
                echo(seq)
                Dim similarity As Single = GetSimilarity(sample(0), seq)
                If (sample(0) = seq) Then
                    similarity = 1
                End If
                similarity = similarity * 100
                echo("Similarity of original dna and the predicted sequence is : " + similarity.ToString + " %")
            End If
        End If
    End Sub

    'Levenshtein string matching algorithm
    Public Function GetSimilarity(string1 As String, string2 As String) As Single
        Dim dis As Single = ComputeDistance(string1, string2)
        Dim maxLen As Single = string1.Length
        If maxLen < string2.Length Then
            maxLen = string2.Length
        End If
        If maxLen = 0.0F Then
            Return 1.0F
        Else
            Return 1.0F - dis / maxLen
        End If
    End Function


    Private Function ComputeDistance(s As String, t As String) As Integer
        Dim n As Integer = s.Length
        Dim m As Integer = t.Length
        Dim distance As Integer(,) = New Integer(n, m) {}
        ' matrix
        Dim cost As Integer = 0
        If n = 0 Then
            Return m
        End If
        If m = 0 Then
            Return n
        End If
        'init1

        Dim i As Integer = 0
        While i <= n
            distance(i, 0) = System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Dim j As Integer = 0
        While j <= m
            distance(0, j) = System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
        End While
        'find min distance

        For i = 1 To n
            For j = 1 To m
                cost = (If(t.Substring(j - 1, 1) = s.Substring(i - 1, 1), 0, 1))
                distance(i, j) = Math.Min(distance(i - 1, j) + 1, Math.Min(distance(i, j - 1) + 1, distance(i - 1, j - 1) + cost))
            Next
        Next
        Return distance(n, m)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reads.Clear()
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = sample.Count
        echo("Chop started...")
        For Each sequence As String In sample
            Dim Min = Val(MinChunkSize.Text)
            Dim Max = Val(MaxChunkSize.Text)
            While sequence.Length > 0
                My.Application.DoEvents()
                Dim rnd = randomN(Min, Max)
                If (sequence.Length - rnd >= Min) Then
                    Dim chunk As String = sequence.Substring(0, rnd)
                    echo("seq: " + vbNewLine + sequence)
                    reads.Add(chunk)
                    sequence = sequence.Substring(rnd)
                    echo("chunk size : " + vbNewLine + rnd.ToString)
                    echo("chunk  : " + vbNewLine + chunk)
                    echo("after seq  : " + vbNewLine + sequence)
                Else
                    echo("seq: " + vbNewLine + sequence)
                    reads.Add(sequence)
                    sequence = ""
                End If
            End While
            ProgressBar1.Value += 1
        Next
        echo("Number of chunks created : " + reads.Count.ToString)
        echo("Chop done.")
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeBruijnGraph.Clear()
        kgram()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (setinputseq = True) Then
            MsgBox("set input sequence turned off")
            setinputseq = False
        Else
            MsgBox("set input sequence turned on")
            setinputseq = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub
End Class


Public Class edge
    Public _to As New vertex
    Public label As String
End Class
Public Class vertex
    Public name As String
    Public inbound As Integer = 0
    Public edges As New List(Of edge)
    Public Sub add_edge(ByVal _to As vertex, ByVal label As String)
        Dim exists = False
        'For Each e As edge In edges
        '    If (e._to.name = _to.name) And e.label = label Then
        '        exists = True
        '    End If
        'Next
        If (exists = False) Then
            Dim ed = New edge
            ed._to = _to
            ed.label = label
            edges.Add(ed)
        End If
    End Sub
End Class