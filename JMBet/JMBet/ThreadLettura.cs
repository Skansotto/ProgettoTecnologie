using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMBet
{
    public class ThreadLettura
    {
        BufferedStream inputBuffer;
        Flags flags;

        public ThreadLettura(BufferedStream buffer, Flags flags)
        {
            inputBuffer = buffer;
            this.flags = flags;
        }

        //public void run()
        //{
        //    while (!flags.getFlagEnd())
        //    {
        //        try
        //        {
        //            if (inputBuffer.)
        //            {
        //                String s = inputBuffer.readLine();
        //                Console.Out.WriteLine(s);

        //                if (s.equals("forceEnd"))
        //                {
        //                    flags.setFlagEnd(false);
        //                }
        //            }
        //        }
        //        catch (IOException e)
        //        {
        //            e.printStackTrace();
        //            break;
        //        }

        //        try
        //        {
        //            sleep(100);
        //        }
        //        catch (InterruptedException e) { }
        //    }
        //}
    }
}
