namespace API
{
    public class Mahasiswa
    {
        public string nim {  get; set; }
        public string name { get; set; }
        public int tahunMasuk { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string nim, string name, int tahunMasuk)
        {
            this. nim = nim;
            this.name = name;
            this.tahunMasuk = tahunMasuk;
        }
    }
}
