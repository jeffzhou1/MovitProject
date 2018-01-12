    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：系统数据-人员
      /// </summary>
      public class Sys_User
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 用户ID，对应的应该是唯一值，例如域账号
			/// </summary>
			public String UserID {get;set;}   
			 
                 
			/// <summary>
			/// 用户密码（弃用）
			/// </summary>
			public String UserPwd {get;set;}   
			 
                 
			/// <summary>
			/// 用户姓名
			/// </summary>
			public String Name {get;set;}   
			 
                 
			/// <summary>
			/// 性别，0表示未定义，1表示男性，2表示女性
			/// </summary>
			public Int32 Gender {get;set;}   
			 
                 
			/// <summary>
			/// 联系电话
			/// </summary>
			public String Phone {get;set;}   
			 
                 
			/// <summary>
			/// 邮箱地址
			/// </summary>
			public String Email {get;set;}   
			 
                 
			/// <summary>
			/// 组织架构ID
			/// </summary>
			public String OrgID {get;set;}   
			 
                 
			/// <summary>
			/// 组织架构
			/// </summary>
			public String OrgName {get;set;}   
			 
                 
			/// <summary>
			/// 部门ID
			/// </summary>
			public String DepartmentId {get;set;}   
			 
                 
			/// <summary>
			/// 部门名称
			/// </summary>
			public String DepartmentName {get;set;}   
			 
                 
			/// <summary>
			/// 职位ID
			/// </summary>
			public String PositionID {get;set;}   
			 
                 
			/// <summary>
			/// 职位
			/// </summary>
			public String PositionName {get;set;}   
			 
                 
			/// <summary>
			/// 头像信息
			/// </summary>
			public String Avatar {get;set;}   
			 
                 
			/// <summary>
			/// 证件类型：10301：身份证，10302：护照，10303：驾驶证，10304：其它

			/// </summary>
			public String IdCard {get;set;}   
			 
                 
			/// <summary>
			/// 证件号码
			/// </summary>
			public String IdCardNo {get;set;}   
			 
                 
			/// <summary>
			/// 开户银行
			/// </summary>
			public String BankType {get;set;}   
			 
                 
			/// <summary>
			/// 银行卡号
			/// </summary>
			public String BankNo {get;set;}   
			 
                 
			/// <summary>
			/// 真实姓名
			/// </summary>
			public String RealName {get;set;}   
			 
                 
			/// <summary>
			/// 联系地址
			/// </summary>
			public String Address {get;set;}   
			 
                 
			/// <summary>
			/// 员工状态 0：试用1：正式2：临时3：试用延期4：解聘5：离职6：退休7：无效
			/// </summary>
			public String UserStatus {get;set;}   
			 
                 
			/// <summary>
			/// 员工类型
			/// </summary>
			public String UserType {get;set;}   
			 
                 
			/// <summary>
			/// 员工编码
			/// </summary>
			public String UserCode {get;set;}   
			 
                 
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

	