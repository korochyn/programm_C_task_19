// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Преподовательский вариант исправленный

const int COEFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double [] lineData1 = InputLineData(LINE1);
double [] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFICIENT]}*x+{lineData2[CONSTANT]}");
    Console.WriteLine($" имеет координаты {coord[X_COORD]}, {coord[Y_COORD]})");
}


// Ввод числа 
double Promt (string message)
{
    Console.Write(message); // Вывод сообщения
    string value = Console.ReadLine()!; // Считывает с консоли строку
    double result = Convert.ToDouble(value); // Преобразует строку в число
    return result; // Возвращает результат
}
// Ввод данных по прямой
double [] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFICIENT] = Promt($"Введите коэффициент для {numberOfLine} прямой ");
    lineData[CONSTANT] = Promt($"Введите константу для {numberOfLine} прямой ");
    return lineData;
}

// Поиск координат
double[] FindCoords (double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData2[COEFICIENT] - lineData1[COEFICIENT]) / (lineData1[CONSTANT] - lineData2[CONSTANT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[COEFICIENT]; 
    return coord;
}

bool ValidateLines(double [] lineDate1, double [] lineDate2)
{
    if (lineDate1[COEFICIENT] == lineData2[COEFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;

        }
    }
    return true;
}