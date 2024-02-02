using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon
{
    public class Book
    {
        public TableOfContents TableOfContents{ get; set; }
        public Index Index { get; set; }
    }
}