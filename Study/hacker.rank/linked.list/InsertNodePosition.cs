using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Solved: 
/// https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem
/// </summary>

namespace Teste
{

    public class InsertNodePosition
    {
        public InsertNodePosition()
        {
        }

        static void Main(string[] args)
        {

        }

        public Node InsertNth(Node head, int data, int position)
        {
            if (head == null)
            {
                var node = new Node
                {
                    Data = data,
                    Next = null
                };
                return node;
            }

            Node headReturn = head;
            Node prior = null;
            int positionActual = 0;

            while (positionActual <= position)
            {

                if (positionActual == position)
                {
                    Node middleNode = new Node
                    {
                        Data = data,
                        Next = head
                    };

                    if (prior != null)
                    {
                        prior.Next = middleNode;
                    }
                    else
                    {
                        headReturn = middleNode;
                    }
                    return headReturn;
                }

                prior = head;
                head = head.Next;
                positionActual++;
            }
            return head;
        }
    }
}
