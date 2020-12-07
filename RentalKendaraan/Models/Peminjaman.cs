using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140052.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCostumer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Customer IdCostumerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
        public Peminjaman InverseIdPeminjamanNavigation { get; set; }
    }
}
