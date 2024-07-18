using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char _islem;   //heryerde geçerli oldığu anlaşılmaıs için _ ile başla
        bool _ekranTemizlenecekMi; // ture yada false döner
        int _ilksayi;
        private void button1_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi == true)  //if (_ekranTemizlenecekMi) böyle yazsan yeter
            {
                lblEkran.Text = "";    //ekran temizlenecekse temizle
                _ekranTemizlenecekMi = false; // yoksa + bastığında her rakanda temizlememesi için
            }
            if(lblEkran.Text == "0")
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            lblEkran.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "0";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            _islem = '+';     //yapılacak işlemi aklında tutucak
            _ekranTemizlenecekMi = true;   //ekranın temizlenip temizlenmemesi hakkında
            _ilksayi = Convert.ToInt32(lblEkran.Text); //girilen ilk sayıyı labelda yazan değere atar
        }
        private void btnFark_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //işlemi yapabilmek için ilk sayı ikinci sayı ve yapılıca işlemi bilmek lazım
            //ilksayi bir değişkende saklı ikinci sayı ekranda(labelda) yazıyor
            //işlemide değişkende saklamıştık
            //işlemin hangisi old bakmak için switch case yapısıyla bak
            int ikincisayi = Convert.ToInt32(lblEkran.Text);
            double sonuc = 0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
            }
            lblEkran.Text = Convert.ToString(sonuc);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";
        }
    }
}
