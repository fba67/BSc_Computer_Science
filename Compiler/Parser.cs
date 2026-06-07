using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace scanner
{
    public class Parser
    {
        string[] code;
        Scanner scnr;
        bool error = false;
        public Parser(string[]c)
        {
            code = c;
            scnr = new Scanner();
            scnr.scanner(code);
            scnr.ShowTokens();
        }
        string GetToken(int i,int j)
        {
            return scnr.SymbolTable[i, j];
        }
        bool match(string s,ref int i)
        {
            if (GetToken(i, 0) == s || GetToken(i, 1) == s)
            {
                i++;
                return true;
            }
            return false;
        }
        public bool LLparser()
        {
            Console.WriteLine("LL Parser:\n");
            int i = 0;
            if (GetToken(i, 0) == "main")
            {
                bool accept=match("main",ref i);
                accept &= match("(", ref i); 
                accept &= match(")", ref i); 
                accept &= match("{", ref i); 
                VarSec(ref i); 
                accept &= match("begin", ref i); 
                stmt_list(ref i,true); 
                accept &= match("end", ref i);
                accept &= match("}", ref i);
                if (accept && !error)
                {
                    Console.WriteLine("Top-Down parsing finished successfully.");
                    Console.WriteLine("________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("Top-Down parsing failed!");
                    Console.WriteLine("________________________________________________________________________");
                }
                return accept;
            }
            else
            {
                Console.WriteLine("Error at beginning of the program. make sure you have the main function.");
                Console.WriteLine("Top-Down parsing failed!");
                Console.WriteLine("________________________________________________________________________");
                return false;
            }
        }
        private bool VarSec(ref int i)
        {
            bool accept, accept2;
            int old_i = i;
            accept2 = accept = match("var", ref i);
            if (accept)
                accept &= VarDec(ref i, true);
            if (!accept2 && accept)
            {
                Console.WriteLine("\"var\" keyword expected at line {0}",scnr.SymbolTable[i,2]);
                error = true;
            }
            return accept;
        }

        private bool VarDec(ref int i,bool flag)
        {
            bool accept,accept2;
            accept = variable_list(ref i,flag);accept2=accept &= match(";",ref i);
            if (!accept2 && !flag)
            {
                Console.WriteLine("; missing at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
            }
            if (accept){
                 VarDec(ref i,accept);
            }
            return accept;
        }

        private bool variable_list(ref int i,bool flag)
        {
            bool accept, accept2;
            accept = variable(ref i);
            accept2 = accept &= match(":", ref i);
            if (!accept2&&!flag)
            {
                Console.WriteLine(": missing at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
            }
            accept2 = accept &= (match("int", ref i) | match("float", ref i));
            if (!accept2&&!flag)
            {
                Console.WriteLine("varible type is requiered at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
            }
            return accept;
        }

        private bool variable(ref int i)
        {
            bool accept;
            accept = match("Identifier", ref i);
            if (!accept)
                Console.WriteLine("Identifier missing at line {0}", scnr.SymbolTable[i, 2]);
            accept &= match(",", ref i);
            if (accept)
            {
                variable(ref i);
            }
            return accept;
        }
        private bool stmt_list(ref int i,bool flag)
        {
            bool  accept = stmt(ref i);
            if (accept)
            {
                stmt_list(ref i,accept);
            }
            return accept;
        }

        private bool stmt(ref int i)
        {
            bool accept=false,accept2;
            if (GetToken(i, 0) == "{")
            {
                accept = match("{", ref i);
                accept2=accept &= match("}", ref i);
                if (!accept2)
                {
                    Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                }
            }
            else if (GetToken(i, 1) == "Identifier")
            {
                accept = assignment(ref i);
                if (!accept)
                {
                    Console.WriteLine("Identifier missing at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                }
            }
            else if (GetToken(i, 0) == "if")
            {
                accept = if_stmt(ref i);
                if (!accept)
                {
                    Console.WriteLine("invalid if statement at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                }
            }
            else if (GetToken(i, 0) == "while")
            {
                accept = while_stmt(ref i);
                if (!accept)
                {
                    Console.WriteLine("invalid while statement at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                }
            }
            
            return accept;
        }
        private bool assignment(ref int i)
        {
            bool accept=false,accept2;
            if (GetToken(i, 1) == "Identifier")
            {
                match(GetToken(i,1), ref i);
                accept = match("=", ref i);
                accept &= expr(ref i); accept2=accept &= match(";", ref i);
                if (!accept2)
                {
                    Console.WriteLine("; missing at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                }
            }
            return accept;
        }

        private bool expr(ref int i)
        {
            bool accept;
            accept = E(ref i);  F(ref i);
            return accept;
        }

        private void F(ref int i)
        {
            bool accept = false;
            if (GetToken(i, 0) == "+")
            {
                match("+", ref i);
                accept = E(ref i);
                F(ref i);
            }
            else if (GetToken(i, 0) == "-")
            {
                match("-", ref i);
                accept = E(ref i);
                F(ref i);
            }
            else if (GetToken(i, 0) == "*")
            {
                match("*", ref i);
                accept = E(ref i);
                F(ref i);
            }
            else if (GetToken(i, 0) == "/")
            {
                match("/", ref i);
                accept = E(ref i);
                F(ref i);
            }
        }

        private bool E(ref int i)
        {
            bool accept = false;
            if (GetToken(i, 0) == "(")
            {
                accept = match("(", ref i);
                accept &= expr(ref i);
                accept &= match(")", ref i);
            }
            else if (GetToken(i, 1) == "Identifier")
                accept = match("Identifier", ref i);
            else if(GetToken(i,1)=="Int")
                accept =match("Int",ref i);
            else if (GetToken(i, 1) == "Float")
                accept = match("Float", ref i);
            return accept;
        }

        private bool if_stmt(ref int i)
        {
            bool accept = false;
            int old_i = i;
            accept = matched_stmt(ref i);
            if (!accept)
            {
                i = old_i;
                accept = open_stmt(ref i);
            }
            return accept;
        }

        private bool open_stmt(ref int i)
        {
            int old_i = i;
            bool accept = match("if", ref i); accept &= cond_sec(ref i); accept &= match("{", ref i); accept &= matched_stmt(ref i); accept &= match("}", ref i); accept &= match("else", ref i); accept &= match("{", ref i);
            if (!accept){
                i = old_i;
                accept = match("if", ref i); accept &= cond_sec(ref i); accept &= match("{", ref i); accept &= stmt_list(ref i,true); accept &= match("}", ref i);
                return accept;
            } 
            accept &= open_stmt(ref i); accept &= match("}", ref i);
            return accept;
        }

        private bool matched_stmt(ref int i)
        {
            bool accept=false;
            if (GetToken(i, 1) == "Identifier")
                accept = assignment(ref i);
            else if (GetToken(i, 0) == "while")
                accept = while_stmt(ref i);
            else if (GetToken(i, 0) == "{")
            {
                accept=match("{", ref i);
                stmt_list(ref i, true);
                accept &= match("}", ref i);
            }
            else if (GetToken(i, 0) == "if")
            {
                accept = match("if", ref i);
                accept &= cond_sec(ref i); accept &= match("{", ref i);
                if (!accept) return false;
                accept &= matched_stmt(ref i); accept &= match("}", ref i); accept &= match("else", ref i); accept &= match("{", ref i);
                if (!accept) return false;
                matched_stmt(ref i); accept &= match("}", ref i);
            }
            return accept;
        }

        private bool cond_sec(ref int i)
        {
            bool accept = match("(", ref i); accept &= cond(ref i); accept &= match(")", ref i);
            return accept;
        }

        private bool cond(ref int i)
        {
            bool accept = false;
            int old_i = i;
            accept = condition(ref i);

            if (!accept)
            {
                i = old_i;
                if (GetToken(i, 0) == "(")
                {
                    bool accept2;
                    accept = match("(", ref i); accept2=accept &= condition(ref i); accept &= match(")", ref i);
                    if (accept2 && !accept)
                    {
                        Console.WriteLine(") missing at line {0}", scnr.SymbolTable[i, 2]);
                        error = true;
                    }
                }
                else
                    i = old_i;
            }
            return accept;
        }

        private bool condition(ref int i)
        {
            bool accept;
            accept = cond_sec1(ref i);  cond_sec2(ref i); accept &= cond_sec1(ref i);
            return accept;
        }

        private bool cond_sec2(ref int i)
        {
            bool accept=false;
            if (GetToken(i, 0) == ">")
            {
                accept = match(">", ref i);
                if (GetToken(i, 0) == "=")
                    match("=", ref i);
            }
            else if (GetToken(i, 0) == "<")
            {
                accept = match("<", ref i);
                if (GetToken(i, 0) == "=")
                    match("=", ref i);
            }
            else if (GetToken(i, 0) == "<>")
                accept = match("<>", ref i);
            else if (GetToken(i, 0) == "=")
            {
                accept = match("==", ref i);
                if (GetToken(i, 0) == "=")
                    match("=", ref i);
            }
            else accept = true;
            return accept;

        }

        private bool cond_sec1(ref int i)
        {
            bool accept=false,accept2;
            int old_i = i;
            if (GetToken(i, 0) == "(")
            {
                accept = match("(", ref i); accept2=accept &= operand(ref i); accept &= match(")", ref i);
                if (accept2 && !accept)
                {
                    Console.WriteLine(") missing at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                }
            }
            else accept = operand(ref i);
            return accept;
        }

        private bool operand(ref int i)
        {
            bool accept=false;
            if (GetToken(i, 1) == "Identifier")
                accept = match("Identifier", ref i);
            else if (GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float")//constant
                accept = match(GetToken(i, 1), ref i);
            return accept;
        }
        
        private bool while_stmt(ref int i)
        {
            bool accept=false;
            if (GetToken(i, 0) == "while")
            {
                accept = match("while", ref i); accept &= cond_sec(ref i); accept &= match("{", ref i);
                stmt_list(ref i,accept); accept &= match("}", ref i);
            }
            return accept;
        }

        bool Continue = true;
        Stack<string> stk = new Stack<string>();
        private void shift(string str1, string str2)
        {
            stk.Push(str1);
            stk.Push(str2);
        }
        bool IsIdentifier(string s)
        {
            for (int i = 0; scnr.SymbolTable[i, 0] != ""; i++)
                if (scnr.SymbolTable[i, 0] == s && scnr.SymbolTable[i, 1] == "Identifier")
                    return true;
            return false;
        }
        public bool LRParser()
        {
            Console.WriteLine("\n\nLR Parser:\n");
            int i = 0;
            stk.Push("0");
            while (Continue == true && stk.Peek() != null)
            {
                if (stk.Peek() == "0")
                    state0(ref i);
                else if (stk.Peek() == "1")
                {
                    return state1(ref i);
                }
                else if (stk.Peek() == "2")
                    state2(ref i);
                else if (stk.Peek() == "3")
                    state3(ref i);
                else if (stk.Peek() == "4")
                    state4(ref i);
                else if (stk.Peek() == "5")
                    state5(ref i);
                else if (stk.Peek() == "6" || stk.Peek() == "15")
                    state6(ref i);
                else if (stk.Peek() == "7")
                    state7(ref i);
                else if (stk.Peek() == "8")
                    state8(ref i);
                else if (stk.Peek() == "9")
                    state9(ref i);
                else if (stk.Peek() == "10")
                    state10(ref i);
                else if (stk.Peek() == "11")
                    state11(ref i);
                else if (stk.Peek() == "12")
                    state12(ref i);
                else if (stk.Peek() == "13")
                    state13(ref i);
                else if (stk.Peek() == "14")
                    state14(ref i);
                else if (stk.Peek() == "15")
                    state15(ref i);
                else if (stk.Peek() == "16")
                    state16(ref i);
                else if (stk.Peek() == "17")
                    state17(ref i);
                else if (stk.Peek() == "18")
                    state18(ref i);
                else if (stk.Peek() == "19")
                    state19(ref i);
                else if (stk.Peek() == "20")
                    state20(ref i);
                else if (stk.Peek() == "21")
                    state21(ref i);
                else if (stk.Peek() == "22")
                    state22(ref i);
                else if (stk.Peek() == "23")
                    state23(ref i);
                else if (stk.Peek() == "24")
                    state24(ref i);
                else if (stk.Peek() == "25")
                    state25(ref i);
                else if (stk.Peek() == "26" || stk.Peek() == "27")
                    state26_27(ref i);
                else if (stk.Peek() == "28")
                    state28(ref i);
                else if (stk.Peek() == "29" || stk.Peek() == "36" || stk.Peek() == "42" || stk.Peek() == "43" || stk.Peek() == "44" || stk.Peek() == "45")
                    state29_36_42_43_44_45(ref i);
                else if (stk.Peek() == "30")
                    state30(ref i);
                else if (stk.Peek() == "31")
                    state31(ref i);
                else if (stk.Peek() == "32")
                    state32(ref i);
                else if (stk.Peek() == "33")
                    state33(ref i);
                else if (stk.Peek() == "34")
                    state34(ref i);
                else if (stk.Peek() == "35")
                    state35(ref i);
                else if (stk.Peek() == "36")
                    state36(ref i);
                else if (stk.Peek() == "37")
                    state37(ref i);
                else if (stk.Peek() == "38")
                    state38(ref i);
                else if (stk.Peek() == "39")
                    state39(ref i);
                else if (stk.Peek() == "40")
                    state40(ref i);
                else if (stk.Peek() == "41")
                    state41(ref i);
                else if (stk.Peek() == "46" || stk.Peek() == "47" || stk.Peek() == "48" || stk.Peek() == "49")
                    state46_47_48_49(ref i);
                else if (stk.Peek() == "50")
                    state50(ref i);
                else if (stk.Peek() == "51")
                    state51(ref i);
                else if (stk.Peek() == "52")
                    state52(ref i);
                else if (stk.Peek() == "53")
                    state53(ref i);
                else if (stk.Peek() == "54")
                    state54(ref i);
                else if (stk.Peek() == "55")
                    state55(ref i);
                else if (stk.Peek() == "56")
                    state56(ref i);
                else if (stk.Peek() == "57")
                    state57(ref i);
                else if (stk.Peek() == "58")
                    state58(ref i);
                else if (stk.Peek() == "59")
                    state59(ref i);
                else if (stk.Peek() == "60")
                    state60(ref i);
                else if (stk.Peek() == "61")
                    state61(ref i);
                else if (stk.Peek() == "62")
                    state62(ref i);
                else if (stk.Peek() == "63")
                    state63(ref i);
                else if (stk.Peek() == "67" || stk.Peek() == "75")
                    state67_75(ref i);
                else if (stk.Peek() == "68")
                    state68(ref i);
                else if (stk.Peek() == "69")
                    state69(ref i);
                else if (stk.Peek() == "70")
                    state70(ref i);
                else if (stk.Peek() == "71")
                    state71(ref i);
                else if (stk.Peek() == "72")
                    state72(ref i);
                else if (stk.Peek() == "73")
                    state73(ref i);
                else if (stk.Peek() == "74")
                    state74(ref i);
                else if (stk.Peek() == "76")
                    state76(ref i);
                else if (stk.Peek() == "77")
                    state77(ref i);
                else if (stk.Peek() == "78")
                    state78(ref i);
                else if (stk.Peek() == "79")
                    state79(ref i);
                else if (stk.Peek() == "80")
                    state80(ref i);
                else if (stk.Peek() == "81")
                    state81(ref i);
                else if (stk.Peek() == "82")
                    state82(ref i);
                else if (stk.Peek() == "83")
                    state83(ref i);
                else if (stk.Peek() == "84")
                    state84(ref i);
                else if (stk.Peek() == "85")
                    state85(ref i);
                else if (stk.Peek() == "86")
                    state86(ref i);
                else if (stk.Peek() == "87")
                    state87(ref i);
                else if (stk.Peek() == "88")
                    state88(ref i);
                else if (stk.Peek() == "89")
                    state89(ref i);
                else if (stk.Peek() == "90")
                    state90(ref i);
                else if (stk.Peek() == "91")
                    state91(ref i);
                else if (stk.Peek() == "92")
                    state92(ref i);

                else if (stk.Peek() == "Start")
                    goto_Start();
                else if (stk.Peek() == "VarSec")
                    goto_VarSec();
                else if (stk.Peek() == "VarDec")
                    goto_VarDec();
                else if (stk.Peek() == "variable_list")
                    goto_variable_list();
                else if (stk.Peek() == "variable")
                    goto_variable();
                else if (stk.Peek() == "stmt_list")
                    goto_stmt_list();
                else if (stk.Peek() == "stmt")
                    goto_stmt();
                else if (stk.Peek() == "assignment")
                    goto_assignment();
                else if (stk.Peek() == "expr")
                    goto_expr();
                else if (stk.Peek() == "F")
                    gotoF();
                else if (stk.Peek() == "E")
                    gotoE();
                else if (stk.Peek() == "if_stmt")
                    goto_if_stmt();
                else if (stk.Peek() == "while_stmt")
                    goto_while_stmt();
                else if (stk.Peek() == "cond_sec")
                    goto_cond_sec();
                else if (stk.Peek() == "cond")
                    goto_cond();
                else if (stk.Peek() == "condition")
                    goto_condition();
                else if (stk.Peek() == "cond_sec1")
                    goto_cond_sec1();
                else if (stk.Peek() == "operand")
                    goto_operand();
                else if (stk.Peek() == "cond_sec2")
                    goto_cond_sec2();
            }
            return Continue;
        }

        private void goto_cond_sec2()
        {
            stk.Pop();
            if (stk.Peek() == "68")
            {
                stk.Push("cond_sec2");
                stk.Push("75");
            }
            else
            {
                stk.Push("cond_sec2");
                error = true;
            }
        }

        private void goto_operand()
        {
            stk.Pop();
            if (stk.Peek() == "33" || stk.Peek() == "75")
            {
                stk.Push("operand");
                stk.Push("61");
            }
            else if (stk.Peek() == "67")
            {
                stk.Push("operand");
                stk.Push("73");
            }
            else if (stk.Peek() == "70")
            {
                stk.Push("operand");
                stk.Push("71");
            }
            else
            {
                stk.Push("operand");
                error = true;
            }
        }

        private void goto_cond_sec1()
        {
            stk.Pop();
            if (stk.Peek() == "33" || stk.Peek() == "67")
            {
                stk.Push("cond_sec1");
                stk.Push("68");
            }
            else if (stk.Peek() == "75")
            {
                stk.Push("cond_sec1");
                stk.Push("74");
            }
            else
            {
                stk.Push("cond_sec1");
                error = true;
            }
        }

        private void goto_condition()
        {
            stk.Pop();
            if (stk.Peek() == "33")
            {
                stk.Push("condition");
                stk.Push("60");
            }
            else if (stk.Peek() == "67")
            {
                stk.Push("condition");
                stk.Push("69");
            }
            else
            {
                stk.Push("condition");
                error = true;
            }
        }

        private void goto_cond()
        {
            stk.Pop();
            if (stk.Peek() == "33")
            {
                stk.Push("cond");
                stk.Push("58");
            }
            else
            {
                stk.Push("cond");
                error = true;
            }
        }

        private void goto_cond_sec()
        {
            stk.Pop();
            if (stk.Peek() == "26")
            {
                stk.Push("cond_sec");
                stk.Push("30");
            }
            else if (stk.Peek() == "27")
            {
                stk.Push("cond_sec");
                stk.Push("32");
            }
            else
            {
                stk.Push("cond_sec");
                error = true;
            }
        }

        private void goto_while_stmt()
        {
            stk.Pop();
            if (stk.Peek() == "8" || stk.Peek() == "20" || stk.Peek() == "31" || stk.Peek() == "55" || stk.Peek() == "86")
            {
                stk.Push("while_stmt");
                stk.Push("23");
            }
            else
            {
                stk.Push("while_stmt");
                error = true;
            }
        }

        private void goto_if_stmt()
        {
            stk.Pop();
            if (stk.Peek() == "8" || stk.Peek() == "20" || stk.Peek() == "31" || stk.Peek() == "55" || stk.Peek() == "86")
            {
                stk.Push("if_stmt");
                stk.Push("22");
            }
            else
            {
                stk.Push("if_stmt");
                error = true;
            }
        }

        private void gotoE()
        {
            stk.Pop();
            if (stk.Peek() == "29" || stk.Peek() == "36")
            {
                stk.Push("E");
                stk.Push("35");
            }
            else if (stk.Peek() == "42")
            {
                stk.Push("E");
                stk.Push("46");
            }
            else if (stk.Peek() == "43")
            {
                stk.Push("E");
                stk.Push("47");
            }
            else if (stk.Peek() == "44")
            {
                stk.Push("E");
                stk.Push("48");
            }
            else if (stk.Peek() == "45")
            {
                stk.Push("E");
                stk.Push("49");
            }
            else
            {
                stk.Push("E");
                error = true;
            }
        }

        private void gotoF()
        {
            stk.Pop();
            if (stk.Peek() == "35")
            {
                stk.Push("F");
                stk.Push("41");
            }
            else if (stk.Peek() == "46")
            {
                stk.Push("F");
                stk.Push("50");
            }
            else if (stk.Peek() == "47")
            {
                stk.Push("F");
                stk.Push("51");
            }
            else if (stk.Peek() == "48")
            {
                stk.Push("F");
                stk.Push("52");
            }
            else if (stk.Peek() == "49")
            {
                stk.Push("F");
                stk.Push("53");
            }
            else
            {
                stk.Push("F");
                error = true;
            }
        }

        private void goto_expr()
        {
            stk.Pop();
            if (stk.Peek() == "29")
            {
                stk.Push("expr");
                stk.Push("34");
            }
            else if (stk.Peek() == "36")
            {
                stk.Push("expr");
                stk.Push("39");
            }
            else
            {
                stk.Push("expr");
                error = true;
            }
        }

        private void goto_assignment()
        {
            stk.Pop();
            if (stk.Peek() == "8" || stk.Peek() == "20" || stk.Peek() == "31" || stk.Peek() == "55" || stk.Peek() == "86")
            {
                stk.Push("assignment");
                stk.Push("21");
            }
            else
            {
                stk.Push("assignment");
                error = true;
            }
        }

        private void goto_stmt()
        {
            stk.Pop();
            if (stk.Peek() == "8" || stk.Peek() == "20" || stk.Peek() == "31" || stk.Peek() == "55" || stk.Peek() == "86")
            {
                stk.Push("stmt");
                stk.Push("20");
            }
            else
            {
                stk.Push("stmt");
                error = true;
            }
        }

        private void goto_stmt_list()
        {
            stk.Pop();
            if (stk.Peek() == "8")
            {
                stk.Push("stmt_list");
                stk.Push("19");
            }
            else if (stk.Peek() == "20")
            {
                stk.Push("stmt_list");
                stk.Push("91");
            }
            else if (stk.Peek() == "31")
            {
                stk.Push("stmt_list");
                stk.Push("83");
            }
            else if (stk.Peek() == "55")
            {
                stk.Push("stmt_list");
                stk.Push("56");
            }
            else if (stk.Peek() == "86")
            {
                stk.Push("stmt_list");
                stk.Push("87");
            }
            else
            {
                stk.Push("stmt_list");
                error = true;
            }
        }

        private void goto_variable()
        {
            stk.Pop();
            if (stk.Peek() == "6" || stk.Peek() == "13")
            {
                stk.Push("variable");
                stk.Push("11");
            }
            else if (stk.Peek() == "15")
            {
                stk.Push("variable");
                stk.Push("18");
            }
            else
            {
                stk.Push("variable");
                error = true;
            }
        }

        private void goto_variable_list()
        {
            stk.Pop();
            if (stk.Peek() == "6" || stk.Peek() == "13")
            {
                stk.Push("variable_list");
                stk.Push("10");
            }
            else
            {
                stk.Push("variable_list");
                error = true;
            }
        }

        private void goto_VarDec()
        {
            stk.Pop();
            if (stk.Peek() == "6")
            {
                stk.Push("VarDec");
                stk.Push("9");
            }
            else if (stk.Peek() == "13")
            {
                stk.Push("VarDec");
                stk.Push("16");
            }
            else
            {
                stk.Push("VarDec");
                error = true;
            }
        }

        private void goto_VarSec()
        {
            stk.Pop();
            if (stk.Peek() == "5")
            {
                stk.Push("VarSec");
                stk.Push("7");
            }
            else
            {
                stk.Push("VarSec");
                error = true;
            }
        }

        private void goto_Start()
        {
            stk.Pop();
            if (stk.Peek() == "0")
            {
                stk.Push("Start");
                stk.Push("1");
            }
            else
            {
                stk.Push("Start");
                error = true;
            }
        }

        private void state92(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "end" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}" || GetToken(i, 0) == "if" || GetToken(i, 0) == "while")
            {//assigment-->id=expr
                while (stk.Peek() != ";")
                    stk.Pop();
                while (stk.Peek() != "expr")
                    stk.Pop();
                while (stk.Peek() != "=")
                    stk.Pop();
                while (stk.Peek() != "Identifier")
                    stk.Pop();
                stk.Pop();
                stk.Push("assignment");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state91(ref int i)
        {
            if (GetToken(i, 0) == "end" || GetToken(i, 0) == "}")
            {//stmt_list-->stmt stmt_list
                while (stk.Peek() != "stmt_list")
                    stk.Pop();
                while (stk.Peek() != "stmt")
                    stk.Pop();
                stk.Pop();
                stk.Push("stmt_list");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state90(ref int i)
        {
            if (GetToken(i, 0) == "end" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "if" || GetToken(i, 0) == "while" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}")
            {//if_stmt-->if cond_sec{stmt_list}else{stmt_list}
                while (stk.Peek() != "}")
                    stk.Pop();
                while (stk.Peek() != "stmt_list")
                    stk.Pop();
                while (stk.Peek() != "{")
                    stk.Pop();
                while (stk.Peek() != "else")
                    stk.Pop();
                while (stk.Peek() != "}")
                    stk.Pop();
                while (stk.Peek() != "stmt_list")
                    stk.Pop();
                while (stk.Peek() != "{")
                    stk.Pop();
                while (stk.Peek() != "cond_sec")
                    stk.Pop();
                while (stk.Peek() != "if")
                    stk.Pop();
                stk.Pop();
                stk.Push("if_stmt");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state89(ref int i)
        {
            if (GetToken(i, 0) == "")
            {//start-->main(){VarSec begin stmt_list end}
                while (stk.Peek() != "}")
                    stk.Pop();
                while (stk.Peek() != "end")
                    stk.Pop();
                while (stk.Peek() != "stmt_list")
                    stk.Pop();
                while (stk.Peek() != "begin")
                    stk.Pop();
                while (stk.Peek() != "VarSec")
                    stk.Pop();
                while (stk.Peek() != "{")
                    stk.Pop();
                while (stk.Peek() != ")")
                    stk.Pop();
                while (stk.Peek() != "(")
                    stk.Pop();
                while (stk.Peek() != "main")
                    stk.Pop();
                stk.Pop();
                stk.Push("Start");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state88(ref int i)
        {
            if (GetToken(i, 0) == "}")
            {
                shift("}", "89");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("}", "90");
                error = true;
            }
        }

        private void state87(ref int i)
        {
            if (GetToken(i, 0) == "}")
            {
                shift("}", "90");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("}", "90");
                error = true;
            }
        }

        private void state86(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "25");
                i++;
            }
            else if (GetToken(i, 0) == "if")
            {
                shift("if", "26");
                i++;
            }
            else if (GetToken(i, 0) == "while")
            {
                shift("while", "27");
                i++;
            }
            else if (GetToken(i, 0) == "}")
            {//stmt_list-->ε                      
                stk.Push("stmt_list");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state85(ref int i)
        {
            if (GetToken(i, 0) == "{")
            {
                shift("{", "86");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("{", "86");
                error = true;
            }
        }

        private void state84(ref int i)
        {
            if (GetToken(i, 0) == "end" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "if" || GetToken(i, 0) == "while" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}")
            {//if_stmt-->if cond_sec{stmt_list}
                while (stk.Peek() != "}")
                    stk.Pop();
                while (stk.Peek() != "stmt_list")
                    stk.Pop();
                while (stk.Peek() != "{")
                    stk.Pop();
                while (stk.Peek() != "cond_sec")
                    stk.Pop();
                while (stk.Peek() != "if")
                    stk.Pop();
                stk.Pop();
                stk.Push("if_stmt");
            }
            else if (GetToken(i, 0) == "else")
            {
                shift("else", "85");
                i++;
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state83(ref int i)
        {
            if (GetToken(i, 0) == "}")
            {
                shift("}", "84");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("}", "84");
                error = true;
            }
        }

        private void state82(ref int i)
        {
            if (GetToken(i, 0) == "(" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float" || GetToken(i, 0) == "'")
            {//cond_sec2--> ==
                while (stk.Peek() != "=")
                    stk.Pop();
                while (stk.Peek() != "=")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec2");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state81(ref int i)
        {
            if (GetToken(i, 0) == "(" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float" || GetToken(i, 0) == "'")
            {//cond_sec2--> <>
                while (stk.Peek() != ">")
                    stk.Pop();
                while (stk.Peek() != "<")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec2");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state80(ref int i)
        {
            if (GetToken(i, 0) == "(" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float" || GetToken(i, 0) == "'")
            {//cond_sec2--> <=
                while (stk.Peek() != "=")
                    stk.Pop();
                while (stk.Peek() != "<")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec2");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state79(ref int i)
        {
            if (GetToken(i, 0) == "(" || IsIdentifier(GetToken(i, 0)) || scnr.IsType(GetToken(i, 1)))
            {//cond_sec2--> >=
                while (stk.Peek() != "=")
                    stk.Pop();
                while (stk.Peek() != ">")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec2");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state78(ref int i)
        {
            if ((GetToken(i, 0) == "="))
            {
                shift("=", "82");
                i++;
            }
            else
            {
                Console.WriteLine("= missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("=", "82");
                error = true;
            }
        }

        private void state77(ref int i)
        {
            if ((GetToken(i, 0) == ">"))
            {
                shift(">", "81");
                i++;
            }
            else if ((GetToken(i, 0) == "="))
            {
                shift("=", "80");
                i++;
            }
            if (GetToken(i, 0) == "(" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float" || GetToken(i, 0) == "'")
            {//cond_sec2--> <
                while (stk.Peek() != "<")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec2");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state76(ref int i)
        {
            if (GetToken(i, 0) == "(" || IsIdentifier(GetToken(i, 0)) || GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float" || GetToken(i, 0) == "'")
            {//cond_sec2--> >
                while (stk.Peek() != ">")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec2");
            }
            else if (GetToken(i, 0) == "=")
            {
                shift("=", "79");
                i++;
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state74(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {//condition-->cond_sec1 cond_sec2 cond_sec1
                while (stk.Peek() != "cond_sec1")
                    stk.Pop();
                while (stk.Peek() != "cond_sec2")
                    stk.Pop();
                while (stk.Peek() != "cond_sec1")
                    stk.Pop();
                stk.Pop();//pop cond_sec1
                stk.Push("condition");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state73(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {
                shift(")", "72");
                i++;
            }
            else if (GetToken(i, 0) == ">" || GetToken(i, 0) == "<" || GetToken(i, 0) == "=")
            {//reduce_34                        
                while (stk.Peek() != "operand")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec1");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state72(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ">" || GetToken(i, 0) == "<" || GetToken(i, 0) == "=")
            {//cond_sec1-->(operand)
                while (stk.Peek() != ")")
                    stk.Pop();
                while (stk.Peek() != "operand")
                    stk.Pop();
                while (stk.Peek() != "(")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec1");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state71(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {
                shift(")", "72");
                i++;
            }
            else
            {
                Console.WriteLine(") missing at line {0}", scnr.SymbolTable[i, 2]);
                shift(")", "72");
                error = true;
            }
        }

        private void state70(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "62");
                i++;
            }
            else if (GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float")
            {
                shift("Const", "63");
                i++;
            }

            else
            {
                Console.WriteLine("identifier or constant missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("Const", "63");
                error = true;
            }
        }

        private void state69(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {
                shift(")", "54");
                i++;
            }
            else
            {
                Console.WriteLine(") missing at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
            }
        }

        private void state68(ref int i)
        {
            if (GetToken(i, 0) == ">")
            {
                shift(">", "76");
                i++;
            }
            else if (GetToken(i, 0) == "<")
            {
                shift("<", "77");
                i++;
            }
            else if (GetToken(i, 0) == "=")
            {
                shift("=", "78");
                i++;
            }
            else
            {
                Console.WriteLine("comparative operator missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("=", "78");
                error = true;
            }
        }

        private void state67_75(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "62");
                i++;
            }
            else if (GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float")
            {
                shift("Const", "63");
                i++;
            }

            else if (GetToken(i, 0) == "(")
            {

                shift("(", "70");
                i++;
            }
            else
            {
                Console.WriteLine("identifier missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("Identifier", "62");
                error = true;
            }
        }

        private void state63(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == "<" || GetToken(i, 0) == ">" || GetToken(i, 0) == "=")
            {//operand-->const

                while (stk.Peek() != "Const")
                    stk.Pop();
                stk.Pop();
                stk.Push("operand");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state62(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == "<" || GetToken(i, 0) == ">" || GetToken(i, 0) == "=")
            {//operand-->id

                while (stk.Peek() != "Identifier")
                    stk.Pop();
                stk.Pop();
                stk.Push("operand");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state61(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == "<" || GetToken(i, 0) == ">" || GetToken(i, 0) == "=")
            {//cond_sec1-->operand

                while (stk.Peek() != "operand")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec1");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state60(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {//cond-->condition

                while (stk.Peek() != "condition")
                    stk.Pop();
                stk.Pop();//pop condition
                stk.Push("cond");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state59(ref int i)
        {
            if (GetToken(i, 0) == "{")
            {//cond_sec-->(cond)

                while (stk.Peek() != ")")
                    stk.Pop();
                while (stk.Peek() != "cond")
                    stk.Pop();
                while (stk.Peek() != "(")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond_sec");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state58(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {
                shift(")", "59");
                i++;
            }
            else
            {
                Console.WriteLine(") missing at line {0}", scnr.SymbolTable[i, 2]);
                shift(")", "59");
                error = true;
            }
        }

        private void state57(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "end" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}" || GetToken(i, 0) == "if" || GetToken(i, 0) == "while")
            {//while_stmt-->while cond_sec{stmt_list}

                while (stk.Peek() != "}")
                    stk.Pop();
                while (stk.Peek() != "stmt_list")
                    stk.Pop();
                while (stk.Peek() != "{")
                    stk.Pop();
                while (stk.Peek() != "cond_sec")
                    stk.Pop();
                while (stk.Peek() != "while")
                    stk.Pop();
                stk.Pop();
                stk.Push("while_stmt");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state56(ref int i)
        {
            if (GetToken(i, 0) == "}")
            {
                shift("}", "57");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
                shift("}", "57");
            }
        }

        private void state55(ref int i)
        {
            if (GetToken(i, 0) == "{")
            {

                shift("{", "24");
                i++;
            }
            else if ((IsIdentifier(GetToken(i, 0))))
            {
                shift("Identifier", "25");
                i++;
            }
            else if (GetToken(i, 0) == "if")
            {
                shift("if", "26");
                i++;
            }
            else if (GetToken(i, 0) == "while")
            {
                shift("while", "27");
                i++;
            }
            else if (GetToken(i, 0) == "}")
            {//reduce_10

                stk.Push("stmt_list");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state54(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {//cond-->(condition)
                while (stk.Peek() != ")")
                    stk.Pop();
                while (stk.Peek() != "condition")
                    stk.Pop();
                while (stk.Peek() != "(")
                    stk.Pop();
                stk.Pop();
                stk.Push("cond");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state53(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";")
            {//F-->/EF
                while (stk.Peek() != "F")
                    stk.Pop();
                while (stk.Peek() != "E")
                    stk.Pop();
                while (stk.Peek() != "/")
                    stk.Pop();
                stk.Pop();
                stk.Push("F");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state52(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";")
            {//F-->*EF
                while (stk.Peek() != "F")
                    stk.Pop();
                while (stk.Peek() != "E")
                    stk.Pop();
                while (stk.Peek() != "*")
                    stk.Pop();
                stk.Pop();
                stk.Push("F");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state51(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";")
            {//F-->-EF
                while (stk.Peek() != "F")
                    stk.Pop();
                while (stk.Peek() != "E")
                    stk.Pop();
                while (stk.Peek() != "-")
                    stk.Pop();
                stk.Pop();
                stk.Push("F");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state50(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";")
            {//F-->+EF
                while (stk.Peek() != "F")
                    stk.Pop();
                while (stk.Peek() != "E")
                    stk.Pop();
                while (stk.Peek() != "+")
                    stk.Pop();
                stk.Pop();
                stk.Push("F");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state46_47_48_49(ref int i)
        {
            if (GetToken(i, 0) == "+")
            {
                shift("+", "42");
                i++;
            }
            else if ((GetToken(i, 0) == "-"))
            {
                shift("-", "43");
                i++;
            }
            else if (GetToken(i, 0) == "*")
            {
                shift("*", "44");
                i++;
            }
            else if (GetToken(i, 0) == "/")
            {
                shift("/", "45");
                i++;
            }
            else if (GetToken(i, 0) == ";" || GetToken(i, 0) == ")")
            {//F-->ε
                stk.Push("F");

            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state41(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";")
            {//expr-->EF
                while (stk.Peek() != "F")
                    stk.Pop();
                while (stk.Peek() != "E")
                    stk.Pop();
                stk.Pop();
                stk.Push("expr");
            }
            else
            {
                Console.WriteLine(") or ; missing at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state40(ref int i)
        {
            if (GetToken(i, 0) == ";" || GetToken(i, 0) == "+" || GetToken(i, 0) == "-" || GetToken(i, 0) == "*" || GetToken(i, 0) == "/")
            {//E-->expr
                while (stk.Peek() != ")")
                    stk.Pop();
                while (stk.Peek() != "expr")
                    stk.Pop();
                while (stk.Peek() != "(")
                    stk.Pop();
                stk.Pop();
                stk.Push("E");
            }
            else
            {
                Console.WriteLine("missing separator at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state39(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {
                shift(")", "40");
                i++;
            }
            else
            {
                Console.WriteLine(") missing at line {0}", scnr.SymbolTable[i, 2]);
                shift(")", "40");
                error = true;
            }
        }

        private void state38(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";" || GetToken(i, 0) == "+" || GetToken(i, 0) == "-" || GetToken(i, 0) == "*" || GetToken(i, 0) == "/")
            {//E-->const
                while (stk.Peek() != "Const")
                    stk.Pop();
                stk.Pop();
                stk.Push("E");
            }
            else
            {
                Console.WriteLine("; or ) or operand missing at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state37(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";" || GetToken(i, 0) == "+" || GetToken(i, 0) == "-" || GetToken(i, 0) == "*" || GetToken(i, 0) == "/")
            {//E-->id
                while (stk.Peek() != "Identifier")
                    stk.Pop();
                stk.Pop();
                stk.Push("E");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state36(ref int i)
        {
            if (GetToken(i, 0) == "(")
            {

                shift("(", "36");
                i++;
            }
            else if ((IsIdentifier(GetToken(i, 0))))
            {
                shift("Identifier", "37");
                i++;
            }
            else if (GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float")
            {
                shift("Const", "38");
                i++;
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state35(ref int i)
        {
            if (GetToken(i, 0) == ")" || GetToken(i, 0) == ";")
            {//F-->ε
                stk.Push("F");
            }
            else if ((GetToken(i, 0) == "+"))
            {
                shift("+", "42");
                i++;
            }
            else if ((GetToken(i, 0) == "-"))
            {
                shift("-", "43");
                i++;
            }
            else if ((GetToken(i, 0) == "*"))
            {
                shift("*", "44");
                i++;
            }
            else if ((GetToken(i, 0) == "/"))
            {
                shift("/", "45");
                i++;
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state34(ref int i)
        {
            if (GetToken(i, 0) == ";")
            {
                shift(";", "92");
                i++;
            }
            else
            {
                Console.WriteLine("; missing at line {0}", scnr.SymbolTable[i, 2]);
                shift(";", "92");
                error = true;
            }
        }

        private void state33(ref int i)
        {
            if ((IsIdentifier(GetToken(i, 0))))
            {
                shift("Identifier", "62");
                i++;
            }
            else if (GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float")
            {
                shift("Const", "63");
                i++;
            }
            //else if ((GetToken(i, 0) == "'"))
            //{
            //    shift("'", "64");
            //    i++;
            //}
            else if ((GetToken(i, 0) == "("))
            {
                shift("(", "67");
                i++;
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state32(ref int i)
        {
            if ((GetToken(i, 0) == "{"))
            {
                shift("{", "55");
                i++;
            }
            else
            {
                Console.WriteLine("{ missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("{", "55");
                error = true;
            }
        }

        private void state31(ref int i)
        {
            if ((IsIdentifier(GetToken(i, 0))))
            {
                shift("Identifier", "25");
                i++;
            }
            else if ((GetToken(i, 0) == "if"))
            {
                shift("if", "26");
                i++;
            }
            else if ((GetToken(i, 0) == "while"))
            {
                shift("while", "27");
                i++;
            }
            else if (GetToken(i, 0) == "}")
            {//reduce_10                        

                stk.Push("stmt_list");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state30(ref int i)
        {
            if ((GetToken(i, 0) == "{"))
            {
                shift("{", "31");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("{", "31");
                error = true;
            }
        }

        private void state29_36_42_43_44_45(ref int i)
        {
            if ((GetToken(i, 0) == "("))
            {
                shift("(", "36");
                i++;
            }
            else if ((IsIdentifier(GetToken(i, 0))))
            {
                shift("Identifier", "37");
                i++;
            }
            else if (GetToken(i, 1) == "Int" || GetToken(i, 1) == "Float")
            {
                shift("Const", "38");
                i++;
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state28(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "end" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}" || GetToken(i, 0) == "if" || GetToken(i, 0) == "while")
            {//stmt-->{}
                while (stk.Peek() != "}")
                    stk.Pop();
                while (stk.Peek() != "{")
                    stk.Pop();
                stk.Pop();
                stk.Push("stmt");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state26_27(ref int i)
        {
            if ((GetToken(i, 0) == "("))
            {
                shift("(", "33");
                i++;
            }
            else
            {
                Console.WriteLine("( missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("(", "33");
                error = true;
            }
        }

        private void state25(ref int i)
        {
            if ((GetToken(i, 0) == "="))
            {
                shift("=", "29");
                i++;
            }
            else
            {
                Console.WriteLine("= missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("=", "29");
                error = true;
            }
        }

        private void state24(ref int i)
        {
            if (GetToken(i, 0) == "}")
            {
                shift("}", "28");
                i++;
            }
            else
            {
                Console.WriteLine("} missing at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
            }
        }

        private void state23(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "end" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}" || GetToken(i, 0) == "if" || GetToken(i, 0) == "while")
            {//stmt-->while_stmt
                while (stk.Peek() != "while_stmt")
                {
                    stk.Pop();
                }

                stk.Pop();
                stk.Push("stmt");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state22(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "end" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}" || GetToken(i, 0) == "if" || GetToken(i, 0) == "while")
            {//stmt-->if_stmt
                while (stk.Peek() != "if_stmt")
                {
                    stk.Pop();
                }

                stk.Pop();
                stk.Push("stmt");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state21(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)) || GetToken(i, 0) == "end" || GetToken(i, 0) == "{" || GetToken(i, 0) == "}" || GetToken(i, 0) == "if" || GetToken(i, 0) == "while")
            {//stmt-->assignment
                while (stk.Peek() != "assignment")
                {
                    stk.Pop();

                }

                stk.Pop();
                stk.Push("stmt");
            }
            else
            {
                Console.WriteLine("syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state20(ref int i)
        {
            if (GetToken(i, 0) == "{")
            {
                shift("{", "24");
                i++;
            }
            else if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "25");
                i++;
            }
            else if (GetToken(i, 0) == "if")
            {
                shift("if", "26");
                i++;
            }
            else if (GetToken(i, 0) == "while")
            {
                shift("while", "27");
                i++;
            }
            else if (GetToken(i, 0) == "end" || GetToken(i, 0) == "}")
            {//reduce_10
                stk.Push("stmt_list");
            }
            else
            {


                Console.WriteLine("suntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state19(ref int i)
        {
            if (GetToken(i, 0) == "end")
            {
                shift("end", "88");
                i++;
            }
            else
            {
                Console.WriteLine("end missing at line {0}", scnr.SymbolTable[i, 2]);
                error = true;
                shift("end", "88");
            }
        }

        private void state18(ref int i)
        {
            if (GetToken(i, 0) == ":")
            {//variable-->id,variable                        
                while (stk.Peek() != "variable")
                    stk.Pop();
                while (stk.Peek() != ",")
                    stk.Pop();
                while (stk.Peek() != "Identifier")
                    stk.Pop();
                stk.Pop();
                stk.Push("variable");
            }
            else
            {
                Console.WriteLine(": missing at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state17(ref int i)
        {
            if (GetToken(i, 0) == ";")
            {//variable_list-->variable:type
                while (stk.Peek() != "int" && stk.Peek() != "float" && stk.Peek() != "bool")
                    stk.Pop();
                while (stk.Peek() != ":")
                    stk.Pop();
                while (stk.Peek() != "variable")
                    stk.Pop();
                stk.Pop();
                stk.Push("variable_list");
            }
            else
            {
                Console.WriteLine("; missing at line {0}", scnr.SymbolTable[i, 2]);
                Continue = false;
            }
        }

        private void state16(ref int i)
        {
            if (GetToken(i, 0) == "begin")
            {//VarDec-->variale_list;VarDec
                while (stk.Peek() != "VarDec")
                    stk.Pop();
                while (stk.Peek() != ";")
                    stk.Pop();
                while (stk.Peek() != "variable_list")
                    stk.Pop();
                stk.Pop();
                stk.Push("VarDec");
            }
            else
            {
                Console.WriteLine("Syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue=false;
            }
        }

        private void state15(ref int i)
        {
            if ((IsIdentifier(GetToken(i, 0))))
            {
                shift("Identifier", "12");
                i++;
            }
            else
            {
                Console.WriteLine("missing identifier.");
                shift("Identifier", "12");
            }
        }

        private void state14(ref int i)
        {
            if (scnr.IsType(GetToken(i, 0)))
            {
                shift(GetToken(i, 0), "17");
                i++;
            }
            else
            {
                Console.WriteLine("Variable type missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("int", "17");
            }
        }

        private void state13(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "12");
                i++;
            }
            else if (GetToken(i, 0) == "begin")
            {//VarDec-->variable_list;
                while (stk.Peek() != ";")
                    stk.Pop();
                while (stk.Peek() != "variable_list")
                    stk.Pop();
                stk.Pop();
                stk.Push("VarDec");
            }
            else
            {
                Console.WriteLine("Syntax error at line {0}", scnr.SymbolTable[i, 2]);
                Continue= false;
            }
        }

        private void state12(ref int i)
        {
            if (GetToken(i, 0) == ",")
            {
                shift(",", "15");
                i++;
            }
            else if (GetToken(i, 0) == ":")
            {//variable-->id
                while (stk.Peek() != "Identifier")
                    stk.Pop();
                stk.Pop();
                stk.Push("variable");
            }
            else
            {
                if (IsIdentifier(GetToken(i, 1)) && IsIdentifier(GetToken(i - 1, 1)))
                {
                    Console.WriteLine(", missing at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                    shift(",", "15");
                }
                else if (scnr.IsType(GetToken(i, 1)))
                {
                    Console.WriteLine(": missing at line {0}", scnr.SymbolTable[i, 2]);
                    error = true;
                    while (stk.Peek() != "Identifier")
                    {
                        stk.Pop();
                    }
                    stk.Pop();
                    stk.Push("variable");
                }
            }
        }

        private void state11(ref int i)
        {
            if (GetToken(i, 0) == ":")
            {
                shift(":", "14");
                i++;
            }
            else
            {
                Console.WriteLine(": missing at line {0}", scnr.SymbolTable[i, 2]);
                shift(":", "14");
            }
        }

        private void state10(ref int i)
        {
            if (GetToken(i, 0) == ";")
            {
                shift(";", "13");
                i++;
            }
            else
            {
                Console.WriteLine("; missing at line {0}", scnr.SymbolTable[i, 2]);
                shift(";", "13");
            }
        }

        private void state9(ref int i)
        {
            if (GetToken(i, 0) == "begin")
            {//VarSec-->var varDec
                while (stk.Peek() != "VarDec")
                    stk.Pop();
                while (stk.Peek() != "var")
                    stk.Pop();
                stk.Pop();
                stk.Push("VarSec");
            }
            else
            {
                Console.WriteLine("Syntax error at line{0}", scnr.SymbolTable[i, 2]);
                Continue= false;
            }
        }

        private void state8(ref int i)
        {
            if (GetToken(i, 0) == "{")
            {
                shift("{", "24");
                i++;
            }
            else if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "25");
                i++;
            }
            else if (GetToken(i, 0) == "if")
            {
                shift("if", "26");
                i++;
            }
            else if (GetToken(i, 0) == "while")
            {
                shift("while", "27");
                i++;
            }
            else if (GetToken(i, 0) == "end")
            {//reduce_10
                stk.Push("stmt_list");
            }
            else
            {
                Console.WriteLine("Syntax error at line{0}", scnr.SymbolTable[i, 2]);
                Continue= false;
            }
        }

        private void state7(ref int i)
        {
            if (GetToken(i, 0) == "begin")
            {
                shift("begin", "8");
                i++;
            }
            else
            {
                Console.WriteLine("\"begin\" keyword requiered at line {0}", scnr.SymbolTable[i, 2]);
                shift("begin", "8");
            }
        }

        private void state6(ref int i)
        {
            if (IsIdentifier(GetToken(i, 0)))
            {
                shift("Identifier", "12");
                i++;
            }
            else
            {
                Console.WriteLine("identifier missing at line {0}", scnr.SymbolTable[i, 2]);
                shift("Identifier", "12");
            }
        }

        private void state5(ref int i)
        {
            if (GetToken(i, 0) == "var")
            {
                shift("var", "6");
                i++;
            }
            else if (GetToken(i, 0) == "begin")
            {//reduce_44
                stk.Push("VarSec");
            }
            else
            {
                Console.WriteLine("\"begin\" keyword is requiered at line {0}", scnr.SymbolTable[i, 2]);
                shift("begin", "6");
            }
        }

        private void state4(ref int i)
        {
            if (GetToken(i, 0) == "{")
            {
                shift("{", "5");
                i++;
            }
            else
            {
                Console.WriteLine("{ missing.");
                shift("{", "6");
            }
        }

        private void state3(ref int i)
        {
            if (GetToken(i, 0) == ")")
            {
                shift(")", "4");
                i++;
            }
            else
            {
                Console.WriteLine(") missing.");
                //return false;
                shift(")", "4");
            }
        }

        private void state2(ref int i)
        {
            if (GetToken(i, 0) == "(")
            {
                shift("(", "3");
                i++;
            }
            else
            {
                Console.WriteLine(") missing.");
                shift("(", "3");
            }
        }

        private bool state1(ref int i)
        {
            if (GetToken(i, 0) == "" && !error)
            {
                Console.WriteLine("Bottom-Up Parsing finished successfully");
                Continue = true;
                return true;
            }
            else
            {
                Console.WriteLine("Parsing failed!");
                return false;
            }
        }

        private void state0(ref int i)
        {
            if (GetToken(i, 0) == "main")
            {
                shift("main", "2");
                i++;
            }
            else
            {

                Console.WriteLine("Error at beginning of the program. make sure you have the main function.");
                //return false;
                shift("main", "2");
                error = true;
            }
        }
    }
    public class Scanner{
        public string[,] SymbolTable = new string[10000, 3];
        string[] keywords = { "if","else","while","for","var","begin","end","main"};
        string[] types = { "int", "float", "string", "bool", "Int", "Float", "String", "Bool" };
        int STind = 0;
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
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')||c=='_')
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
        public bool IsType(string s)
        {
            for (int i = 0; i < types.Length; i++)
                if (s == types[i])
                    return true;
            return false;
        }
        private bool IsSeparator(char c)
        {
            if ((c == ' ') || (c == '(') || (c == ')') || (c == '{') || (c == '}') || (c == ':') || (c == ';') || (c == ',') || (c == '\''))
                return true;
            return false;
        }
        private bool IsOperator(string s)
        {
            if ((s[0] == '*') || (s[0] == '/') || (s[0] == '+') || (s[0] == '-') || (s[0] == '=') || (s[0] == '<') || (s[0] == '>') || (s[0] == '%') || (s[0] == '&') || (s[0] == '|'))// || (s == "==") || (s == "<=") || (s == ">=") || (s == "||") || (s == "&&")||s=="!=" ||s[0]=='!')
                return true;
            return false;
        }
        public void scanner(string[]code)
        {
            int row = 0;
            int col = 0;
            string token = "";
            STind = 0;
            for (int i = 0; i < SymbolTable.GetLength(0); i++)
                for (int j = 0; j < SymbolTable.GetLength(1);j++ )
                    SymbolTable[i, j] = "";
            row = code.Length;
            for (int k = 0; k < row; k++)
            {
                int sind = 0;
                token = code[k].ToString();
                col = token.Length;
                while (sind < col)
                {
                    if ((!IsSeparator(token[sind])) && (!IsOperator(token[sind].ToString())) && !IsType(token[sind].ToString()))
                    {
                        while ((sind < col) && (!IsSeparator(token[sind])) && (!IsOperator(token[sind].ToString())) && !IsType(token[sind].ToString()))
                        {
                            SymbolTable[STind, 0] += token[sind];
                            sind++;
                        }
                        SymbolTable[STind, 2] = (k + 1).ToString();
                        SymbolTable[STind, 1] = "Identifier";
                        STind++;
                    }
                    else if (IsSeparator(token[sind]))
                    {
                        if (token[sind] != ' ')
                        {
                            SymbolTable[STind, 0] = token[sind].ToString();
                            SymbolTable[STind, 1] = "Separator";
                            SymbolTable[STind, 2] = (k + 1).ToString();
                            STind++;
                        }
                        sind++;
                    }
                    else if (IsOperator(token[sind].ToString()))
                    {
                        SymbolTable[STind, 0] = token[sind].ToString();
                        SymbolTable[STind, 1] = "Operand";
                        SymbolTable[STind, 2] = (k + 1).ToString();

                        STind++;
                        sind++;
                    }
                    SymbolTable[STind, 1] = "Identifier";
                }
            }
            for (int i = 0; i < STind; i++)
            {
                for (int j = 0; j < keywords.Length; j++)
                {
                    if (SymbolTable[i, 0] != ""&&!IsNumber(SymbolTable[i,0]))
                    {
                        if (Iskeyword(SymbolTable[i,0])||IsType(SymbolTable[i,0]))
                        {
                            SymbolTable[i, 1] = "Reserved";
                            SymbolTable[STind, 2] = (i+1).ToString(); 
                        }
                    }
                }
            }
            token = "";
            for (int i = 0; i < STind; i++)
            {
                if (SymbolTable[i, 0] != "" && SymbolTable[i, 1] == "Identifier")
                {
                    token = SymbolTable[i, 0];
                    SymbolTable[STind, 2] = (i + 1).ToString();
                    for (int j = 0; j < token.Length; j++)
                    {
                        if (IsAlphabet(token[0]))
                        {
                            for (int k = 1; k < token.Length; k++)
                            {
                                if (!(IsDigit(token[k]) || IsAlphabet(token[k])||token[k]=='_'))
                                {
                                    SymbolTable[i, 1] = "Error";
                                    SymbolTable[STind, 2] = (i+1).ToString();
                                }
                            }
                        }
                        else if (IsDigit(token[0]))
                        {
                            SymbolTable[i, 1] = "Int";
                            bool flag = false;
                            for (int t = 1; t < (token.Length); t++)
                            {
                                if (token[t] == '.')
                                {
                                    if (flag == true)
                                    {
                                        SymbolTable[i, 1] = "Error";
                                        SymbolTable[STind, 2] = (i + 1).ToString();
                                    }
                                    else
                                    {
                                        SymbolTable[i, 1] = "Float";
                                        SymbolTable[STind, 2] = (i + 1).ToString();
                                        flag = true;
                                    }
                                }
                                else
                                    if (!IsDigit(token[t]))
                                    {
                                        SymbolTable[i, 1] = "Error";
                                        SymbolTable[STind, 2] = (i + 1).ToString();
                                    }
                            }
                        }
                        else
                        {
                            SymbolTable[i, 1] = "Error";
                            SymbolTable[STind, 2] = (i + 1).ToString();
                        }
                    }
                }
            }
            
        }
        public void ShowTokens() {
            for (int i = 0; i < SymbolTable.GetLength(0)&&SymbolTable[i,0]!=""; i++)
                    Console.WriteLine(i.ToString()+":\t"+SymbolTable[i,0]+"\t"+SymbolTable[i,1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for LL parsing, press 2 for LR parsing: ");
            int selection = int.Parse(Console.ReadLine());
            string path = "C:\\Users\\Fateme\\Desktop\\input.txt";
            string[] code = File.ReadAllLines(path);
            Parser p = new Parser(code);
            //if (selection == 1)
            //    p.LLparser();
            //else if (selection == 2)
            //    p.LRParser();
            //else Console.WriteLine("Incorrect input!");
            p.LLparser();
            p.LRParser();
        }
    }
}
