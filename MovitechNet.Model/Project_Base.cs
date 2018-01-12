    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：项目数据-基本信息
      /// </summary>
      public class Project_Base
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 项目名称
			/// </summary>
			public String Name {get;set;}   
			 
                 
			/// <summary>
			/// 项目编号
			/// </summary>
			public String No {get;set;}   
			 
                 
			/// <summary>
			/// 项目地址
			/// </summary>
			public String Address {get;set;}   
			 
                 
			/// <summary>
			/// 建筑类型
			/// </summary>
			public String BuildType {get;set;}   
			 
                 
			/// <summary>
			/// 用地面积
			/// </summary>
			public String LandAcreage {get;set;}   
			 
                 
			/// <summary>
			/// 土地获取方式
			/// </summary>
			public String ObtainType {get;set;}   
			 
                 
			/// <summary>
			/// 计容面积
			/// </summary>
			public Nullable<Decimal> VolumeArea {get;set;}
			 
                 
			/// <summary>
			/// 总建筑面积
			/// </summary>
			public Nullable<Decimal> BuildArea {get;set;}
			 
                 
			/// <summary>
			/// 容积率
			/// </summary>
			public Nullable<Decimal> PlotRatio {get;set;}
			 
                 
			/// <summary>
			/// 土地总价
			/// </summary>
			public Nullable<Decimal> LandPrice {get;set;}
			 
                 
			/// <summary>
			/// 楼板价
			/// </summary>
			public Nullable<Decimal> FloorPrice {get;set;}
			 
                 
			/// <summary>
			/// 项目总投资
			/// </summary>
			public String InvestAmount {get;set;}   
			 
                 
			/// <summary>
			/// 项目总货值
			/// </summary>
			public String CargoValue {get;set;}   
			 
                 
			/// <summary>
			/// 开盘时间
			/// </summary>
			public Nullable<DateTime> OpenTime {get;set;}
			 
                 
			/// <summary>
			/// 建筑限高
			/// </summary>
			public String HighLimit {get;set;}   
			 
                 
			/// <summary>
			/// 项目概况
			/// </summary>
			public String Survey {get;set;}   
			 
                 
			/// <summary>
			/// 项目资金峰值
			/// </summary>
			public Nullable<Decimal> PeakCapital {get;set;}
			 
                 
			/// <summary>
			/// 创建人
			/// </summary>
			public String Creator {get;set;}   
			 
                 
			/// <summary>
			/// 创建时间
			/// </summary>
			public Nullable<DateTime> CreateTime {get;set;}
			 
                 
			/// <summary>
			/// 修改人
			/// </summary>
			public String Editor {get;set;}   
			 
                 
			/// <summary>
			/// 修改时间
			/// </summary>
			public Nullable<DateTime> EditTime {get;set;}
			 
                 
			/// <summary>
			/// 审核状态，0：未审核，1：审核中，2：审核通过，3：审核不通过
			/// </summary>
			public Int32 AuditState {get;set;}   
			 
                 
			/// <summary>
			/// 审核意见
			/// </summary>
			public String AuditDesc {get;set;}   
			 
                 
			/// <summary>
			/// 发布状态，0：未发布，1：已发布
			/// </summary>
			public Int32 PublishState {get;set;}   
			 
                 
			/// <summary>
			/// 发布时间
			/// </summary>
			public Nullable<DateTime> PublishTime {get;set;}
			 
                 
			/// <summary>
			/// 备用字段1
			/// </summary>
			public String F1 {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段2
			/// </summary>
			public String F2 {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段3
			/// </summary>
			public String F3 {get;set;}   
			 
                 
			/// <summary>
			/// 数据是否有效
			/// </summary>
			public Boolean Enabled {get;set;}   
			 
                 
			/// <summary>
			/// 是否项目预热
			/// </summary>
			public Boolean PreState {get;set;}   
			 
                 
			/// <summary>
			/// 预计开盘时间
			/// </summary>
			public Nullable<DateTime> ExpectOpenTime {get;set;}
			 
                 
			/// <summary>
			/// 方案宣讲时间
			/// </summary>
			public Nullable<DateTime> ProgramPreachTime {get;set;}
			 
                 
			/// <summary>
			/// 公司投资额（弃用）
			/// </summary>
			public Nullable<Decimal> DyInvestAmount {get;set;}
			 
                 
			/// <summary>
			/// 跟投总额
			/// </summary>
			public Nullable<Decimal> FlowInvestAmount {get;set;}
			 
                 
			/// <summary>
			/// 现金流回正(预计首次返本)
			/// </summary>
			public Nullable<DateTime> CashFlowBack {get;set;}
			 
                 
			/// <summary>
			/// 股权退出(预计首次分红)
			/// </summary>
			public Nullable<DateTime> StockRightQuit {get;set;}
			 
                 
			/// <summary>
			/// 强制跟投总比例
			/// </summary>
			public Nullable<Decimal> InvestmentRatio1 {get;set;}
			 
                 
			/// <summary>
			/// 自愿跟投总比例
			/// </summary>
			public Nullable<Decimal> InvestmentRatio2 {get;set;}
			 
                 
			/// <summary>
			/// 优先跟投总比例
			/// </summary>
			public Nullable<Decimal> InvestmentRatio3 {get;set;}
			 
                 
			/// <summary>
			/// 跟投平台持股比例
			/// </summary>
			public Nullable<Decimal> PlatformRatio {get;set;}
			 
                 
			/// <summary>
			/// 预计销售均价
			/// </summary>
			public Nullable<Decimal> ExpectSellingPrice {get;set;}
			 
       
    }    
}

	