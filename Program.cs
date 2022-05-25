using System; 

namespace Study 
{
    class Program 
    {
        static void Main() 
        {
            System.Console.WriteLine("Здравствуйте! Как Вас зовут?");
            string userName = Console.ReadLine(); 
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("{0}, добро пожаловать в упрощённую версию калькулятора!", userName);
            System.Console.WriteLine("Введите первое число");
            float userFirstNumber = float.Parse(Console.ReadLine()); 
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Введено первое число: {0}", userFirstNumber);
            System.Console.WriteLine("Введите второе число");
            float userSecondNumber = float.Parse(Console.ReadLine()); 
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Первое число: {0}", userFirstNumber);
            System.Console.WriteLine("Второе число: {0}", userSecondNumber);
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("{0}, пожалуйста, выберите необходимое действие:", userName);
            System.Console.WriteLine("'+' Сложение");
            System.Console.WriteLine("'-' Вычитание ");
            System.Console.WriteLine("'*' Умножение");
            System.Console.WriteLine("'/' Деление");
            string userDesicion = Console.ReadLine(); 
            System.Console.WriteLine("--------------------------");
            switch(userDesicion)
            {
               // Сложение
               case "+": 
                    float sumRes = userFirstNumber + userSecondNumber; 
                    System.Console.WriteLine("Результат сложения : {0}", sumRes);
                    System.Console.WriteLine("--------------------------");
                    Console.WriteLine("Нажмите любую кнопку для завершения процесса");
                    Console.ReadLine(); 
                    break;
               // Вычитание
               case "-": 
                    System.Console.WriteLine("{0}, уточните, из какого числа будем вычитать?:", userName);
                    System.Console.WriteLine("'1' Из первого второе: {0} - {1}", userFirstNumber, userSecondNumber);
                    System.Console.WriteLine("'2' Из второго первое: {0} - {1}", userSecondNumber, userFirstNumber);
                    byte subUserDesicion = byte.Parse(Console.ReadLine());     
                        if(subUserDesicion == 1)
                            {
                            float subRes1 = userFirstNumber - userSecondNumber; 
                            System.Console.WriteLine("Результат вычитания: {0}", subRes1);
                            } 
                        else if(subUserDesicion == 2)
                            {
                            float subRes2 = userSecondNumber - userFirstNumber; 
                            System.Console.WriteLine("Результат вычитания: {0}", subRes2);
                            }
                        else
                            {
                            System.Console.WriteLine("{0}, Вы не выбрали действие. Пожалуйста, перезапустите программу.");
                            }
                        System.Console.WriteLine("--------------------------");
                        Console.WriteLine("Нажмите любую кнопку для завершения процесса");
                        Console.ReadLine();     
                    break; 
               // Умножение
               case "*": 
                    float mulRes = userFirstNumber * userSecondNumber; 
                    System.Console.WriteLine("Результат умножения : {0}", mulRes);
                    System.Console.WriteLine("--------------------------");
                    Console.WriteLine("Нажмите любую кнопку для завершения процесса");
                    Console.ReadLine(); 
                    break;
               // Деление     
               case "/": 
                    System.Console.WriteLine("{0}, уточните, на каое число будем делить?:", userName);
                    System.Console.WriteLine("'1' Первое на второе: {0} : {1}", userFirstNumber, userSecondNumber);
                    System.Console.WriteLine("'2' Второе на первое: {0} : {1}", userSecondNumber, userFirstNumber);
                    byte divUserDesicion = byte.Parse(Console.ReadLine());     
                        if(divUserDesicion == 1)
                            {
                            float divRes1 = userFirstNumber / userSecondNumber; 
                            System.Console.WriteLine("Результат деления: {0}", divRes1);
                            } 
                        else if(divUserDesicion == 2)
                            {
                            float divRes2 = userSecondNumber / userFirstNumber; 
                            System.Console.WriteLine("Результат деления: {0}", divRes2);
                            }
                        else
                            {
                            System.Console.WriteLine("{0}, Вы не выбрали действие. Пожалуйста, перезапустите программу.");
                            }
                        System.Console.WriteLine("--------------------------");
                        Console.WriteLine("Нажмите любую кнопку для завершения процесса");
                        Console.ReadLine();     
                    break;     
                default: 
                {
                    System.Console.WriteLine("{0}, Вы не выбрали действите. Пожалуйста, перезапустите программу");
                    System.Console.WriteLine("--------------------------");
                    Console.WriteLine("Нажмите любую кнопку для завершения процесса");
                    Console.ReadLine(); 
                    break;
                }                 
            }

        }
    }

}
