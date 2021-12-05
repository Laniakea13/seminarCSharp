// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int numberX = new Random().Next(-2147483640, 2147483640);
int numberY = new Random().Next(-2147483640, 2147483640);
Console.WriteLine($"х = {numberX}, y = {numberY}");
if(numberX ==0 | numberY ==0 ) Console.Write("Начтине выполнение заново, один из параметров равен нулю)");
if (numberX > 0 & numberY > 0) Console.WriteLine("Точки находятся в I четверти");
if (numberX < 0 & numberY > 0) Console.WriteLine("Точки находятся в II четверти");
if (numberX < 0 & numberY < 0) Console.WriteLine("Точки находятся в III четверти");
if (numberX > 0 & numberY < 0) Console.WriteLine("Точки находятся в IV четверти");