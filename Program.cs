string[] table = new string[5] {"bud", "fill", "array", "yes", "42"};
string[] tale3 = new string[table.Length];

void Fill(string[] table, string[] tale3)
{ 
int count = 0;
for (int i = 0; i < table.Length; i++)
{
     if(table[i].Length <= 3)
     {
        tale3[count] = table[i];
        count++;
     }
}
}

void Print(string[] table)
{ 
for (int i = 0; i < table.Length; i++)
{
    System.Console.WriteLine($"{table[i]}");
}
}


Fill(table, tale3);
Print(tale3);