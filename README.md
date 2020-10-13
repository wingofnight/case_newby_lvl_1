# case_newby_lvl_1
Доделать класс)


Необходимо доделать все экземпляры классов ColorProfile соотвественно цветам ConsoleColor.
Все это делается для удобства использования функции рисования в консоли. 

Создаем новыей экземпляр класса  ColorProfile. Называем его новым цветом - например Red:

            ColorProfile Red = new ColorProfile();
 
 Затем как в примере, задаем цвета фону и символу:
 
            Red.ForeGround = ConsoleColor.Red;
            Red.BackGround = ConsoleColor.Black;
           
**Также надо сделать конструктор класса, что бы при создании основного класса, запускалась функция создающая эти цветные классы,
а так же конструктор класса должен задавать поле symbol.

            public SectorPaint(string symbol){ClassesCreate(); this.symbol = symbol;}
            
            
