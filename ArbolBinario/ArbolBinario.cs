﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class ArbolBinario
    {

        public Nodo root;
        
        //public ArbolBinario(){
        //    this.root = null;
        //}

        public Nodo createNodo(int num)
        {

            Nodo new_nodo = new Nodo();

            new_nodo.num = num;
            new_nodo.rigth = null;
            new_nodo.left = null;

            return new_nodo;
        }

        public Nodo insertNodo(Nodo tree, int num)
        {
            if(tree.num == 0)
            {
                Nodo new_root = createNodo(num);
                tree = new_root;
            }
            else
            {
                int rootValue = tree.num;

                if( num < rootValue)
                {
                    insertNodo(tree.left, num);
                }
                else
                {
                    insertNodo(tree.rigth, num);
                }

            }

            return tree;
        }
    }
}