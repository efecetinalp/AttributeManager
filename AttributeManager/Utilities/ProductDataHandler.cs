using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFITF;
using PARTITF;
using MECMOD;
using CATMat;
using DRAFTINGITF;
using ProductStructureTypeLib;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace AttributeManager.Utilities
{
    public class ProductDataHandler
    {
        private INFITF.Application CATIA_;
        private Document Document_;

        private List<string> GeneratedDatas;

        public ProductDataHandler()
        {
            CATIA_ = AttributeManagerForm.CATIA;
            Document_ = CATIA_.ActiveDocument;
            GenerateListData();
        }

        public string GetCurrentMaterial(Part part)
        {
            Material material;
            MaterialManager materialManager = (MaterialManager)part.GetItem("CATMatManagerVBExt");
            materialManager.GetMaterialOnPart(part, out material);

            if (material is null)
            {
                return "---";
            }
            else
            {
                return material.get_Name();
            }
        }

        #region Search Sub Product

        public void SearchSubProduct(Product currentProduct, string searchedProduct)
        {
            if (currentProduct.Products.Count > 0)
            {
                for (int i = 1; i <= currentProduct.Products.Count; i++)
                {
                    if (currentProduct.Products.Item(i).get_Name() == searchedProduct)
                    {
                        GetSearchedProduct = currentProduct.Products.Item(i).ReferenceProduct;
                    }

                    //search in sub product assembly
                    SearchSubProduct(currentProduct.Products.Item(i).ReferenceProduct, searchedProduct);
                }
            }
        }

        public Product GetSearchedProduct { get; private set; }

        #endregion

        #region Generate Initial Product List

        private void GenerateListData()
        {
            GeneratedDatas = new();

            if (Document_ != null)
            {
                if (Document_ is PartDocument)
                {
                    PartDocument partDocument = (PartDocument)Document_;
                    GeneratedDatas.Add(partDocument.Product.get_Name() + "|"
                        + "Main" + "|"
                        + partDocument.Product.get_DescriptionRef() + "|"
                        + GetMaterialOnPart(partDocument.Part));
                }
                else if (Document_ is ProductDocument)
                {
                    ProductDocument productDocument = (ProductDocument)Document_;
                    GeneratedDatas.Add(productDocument.Product.get_Name() + "|"
                        + "Main" + "|"
                        + productDocument.Product.get_DescriptionRef() + "|"
                        + "---");
                    GetSubProductData(productDocument.Product);
                }
            }
            else
                MessageBox.Show("Document not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void GetSubProductData(Product product)
        {
            if (product.Products.Count > 0)
            {
                for (int i = 1; i <= product.Products.Count; i++)
                {
                    string materialName;
                    if (product.Products.Item(i).ReferenceProduct.Parent is PartDocument)
                    {
                        Part currentPart = ((PartDocument)product.Products.Item(i).ReferenceProduct.Parent).Part;
                        materialName = GetMaterialOnPart(currentPart);
                    }
                    else
                        materialName = "---";

                    string result = GeneratedDatas.FirstOrDefault(x => x.Split("|")[0] == product.Products.Item(i).get_PartNumber());
                    if (result == null)
                    {
                        GeneratedDatas.Add(product.Products.Item(i).get_PartNumber() + "|"
                        + product.Products.Item(i).get_Name() + "|"
                        + product.Products.Item(i).get_DescriptionRef() + "|"
                        + materialName);
                    }

                    GetSubProductData(product.Products.Item(i).ReferenceProduct);
                }
            }
        }

        private string GetMaterialOnPart(Part part)
        {
            Material material;
            MaterialManager materialManager = (MaterialManager)part.GetItem("CATMatManagerVBExt");
            materialManager.GetMaterialOnPart(part, out material);

            if (material is null)
                return "---";
            else
                return material.get_Name();
        }

        #endregion

        #region Get Generated List Methods

        public List<string> GetProductList()
        {
            List<string> results = new();
            foreach (var data in GeneratedDatas)
            {
                results.Add(data.Split("|")[0]);
            }

            return results;
        }

        public List<string> GetInstanceNameList()
        {
            List<string> results = new();
            foreach (var data in GeneratedDatas)
            {
                results.Add(data.Split("|")[1]);
            }

            return results;
        }

        public List<string> GetDescriptionList()
        {
            List<string> results = new();
            foreach (var data in GeneratedDatas)
            {
                results.Add(data.Split("|")[2]);
            }

            return results;
        }

        public List<string> GetMaterialList()
        {
            List<string> results = new();
            foreach (var data in GeneratedDatas)
            {
                results.Add(data.Split("|")[3]);
            }

            return results;
        }

        #endregion
    }
}
