﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OS
{
    class NPP
    {
        public static int[,] arrCTRT = new int[calcTBT(), 2];
        static bool[,] arrAT = new bool[calcTBT(), Process_Scheduling.noProcess];
        static ArrayList arrQueue = new ArrayList();
        static int current;
        static int Qcount = 0;
        static int time = 0;
        static bool processing = false;


        public static void doNPP()
        {
            OrganizeAT();
            Process();
            updateCT();
            updateRT();

        }

        public static void Process()
        {
            for (int i = 0; i < calcTBT(); i++)
            {
                for (int j = 0; j < Process_Scheduling.noProcess; j++)
                {
                    if (arrAT[i, j])
                    {


                        arrQueue.Add(j + 1);
                        Qcount += 1;

                    }

                }
                if (!processing)
                {
                    current = pickProcess();
                    arrCTRT[i, 1] = current;
                    time += fetchBT(current);
                    processing = true;
                }
                else
                {
                    if (i == time)
                    {
                        arrCTRT[i, 0] = current;
                        processing = false;
                        if (Qcount > 0)
                        {
                            current = pickProcess();
                            arrCTRT[i, 1] = current;
                            time += fetchBT(current);
                            processing = true;
                        }
                    }

                }

            }
        }



        static int pickProcess()
        {
            int highPrio = (int)arrQueue[0];
            int index = 0;

            for (int i = 0; i < Qcount; i++)
            {
                if (fetchPrio((int)arrQueue[i]) > fetchPrio(highPrio))
                {
                    highPrio = (int)arrQueue[i];
                    index = i;
                }
            }
            arrQueue.RemoveAt(index);
            Qcount -= 1;

            return highPrio;
        }



        static void OrganizeAT()
        {
            for (int i = 0; i < Process_Scheduling.noProcess; i++)
            {
                int AT = Process_Scheduling.data[i, 1];
                placeAT(AT, i);
            }
        }

        static void placeAT(int AT, int PNO)
        {
            arrAT[AT, PNO] = true;
        }

        static int calcTBT()
        {
            int TBT = 0;
            for (int i = 0; i < Process_Scheduling.noProcess; i++)
            {
                TBT = TBT + Process_Scheduling.data[i, 2];
            }
            return TBT + 1;
        }

        static void updateCT()
        {
            for (int i = 0; i < calcTBT(); i++)
            {
                if (arrCTRT[i, 0] > 0)
                {
                    Process_Scheduling.data[getIndexOf(arrCTRT[i, 0]), 5] = i;
                }
            }
        }

        static void updateRT()
        {
            for (int i = 0; i < calcTBT(); i++)
            {
                if (arrCTRT[i, 1] > 0)
                {
                    Process_Scheduling.data[getIndexOf(arrCTRT[i, 1]), 4] = i;
                }
            }
        }

        static int getIndexOf(int PNO)
        {
            for (int i = 0; i < Process_Scheduling.noProcess; i++)
            {
                if (Process_Scheduling.data[i, 0] == PNO)
                {
                    return i;
                }
            }
            return 0;
        }

        static int fetchBT(int PNO)
        {
            for (int i = 0; i < Process_Scheduling.noProcess; i++)
            {
                if (Process_Scheduling.data[i, 0] == PNO)
                {
                    return Process_Scheduling.data[i, 2];
                }
            }
            return 0;
        }

        static int fetchPrio(int PNO)
        {
            for (int i = 0; i < Process_Scheduling.noProcess; i++)
            {
                if (Process_Scheduling.data[i, 0] == PNO)
                {
                    return Process_Scheduling.data[i, 3];
                }
            }
            return 0;
        }
    }
}
