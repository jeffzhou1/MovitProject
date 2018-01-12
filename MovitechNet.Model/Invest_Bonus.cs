    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-返本分红
      /// </summary>
      public class Invest_Bonus
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 用户ID
			/// </summary>
			public String UserID {get;set;}   
			 
                 
			/// <summary>
			/// 项目ID
			/// </summary>
			public Guid ProjectID {get;set;}   
			 
                 
			/// <summary>
			/// 本次应分配金额
			/// </summary>
			public Nullable<Decimal> InterestPayment {get;set;}
			 
                 
			/// <summary>
			/// 本次实际应付金额（实际到账金额）
			/// </summary>
			public Nullable<Decimal> InterestRealPayment {get;set;}
			 
                 
			/// <summary>
			/// 额度中债权金额/上次分配后债权余额【弃用】
			/// </summary>
			public Nullable<Decimal> DebtMoney_DebtBalance {get;set;}
			 
                 
			/// <summary>
			/// 杠杆金额/上次分配后杠杆余额【弃用】
			/// </summary>
			public Nullable<Decimal> LeverMoney_LeverBalance {get;set;}
			 
                 
			/// <summary>
			/// 返本金额【弃用】
			/// </summary>
			public Nullable<Decimal> CorpusReturn {get;set;}
			 
                 
			/// <summary>
			/// 本次归还杠杆金额【弃用】
			/// </summary>
			public Nullable<Decimal> LeverReturn {get;set;}
			 
                 
			/// <summary>
			/// 本次返还债权金额【弃用】
			/// </summary>
			public Nullable<Decimal> DebtReturn {get;set;}
			 
                 
			/// <summary>
			/// 本次返还股权金额【弃用】
			/// </summary>
			public Nullable<Decimal> StockReturn {get;set;}
			 
                 
			/// <summary>
			/// 债权余额【弃用】
			/// </summary>
			public Nullable<Decimal> DebtBalance {get;set;}
			 
                 
			/// <summary>
			/// 配资余额
			/// </summary>
			public Nullable<Decimal> LeverBalance {get;set;}
			 
                 
			/// <summary>
			/// 股权余额【弃用】
			/// </summary>
			public Nullable<Decimal> StockBalance {get;set;}
			 
                 
			/// <summary>
			/// 额度中股金额【弃用】
			/// </summary>
			public Nullable<Decimal> StockMoney {get;set;}
			 
                 
			/// <summary>
			/// 本次扣除配资金额
			/// </summary>
			public Nullable<Decimal> AllotMoney {get;set;}
			 
                 
			/// <summary>
			/// 配资累计结息
			/// </summary>
			public Nullable<Decimal> LeverInterest {get;set;}
			 
                 
			/// <summary>
			/// 本次扣除配资利息金额
			/// </summary>
			public Nullable<Decimal> LeverDelInterest {get;set;}
			 
                 
			/// <summary>
			/// 个人所得税
			/// </summary>
			public Nullable<Decimal> PersonalIncomeTax {get;set;}
			 
                 
			/// <summary>
			/// 管理费
			/// </summary>
			public Nullable<Decimal> ManageFee {get;set;}
			 
                 
			/// <summary>
			/// 累计分配（实际到账）
			/// </summary>
			public Nullable<Decimal> ActualIncome {get;set;}
			 
                 
			/// <summary>
			/// 累计自有资金投入
			/// </summary>
			public Nullable<Decimal> ActualPayment {get;set;}
			 
                 
			/// <summary>
			/// 累计收益
			/// </summary>
			public Nullable<Decimal> IncomeAmount {get;set;}
			 
                 
			/// <summary>
			/// 备注
			/// </summary>
			public String Remarks {get;set;}   
			 
                 
			/// <summary>
			/// 本次返本分红批次，同项目同用户：数字累加
			/// </summary>
			public Int32 BatchNo {get;set;}   
			 
                 
			/// <summary>
			/// 本次返本分红日期
			/// </summary>
			public Nullable<DateTime> ReturnTime {get;set;}
			 
                 
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
			/// 数据来源，0：未定义，1：导入
			/// </summary>
			public Int32 DataSource {get;set;}   
			 
                 
			/// <summary>
			/// 审核状态，0：未审核，1：审核中，2：审核通过，3：审核不通过
			/// </summary>
			public Int32 AuditState {get;set;}   
			 
                 
			/// <summary>
			/// 审核意见
			/// </summary>
			public String AuditDesc {get;set;}   
			 
                 
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
			 
       
    }    
}

	