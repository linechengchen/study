/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:38
  Description:    ���ݱ�St_TQuestionJiuCuo��Ӧ��ҵ���߼���St_TQuestionJiuCuo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_TQuestionJiuCuo_Entity:St_TQuestionJiuCuo
 * 
************************************************************/
/************************************************************
SQL���룺
select AutoId,Answer,CreateTime,KemuId,OpenId,QuestionAutoId,QuestionId from St_TQuestionJiuCuo
delete from St_TQuestionJiuCuo
INSERT INTO St_TQuestionJiuCuo (AutoId,Answer,CreateTime,KemuId,OpenId,QuestionAutoId,QuestionId)
     VALUES
           ('','','','','','','')
UPDATE St_TQuestionJiuCuo SET ...
������ֵ���룺
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Answer = valObj2.Answer;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.KemuId = valObj2.KemuId;
        valObj.OpenId = valObj2.OpenId;
        valObj.QuestionAutoId = valObj2.QuestionAutoId;
        valObj.QuestionId = valObj2.QuestionId; 
        valObj.AutoId = "";
        valObj.Answer = "";
        valObj.CreateTime = "";
        valObj.KemuId = "";
        valObj.OpenId = "";
        valObj.QuestionAutoId = "";
        valObj.QuestionId = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Answer": $("#txt_Answer").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "KemuId": $("#txt_KemuId").val(),
        "OpenId": $("#txt_OpenId").val(),
        "QuestionAutoId": $("#txt_QuestionAutoId").val(),
        "QuestionId": $("#txt_QuestionId").val(), 
 * ************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// <para></para>
    /// <para>��St_TQuestionJiuCuo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_TQuestionJiuCuo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_TQuestionJiuCuo Factory()
        {
            return new St_TQuestionJiuCuo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Answer
        {            
            get { return this.Answer; }
            set { this.Answer = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _QuestionAutoId
        {            
            get { return this.QuestionAutoId; }
            set { this.QuestionAutoId = value; }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _QuestionId
        {            
            get { return this.QuestionId; }
            set { this.QuestionId = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Answer
        {
            get { return this.m_answer; }
            set //
            {
                if (!answer_initialized || m_answer != value)
                {
                    this.m_answer = value;
                }
                answer_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime CreateTime
        {
            get { return this.m_createtime; }
            set //
            {
                if (!createtime_initialized || m_createtime != value)
                {
                    this.m_createtime = value;
                }
                createtime_initialized = true;
            }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string OpenId
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int QuestionAutoId
        {
            get { return this.m_questionautoid; }
            set //
            {
                if (!questionautoid_initialized || m_questionautoid != value)
                {
                    this.m_questionautoid = value;
                }
                questionautoid_initialized = true;
            }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string QuestionId
        {
            get { return this.m_questionid; }
            set //
            {
                if (!questionid_initialized || m_questionid != value)
                {
                    this.m_questionid = value;
                }
                questionid_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[St_TQuestionJiuCuo].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer =  new AttributeItem("[St_TQuestionJiuCuo].[Answer]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_TQuestionJiuCuo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_TQuestionJiuCuo].[KemuId]", typeof(string), 50, default(string));
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[St_TQuestionJiuCuo].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionAutoId =  new AttributeItem("[St_TQuestionJiuCuo].[QuestionAutoId]", typeof(int), 4, default(int));
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionId =  new AttributeItem("[St_TQuestionJiuCuo].[QuestionId]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private string m_answer;
        /// <summary></summary>
        protected bool answer_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private int m_questionautoid;
        /// <summary></summary>
        protected bool questionautoid_initialized = false;
        
        private string m_questionid;
        /// <summary></summary>
        protected bool questionid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TQuestionJiuCuo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.answer_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.questionautoid_initialized = IsLoadAllAttributes;this.questionid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TQuestionJiuCuo value = new St_TQuestionJiuCuo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer"))
				value.answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionAutoId"))
				value.questionautoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionId"))
				value.questionid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_TQuestionJiuCuo Clone()
        {
            return (St_TQuestionJiuCuo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_TQuestionJiuCuo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_TQuestionJiuCuo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_TQuestionJiuCuo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_TQuestionJiuCuo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_TQuestionJiuCuo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_TQuestionJiuCuo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_TQuestionJiuCuo(int autoid1, string answer1, DateTime createtime1, string kemuid1, string openid1, int questionautoid1, string questionid1)
        {
            
            this.AutoId = autoid1;
            
            this.Answer = answer1;
            
            this.CreateTime = createtime1;
            
            this.KemuId = kemuid1;
            
            this.OpenId = openid1;
            
            this.QuestionAutoId = questionautoid1;
            
            this.QuestionId = questionid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_TQuestionJiuCuo FromIView(IView view)
        {
            return (St_TQuestionJiuCuo)IView.GetITable(view, "St_TQuestionJiuCuo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_TQuestionJiuCuo GetOneInstance()
        {
            St_TQuestionJiuCuo value = new St_TQuestionJiuCuo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_TQuestionJiuCuo Retrieve()
        {
            BLLTable<St_TQuestionJiuCuo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "Answer":
			        return Answer;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "QuestionAutoId":
			        return QuestionAutoId;
			    			
			    case "QuestionId":
			        return QuestionId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Answer":
			        this.Answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionAutoId":
			        this.QuestionAutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "QuestionId":
			        this.QuestionId = Convert.ToString(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>ͨ������ ��ȡ���ֶ��Ƿ��ѱ���ʼ��</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					return autoid_initialized;
				
				case "Answer":
					return answer_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "QuestionAutoId":
					return questionautoid_initialized;
				
				case "QuestionId":
					return questionid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "Answer":
					answer_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "QuestionAutoId":
					questionautoid_initialized = ret;
					return true;
				
				case "QuestionId":
					questionid_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region ��ȡDataParameter PropertyInfo

        /// <summary>
        /// ��ȡ���б���ʼ������ֵ����ȡAttributeItem
        /// Ŀ��Ϊ��ȡ System.Windows.Forms.DataGridViewTextBoxColumn[] ���м����ݲ������ �Զ���� MyDataGridViewTextBoxColumn (����̳��� DataGridViewTextBoxColumn)
        /// ������������α����ķ�������Ϊ�˱����װ���̣�ʹ��Դ����ģʽ��ʱ�򣬲���������windows.form.dll��
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (autoid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (answer_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.Answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (questionautoid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.QuestionAutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionAutoId);
                }
			}
			
			if (questionid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.QuestionId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionId);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json����
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        [Serializable]
        public class St_TQuestionJiuCuoJson
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>��:[CtrlTypeDic-{InputString}]</summary>
            public string Answer { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public string KemuId { get; set; }
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int QuestionAutoId { get; set; }
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public string QuestionId { get; set; }
        }
        #endregion
    }
}