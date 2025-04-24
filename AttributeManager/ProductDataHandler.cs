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

namespace AttributeManager
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
                        PartDocument currentPartDocument = (PartDocument)product.Products.Item(i).ReferenceProduct.Parent;
                        Part currentPart = currentPartDocument.Part;
                        materialName = GetMaterialOnPart(currentPart);
                    }
                    else
                        materialName = "---";

                    GeneratedDatas.Add(product.Products.Item(i).get_PartNumber() + "|"
                        + product.Products.Item(i).get_Name() + "|"
                        + product.Products.Item(i).get_DescriptionRef() + "|"
                        + materialName);

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
    }
}
