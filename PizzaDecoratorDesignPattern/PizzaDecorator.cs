using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class PizzaDecorator:IPizza
    {
        protected IPizza pizza;
        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public virtual string MakePizza()
        {
            return pizza.MakePizza();
        }
    }
}
