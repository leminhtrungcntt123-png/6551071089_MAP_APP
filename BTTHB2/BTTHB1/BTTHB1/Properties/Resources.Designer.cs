using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.IO;

namespace HotelManagement.Properties
{
    public class Resources
    {
        private static readonly ConcurrentDictionary<string, Image> _cache = new(StringComparer.OrdinalIgnoreCase);

        public static Image GetImage(string name)
        {
            return _cache.GetOrAdd(name, key =>
            {
                var asm = typeof(Resources).Assembly;
                string[] candidates = new[]
                {
                    $"HotelManagement.Resources.{key}.png",
                    $"BTTHB1.Resources.{key}.png",
                    $"{key}.png"
                };

                foreach (var resName in candidates)
                {
                    using var stream = asm.GetManifestResourceStream(resName);
                    if (stream != null)
                    {
                        using var ms = new MemoryStream();
                        stream.CopyTo(ms);
                        ms.Position = 0;
                        return Image.FromStream(ms);
                    }
                }

                // Check filesystem
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                string[] fileCandidates = new[]
                {
                    Path.Combine(appDir, "Resources", $"{key}.png"),
                    Path.Combine(appDir, "..", "..", "..", "Resources", $"{key}.png"),
                    Path.Combine("Resources", $"{key}.png")
                };

                foreach (var path in fileCandidates)
                {
                    if (File.Exists(path))
                    {
                        byte[] bytes = File.ReadAllBytes(path);
                        using var ms = new MemoryStream(bytes);
                        return Image.FromStream(ms);
                    }
                }

                return new Bitmap(32, 32);
            });
        }

        public static Image DangNhap => GetImage("DangNhap");
        public static Image pictureIcon => GetImage("pictureIcon");
        public static Image Menu => GetImage("Menu");
        public static Image user => GetImage("user");
        public static Image MenuThongKe => GetImage("MenuThongKe");
        public static Image MenuTrangChu => GetImage("MenuTrangChu");
        public static Image MenuQuanLyTaiKhoan => GetImage("MenuQuanLyTaiKhoan");
        public static Image MenuLoaiPhong => GetImage("MenuLoaiPhong");
        public static Image MenuQuanLyNhanVien => GetImage("MenuQuanLyNhanVien");
        public static Image MenuQuanLyKhachHang => GetImage("MenuQuanLyKhachHang");
        public static Image MenuPhong => GetImage("MenuPhong");
        public static Image MenuTienNghi => GetImage("MenuTienNghi");
        public static Image MenuQuanLyDichVu => GetImage("MenuQuanLyDichVu");
        public static Image MenuSoDoPhong => GetImage("MenuSoDoPhong");
        public static Image MenuDatPhong => GetImage("MenuDatPhong");
        public static Image MenuDanhSachHoaDon => GetImage("MenuDanhSachHoaDon");
        public static Image search => GetImage("search");
        public static Image Phong => GetImage("Phong");
        public static Image edit => GetImage("edit");
        public static Image delete => GetImage("delete");
        public static Image Giuong => GetImage("Giuong");
        public static Image details => GetImage("details");
        public static Image DichVu => GetImage("DichVu");
        public static Image TienNghi => GetImage("TienNghi");
        public static Image KhachHang => GetImage("KhachHang");
        public static Image NhanVien => GetImage("NhanVien");
        public static Image Add => GetImage("Add");
    }
}
