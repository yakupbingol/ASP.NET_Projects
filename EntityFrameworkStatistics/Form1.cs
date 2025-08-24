using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        DbProject3Entities db = new DbProject3Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam kategori sayisi
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            //Toplam urun sayisi
            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            //Toplam musteri sayisi
            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            //Toplam siparis sayisi
            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            //Toplam Stok Sayisi
            var totalProductStockCount = db.TblProduct.Sum(x=>x.ProductStock);
            lblProductTotalStock.Text = totalProductStockCount.ToString();

            //Ortalama urun fiyati
            var averageProductPrice = db.TblProduct.Average(x=>x.ProductPrice);
            lblProductAveragePrice.Text = averageProductPrice.ToString() + "₺";

            //Toplam Meyve Stogu Sayisi
            var totalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId ==1).Sum(y => y.ProductStock);
            lblProductCountByCategoryFruit.Text = totalProductCountByCategoryIsFruit.ToString();

            //Gazoz isimli urunun toplam islem hacmi
            var totalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y =>y.ProductStock).FirstOrDefault();
            var totalPriceByProductNameIsGazozUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
            var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPriceByProductNameIsGazozUnitPrice;
            lblTotalPriceByProductGazoz.Text = totalPriceByProductNameIsGazoz.ToString() + "₺";

            //Stok Sayisi 100den az urunler
            var productCountByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductStockSmaller100.Text = productCountByStockCountSmallerThen100.ToString();

            //Kategorisi sebze ve durumu aktif olan urun stok toplami
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where
                (x => x.CategoryId==(db.TblCategory.Where(w => w.CategoryName =="Sebze").Select(y => y.CategoryId).FirstOrDefault()) && x.ProductStatus ==true).Sum(y => y.ProductStock);
            lblProductCountByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

            //Turkiyeden Yapilan Siparisler SQL
            var orderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) From TblOrder Where CustomerId In (Select CustomerId From TblCustomer Where CustomerCountry='Turkiye')").FirstOrDefault();
            lblOrderCountFromTurkiyeBySQL.Text= orderCountFromTurkiye.ToString();

            //Turkiyeden Yapilan Siparisler EntityFramework
            var turkishCustomerIds = db.TblCustomer.Where(x=>x.CustomerCountry=="Turkiye")
                                                    .Select(y=>y.CustomerId)
                                                    .ToList();
            var orderCountFromTurkiyeWithEF=db.TblOrder.Count(z=>turkishCustomerIds.Contains(z.CustomerId.Value));
            lblOrderCountFromTurkiyeByEF.Text=orderCountFromTurkiyeWithEF.ToString();

            //Siparisler icinde kategorisi meyve olan urunlerin toplam satis fiyatlari SQL sorgusu
            
                var orderTotalPriceCategoryIsMeyve = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) From TblOrder o Join TblProduct p On o.ProductId=p.ProductId Join TblCategory c On p.CategoryId = c.CategoryId Where c.CategoryName='Meyve'").FirstOrDefault();
            lblOrderTotalPriceByCategoryIsMeyve.Text = orderTotalPriceCategoryIsMeyve.ToString() + "₺";

            //Siparisler icinde kategorisi meyve olan urunlerin toplam satis fiyatlari Entity Framework Metodu

            var orderTotalPriceCategoryIsMeyveWithEF = (from o in db.TblOrder
                                                        join p in db.TblProduct on o.ProductId equals p.ProductId
                                                        join c in db.TblCategory on p.CategoryId equals c.CategoryId
                                                        where c.CategoryName == "Meyve"
                                                        select o.TotalPrice).Sum();
            lblOrderTotalPriceByCategoryIsMeyveByEF.Text = orderTotalPriceCategoryIsMeyveWithEF.ToString() + "₺";

            //Son eklenen urunun adi
            var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
            lblLastProductName.Text = lastProductName.ToString();

            //Son eklenen urunun kategori adi
            var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastProductCategoryName = db.TblCategory.Where(x => x.CategoryId == lastProductCategoryId).Select(y=>y.CategoryName).FirstOrDefault();
            lblLastProductNameByCategory.Text = lastProductCategoryName.ToString();

            //Aktif urun sayisi
            var activeProductCount = db.TblProduct.Where(x=>x.ProductStatus==true).Count();
            lblActiveProductCount.Text = activeProductCount.ToString();

            //Toplam kola stok satislarindan kazanilan para
            var colaStock = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y=>y.ProductStock).FirstOrDefault();
            var colaPrice = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();
            var totalKolaStockPrice = colaStock * colaPrice;
            lblTotalPriceWithStockByKola.Text = totalKolaStockPrice + "₺";

            //Sistemde son siparis veren musteri adi
            var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(y=>y.CustomerId).FirstOrDefault();
            var lastCustomerName = db.TblCustomer.Where(x => x.CustomerId == lastCustomerId).Select(y => y.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastCustomerName.ToString();

            //Ulke cesitliligi sayisi
            var countryDifferentCount = db.TblCustomer.Select(x=>x.CustomerCountry).Distinct().Count();
            lblCountryDifferentCount.Text = countryDifferentCount.ToString();
        }


    }
}
