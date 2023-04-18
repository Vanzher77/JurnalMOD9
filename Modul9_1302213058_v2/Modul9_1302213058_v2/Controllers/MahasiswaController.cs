using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Modul9_1302213058_v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
        {
            //pada parameter course terdapat array list, saya menggunakan course = new List<string> untuk menginisialisasi sebuah objek List sebelum digunakan
            new Mahasiswa{Name = "Mochamad Rizky Evan Ramadhan", Nim = "1302213058", Course = new List<string> { "Konstruksi Perangkat Lunak","UX" }, Year = 2021 },
            new Mahasiswa{Name = "Kamal Maula Azka Shidqi", Nim = "1302210032", Course = new List<string>{ "Basis Data","UI"}, Year = 2022 },
            new Mahasiswa{Name = "Ignaj nadhif", Nim = "1302213058", Course = new List<string>{ "Pemrograman Berorientasi Objek","Proting"}, Year = 2023 }
        };

        [HttpGet]
        //membuat output list array dari objek mahasiswa 
        public IEnumerable<Mahasiswa> Get() 
        {
            return mahasiswa;
        }

        [HttpPost]
        //membuat objek mahasiswa baru dan menambahkan objek menyertai nama, nim, matakuliah dan tahun
        public void post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswa.Add(newMahasiswa);
        }

        [HttpGet("index")]
        //memanggil 1 objek mahasiswa menggunakan index array
        public Mahasiswa Get(int  index) 
        {
            return mahasiswa[index];
        }

        [HttpDelete("index")]
        //menghapus objek mahasiswa sesuai dengan array listnya
        public void Delete(int index)
        {
            mahasiswa.RemoveAt(index); 
        }   

    }
}
