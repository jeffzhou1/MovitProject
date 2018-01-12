    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-签约信息
      /// </summary>
      public class Invest_Sign
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
			/// 合同标题
			/// </summary>
			public String Title {get;set;}   
			 
                 
			/// <summary>
			/// 甲方信息：签字或电子章
			/// </summary>
			public String FirstParty {get;set;}   
			 
                 
			/// <summary>
			/// 乙方信息：签字或电子章
			/// </summary>
			public String SecondParty {get;set;}   
			 
                 
			/// <summary>
			/// 丙方信息
			/// </summary>
			public String ThirdParty {get;set;}   
			 
                 
			/// <summary>
			/// 签约时间
			/// </summary>
			public Nullable<DateTime> SignTime {get;set;}
			 
                 
			/// <summary>
			/// 签约平台，0：未定义，1：微信端，2：PC端
			/// </summary>
			public Int32 SignType {get;set;}   
			 
                 
			/// <summary>
			/// 协议模板ID：关联基础数据-协议模板
			/// </summary>
			public Guid TempletID {get;set;}   
			 
                 
			/// <summary>
			/// 备注
			/// </summary>
			public String Remarks {get;set;}   
			 
                 
			/// <summary>
			/// 是否生成合同文档pdf
			/// </summary>
			public Boolean HasFile {get;set;}   
			 
                 
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
			/// 数据是否有效
			/// </summary>
			public Boolean Enabled {get;set;}   
			 
       
    }    
}

	