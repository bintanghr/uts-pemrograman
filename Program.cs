using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen();

            Console.WriteLine("Data diri dosen baru : ");
            Console.Write("Masukkan nama dosen : ");
            dosen1.Nama = Console.ReadLine();
            Console.Write("Jenis kelamin : ");
            dosen1.Gender = Console.ReadLine();
            Console.Write("Nomor id : ");
            dosen1.Id = int.Parse(Console.ReadLine());
            Console.Write("Nomor NIK : ");
            dosen1.Nik = int.Parse(Console.ReadLine());
            Console.Write("Mata kuliah yang diampu : ");
            dosen1.Course = Console.ReadLine();

            dosen1.AddDosen(dosen1.Id, dosen1.Nama, dosen1.Nik, dosen1.Gender);
            dosen1.AddCourse(dosen1.Course);

            Console.ReadKey();
        }
    }
}
