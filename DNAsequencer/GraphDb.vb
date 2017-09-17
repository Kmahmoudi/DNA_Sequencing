Module GraphDb

    Public SrvUri As New Uri("http://localhost:7474/db/data")
    Public User As String = "neo4j"
    Public Password As String = "root"

    Public Sub CreateNode(ByVal Label As String, ByVal Prop As String, ByVal Val As String)
        On Error GoTo er1
        Dim CypherQuery As String = "(n:" + Label + " {" + Prop + ":'" + Val + "'})"
        Dim clnt As New Neo4jClient.GraphClient(SrvUri, User, Password)
        clnt.Connect()
        Dim query = clnt.Cypher.Merge(CypherQuery)
        query.ExecuteWithoutResults()
        Exit Sub
er1:    MsgBox(Err.Description)
    End Sub

    Public Sub clearDB()
        On Error GoTo er
        Dim clnt As New Neo4jClient.GraphClient(SrvUri, User, Password)
        clnt.Connect()
        Dim query = clnt.Cypher.Match("(n)").DetachDelete("n")
        query.ExecuteWithoutResults()
        Exit Sub
er:     MsgBox(Err.Description)
    End Sub



    Public Sub Relation(ByVal Relationship As String, ByVal Label1 As String, ByVal Label2 As String, ByVal Key1 As String, ByVal KeyVal1 As String, ByVal Key2 As String, ByVal KeyVal2 As String)
        On Error GoTo er2
        Dim clnt As New Neo4jClient.GraphClient(SrvUri, User, Password)
        clnt.Connect()
        Dim query = clnt.Cypher.Match("((node1:" + Label1 + "))").Match("((node2:" + Label2 + "))").Where("( node1." + Key1 + " = '" + KeyVal1 + "' AND node2." + Key2 + " = '" + KeyVal2 + "' )").Create("((node1)-[r:" + Relationship + "]->(node2))")
        '' not create unique
        query.ExecuteWithoutResults()
        Exit Sub
er2:    MsgBox(Err.Description)
    End Sub



End Module