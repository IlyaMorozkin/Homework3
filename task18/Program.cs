// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = false;
bool y = false; 

bool x1 = false; 
bool y1 = true;

bool x2 = false;
bool y2 = true;

bool x3 = false;
bool y3 = false;

if ((!(x||y) == (!x&&!y))
&& (!(x1||y1) == (!x&&!y))
&& (!(x2||y2) == (!x2&&!y2))
&& (!(x3||y3) == (!x3!&&y3)))
Console.WriteLine("Истина");
else
Console.WriteLine("Ложь");