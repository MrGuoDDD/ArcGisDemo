using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ConnectAccessDataBase
    {
        public static IWorkspace ConnectAccessDataBaseRun()
        {
            string file = Environment.CurrentDirectory + "\\北京HY_3DNew.mdb";
            IWorkspaceFactory pWorkspaceFactory = new AccessWorkspaceFactoryClass();
            IWorkspace pWorkSpace = pWorkspaceFactory.OpenFromFile(file, 0);
            return pWorkSpace;
        }

        public static IFeatureClass OpenDBData(IWorkspace workSpace,string tableName)
        {
            IFeatureWorkspace pFeatureWorkspace = workSpace as IFeatureWorkspace;
            IWorkspace2 pWorkspace2 = workSpace as IWorkspace2;

            if (!pWorkspace2.get_NameExists(esriDatasetType.esriDTFeatureClass, tableName)) return null;
            
            IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(tableName);
            
            return pFeatureClass;
        }

        public static void DisplayDBData(IFeatureClass pFeatureClass, IMap pMap)
        {
            string sLyrName = "";
            double maxScale = 100;
            double minScale = 100;
            bool bVis = true;
            bool bSel = true;

            IFeatureLayer pFeatureLayer2D = null;
            if (pFeatureClass.FeatureType == ESRI.ArcGIS.Geodatabase.esriFeatureType.esriFTAnnotation)
            {
                pFeatureLayer2D = new FDOGraphicsLayerClass();
            }
            else if (pFeatureClass.FeatureType == ESRI.ArcGIS.Geodatabase.esriFeatureType.esriFTSimple)
            {
                pFeatureLayer2D = new FeatureLayerClass();
            }

            pFeatureLayer2D.FeatureClass = pFeatureClass;
            pFeatureLayer2D.Name = sLyrName;
            pFeatureLayer2D.MaximumScale = maxScale;
            pFeatureLayer2D.MinimumScale = minScale;
            pFeatureLayer2D.Visible = bVis;
            pFeatureLayer2D.Selectable = bSel;
            pFeatureLayer2D.ShowTips = true;
            pFeatureLayer2D.DisplayField = "ToolTip";

            pMap.AddLayer(pFeatureLayer2D);
        }

        public static void UpdateDbData(IFeatureClass pFeatureClass)
        {
            IField pFld = new FieldClass();
            IFieldEdit pFldEdit = pFld as IFieldEdit;
            pFldEdit.Name_2 = "ToolTip";
            pFldEdit.Type_2 = esriFieldType.esriFieldTypeString;
            pFldEdit.Length_2 = 100;
            pFldEdit.IsNullable_2 = true;
            pFeatureClass.AddField(pFld);
            IFeatureCursor pCursor = pFeatureClass.Update(null, false);
            IFeature pFture = pCursor.NextFeature();

            while (pFture != null)
            {
                string tipText = string.Empty;
                int index = 0;

                index = pFture.Fields.FindField("物探点号");
                string code = pFture.get_Value(index).ToString();
                index = pFture.Fields.FindField("附属物");
                string addition = pFture.get_Value(index).ToString();
                index = pFture.Fields.FindField("特征");
                string charactor = pFture.get_Value(index).ToString();

                index = pFture.Fields.FindField("物探点号");
                pFture.set_Value(index, tipText);

                pCursor.UpdateFeature(pFture);
                pFture = pCursor.NextFeature();
            }
        }

        public static void CreateDbTableData()
        {

        }
    }
}
