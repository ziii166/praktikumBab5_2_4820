Console.Write("Masukkan tarif per jam: ");
int tarifPerJam = int.Parse(Console.ReadLine());

Console.Write("Masukkan lama penggunaan: ");
int lamaPenggunaan = int.Parse(Console.ReadLine());

int totalBiaya = tarifPerJam * lamaPenggunaan;

Console.WriteLine($"Total biaya = {totalBiaya}");