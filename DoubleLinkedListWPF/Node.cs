﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListWPF
{
    internal class Node
    {
        private string _data;
        private Node _next;
        private Node _prev;
        public string Data { get { return _data; } set { _data = value; } }
        public Node Next { get { return _next; } set { _next = value; } }
        public Node Prev { get { return _prev; } set { _prev = value; } }
        public Node(string data) { Data = data; }
    }
}