using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book();
      Object obk = bk;
      
      Diary dy = new Diary(38);
      Object ody = dy;
      
      int i = 9;
      Object oi = i;
      
    }
  }
}
