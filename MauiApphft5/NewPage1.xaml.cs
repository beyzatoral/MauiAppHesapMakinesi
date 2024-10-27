using System.Collections.Generic;

namespace MauiApphft5;

public partial class NewPage1 : TabbedPage
{
    public NewPage1()
    {
        InitializeComponent();
    }
    private string islem;
    private double ilkSayi;

    private void Numarator(object sender, EventArgs e)
    {
        var b = sender as Button;
        txtEkran.Text += b.Text;
        var d = double.Parse(txtEkran.Text);
        txtEkran.Text = d.ToString();
    }

    private void EkranClear(object sender, EventArgs e)
    {
        txtEkran.Text = "0";
    }

    private void Virgul(object sender, EventArgs e)
    {
        if (!txtEkran.Text.Contains(","))
        {
            txtEkran.Text += ",";
        }

    }

    private void SonSil(object sender, EventArgs e)
    {
        if (txtEkran.Text.Length > 1)
            txtEkran.Text = txtEkran.Text.Remove(txtEkran.Text.Length - 1);
        else
            txtEkran.Text = "0";

    }

    private void KareHesapla(object sender, EventArgs e)
    {
        double sayi = double.Parse(txtEkran.Text);
        txtEkran.Text = (sayi * sayi).ToString();

    }

    private void KokHesapla(object sender, EventArgs e)
    {
           double sayi = double.Parse(txtEkran.Text);
            txtEkran.Text = Math.Sqrt(sayi).ToString();
     
    }

    private void DortIslem(object sender, EventArgs e)
    {
       
      var b = sender as Button;
        ilkSayi = double.Parse(txtEkran.Text);
        islem = b.Text;
        txtEkran.Text = "0";
}

private void Esittir(object sender, EventArgs e)
    {
            double ikinciSayi = double.Parse(txtEkran.Text);
            double sonuc = 0;

            switch (islem) // "islem" burada "+" veya "-" gibi dört iþlemi temsil eder
            {
                case "+":
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case "/":
                    sonuc = ikinciSayi != 0 ? ilkSayi / ikinciSayi : 0; // Bölme iþleminde sýfýra bölme kontrolü
                    break;
            }

            txtEkran.Text = sonuc.ToString();
        }

    private async void Kaydet_Clicked(object sender, EventArgs e)
    {
        var cevap = await DisplayAlert("Kaydedilsin mi?", "Kaydetmek istediðine emin misin? ", "Evet", "Hayýr");
        if(cevap)
        {
            await DisplayAlert("Kayýt", "Kaydedildi", "OK");
        }
    }

    private void Vazgec_Clicked(object sender, EventArgs e)
    {

    }
}