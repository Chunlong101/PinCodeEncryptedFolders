using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinCodeEncryptedFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //New - Item - Path ".\$i" -ItemType Directory -Name i
                System.IO.Directory.CreateDirectory(i.ToString());

                for (int j = 0; j < 10; j++)
                {
                    //New - Item - Path ".\i\j" - ItemType Directory - Name j
                    System.IO.Directory.CreateDirectory(i.ToString() + "\\" + j.ToString());

                    for (int k = 0; k < 10; k++)
                    {
                        //New - Item - Path ".\i\j\k" - ItemType Directory - Name k
                        System.IO.Directory.CreateDirectory(i.ToString() + "\\" + j.ToString() + "\\" + k.ToString());

                        for (int l = 0; l < 10; l++)
                        {
                            //New - Item - Path ".\i\j\k\l" - ItemType Directory - Name l
                            System.IO.Directory.CreateDirectory(i.ToString() + "\\" + j.ToString() + "\\" + k.ToString() + "\\" + l.ToString());

                            for (int m = 0; m < 10; m++)
                            {
                                //New - Item - Path ".\i\j\k\l\m" - ItemType Directory - Name m
                                System.IO.Directory.CreateDirectory(i.ToString() + "\\" + j.ToString() + "\\" + k.ToString() + "\\" + l.ToString() + "\\" + m.ToString());

                                for (int n = 0; n < 10; n++)
                                {
                                    //New - Item - Path ".\i\j\k\l\m\n" - ItemType Directory - Name n
                                    System.IO.Directory.CreateDirectory(i.ToString() + "\\" + j.ToString() + "\\" + k.ToString() + "\\" + l.ToString() + "\\" + m.ToString() + "\\" + n.ToString());

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
