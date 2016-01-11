using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSElectronicTools.Dummy
{
    class MainClass
    { 
       
        public static IEnumerable<Vector> GetPionts(Vector point)
        {

            yield return point + new Vector(1, 1, 1);
            yield return point + new Vector(1, 1, 0);
            yield return point + new Vector(1, 0, 1);
            yield return point + new Vector(1, 0, 0);
            yield return point + new Vector(0, 1, 1);
            yield return point + new Vector(0, 1, 0);
            yield return point + new Vector(0, 0, 1);
            yield return point + new Vector(0, 0, 0);
        }

        public static void Main(string[] args)
        {
            Vector playerpos = new Vector(0.5, 0.5, 0);

            List<Vector> playerpoints = new List<Vector>();
            playerpoints.Add(new Vector(0, -1, 0));
            playerpoints.Add(new Vector(0, 1, 0));
            playerpoints.Add(new Vector(-1, -1, 0));
            playerpoints.Add(new Vector(-1, 1, 0));
            playerpoints.Add(new Vector(0, -1, 2));
            playerpoints.Add(new Vector(0, 1, 2));
            playerpoints.Add(new Vector(-1, -1, 2));
            playerpoints.Add(new Vector(-1, 1, 2));


            Vector movvector = new Vector(2,0,0.1);

            List<Vector> blockpoints = new List<Vector>();
            blockpoints.AddRange(GetPionts(new Vector(1, 0, 2)));
            blockpoints.AddRange(GetPionts(new Vector(1, 0, 1)));

            bool iscollsion = false;
            bool iscollision_x = false;
            bool iscollision_y = false;
            bool iscollision_z = false;

            Vector colpos = new Vector();
            Vector lowvalue = new Vector();

            Console.WriteLine("Start");

            foreach (var playerpoint in playerpoints)
            {
                Vector movepoint = playerpoint + movvector;

                foreach (var position in blockpoints)
                {
                    Vector v = (playerpoint - position);
                    double lenght = v.Length();
                    Vector vm = (movepoint - position);
                    double lenghtm = vm.Length();

                    Vector e =  ( v / Math.Pow(lenght, 3));
                    Console.WriteLine("X:{0},Y:{1},Z:{2}",e.X,e.Y,e.Z);

                    Vector em=  ( vm / Math.Pow(lenghtm, 3));
                    Console.WriteLine("X:{0},Y:{1},Z:{2}",em.X,em.Y,em.Z);

                    Vector es = e * em;

                    int sx = 1;
                    int sy = 1;
                    int sz = 1;

                    try
                    {
                        sx = Math.Sign(es.X);
                        sy = Math.Sign(es.Y);
                        sz = Math.Sign(es.Z);
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }



                    if (sx <= 0 && sy <= 0 && sz <= 0)
                    {
                        iscollsion = true;

                        if (sx < 0 && (lowvalue.X == 0 ||lowvalue.X > Math.Abs(em.X)))
                        {
                            iscollision_x = true;

                            lowvalue.X = Math.Abs(em.X);
                            colpos.X = position.X;
                        }
                        if (sy < 0 && (lowvalue.Y == 0 ||lowvalue.X > Math.Abs(em.Y)))
                        {
                            iscollision_y = true;
                            
                            lowvalue.X = Math.Abs(em.Y);
                            colpos.Y = position.Y;
                        }
                        if (sz < 0 && (lowvalue.Z == 0 ||lowvalue.X > Math.Abs(em.Z)))
                        {
                            iscollision_z = true;

                            lowvalue.X = Math.Abs(em.Z);
                            colpos.Z = position.Z;
                        }
                    }



                    Console.WriteLine("Kollision X:{0},Y:{1},Z:{2}",sx <= 0,sy <= 0, sz <= 0);


                    Console.WriteLine();
                }
            }





            Console.WriteLine("Kollision: {0} X:{1},Y:{2},Z:{3}",iscollsion,colpos.X,colpos.Y, colpos.Z);
            Console.WriteLine("Kollision X:{0},Y:{1},Z:{2}",iscollision_x,iscollision_y, iscollision_z);

            Vector newmove = movvector;
            if (iscollision_x)
                newmove.X = movvector.X - (colpos.X + playerpos.X);
            if (iscollision_y)
                newmove.Y = movvector.Y - (colpos.Y + playerpos.Y);
            if (iscollision_z)
                newmove.Z = movvector.Z - (colpos.Z + playerpos.Z);

            Console.WriteLine("Move X:{0},Y:{1},Z:{2}",newmove.X,newmove.Y, newmove.Z);
        }
    }
}
