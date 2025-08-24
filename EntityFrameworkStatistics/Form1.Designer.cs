using System;

namespace EntityFrameworkStatistics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProductTotalStock = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProductCountByCategorySebzeAndStatusTrue = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.lblProductStockSmaller100 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalPriceByProductGazoz = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.lblProductCountByCategoryFruit = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.lblProductAveragePrice = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.lblLastProductName = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.lblOrderTotalPriceByCategoryIsMeyveByEF = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.lblOrderTotalPriceByCategoryIsMeyve = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblOrderCountFromTurkiyeByEF = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.lblOrderCountFromTurkiyeBySQL = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.lblCountryDifferentCount = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.lblLastCustomerName = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.lblTotalPriceWithStockByKola = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.lblActiveProductCount = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.lblLastProductNameByCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCategoryCount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Sayisi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(80, 52);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(59, 23);
            this.lblCategoryCount.TabIndex = 0;
            this.lblCategoryCount.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblProductCount);
            this.panel2.Location = new System.Drawing.Point(238, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Urun Sayisi";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(77, 52);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(59, 23);
            this.lblProductCount.TabIndex = 0;
            this.lblProductCount.Text = "label4";
            this.lblProductCount.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(155)))), ((int)(((byte)(174)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblCustomerCount);
            this.panel3.Location = new System.Drawing.Point(453, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Musteri Sayisi";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCount.Location = new System.Drawing.Point(86, 52);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(59, 23);
            this.lblCustomerCount.TabIndex = 0;
            this.lblCustomerCount.Text = "label6";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblOrderCount);
            this.panel4.Location = new System.Drawing.Point(668, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Siparis Sayisi";
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCount.Location = new System.Drawing.Point(77, 52);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(59, 23);
            this.lblOrderCount.TabIndex = 0;
            this.lblOrderCount.Text = "label8";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lblProductTotalStock);
            this.panel5.Location = new System.Drawing.Point(888, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Toplam Stok Sayisi";
            // 
            // lblProductTotalStock
            // 
            this.lblProductTotalStock.AutoSize = true;
            this.lblProductTotalStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTotalStock.Location = new System.Drawing.Point(92, 52);
            this.lblProductTotalStock.Name = "lblProductTotalStock";
            this.lblProductTotalStock.Size = new System.Drawing.Size(69, 23);
            this.lblProductTotalStock.TabIndex = 0;
            this.lblProductTotalStock.Text = "label10";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblProductCountByCategorySebzeAndStatusTrue);
            this.panel6.Location = new System.Drawing.Point(888, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(50, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Aktif Sebze Stogu";
            // 
            // lblProductCountByCategorySebzeAndStatusTrue
            // 
            this.lblProductCountByCategorySebzeAndStatusTrue.AutoSize = true;
            this.lblProductCountByCategorySebzeAndStatusTrue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCountByCategorySebzeAndStatusTrue.Location = new System.Drawing.Point(67, 52);
            this.lblProductCountByCategorySebzeAndStatusTrue.Name = "lblProductCountByCategorySebzeAndStatusTrue";
            this.lblProductCountByCategorySebzeAndStatusTrue.Size = new System.Drawing.Size(69, 23);
            this.lblProductCountByCategorySebzeAndStatusTrue.TabIndex = 0;
            this.lblProductCountByCategorySebzeAndStatusTrue.Text = "label12";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(76)))));
            this.panel7.Controls.Add(this.label43);
            this.panel7.Controls.Add(this.lblProductStockSmaller100);
            this.panel7.Location = new System.Drawing.Point(668, 129);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 6;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.Location = new System.Drawing.Point(25, 18);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(172, 15);
            this.label43.TabIndex = 1;
            this.label43.Text = "Stok Sayisi 100\'den Az Urunler";
            // 
            // lblProductStockSmaller100
            // 
            this.lblProductStockSmaller100.AutoSize = true;
            this.lblProductStockSmaller100.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductStockSmaller100.Location = new System.Drawing.Point(67, 52);
            this.lblProductStockSmaller100.Name = "lblProductStockSmaller100";
            this.lblProductStockSmaller100.Size = new System.Drawing.Size(69, 23);
            this.lblProductStockSmaller100.TabIndex = 0;
            this.lblProductStockSmaller100.Text = "label14";
            this.lblProductStockSmaller100.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(99)))));
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.lblTotalPriceByProductGazoz);
            this.panel8.Location = new System.Drawing.Point(453, 129);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(29, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Gazoz Toplam Islem Hacmi";
            // 
            // lblTotalPriceByProductGazoz
            // 
            this.lblTotalPriceByProductGazoz.AutoSize = true;
            this.lblTotalPriceByProductGazoz.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceByProductGazoz.Location = new System.Drawing.Point(67, 52);
            this.lblTotalPriceByProductGazoz.Name = "lblTotalPriceByProductGazoz";
            this.lblTotalPriceByProductGazoz.Size = new System.Drawing.Size(69, 23);
            this.lblTotalPriceByProductGazoz.TabIndex = 0;
            this.lblTotalPriceByProductGazoz.Text = "label16";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.panel9.Controls.Add(this.label41);
            this.panel9.Controls.Add(this.lblProductCountByCategoryFruit);
            this.panel9.Location = new System.Drawing.Point(238, 129);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 5;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(50, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(119, 15);
            this.label41.TabIndex = 1;
            this.label41.Text = "Toplam Meyve Stogu";
            // 
            // lblProductCountByCategoryFruit
            // 
            this.lblProductCountByCategoryFruit.AutoSize = true;
            this.lblProductCountByCategoryFruit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCountByCategoryFruit.Location = new System.Drawing.Point(67, 54);
            this.lblProductCountByCategoryFruit.Name = "lblProductCountByCategoryFruit";
            this.lblProductCountByCategoryFruit.Size = new System.Drawing.Size(69, 23);
            this.lblProductCountByCategoryFruit.TabIndex = 0;
            this.lblProductCountByCategoryFruit.Text = "label18";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel10.Controls.Add(this.label42);
            this.panel10.Controls.Add(this.lblProductAveragePrice);
            this.panel10.Location = new System.Drawing.Point(12, 129);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 100);
            this.panel10.TabIndex = 4;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(50, 18);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 15);
            this.label42.TabIndex = 1;
            this.label42.Text = "Ortalama Urun Fiyati";
            // 
            // lblProductAveragePrice
            // 
            this.lblProductAveragePrice.AutoSize = true;
            this.lblProductAveragePrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductAveragePrice.Location = new System.Drawing.Point(49, 52);
            this.lblProductAveragePrice.Name = "lblProductAveragePrice";
            this.lblProductAveragePrice.Size = new System.Drawing.Size(69, 23);
            this.lblProductAveragePrice.TabIndex = 0;
            this.lblProductAveragePrice.Text = "label20";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(145)))));
            this.panel11.Controls.Add(this.label21);
            this.panel11.Controls.Add(this.lblLastProductName);
            this.panel11.Location = new System.Drawing.Point(888, 248);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 100);
            this.panel11.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(50, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "Son Eklenen Urun";
            // 
            // lblLastProductName
            // 
            this.lblLastProductName.AutoSize = true;
            this.lblLastProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastProductName.Location = new System.Drawing.Point(67, 52);
            this.lblLastProductName.Name = "lblLastProductName";
            this.lblLastProductName.Size = new System.Drawing.Size(69, 23);
            this.lblLastProductName.TabIndex = 0;
            this.lblLastProductName.Text = "label22";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(220)))), ((int)(((byte)(154)))));
            this.panel12.Controls.Add(this.label23);
            this.panel12.Controls.Add(this.lblOrderTotalPriceByCategoryIsMeyveByEF);
            this.panel12.Location = new System.Drawing.Point(668, 248);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(25, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 15);
            this.label23.TabIndex = 1;
            this.label23.Text = "Meyve Satislari Kazanci EF";
            // 
            // lblOrderTotalPriceByCategoryIsMeyveByEF
            // 
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.AutoSize = true;
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.Location = new System.Drawing.Point(49, 52);
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.Name = "lblOrderTotalPriceByCategoryIsMeyveByEF";
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.Size = new System.Drawing.Size(69, 23);
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.TabIndex = 0;
            this.lblOrderTotalPriceByCategoryIsMeyveByEF.Text = "label24";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            this.panel13.Controls.Add(this.label25);
            this.panel13.Controls.Add(this.lblOrderTotalPriceByCategoryIsMeyve);
            this.panel13.Location = new System.Drawing.Point(453, 248);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 100);
            this.panel13.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(39, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 15);
            this.label25.TabIndex = 1;
            this.label25.Text = "Meyve Satislari Kazanci";
            // 
            // lblOrderTotalPriceByCategoryIsMeyve
            // 
            this.lblOrderTotalPriceByCategoryIsMeyve.AutoSize = true;
            this.lblOrderTotalPriceByCategoryIsMeyve.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotalPriceByCategoryIsMeyve.Location = new System.Drawing.Point(67, 52);
            this.lblOrderTotalPriceByCategoryIsMeyve.Name = "lblOrderTotalPriceByCategoryIsMeyve";
            this.lblOrderTotalPriceByCategoryIsMeyve.Size = new System.Drawing.Size(69, 23);
            this.lblOrderTotalPriceByCategoryIsMeyve.TabIndex = 0;
            this.lblOrderTotalPriceByCategoryIsMeyve.Text = "label26";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(79)))));
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.lblOrderCountFromTurkiyeByEF);
            this.panel14.Location = new System.Drawing.Point(238, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 100);
            this.panel14.TabIndex = 10;
            // 
            // lblOrderCountFromTurkiyeByEF
            // 
            this.lblOrderCountFromTurkiyeByEF.AutoSize = true;
            this.lblOrderCountFromTurkiyeByEF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCountFromTurkiyeByEF.Location = new System.Drawing.Point(67, 54);
            this.lblOrderCountFromTurkiyeByEF.Name = "lblOrderCountFromTurkiyeByEF";
            this.lblOrderCountFromTurkiyeByEF.Size = new System.Drawing.Size(69, 23);
            this.lblOrderCountFromTurkiyeByEF.TabIndex = 0;
            this.lblOrderCountFromTurkiyeByEF.Text = "label28";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.panel15.Controls.Add(this.label29);
            this.panel15.Controls.Add(this.lblOrderCountFromTurkiyeBySQL);
            this.panel15.Location = new System.Drawing.Point(12, 248);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 100);
            this.panel15.TabIndex = 9;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(3, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(193, 15);
            this.label29.TabIndex = 1;
            this.label29.Text = "Turkiyeden Yapilan Siparisler SQL";
            // 
            // lblOrderCountFromTurkiyeBySQL
            // 
            this.lblOrderCountFromTurkiyeBySQL.AutoSize = true;
            this.lblOrderCountFromTurkiyeBySQL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCountFromTurkiyeBySQL.Location = new System.Drawing.Point(67, 52);
            this.lblOrderCountFromTurkiyeBySQL.Name = "lblOrderCountFromTurkiyeBySQL";
            this.lblOrderCountFromTurkiyeBySQL.Size = new System.Drawing.Size(69, 23);
            this.lblOrderCountFromTurkiyeBySQL.TabIndex = 0;
            this.lblOrderCountFromTurkiyeBySQL.Text = "label30";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(79)))), ((int)(((byte)(43)))));
            this.panel16.Controls.Add(this.label31);
            this.panel16.Controls.Add(this.lblCountryDifferentCount);
            this.panel16.Location = new System.Drawing.Point(888, 368);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(200, 100);
            this.panel16.TabIndex = 18;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(50, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(122, 15);
            this.label31.TabIndex = 1;
            this.label31.Text = "Ulke Cesitliligi Sayisi";
            // 
            // lblCountryDifferentCount
            // 
            this.lblCountryDifferentCount.AutoSize = true;
            this.lblCountryDifferentCount.BackColor = System.Drawing.Color.White;
            this.lblCountryDifferentCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountryDifferentCount.Location = new System.Drawing.Point(67, 52);
            this.lblCountryDifferentCount.Name = "lblCountryDifferentCount";
            this.lblCountryDifferentCount.Size = new System.Drawing.Size(69, 23);
            this.lblCountryDifferentCount.TabIndex = 0;
            this.lblCountryDifferentCount.Text = "label32";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
            this.panel17.Controls.Add(this.label33);
            this.panel17.Controls.Add(this.lblLastCustomerName);
            this.panel17.Location = new System.Drawing.Point(668, 368);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(200, 100);
            this.panel17.TabIndex = 16;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(25, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(167, 15);
            this.label33.TabIndex = 1;
            this.label33.Text = "Son Siparis Veren Musteri Adi";
            // 
            // lblLastCustomerName
            // 
            this.lblLastCustomerName.AutoSize = true;
            this.lblLastCustomerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastCustomerName.Location = new System.Drawing.Point(67, 52);
            this.lblLastCustomerName.Name = "lblLastCustomerName";
            this.lblLastCustomerName.Size = new System.Drawing.Size(69, 23);
            this.lblLastCustomerName.TabIndex = 0;
            this.lblLastCustomerName.Text = "label34";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(35)))));
            this.panel18.Controls.Add(this.label35);
            this.panel18.Controls.Add(this.lblTotalPriceWithStockByKola);
            this.panel18.Location = new System.Drawing.Point(453, 368);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(200, 100);
            this.panel18.TabIndex = 17;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(29, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(153, 15);
            this.label35.TabIndex = 1;
            this.label35.Text = "Toplam Kola Kazanc Tutari";
            // 
            // lblTotalPriceWithStockByKola
            // 
            this.lblTotalPriceWithStockByKola.AutoSize = true;
            this.lblTotalPriceWithStockByKola.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceWithStockByKola.Location = new System.Drawing.Point(67, 52);
            this.lblTotalPriceWithStockByKola.Name = "lblTotalPriceWithStockByKola";
            this.lblTotalPriceWithStockByKola.Size = new System.Drawing.Size(69, 23);
            this.lblTotalPriceWithStockByKola.TabIndex = 0;
            this.lblTotalPriceWithStockByKola.Text = "label36";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.panel19.Controls.Add(this.label37);
            this.panel19.Controls.Add(this.lblActiveProductCount);
            this.panel19.Location = new System.Drawing.Point(238, 368);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(200, 100);
            this.panel19.TabIndex = 15;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(50, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 15);
            this.label37.TabIndex = 1;
            this.label37.Text = "Aktif Urun Sayisi";
            // 
            // lblActiveProductCount
            // 
            this.lblActiveProductCount.AutoSize = true;
            this.lblActiveProductCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblActiveProductCount.Location = new System.Drawing.Point(67, 54);
            this.lblActiveProductCount.Name = "lblActiveProductCount";
            this.lblActiveProductCount.Size = new System.Drawing.Size(69, 23);
            this.lblActiveProductCount.TabIndex = 0;
            this.lblActiveProductCount.Text = "label38";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(189)))));
            this.panel20.Controls.Add(this.label39);
            this.panel20.Controls.Add(this.lblLastProductNameByCategory);
            this.panel20.Location = new System.Drawing.Point(12, 368);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 100);
            this.panel20.TabIndex = 14;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(16, 18);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(180, 15);
            this.label39.TabIndex = 1;
            this.label39.Text = "Son Eklenen Urunun Kategorisi";
            // 
            // lblLastProductNameByCategory
            // 
            this.lblLastProductNameByCategory.AutoSize = true;
            this.lblLastProductNameByCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastProductNameByCategory.Location = new System.Drawing.Point(67, 52);
            this.lblLastProductNameByCategory.Name = "lblLastProductNameByCategory";
            this.lblLastProductNameByCategory.Size = new System.Drawing.Size(69, 23);
            this.lblLastProductNameByCategory.TabIndex = 0;
            this.lblLastProductNameByCategory.Text = "label40";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turkiyeden Yapilan Siparisler EF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 571);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Istatistikler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label14_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProductTotalStock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProductCountByCategorySebzeAndStatusTrue;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lblProductStockSmaller100;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalPriceByProductGazoz;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblProductCountByCategoryFruit;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblProductAveragePrice;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblLastProductName;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblOrderTotalPriceByCategoryIsMeyveByEF;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblOrderTotalPriceByCategoryIsMeyve;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblOrderCountFromTurkiyeByEF;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblOrderCountFromTurkiyeBySQL;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblCountryDifferentCount;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblLastCustomerName;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblTotalPriceWithStockByKola;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblActiveProductCount;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblLastProductNameByCategory;
        private System.Windows.Forms.Label label1;
    }
}

