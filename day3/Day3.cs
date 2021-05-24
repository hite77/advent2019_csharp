using System;
using System.Collections.Generic;

namespace day3
{
    // calculate the distances and pick smallest...
 
    public class Coords
    {

        public int X { get; set; }
        public int Y { get; set; }
        
        public Coords(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj) => this.Equals(obj as Coords);

        public bool Equals(Coords c)
        {
            if (c is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, c))
            {
                return true;
            }

            if (this.GetType() != c.GetType())
            {
                return false;
            }

            return (X == c.X) && (Y == c.Y);
        }

        public override int GetHashCode() => (X, Y).GetHashCode();

        public static bool operator ==(Coords lhs, Coords rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }

                return false;
            }
                return lhs.Equals(rhs);
        }

        public static bool operator !=(Coords lhs, Coords rhs) => !(lhs == rhs);
    }


    public class CrossedWires
    {
        private List<Coords> firstLine = new List<Coords>();
        private List<Coords> secondLine = new List<Coords>();

        private Coords recordCoords(int currentx, int currenty, List<Coords> line, char c, int count)
        {
            var incrementx = 0;
            var incrementy = 0;

            switch (c)
            {
                case 'U':
                    incrementy += 1;
                    break;
                case 'D':
                    incrementy -= 1;
                    break;
                case 'L':
                    incrementx -= 1;
                    break;
                case 'R':
                    incrementx += 1;
                    break;
            }

            for (int i = 0; i < count; i++)
            {
                currentx += incrementx;
                currenty += incrementy;
                line.Add(new Coords(currentx, currenty));
            }

            return new Coords(currentx, currenty);
        }


        private void recordLine(string directions, List<Coords> line)
        {
            int x = 0;
            int y = 0;

            foreach (string s in directions.Split(','))
            {
                var trimmedS = s.Trim();
                var coord = recordCoords(x, y, line, trimmedS[0], Int32.Parse(trimmedS.Substring(1)));
                x = coord.X;
                y = coord.Y;
            }
        }

        public void line1(string directions)
        {
           recordLine(directions, firstLine);
        }

        public void line2(string directions)
        {
            recordLine(directions, secondLine);
        }



        public int distance()
        {
            var distance = 0;
            foreach (Coords coord in firstLine)
            {
                if (secondLine.Contains(coord))
                {
                    if ((distance == 0) || (Math.Abs(coord.X) + Math.Abs(coord.Y) < distance))
                    {
                        distance = Math.Abs(coord.X) + Math.Abs(coord.Y);
                    }
                }
            }

            return distance;
        }

        public int distancePartTwo()
        {
            var distance = 0;
            foreach (Coords coord in firstLine)
            {
                if (secondLine.Contains(coord))
                {
                    if ((distance == 0) || (firstLine.IndexOf(coord) + secondLine.IndexOf(coord) < distance + 2))
                    {
                        distance = firstLine.IndexOf(coord) + secondLine.IndexOf(coord) + 2;
                    }
                }
            }
            return distance;
        }
    }
}
