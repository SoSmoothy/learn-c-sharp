using System;

namespace basic_about_c_sharp.basic.PhanSo
{
    public class PhanSo
    {
        private double _tuSo;
        private double _mauSo;

        public PhanSo() {}
        public PhanSo(double tuSo, double mauSo)
        {
            _tuSo = tuSo;
            _mauSo = mauSo;
        }
        public double TuSo
        {
            get => _tuSo;
            set
            {
                _tuSo = value;
            }
        }

        public double MauSo
        {
            get => _mauSo;
            set
            {
                if (value != 0)
                {
                    _mauSo = value;
                }
                else
                {
                    throw new ArgumentException("Mẫu số không thể bằng 0!");
                }
            }
        }

        public override string ToString()
        {
            return $"Phân số: {this.TuSo}/{this.MauSo}";
        }
    }
}