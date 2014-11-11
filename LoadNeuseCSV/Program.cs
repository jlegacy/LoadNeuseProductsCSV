using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using LINQtoCSV;

namespace LoadNeuseCSV
{
    internal class ProductCSV
    {
        [CsvColumn(Name = "brandName", FieldIndex = 1)]
        public string BrandName { get; set; }

        [CsvColumn(Name = "modelName", FieldIndex = 2)]
        public string ModelName { get; set; }

        [CsvColumn(Name = "modelYear", FieldIndex = 3)]
        public string ModelYear { get; set; }

        [CsvColumn(Name = "modelSKU", FieldIndex = 4)]
        public string ModelSku { get; set; }

        [CsvColumn(Name = "modelDescription", FieldIndex = 5)]
        public string ModelDescription { get; set; }

        [CsvColumn(Name = "modelImage", FieldIndex = 6)]
        public string NodelImage { get; set; }

        [CsvColumn(Name = "imageCaption", FieldIndex = 7)]
        public string ImageCaption { get; set; }

        [CsvColumn(Name = "gender", FieldIndex = 8)]
        public string Gender { get; set; }

        [CsvColumn(Name = "categoryID", FieldIndex = 9)]
        public int CategoryID { get; set; }

        [CsvColumn(Name = "sku", FieldIndex = 10)]
        public string Sku { get; set; }

        [CsvColumn(Name = "mpn", FieldIndex = 11)]
        public string mpn { get; set; }

        [CsvColumn(Name = "gtin1", FieldIndex = 12)]
        public string Gtin1 { get; set; }

        [CsvColumn(Name = "gtin2", FieldIndex = 13)]
        public string Gtin2 { get; set; }

        [CsvColumn(Name = "msrp", FieldIndex = 14)]
        public double Msrp { get; set; }

        [CsvColumn(Name = "dealerCost", FieldIndex = 15)]
        public double DealerCost { get; set; }

        [CsvColumn(Name = "specialCost", FieldIndex = 16)]
        public string SpecialCost { get; set; }

        [CsvColumn(Name = "lowMsrp", FieldIndex = 17)]
        public double LowMsrp { get; set; }

        [CsvColumn(Name = "length", FieldIndex = 18)]
        public string Length { get; set; }

        [CsvColumn(Name = "width", FieldIndex = 19)]
        public string Width { get; set; }

        [CsvColumn(Name = "height", FieldIndex = 20)]
        public string Height { get; set; }

        [CsvColumn(Name = "weight", FieldIndex = 21)]
        public double Weight { get; set; }

        [CsvColumn(Name = "image", FieldIndex = 22)]
        public string Image { get; set; }

        [CsvColumn(Name = "unit", FieldIndex = 23)]
        public string Unit { get; set; }

        [CsvColumn(Name = "hazmatCode", FieldIndex = 24)]
        public string HazmatCode { get; set; }

        [CsvColumn(Name = "taxable", FieldIndex = 25)]
        public string Taxable { get; set; }

        [CsvColumn(Name = "shippable", FieldIndex = 26)]
        public string Shippable { get; set; }

        [CsvColumn(Name = "shipGround", FieldIndex = 27)]
        public string ShipGround { get; set; }

        [CsvColumn(Name = "shipAir", FieldIndex = 28)]
        public string ShipAir { get; set; }

        [CsvColumn(Name = "ormd", FieldIndex = 29)]
        public string Ormd { get; set; }

        [CsvColumn(Name = "FFLrequired", FieldIndex = 30)]
        public string FfLrequired { get; set; }

        [CsvColumn(Name = "NFArequired", FieldIndex = 31)]
        public string NfArequired { get; set; }

        [CsvColumn(Name = "variHash", FieldIndex = 32)]
        public string VariHash { get; set; }

        [CsvColumn(Name = "name", FieldIndex = 33)]
        public string Name { get; set; }

        [CsvColumn(Name = "id", FieldIndex = 34)]
        public string Id { get; set; }

        [CsvColumn(Name = "text", FieldIndex = 35)]
        public string Text { get; set; }
    }

    internal class Program
    {
        public static int templateCategory { get; set; }
        public static int neuseSection { get; set; }

 
        private static void Main(string[] args)
        {
            templateCategory = Convert.ToInt32(args[0]);
            neuseSection = Convert.ToInt32(args[1]);

             LogFile logger = new LogFile();

             logger.MyLogFile("cat:", templateCategory.ToString());
             logger.MyLogFile("sect:", neuseSection.ToString());

            var fd = new CsvFileDescription();
            fd.SeparatorChar = ',';
            fd.FirstLineHasColumnNames = true;
            fd.TextEncoding = Encoding.Default;

            var cc = new CsvContext();

            IEnumerable<ProductCSV> products =
                cc.Read<ProductCSV>("C:\\Users\\jlegacy\\Desktop\\NeuseCSV.csv", fd);

// Data is now available via variable products.

            IEnumerable<ProductCSV> productsByName =
                from p in products
                where (p.CategoryID.Equals(neuseSection))
                select p;
// or ...
            foreach (ProductCSV item in productsByName)
            {
                IEnumerable<ProductCSV> SKURecords =
                    from z in products
                    where
                        (z.ModelSku.CompareTo(item.ModelSku) == 0) && (z.CategoryID == 0) &&
                        (z.Id.CompareTo("Description1") == 0)
                    select z;

                foreach (ProductCSV z in SKURecords)
                {
                    //Data maping object to our database
                    var text = new ProductDataContext();
                    var myProduct = new product();

             /*       var dc = new ProductDataContext();
                    IQueryable<product> q =
                        from a in dc.GetTable<product>()
                        where a.pID.Equals(z.Gtin1)
                        select a;
                    if (q.Any())
                    {
                        foreach (product x in q)
                        {
                            buildData(x, z);
                            dc.SubmitChanges();
                            saveImage(z);
                        }
                    }
                    else
                    { */
                    if (z.Id.CompareTo("Description1") == 0)
                    { 
                        buildData(myProduct, z);
                        text.products.InsertOnSubmit(myProduct);
                        if (myProduct.pID != null)
                        {
                            try
                            {
                                text.SubmitChanges();
                                saveImage(z);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        //}
                    }
                }

                // executes the appropriate commands to implement the changes to the database
            }
        }

        private static void buildData(product myProduct, ProductCSV item)
        {
            myProduct.pID = item.Gtin1;
            myProduct.pName = HttpUtility.UrlDecode(item.Text);
            myProduct.pName2 = HttpUtility.UrlDecode(item.ModelName);
            myProduct.pSection = templateCategory;

            myProduct.pDescription = HtmlEncode(item.ModelDescription);

            myProduct.pLongdescription = HttpUtility.UrlDecode(item.ModelDescription);
            myProduct.pSKU = item.ModelSku;

            myProduct.pPrice = item.Msrp;
            myProduct.pListPrice = 0;

            myProduct.pWeight = item.Weight;
            myProduct.pTax = 0;
            myProduct.pWholesalePrice = 0;
            myProduct.pShipping = 0;
            myProduct.pShipping2 = 0;
            myProduct.pStaticPage = false;
            myProduct.pStockByOpts = false;
            myProduct.pRecommend = false;
            myProduct.pGiftWrap = false;
            myProduct.pBackOrder = false;
            myProduct.pOrder = 0;

            myProduct.pDisplay = 1;
            myProduct.pSell = 1;

            myProduct.pManufacturer = GetManufacturer(item.BrandName);
            myProduct.pDropship = 0;

            myProduct.pSearchParams = HttpUtility.UrlDecode(item.Text);
        }

        public static string HtmlEncode(string text)
        {
            char[] chars = HttpUtility.HtmlEncode(text).ToCharArray();
            var result = new StringBuilder(text.Length + (int) (text.Length*0.1));

            foreach (char c in chars)
            {
                int value = Convert.ToInt32(c);
                if (value > 127)
                    result.AppendFormat("&#{0};", value);
                else
                    result.Append(c);
            }

            return result.ToString();
        }

        private static int GetManufacturer(string x)
        {
            int manufacturer = 0;

            var text = new searchCriteriaDataContext();
   
            IQueryable<searchcriteria> q =
                from a in text.GetTable<searchcriteria>()
                where (a.scWorkingName.ToLower().Trim().CompareTo(x.ToLower().Trim()) == 0)
                select a;
            if (q.Any())
            {
                foreach (searchcriteria z in q)
                {
                   manufacturer = z.scID;
                }
            }

            return manufacturer;
        }


        private static void saveImage(ProductCSV item)
        {
          
            var text2 = new productImagesDataContext();
            var dc = new productImagesDataContext();

            var myProductImage = new productimage();

            IQueryable<productimage> q =
                from a in dc.GetTable<productimage>()
                where a.imageProduct.Equals(item.Gtin1) && (a.imageType == 0)
                select a;
            if (q.Any())
            {
                foreach (productimage x in q)
                {
                    buildImage(x, item, 0);
                    dc.SubmitChanges();
                }
            }
            else
            {
                buildImage(myProductImage, item, 0);
                text2.productimages.InsertOnSubmit(myProductImage);
                text2.SubmitChanges();
            }

            var text3 = new productImagesDataContext();
            var dc2 = new productImagesDataContext();
            myProductImage = new productimage();

            IQueryable<productimage> z =
                from a in dc2.GetTable<productimage>()
                where a.imageProduct.Equals(item.Gtin1) && (a.imageType == 1)
                select a;
            if (z.Any())
            {
                foreach (productimage x in z)
                {
                    buildImage(x, item, 1);
                    dc2.SubmitChanges();
                }
            }
            else
            {
                buildImage(myProductImage, item, 1);
                text3.productimages.InsertOnSubmit(myProductImage);
                text3.SubmitChanges();
            }
        }

        private static void buildImage(productimage myProductImage, ProductCSV item, short imgTyp)
        {
            
            myProductImage.imageNumber = 0;
            myProductImage.imageType = imgTyp;
            var size = "s";
            switch (imgTyp)
            {
                case 0:
                    size = "s";
                    break;
                case 1:
                    size = "l";
                    break;
                default:
                    size = "s";
                    break;
            }

            myProductImage.imageSrc = "prodImages" + getPath(item.Image) + size +item.Image;
            myProductImage.imageProduct = item.Gtin1;
        }

        private static string getPath(String text)
        {
            string pat = @"(^[0-9]+)";
            string result;

            // Instantiate the regular expression object.
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            // Match the regular expression pattern against a text string.
            Match m = r.Match(text);

            return '/' + m.ToString().Substring(0, 2) + '/' + m.ToString().Substring(2, 2) + '/';
        }
    }
}