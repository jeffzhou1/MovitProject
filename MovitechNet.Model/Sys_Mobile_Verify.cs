    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：系统数据-手机验证码信息
      /// </summary>
      public class Sys_Mobile_Verify
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 用户名
			/// </summary>
			public String UserID {get;set;}   
			 
                 
			/// <summary>
			/// 手机号码
			/// </summary>
			public String MobileNo {get;set;}   
			 
                 
			/// <summary>
			/// 验证码
			/// </summary>
			public String VerifyCode {get;set;}   
			 
                 
			/// <summary>
			/// 发送时间
			/// </summary>
			public Nullable<DateTime> Createtime {get;set;}
			 
                 
			/// <summary>
			/// 到期时间
			/// </summary>
			public Nullable<DateTime> Expiretime {get;set;}
			 
                 
			/// <summary>
			/// 校验时间
			/// </summary>
			public Nullable<DateTime> Verifytime {get;set;}
			 
                 
			/// <summary>
			/// 数据是否有效
			/// </summary>
			public Boolean Enabled {get;set;}   
			 
       
    }    
}

	