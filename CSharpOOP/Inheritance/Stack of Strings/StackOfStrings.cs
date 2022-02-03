using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings
        : Stack<string>
    {
        private Stack<string> stack;

        public StackOfStrings()
        {
            stack = new Stack<string>();
        }

        public bool IsEmpty()
        {
            if (stack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddRange(Stack<string> stuff)
        {
            foreach (var item in stuff)
            {
                stack.Push(item);
            }
        }
    }
}
