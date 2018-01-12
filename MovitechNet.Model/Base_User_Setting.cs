    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-人员设置
      /// </summary>
      public class Base_User_Setting
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
			/// 用户密码（加密后）
			/// </summary>
			public String UserPwd {get;set;}   
			 
                 
			/// <summary>
			/// 跟投性质，0：未定义，1：强投，2：优先，3：自愿
			/// </summary>
			public Int32 InvestCategory {get;set;}   
			 
                 
			/// <summary>
			/// 强投比例，直接存储百分比数字不带单位，例如50，单位默认%
			/// </summary>
			public Int32 ForceRate {get;set;}   
			 
                 
			/// <summary>
			/// 强投范围，0：未定义，1：集团，2：区域公司
			/// </summary>
			public Int32 ForceRange {get;set;}   
			 
                 
			/// <summary>
			/// 杠杆倍数，0、1、2、3
			/// </summary>
			public Decimal LeverTimes {get;set;}   
			 
                 
			/// <summary>
			/// 跟投额度下限
			/// </summary>
			public Decimal MoneyLowerLimit {get;set;}   
			 
                 
			/// <summary>
			/// 跟投额度上限
			/// </summary>
			public Decimal MoneyUpperLimit {get;set;}   
			 
                 
			/// <summary>
			/// 证件类型
			/// </summary>
			public String IdCard {get;set;}   
			 
                 
			/// <summary>
			/// 证件号码
			/// </summary>
			public String IdCardNo {get;set;}   
			 
                 
			/// <summary>
			/// 联系地址
			/// </summary>
			public String Address {get;set;}   
			 
                 
			/// <summary>
			/// 开户银行
			/// </summary>
			public String BankType {get;set;}   
			 
                 
			/// <summary>
			/// 银行卡号码
			/// </summary>
			public String BankNo {get;set;}   
			 
                 
			/// <summary>
			/// 真实姓名
			/// </summary>
			public String RealName {get;set;}   
			 
                 
			/// <summary>
			/// 手机
			/// </summary>
			public String Phone {get;set;}   
			 
                 
			/// <summary>
			/// 邮箱
			/// </summary>
			public String Email {get;set;}   
			 
                 
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

	