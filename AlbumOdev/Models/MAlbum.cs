using System.ComponentModel.DataAnnotations;

namespace AlbumOdev.Models
{
    public class MAlbum
    {
        [Key]
        public int AlbumID { get; set; }
        public int AlbumNo { get; set; }
        public string AlbumTur {  get; set; }
        public string SanatciBilgi { get; set; }
        public string AlbumAdi { get; set; }
        public Decimal AlbumFiyat { get; set; } 
        public bool Yerli { get; set; }
    }
}
