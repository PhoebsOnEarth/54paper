using System;
using System.Linq;
using System.Collections.Generic;
namespace SA54PAPER
{
    public class SectionA
    {
        public static string[,] AllRecords = new string[,]
        {
            {"11235929","Loh Ying Hui","2021-11-03 17:33:13","2021-11-03 19:28:02","Hall B" },
            {"11236832","Chang Wen Ming","2021-11-02 09:02:23","2021-11-02 10:32:42","Hall C" },
            {"11236375","Ang Zheng De","2021-11-03 18:02:23","2021-11-03 20:34:29","Hall B" },
            {"11236956","Say Zi Rui","2021-11-03 18:02:23","2021-11-03 13:08:31","Hall A" },
            {"11236236","Vaneet Sura","2021-11-03 16:25:29","2021-11-03 18:53:19","Hall B" }

        };

        public static string[]? GetRecord(string? inId)
        {
            for(int row = 0; row < AllRecords.GetLength(0); row++)
            {
                if (String.Equals(AllRecords[row, 0], inId))
                {
                    string[] record = new string[AllRecords.GetLength(1)];
                    for(int col = 0; col < AllRecords.GetLength(1); col++)
                    {
                        record[col] = AllRecords[row, col];
                    }
                    foreach (var r in record)
                    {
                        Console.WriteLine(r);
                    }
                    return record;                    
                }
            }
            
            return null;
        }

        public static bool WasAtTheSameLocation(string inCandidateLocation,string inTargetLocation)
        {
            if (String.Equals(inCandidateLocation, inTargetLocation))
            {
                return true;
            }
            return false;
        }

        public static bool DidActivityOverlap(DateTime inCandidateEntryTime,
            DateTime inCandidateExitTime, DateTime inTargetEntryTime,
            DateTime inTargetExitTime)
        {
            if(!(inTargetEntryTime > inCandidateExitTime || inTargetExitTime < inCandidateEntryTime))
            {
                return true;
            }
            return false;
        }
        public static DateTime GetTimeFromTimeStampString(string inTimeStampString)
        {
            DateTime a =  DateTime.ParseExact(inTimeStampString, "yyyy-MM-dd HH:mm:ss", null);
            Console.WriteLine(a);
            return a;
        }

        public static void PrintLinkedIds(string? targetId,DateTime targetEntryTime,DateTime targetExitTime,string targetLocation)
        {
            List<string> res = new List<string>();
            for(int row = 0; row< AllRecords.GetLength(0); row++)
            {
                if (!String.Equals(AllRecords[row, 0], targetId))
                {
                    if (WasAtTheSameLocation(AllRecords[row, 4], targetLocation))
                    {
                        if (DidActivityOverlap(GetTimeFromTimeStampString(AllRecords[row, 2])
                            , GetTimeFromTimeStampString(AllRecords[row,3])
                            , targetEntryTime
                            ,targetExitTime))
                        {
                            res.Add(AllRecords[row, 0]);
                        }
                    }
                }
                foreach(var l in res)
                {
                    Console.WriteLine(l);
                }
                
            }
        }

    }
}

