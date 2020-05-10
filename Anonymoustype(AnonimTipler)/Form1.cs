using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymoustype_AnonimTipler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isim = "Negan"; // string
            var durum = true; // bool
            // İlk değer ataması hangi tipte oldu ise bir sonraki değer ataması farklı tip yapılamaz.
            // isim = 4; // İsim değişkeninin tipi ilk atamada string olduğu için string olarak kullanılır. Atama yanlıştır.
            /* İlk değer ataması zorunludur.
               var sayi;
               sayi = 4;
            // eğer ilk değer atamıyorsak */
            var sayi = default(int);
            sayi = 4;

            // Anonim olarak sık kullanılan yer foreach döngüsüdür. 
            int[] sayilar = { 4, 5, 2, 3, 41 };
            foreach (var item in sayilar)
            {
                MessageBox.Show(item.ToString());
            }

            // Var özellikle linq mimarisinde anlık olarak değer oluşturmada ve birden fazla tipin birleşiminde kullanılır .
            var ogr = new Ogrenci();
            ogr.Adi = "Negan";
            ogr.Soyadi = "Lucille";

            Ogrenci ogr1 = new Ogrenci { Adi = "Rick", Soyadi = "Grimes" };
            var egt = new Egitmen { Adi = "asd", Soyadi = "123" };
        }
    }
}