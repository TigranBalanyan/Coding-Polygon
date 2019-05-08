using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPolygon
{
    public delegate void ErrorDel();
    public class Subscriber
    {

        public ErrorDel ErrDel { get; set; }
        
        public void Error()
        {
            throw new InvalidCastException(); //xosqi error
            if(this.ErrDel != null)
            {
                ErrDel();
            }
        }

       
        
    }
}
