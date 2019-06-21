using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_v2
{
    class Incidents
    {
        public int Vertex
        {
            get;
            set;
        }

        List<int> neighBorhoods = new List<int>();

        public Incidents(int vertex)
        {
            Vertex = vertex;
        }
        public List<int> NeighBorhoods
        {
            get;
            set;
        }
        public void Add(int incidentVertex)
        {
            neighBorhoods.Add(incidentVertex);
        }
    }
}
