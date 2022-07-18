<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>决策分析相关算法</title>
</head>
<body>
xhhdfuxbvuj3949234 数据库连接位置
<h1>图例</h1>
<h2><font style="color: #9c27b0">1.有问题的地方</font></h2>
<h2><font style="color: #84613d">2.ArcMap接口调用</font></h2>
<h2><font style="color: green">3.计算公式</font></h2>


<h1>北京化二 地下管网信息系统</h1>
<h1>点线表字段说明</h1>
<h2>1.线表</h2>
<ul>
    <li>起点埋深</li>
    给水埋深 到管顶<br>
    排水埋深 到管底（内壁）<br>
    <li>终点埋深</li>
    <li>起点高程=起点地面高程-起点埋深</li>
    <li>终点高程=终点地面高程-终点埋深</li>
</ul>
<h2>2.点表</h2>
<ul>
    <li>地面高程</li>
</ul>
<h1>问题</h1>
<font style="color: #9c27b0">
<ul>
    <li>埋设方式与管类型的关系 断面类型(0为圆管,1为方管) lsdjnvoihjf890234865</li>
    if (tGxAnaInfo.DType == "直埋")<br>
    tGxAnaInfo.DmType = 0;<br>
    else<br>
    tGxAnaInfo.DmType = 1;<br>
    <li>方管与圆管管径存储方式的区别是什么 dkhnd9762650shctri</li>
    <li>横剖面分析，计算长度时没有考虑高程，因此后续的高程插值计算与实际高程误差很大 sdkhfxvhujf92374682394hxid</li>
    <li>对硬材料管的高程进行插值计算得出的结果与实际高程基本没有误差，但软材料插值出来的结果是存在一定误差的（随地面高程的改变而改变）（待商榷） 求管线某点高程</li>
    <li>求管径的算法不一致，冗余  jxhfleinxv89236xhchd 与 jvjuhx[];.'1283 </li>
    <li>判断管网是否为排水的方法不一致，并且通过编码常量来定义，不支持后期改动 klnfhfkjebr824649123 与 sjdfhioxhgdksdjfh</li>
    <li>枚举类型是否应该确定到具体类型，else之后是有很多类型的 sdhfhxfdj2384675239hxdfg</li>
    <li>横剖面与纵剖面图纸间距的问题 求的应该是管线在xy平面投影的长度</li>
</ul>
</font>
<h1>一、决策分析算法</h1>
<h3>菜单按钮处理的公共流程</h3>
<li>1.点击菜单,所有菜单点击事件共用一个处理器,switch通过item.name分发处理 lshbxkhgh8763912hdsl</li>
<li>2.修改鼠标样式</li>
<li>3.MapCtrlMain.CurrentTool = null; arcmap特有工具对象设置为空</li>
<li>4.ksdofoxhhg0237497 记录当前地图工作状态</li><br>
<li>5.鼠标左键按下的事件处理程序(Down) FBMouseDown,FBMouseMove,FBEnd三个函数完成鼠标跟踪效果 lsekjfhfvoer923874923</li>
<li>6.dknfgikr9716349734 鼠标移动时的处理代码 AppComFun.FBMouseMove</li>
<li>7.鼠标按键释放的处理程序(Up) FBEnd xlkjvhfklhasdfh9123797532</li>
<h3>UPGIS类库的调用方式</h3>
Program.UPGISFacade.LSGOMenuAnalysis.SelectPipeLine(pEnv, _mapCtrl); skjhvhofr02374hdfbqiodbxlz<br>
public static UPGISSystemFacade UPGISFacade; 单例集合管理实例对象调用 jxnfj388jbzhwi<br>
<h3>GISMAP相关的操作接口</h3>
<h4>1.地图对象的搜索方法</h4>
<ul>
    <li><font style="color: red">横剖面分析</font></li>
    <li><img src="../../images/20.png"/></li>
    <li><img src="../../images/21.png"/></li>
    <li>操作逻辑：点击菜单栏功能之后，使用鼠标在地图上拖拽，会显示辅助线，放开鼠标，显示辅助线与管线交点的横剖面图</li>
    <li>ksdofoxhhg0237497 剖面分析菜单按下的事件处理代码</li>
    <li>fml,bkg98618237 鼠标左键按下的处理代码</li>
    <li>skncjfjsie86293 鼠标移动时的处理代码</li>
    <li>sjdlfjaoxxue 鼠标左键释放的处理代码</li><br>
    <li><h5>横剖面分析算法 dkjfkbxihfd98346</h5></li>
    <ul>
        <font style="color: green">
        <li>1.需要数据库对象（用于获取要素属性数据）、地图对象、临时图形对象</li>
        <font style="color: #84613d"><li>2.通过地图对象与临时图形求出与临时图形相交的要素（通过arcgis接口实现） ISpatialFilter空间数据查询对象</li>
            ISpatialFilter pSFilter = new SpatialFilterClass();<br>
            pSFilter.Geometry = pGeometry;<br>
            pSFilter.WhereClause = whereClause;<br>
            IFeatureCursor pFCursor = pLyr.FeatureClass.Search(pQuerFilter, false);<br>
            IFeature pfeature = pFCursor.NextFeature();<br>
        </font>
        <li>3.求出临时线段的起点与终点</li>
            <font style="color: #84613d"><li>4.求出临时线段与要素相交的点（使用ArcGisMap接口进行计算的）</li>
            IPolyline pLine = pFeature.Shape as IPolyline;<br>
            ITopologicalOperator pTopo = pPolyline as ITopologicalOperator;<br>
            IGeometry pGeo = pTopo.Intersect(pLine as IGeometry, esriGeometryDimension.esriGeometry0Dimension);<br>
            IPoint pPoint = (pGeo as IPointCollection).get_Point(0);<br>
            </font>
            <li>5.起点地面高程=管线起点管顶高程+起点埋深</li>
            <li>6.终点地面高程=管线终点管顶高程+终点埋深</li>
            如果埋设方式为直埋，则断面类型为圆管，否则为方管。<br>
            圆管直径=圆管垂直管径*0.001<br>
            方管管径去字段值的第一个数字值*0.001<br>
            <li>求管径的方法</li>
            if (LSGOGisComFun.IsDoubleNumeric(tGxAnaInfo.Ds) == true)<br>
            {<br>
            tGxAnaInfo.Ds1 = double.Parse(tGxAnaInfo.Ds);<br>
            sngDs = tGxAnaInfo.Ds1 * 0.001;<br>
            }<br>
            else<br>
            {<br>
            //dkhnd9762650shctri<br>
            tGxAnaInfo.Ds2 = double.Parse(GetSquPipeDia(tGxAnaInfo.Ds));<br>
            sngDs = tGxAnaInfo.Ds2 * 0.001;<br>
            }<br>
            <h5>排水: xkbkfhiughdf9871265h</h5>
            <font style="color: #9c27b0">
            <li>管线起点管底高程=起点管顶高程（起点高程）</li>
            <li>管线终点管底高程=终点管顶高程（终点高程）</li>
            <li>管线起点管顶高程=管线起点管底高程+直径</li>
            <li>管线终点管顶高程=管线终点管底高程+直径</li>
                tGxAnaInfo.BtmH1 = tGxAnaInfo.TopH1;<br>
                tGxAnaInfo.BtmH2 = tGxAnaInfo.BtmH1 + sngDs;<br>
                tGxAnaInfo.BtmH2 = tGxAnaInfo.TopH2;<br>
                tGxAnaInfo.TopH2 = tGxAnaInfo.BtmH2 + sngDs;<br>
                <br>
                //tGxAnaInfo.BtmH1 = tGxAnaInfo.TopH1;<br>
                //tGxAnaInfo.BtmH2 = tGxAnaInfo.TopH2;<br>
                //tGxAnaInfo.TopH1 = tGxAnaInfo.BtmH1 + sngDs;<br>
                //tGxAnaInfo.TopH2 = tGxAnaInfo.BtmH2 + sngDs;<br>
            </font>
            <h5>非排水：</h5>
            <li>7.管线起点管底高程=管线起点管顶高程-直径</li>
            <li>8.管线终点管底高程=管线终点管顶高程-直径</li><br>
            <li>9.管线起点中心高程=(管线起点管顶高程+管线起点管底高程)/2</li>
            <li>10.管线终点中心高程=(管线终点管顶高程+管线终点管底高程)/2</li>


            格式说明：<br>

            ***横断面分析：***<br>

            城市名称，分析类型<br>
            断面线起点坐标<br>
            断面线终点坐标<br>
            管线代码，管线颜色(RGB)，地面高程，中心高程，管径，离起点距离，所在道路<br>


            ***正断面分析：***<br>

            城市名称，分析类型<br>
            X，Y，管线代码，地面高程，中心高程，管径，所在道路<br>


            <li>11.起点到交点的距离</li>
            CrsToP1 = Math.Sqrt(Math.Pow(tGxAnaInfo.CrsX - dX1, 2) + Math.Pow(tGxAnaInfo.CrsY - dY1, 2));
            <li>12.两个交点之间的距离</li>
            P1ToP2 = Math.Sqrt(Math.Pow(dX1 - dX2, 2) + Math.Pow(dY1 - dY2, 2));
            <li>13.管线断点处中心高程 根据距离比插值计算得出</li>
            tGxAnaInfo.CrsCenH = (tGxAnaInfo.CenH2 - tGxAnaInfo.CenH1) * CrsToP1 / P1ToP2 + tGxAnaInfo.CenH1;
            <li>14.断点处管顶高程=断点中心点高程+半径</li>
            tGxAnaInfo.CrsTopH = tGxAnaInfo.CrsCenH + sngDs * 0.5;
            <li>15.断点处管底高程=断点中心点高程-半径</li>
            tGxAnaInfo.CrsBtmH = tGxAnaInfo.CrsCenH - sngDs * 0.5;
            <li>16.管线断点处地面高程 根据距离比插值计算得出</li>
            tGxAnaInfo.CrsSurfH = (tGxAnaInfo.SurfH2 - tGxAnaInfo.SurfH1) * CrsToP1 / P1ToP2 + tGxAnaInfo.SurfH1;
            <li>17.管线断点处中心埋深=管线断点处地面高程-管线断点处中心高程</li>
            tGxAnaInfo.CrsCenDeep = tGxAnaInfo.CrsSurfH - tGxAnaInfo.CrsCenH;
            <li>18.管线断点处管顶埋深=管线断点处地面高程-管线断点处管顶高程</li>
            tGxAnaInfo.CrsTopDeep = tGxAnaInfo.CrsSurfH - tGxAnaInfo.CrsTopH;
            <li>19.管线断点处管底埋深=管线断点处地面高程-管线断点处管底高程</li>
            tGxAnaInfo.CrsBtmDeep = tGxAnaInfo.CrsSurfH - tGxAnaInfo.CrsBtmH;
            <li>20.管线断点至拉线起点的距离</li>
            tGxAnaInfo.CrsToStart = Math.Sqrt(Math.Pow(tGxAnaInfo.CrsX - pStart.X, 2) + Math.Pow(tGxAnaInfo.CrsY - pStart.Y, 2));
            <li>21.写入Cross.txt文件，使用DMFX.exe进行横剖面分析</li>
            写入每个交点的内容：<br>
            管线类型代码（小类）、管线类型名称（小类）、要素颜色、管线断点处地面高程、管线断点处中心高程、管径（取自字段值）、管线断点至拉线起点的距离、道路名称<br>
        </font>
    </ul>
    <li><font style="color: red">纵剖面分析</font></li>
    <li><img src="../../images/22.png"/></li>
    <li><img src="../../images/23.png"/></li>
    <li>鼠标点击按下事件 选择地图要素（要求是连续的管线） jfnhxxjuenh873424hxid</li>
    pEnv = _mapCtrl.TrackRectangle(); 等待式鼠标拖动画矩形框选<br>
    Program.UPGISFacade.LSGOMenuAnalysis.SelectPipeLine(pEnv, _mapCtrl); 根据框选结果选择管线<br>
    <li>鼠标点击右键释放事件 进行纵剖面分析 jhdnfhe09734hxcbve9023</li>
    <h5>纵剖面算法分析</h5>
    <ul>
        <li>1.通过统计所选管线点号单点数量来确定所选管线是否连续（如果是连续管线的话，有且只有两个单点） djgcyhfudfj86234681hchn</li>
        <li>2.统计相同点号重复的最大数量，最大数量不能大于2，因为无法处理三通以及多通管线</li>
        <font style="color: #9c27b0">
        <li>3.判断是否属于排水管道，分别进行计算处理(计算管线中心高程)</li>
        通过代码字符常量 /YS/WS/HS/ 判断是否是排水 sjdfhioxhgdksdjfh<br>
        if ("/YS/WS/HS/".IndexOf(arVertPipePnt[i].SubTypeCode) != -1)<br>
        </font>
        <font style="color: #9c27b0">
        <li>4.求管径</li>
        if (LSGOGisComFun.IsDoubleNumeric(arVertPipePnt[i].Ds))<br>
        sngDs = Convert.ToDouble(arVertPipePnt[i].Ds) * 0.001;<br>
        else<br>
        sngDs = Convert.ToDouble(GetSquPipeDia(arVertPipePnt[i].Ds)) * 0.001;<br>
        </font>
        <li>5.处理流程</li>
        依次获取管线节点，记录相关信息，形成数组<br>
        截面点数量=选择管段数量+1<br>

    </ul>
    <li><font style="color: red">火灾抢险分析</font></li>
    <ul>
        <li>菜单栏点击事件 jbfbvuhf87237y4gd73</li>
        <li>鼠标左键点击事件 sldjfasbnxoheori</li>
    </ul>
    <font style="color: blue">Label: sldjfasbnxoheori</font><br>
    1.找出所有满足条件的点（消防栓、搜索半径）<br>
    ISpatialFilter pSFilter = new SpatialFilterClass();<br>
    pSFilter.Geometry = Geometry;<br>
    pSFilter.SpatialRel = SpatialRelEnum;<br>
    string whereClause = "[附属物] = '消防栓'";<br>
    pSFilter.WhereClause = whereClause;<br>
    pSFilter.GeometryField = FeatureLayer.FeatureClass.ShapeFieldName;<br>
    pSFilter.SubFields = "*";<br>
    IFeatureCursor pFCursor = FeatureLayer.FeatureClass.Search(pSFilter, false);<br><br>
    2.求出每个点到事故点的最短距离<br>
    IProximityOperator pProximity = (IProximityOperator)pGeometry;<br>
    //Returns the minimum distance between two geometries.<br>
    double distance = pProximity.ReturnDistance(pGeometry2);<br><br>
    <li><font style="color: red">爆管关阀分析</font></li>
    <font style="color: blue">Label: jjhwich89erhx;'x</font><br>
    1.找到事故点所在管段的相关信息<br>
    2.找到管段相关管线所在图层，找到相关管点所在图层<br>
    3.找到事故点所在管段的起始点号与终止点号<br>
    4.从事故点管段开始向两边遍历寻找最近的阀门和通往阀门的管段<br>
    注：仅仅在给水、热力、燃气图层上进行搜索阀门井、阀门,进行爆管分析<br><br>





    <li><font style="color: red">垂直净距分析</font></li>
    <font style="color: blue">Label: xnxbgdjfh812387rvxqyh MouseDown事件</font><br>
    private void MapCtrlMain_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)<br>
    pPolygon = _mapCtrl.TrackPolygon(); 阻塞式绘制临时图形，绘制完成再进行后续处理<br>
    Program.UPGISFacade.LSGOMenuAnalysis.PopAnalyseVerDis(_mapCtrl, pPolygon as IGeometry, ref axGrid, 1);<br>
    <font style="color: blue">Label: m,.9jsgtcz4</font><br>
    /// <param name="AnalysisType">分析类型,0为覆土深度分析,1为垂直净距分析</param><br>
    public void PopAnalyseVerDis(MapControl mapControl, IGeometry pPolyline, ref  Grid aGrid, short AnalysisType)<br>
    <font style="color: blue">Label: ddnxbcfi0986w2jdk</font><br>
    pFeaArr = PlineEntGet(mapControl, pPolyline);//获得框选到的所有管线<br>
    计算所选管线基本参数<br>
    arrGxAnaInfo = GetFeaturesVal(pFeaArr, false, pPolyline as IPolyline);<br>

    1.QDMS（起点埋深） Deep1（起点埋深）<br>
    2.ZDMS（终点埋深） Deep2（终点埋深）<br>
    3.QDGC（起点高程） TopH1（管线起点管顶高程）<br>
    4.ZDGC（终点高程） TopH2（管线终点管顶高程）<br>
    5.SurfH1（起点地面高程）=Deep1+TopH1<br>
    6.SurfH2（终点地面高程）=Deep2+TopH2<br>
    给水<br>
    7.BtmH1（管线起点管底高程）=TopH1-sngDs（直径)<br>
    8.BtmH2（管线终点管底高程）=TopH2-sngDs<br><br>
    设置垂直净距分析 uiddjfoier2394896gdf023<br>
    SetGridB(mapControl, pFeaArr, arrGxAnaInfo, pPolyline, ref aGrid)<br>
    遍历所选管线，依次求出管线与其他所有管线的所有交点<br>
    查询前置条件：不同小类管线（燃气类管线可以在本类型中进行分析）<br>
    <font style="color: #9c27b0">交点不能在第一条线的两个端点 kxnfejncm,wl2984<br></font>
    (pPntColl.get_Point(0).X != pLine1.FromPoint.X && pPntColl.get_Point(0).X != pLine1.ToPoint.X)<br>
    DataGrid表格初始化 一个交点一行<br>
    计算相关属性<br>
    GetCrossFeaVal(arrGxAnaInfoList[i], pLine1, pPntColl.get_Point(0), false, null); dhcjdjsdf82349hsdgf<br>
    <font style="color: green">
    净垂距=管线断点处管顶埋深-管线断点处管底埋深  小于规范值时，提示不规范<br>
    </font>





    <li><font style="color: red">水平净距分析</font></li>
    <ul>
        <li>dkfjnvifhiok 水平净距菜单栏点击事件</li>
        单例设置窗口（全局变量）<br>
        单例选择集对象（全局变量）<br>
        <li>fhfnxmfhihsql;;.9384 MouseDown事件</li>
        <li>nxcvbfhj39848sdfh383hgkx MouseMove事件</li>
        <li>dfnvbfh2347802hjsdhfei MouseUp事件</li>
        根据临时图元进行管线选择<br>
        根据所选图元进行水平净距分析,记录当前选择的管线，放到全局数组<br>
        第二次选择的管线要与第一次的一些属性一致，包括大类、小类、管径、埋设方式、管线压力<br>
        <font style="color: #9c27b0">
        <li>求两个几何对象的最小距离</li>
        double shortestDistance = (pPolyLine1 as IProximityOperator).ReturnDistance(pPolyLine2 as IGeometry);<br>
        </font>
        相交管线不能进行水平净距分析(最小距离为0)<br>
        判断所选管线是否满足进行水平净距分析的条件<br>
        int temp = ISGoodLines(pFeatureList); kdfkxnvk234987gq<br>
        <li>fjcnvhnohf293480hsdhrf 右键点击事件</li>
        弹出水平净距设置对话框<br>
        分两次选择<br>
        第二次选择之后点击确定按钮，会求两次选择的几何对象之间的最短距离<br>
        从数据库中获取标准值<br>
        HSTANDARD xnvljfgoj234078<br>
        计算值标准值时，水平净距不符合规范 dkhcn1203874<br>

    </ul>
    <font style="color: blue">Label: xkdhfahsoer34nbvb  水平净距分析对话框</font><br>





    <li><font style="color: red">空间三维</font></li>
    <font style="color: blue">Label: ksdhixufie934979669-khg 开始</font><br>
    <font style="color: blue">Label: sdhfihxiuyre1029965569 所选数据存入3ds文件中的代码</font><br>
    如果所选管线存在起始点坐标与终点坐标重合的话，三维分析界面功能不可用<br>
    /* X1,Y1,Z1,X2,Y2,Z2,Color,管径,管线代码,起点点号,终点点号,管径,材质,起点高程,终点高程,起点埋深,终点埋深,年代,权属单位,备注*/<br>
</ul>
<h1>二、其他相关算法</h1>
<ul>
    <li><font style="color: red">管线数据入库流程，用从点线表里取到的x,y值生成arcmap中的几何对象</font></li>
    <font style="color: blue">Label: a;ldkfjklasnd</font><br>
    pLine = new PolylineClass();<br>
    pSPt = new PointClass();<br>
    pEPt = new PointClass();<br>
    pSPt.PutCoords(Convert.ToDouble(dr["b." + LSGOGisPubVar.X]), Convert.ToDouble(dr["b." + LSGOGisPubVar.Y]));<br>
    pEPt.PutCoords(Convert.ToDouble(dr["c." + LSGOGisPubVar.X]), Convert.ToDouble(dr["c." + LSGOGisPubVar.Y]));<br>
    object obj = Type.Missing;<br>
    pLine.AddPoint(pSPt, ref obj, ref obj);<br>
    pLine.AddPoint(pEPt, ref obj, ref obj);<br><br>
    <li><font style="color: red">管线长度计算,全库管线长度统计</font></li>
    select A.材质 as F1,Sum(sqr((A.起点高程-A.终点高程)*(A.起点高程-A.终点高程)+(B.Y-C.Y)*(B.Y-C.Y)+(B.X-C.X)*(B.X-C.X))) AS F2 from (CSL as A inner join CSP as B on A.起始点号=B.物探点号)
    inner join CSP as C on A.终止点号=C.物探点号 Group BY A.材质<br>
    据猜测，z=点高程-埋深<br>
    验证map成图的几何数据
</ul>
</body>
</html>