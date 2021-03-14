using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class PlainPizza : IPizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
