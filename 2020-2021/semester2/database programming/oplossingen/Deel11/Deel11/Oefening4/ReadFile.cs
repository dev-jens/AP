using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(FillRowMethodName ="ReadRow",
        TableDefinition ="Line NVARCHAR(MAX), NumCharacters INT, NumWords INT")]
    public static IEnumerable ReadFile(SqlString filePath)
    {
        string line;
        ArrayList ArrayLines = new ArrayList();
        System.IO.StreamReader file = new System.IO.StreamReader(filePath.Value);

        while ((line = file.ReadLine()) != null)
        {
            ArrayLines.Add(line);
        }

        return ArrayLines;
    }

    public static void ReadRow(object obj, out string line, out int numchar, out int numwords)
    {
        line = obj.ToString();
        numchar = line.Length;
        numwords = line.Split(' ').Length;
    }
}
