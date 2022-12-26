// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistBeetwDots(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
    {
        double DistBeetwDots = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));
        return DistBeetwDots;
    }

int Xa = 3; int Ya = 6; int Za = 8;
int Xb = 2; int Yb = 1; int Zb = -7;

double Distance = DistBeetwDots(Xa, Ya, Za, Xb, Yb, Zb);
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве равно {Distance:f}");