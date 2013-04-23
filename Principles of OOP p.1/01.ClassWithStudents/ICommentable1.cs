using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassWithStudents
{
    interface ICommentable
    {
        List<string> Comments { get; set; }
        void AddComment(string comment);
    }
}