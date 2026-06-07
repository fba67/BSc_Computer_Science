using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ll1
{

    public class Scanner
    {
        public string[,] SymbolTable = new string[1000, 3];
        string[] keywords = { "if", "elseif", "while", "record", "not", "for", "return", "var", "begin", "end", "loop", "write", "read", "of", "is", "nil", "array", "program", "div", "mod", "exit", "then", "false", "true", "to", "do", "by", "or", "procedure", "type", "else" };
        string[] types = { "integer", "real", "boolean", "string" };
        int y = 0;
        bool IsDigit(char c)
        {
            if (c - '0' >= 0 && c - '0' < 10)
                return true;
            return false;
        }
        private bool IsNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!IsDigit(s[i]))
                    return false;
            return true;
        }
        bool IsAlphabet(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_')
                return true;
            return false;
        }
        bool Iskeyword(string s)
        {
            for (int i = 0; i < keywords.Length; i++)
                if (s == keywords[i])
                    return true;
            return false;
        }
        bool IsType(string s)
        {
            for (int i = 0; i < types.Length; i++)
                if (s == types[i])
                    return true;
            return false;
        }
        private bool seperator(string s)
        {
            return ((s == " ") || (s == "(") || (s == ")") || (s == "{") || (s == "}") || (s == ":") ||
                    (s == ".") || (s == ";") || (s == ",") || (s == "[") || (s == "]") || (s == "[<") ||
                    (s == ">]"));
        }
        private bool operand(string s)
        {
            return ((s == "*") || (s == "/") || (s == "+") || (s == "-") || (s == "=") || (s == "<") ||
                    (s == ">") || (s == "<=") || (s == ">=") || (s == "<>") || (s == ":="));
        }
        private bool specialcharacter(char c)
        {
            return ((c == '"') || (c == '(') || (c == ')') || (c == '{') || (c == '}') ||
                    (c == ':') || (c == '.') || (c == ';') || (c == ',') || (c == '[') ||
                    (c == ']') || (c == '*') || (c == '/') || (c == '+') || (c == '-') ||
                    (c == '=') || (c == '<') || (c == '>') || (c == ' '));
        }
        public string getstring(string s, ref int p)
        {
            if (p > s.Length - 1)
                return "";

            if (specialcharacter(s[p]))
            {
                // Check for multi character operators
                if (p + 1 < s.Length)
                {
                    if (s[p] == '[' && s[p + 1] == '<')
                    {
                        p += 2;
                        return "[<";
                    }
                    else if (s[p] == '>' && s[p + 1] == ']')
                    {
                        p += 2;
                        return ">]";
                    }
                    else if (s[p] == ':' && s[p + 1] == '=')
                    {
                        p += 2;
                        return ":=";
                    }
                    else if (s[p] == '<' && s[p + 1] == '=')
                    {
                        p += 2;
                        return "<=";
                    }
                    else if (s[p] == '>' && s[p + 1] == '=')
                    {
                        p += 2;
                        return ">=";
                    }
                    else if (s[p] == '<' && s[p + 1] == '>')
                    {
                        p += 2;
                        return "<>";
                    }
                    else if (s[p] == '(' && s[p + 1] == '*')
                    {
                        p += 2;
                        return "(*";
                    }
                    else if (s[p] == '*' && s[p + 1] == ')')
                    {
                        p += 2;
                        return "*)";
                    }
                }

                p++;
                return s[p - 1].ToString();
            }
            else
            {
                string t = "";
                while (p < s.Length && !specialcharacter(s[p]))
                {
                    t += s[p];
                    p++;

                    // Handling the real numbers:
                    if (p < s.Length && s[p] == '.')
                    {
                        if (IsDigit(s[p - 1]))
                        {
                            t += s[p];
                            p++;
                        }
                    }
                }
                return t;
            }
        }
        public void scanner(string[] code)
        {
            //////////////////////////////////Read Input & Enter in Sym TBL///////////////////////////////////
            int n_line = 0;
            int l_line = 0;
            string s1 = "";
            string tmp;
            y = 0;// index for Symbole table ST[y,]
            ///// Clear the Symbol Table//////
            Array.Clear(SymbolTable, 0, 1000);

            //////////////////////////////////

            bool begincomment = false;

            n_line = code.Length;
            for (int k = 0; k < n_line; k++)
            {
                int p = 0;
                s1 = code[k].ToString();
                l_line = s1.Length;
                //Console.WriteLine(s1.Length.ToString());
                while (p < l_line)
                {
                    try
                    {
                        // comment:
                        if (begincomment)
                        {
                            while (p < l_line)
                            {
                                tmp = getstring(s1, ref p);
                                if (tmp == "*)")
                                {
                                    begincomment = false;
                                    break;
                                }
                            }
                        }

                        tmp = getstring(s1, ref p);

                        if (tmp != " " && tmp != "\"" && tmp != "" && tmp != "(*")
                        {
                            SymbolTable[y, 0] = tmp;

                            if (seperator(tmp))
                                SymbolTable[y, 1] = "Seperator";
                            else if (operand(tmp))
                                SymbolTable[y, 1] = "Operand";
                            else
                                SymbolTable[y, 1] = "id";

                            SymbolTable[y, 2] = k.ToString();
                            y++;
                        }

                        // write:
                        if (tmp == "\"")
                        {
                            while (s1[++p] != '"') ; p++;
                        }

                        // comment:
                        if (tmp == "(*")
                            begincomment = true;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            ///////////////////////////////////specification Reserved Word//////////////
            for (int i = 0; i < y; i++)
            {
                {
                    if (SymbolTable[i, 0] != null && !IsNumber(SymbolTable[i, 0]))
                    {
                        if (Iskeyword(SymbolTable[i, 0]) || IsType(SymbolTable[i, 0]))
                        {
                            SymbolTable[i, 1] = "Reserved";
                            //SymbolTable[i, 2] = i.ToString();

                        }
                    }
                }
            }
            ////////////////////////////////////specification digit/////////////////////////////////////
            s1 = "";
            for (int i = 0; i < y; i++)
            {
                if (SymbolTable[i, 0] != null && SymbolTable[i, 1] == "id")//// I change the Identifier to id
                {

                    s1 = SymbolTable[i, 0];
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (IsAlphabet(s1[0]))
                        {
                            for (int k = 1; k < s1.Length; k++)
                            {
                                if (IsDigit(s1[k]) || IsAlphabet(s1[k]) || s1[k].ToString() == "[" || s1[k].ToString() == "]")
                                {

                                }
                                else
                                {
                                    SymbolTable[i, 1] = "Error";
                                }
                            }
                        }
                        else if (IsDigit(s1[0]))
                        {
                            SymbolTable[i, 1] = "Int";
                            bool flag = false;
                            for (int t = 1; t < (s1.Length); t++)
                            {

                                if (s1[t] == '.')
                                {
                                    if (flag == true)
                                    {
                                        SymbolTable[i, 1] = "Error";
                                    }
                                    else
                                    {
                                        SymbolTable[i, 1] = "Real";
                                        flag = true;
                                    }
                                }
                                else
                                    if (!IsDigit(s1[t]))
                                    {
                                        SymbolTable[i, 1] = "Error";//st1[i, 1] = "Digit";
                                    }
                            }
                        }
                        else
                        {
                            SymbolTable[i, 1] = "Error";
                        }
                    }
                }
            }
            ////////////////////////////////////specification Char/////////////////////////////////////
            s1 = "";
            int b = 0;
            while (b <= y)
            {
                if (SymbolTable[b, 0] != null && SymbolTable[b, 0] == "'")
                {
                    b++;
                    if (SymbolTable[b, 0] != null)
                    {
                        b++;
                        if (SymbolTable[b, 0] != null && SymbolTable[b, 0] == "'")
                        {
                            SymbolTable[b - 1, 1] = "Char";
                            b++;
                        }
                    }
                }
                b++;
            }
        }

        public void ShowTokens()
        {
            for (int i = 0; i < SymbolTable.GetLength(0) && SymbolTable[i, 0] != null; i++)
                Console.WriteLine(i.ToString() + ":\t" + SymbolTable[i, 0] + "\t" + SymbolTable[i, 1]);
        }
    }
}

