using System;
using System.Collections.Generic;

namespace Domain
{
    public class Arvore
    {
            public int id;
            public Arvore left, right;
            public Arvore(int data)
            {
                this.id = data;
                left = right = null;
            }
     }



}


