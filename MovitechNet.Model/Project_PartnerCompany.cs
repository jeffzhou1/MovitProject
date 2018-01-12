    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：项目数据-合伙企业
      /// </summary>
      public class Project_PartnerCompany
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 项目ID
			/// </summary>
			public Guid ProjectID {get;set;}   
			 
                 
			/// <summary>
			/// 企业名称
			/// </summary>
			public String CompanyName {get;set;}   
			 
                 
			/// <summary>
			/// 营业执照号
			/// </summary>
			public String LicenseNo {get;set;}   
			 
                 
			/// <summary>
			/// 负责人
			/// </summary>
			public String PersonLiable {get;set;}   
			 
                 
			/// <summary>
			/// 联系电话
			/// </summary>
			public String ContractPhone {get;set;}   
			 
                 
			/// <summary>
			/// 联系地址
			/// </summary>
			public String ContractAddress {get;set;}   
			 
                 
			/// <summary>
			/// 传真号码
			/// </summary>
			public String FaxNo {get;set;}   
			 
                 
			/// <summary>
			/// 电子邮箱
			/// </summary>
			public String Email {get;set;}   
			 
                 
			/// <summary>
			/// 开户行
			/// </summary>
			public String BankName {get;set;}   
			 
                 
			/// <summary>
			/// 账户名称
			/// </summary>
			public String BankCardName {get;set;}   
			 
                 
			/// <summary>
			/// 银行卡号
			/// </summary>
			public String BankCardNo {get;set;}   
			 
                 
			/// <summary>
			/// 备注
			/// </summary>
			public String Remarks {get;set;}   
			 
                 
			/// <summary>
			/// 跟投平台签字/章图片（二进制）
			/// </summary>
			public String CompanyPic {get;set;}   
			 
                 
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
			public String Editot {get;set;}   
			 
                 
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
			 
                 
			/// <summary>
			/// 代持人
			/// </summary>
			public String Bearer {get;set;}   
			 
                 
			/// <summary>
			/// 代持人开户行
			/// </summary>
			public String BearerBankName {get;set;}   
			 
                 
			/// <summary>
			/// 代持人银行账户名称
			/// </summary>
			public String BearerBankCardName {get;set;}   
			 
                 
			/// <summary>
			/// 代持人银行卡号
			/// </summary>
			public String BearerBankCardNo {get;set;}   
			 
                 
			/// <summary>
			/// 代持人身份证号码
			/// </summary>
			public String BearerIdCardNo {get;set;}   
			 
                 
			/// <summary>
			/// 跟投平台持股公司
			/// </summary>
			public String BearerCompany {get;set;}   
			 
                 
			/// <summary>
			/// 跟投平台公司持股比例
			/// </summary>
			public Nullable<Decimal> BearerRatio {get;set;}
			 
                 
			/// <summary>
			/// 代持人签字/章图片（二进制）
			/// </summary>
			public String BearerPic {get;set;}   
			 
       
    }    
}

	