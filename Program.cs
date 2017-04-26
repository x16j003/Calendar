using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime dateNow = DateTime.Now;
            Console.Write("{0}年 {1}月\n", dateNow.Year, dateNow.Month);
            Console.ReadLine();*/
            DateTime dateNow= DateTime.Now;
            Console.Write("{0}年 {1}月\n", dateNow.Year, dateNow.Month);
            //現在の年日の一日を取得する
            DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1", dateNow.Year, dateNow.Month));
            DispLayCalendar(dateFirst);
            Console.ReadLine();
           
        }
        static void DispLayCalendar(DateTime dateFirst)
        {
            int week;
            int month = dateFirst.Month;
            //曜日タイトルの表示
            Console.Write("--------------\n");
            Console.Write("日 月 火 水 木 金 土\n");
            //一日の開始位置まで空白を表示する
            for (week = 0; week < (int)dateFirst.DayOfWeek; week++)
                Console.Write("   ");
            //月の終わりまでの日まで1週間ごとに日にちの表示する
            while (month == dateFirst.Month)
            {
                for (; week < 7 && month == dateFirst.Month; week++)
                {
                    Console.Write("{0, 2} ", dateFirst.Day);
                    dateFirst = dateFirst.AddDays(1);
                }
                Console.Write("\n");
                week = 0;
            }
        }
    }
}
