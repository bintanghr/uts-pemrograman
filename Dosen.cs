using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUts
{
    internal class Dosen
    {
        //private variable
        private int id;
        private string nama;
        private int nik;
        private string gender;
        private string course;

        //properti
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        //method
        public Dosen()
        {
            id = 554273;
            nama = "Kamarudin";
            nik = 21114325;
            gender = "Laki-laki";
            course = "Pemrograman";
            
            Console.WriteLine("Nama dosen : {0}", this.nama);
            Console.WriteLine("Jenis Kelamin : {0}", this.gender);
            Console.WriteLine("Nomor Id : {0}", this.id);
            Console.WriteLine("Nomor Nik : {0}", this.nik);
            Console.WriteLine("Mata kuliah yang diampu : {0}", this.course);
            Console.WriteLine();
        }
        public void AddDosen(int id, string nama, int nik, string gender)
        {
            Console.WriteLine();
            Console.WriteLine("Penambahan data diri dosen : ");
            Console.WriteLine("Nama dosen : {0}", Nama);
            Console.WriteLine("Jenis Kelamin : {0}", Gender);
            Console.WriteLine("Nomor Id : {0}", Id);
            Console.WriteLine("Nomor Nik : {0}", Nik);
        }

        public void AddCourse(string course)
        {
            Console.WriteLine("Mata kuliah yang diampu : {0}", Course);
            Console.WriteLine("Berhasil !");
        }
    }
}
