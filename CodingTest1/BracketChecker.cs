﻿using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace CodingTest1
{
   public class BracketChecker
    {
        public bool checkBrackets(string ipString)
        {
            Stack stack = new Stack();
            if (String.IsNullOrEmpty(ipString))
            {
                throw new ArgumentNullException();
            }

            string splChrs = "{}[]()";
            Regex regex = new Regex(@"[" + splChrs + "]+");
            Match match = regex.Match(ipString);
            if (!match.Success)
            {
                throw new InvalidOperationException();
            }

            var ipStringChar = ipString.ToCharArray();

            for (int i = 0; i < ipStringChar.Length; i++)
            {
                if(ipStringChar[i] == '{' || ipStringChar[i] == '(' || ipStringChar[i] == '[')
                    stack.Push(ipStringChar[i]);

                if (ipStringChar[i] == '}' || ipStringChar[i] == ')' || ipStringChar[i] == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    else if (!isMatchingPair(Convert.ToChar(stack.Pop().ToString()), ipStringChar[i]))
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }

        public bool isMatchingPair(char paranthesis1, char paranthesis2)
        {
            if ((paranthesis1 == '{' && paranthesis2 == '}') || (paranthesis1 == '(' && paranthesis2 == ')') || (paranthesis1 == '[' && paranthesis2 == ']'))
                return true;
            return false;
        }
    }
}