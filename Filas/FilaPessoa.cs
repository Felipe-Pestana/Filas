using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Pessoa aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                tail.setNext(aux);
                tail = aux;
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                if (tail == head) //verifico se tenho um elemento só
                {
                    head = tail = null;
                }

                else
                {
                    this.head = head.getNext();
                }
            }
        }


        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
