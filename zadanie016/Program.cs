// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите порядновый номер дня недели - ");
int day = int.Parse(Console.ReadLine());
if(day > 7) Console.Write("В неделе всего 7 дней");
if(day == 6 ^ day == 7) Console.Write("Поздравляю, это выходной!");
if(day ==1 | day ==2 | day ==3 | day ==4 | day ==5) Console.Write("Это будний день :(");
