/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TCity��Ӧ��ҵ���߼���TCity
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TCity_Entity:TCity
 * 
************************************************************/
/************************************************************
SQL���룺
select AutoId,Id,Name,X,Y,IsHot,Create_by,Create_by_name from TCity
delete from TCity
INSERT INTO TCity (AutoId,Id,Name,X,Y,IsHot,Create_by,Create_by_name)
     VALUES
           ('','','','','','','','')
UPDATE TCity SET ...
������ֵ���룺
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.X = valObj2.X;
        valObj.Y = valObj2.Y;
        valObj.IsHot = valObj2.IsHot;
        valObj.Create_by = valObj2.Create_by;
        valObj.Create_by_name = valObj2.Create_by_name; 
        valObj.AutoId = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.X = "";
        valObj.Y = "";
        valObj.IsHot = "";
        valObj.Create_by = "";
        valObj.Create_by_name = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "X": $("#txt_X").val(),
        "Y": $("#txt_Y").val(),
        "IsHot": $("#txt_IsHot").val(),
        "Create_by": $("#txt_Create_by").val(),
        "Create_by_name": $("#txt_Create_by_name").val(), 
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
    /// <para>��TCity���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TCity : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TCity Factory()
        {
            return new TCity();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _X
        {            
            get { return this.X; }
            set { this.X = value; }
        }
        
        /// <summary> γ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Y
        {            
            get { return this.Y; }
            set { this.Y = value; }
        }
        
        /// <summary> �Ƿ�����:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by_name
        {            
            get { return this.Create_by_name; }
            set { this.Create_by_name = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal X
        {
            get { return this.m_x; }
            set //
            {
                if (!x_initialized || m_x != value)
                {
                    this.m_x = value;
                }
                x_initialized = true;
            }
        }
        
        /// <summary> γ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Y
        {
            get { return this.m_y; }
            set //
            {
                if (!y_initialized || m_y != value)
                {
                    this.m_y = value;
                }
                y_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�����:[CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsHot
        {
            get { return this.m_ishot; }
            set //
            {
                if (!ishot_initialized || m_ishot != value)
                {
                    this.m_ishot = value;
                }
                ishot_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Create_by
        {
            get { return this.m_create_by; }
            set //
            {
                if (!create_by_initialized || m_create_by != value)
                {
                    this.m_create_by = value;
                }
                create_by_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Create_by_name
        {
            get { return this.m_create_by_name; }
            set //
            {
                if (!create_by_name_initialized || m_create_by_name != value)
                {
                    this.m_create_by_name = value;
                }
                create_by_name_initialized = true;
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
            public static AttributeItem AutoId =  new AttributeItem("[TCity].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TCity].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[TCity].[Name]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X =  new AttributeItem("[TCity].[X]", typeof(decimal), 18, default(decimal));
            
            /// <summary>γ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Y =  new AttributeItem("[TCity].[Y]", typeof(decimal), 18, default(decimal));
            
            /// <summary>�Ƿ�����:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[TCity].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[TCity].[Create_by]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by_name =  new AttributeItem("[TCity].[Create_by_name]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private decimal m_x;
        /// <summary></summary>
        protected bool x_initialized = false;
        
        private decimal m_y;
        /// <summary></summary>
        protected bool y_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_create_by_name;
        /// <summary></summary>
        protected bool create_by_name_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TCity";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.x_initialized = IsLoadAllAttributes;this.y_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.create_by_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TCity value = new TCity();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X"))
				value.x_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Y"))
				value.y_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by_name"))
				value.create_by_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TCity Clone()
        {
            return (TCity)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TCity()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TCity() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TCity(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TCity(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TCity(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TCity(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TCity(int autoid1, int id1, string name1, decimal x1, decimal y1, bool ishot1, string create_by1, string create_by_name1)
        {
            
            this.AutoId = autoid1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.X = x1;
            
            this.Y = y1;
            
            this.IsHot = ishot1;
            
            this.Create_by = create_by1;
            
            this.Create_by_name = create_by_name1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TCity FromIView(IView view)
        {
            return (TCity)IView.GetITable(view, "TCity");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TCity GetOneInstance()
        {
            TCity value = new TCity();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TCity Retrieve()
        {
            BLLTable<TCity>.GetRowData(this);
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
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "X":
			        return X;
			    			
			    case "Y":
			        return Y;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "Create_by_name":
			        return Create_by_name;
			
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
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X":
			        this.X = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Y":
			        this.Y = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by_name":
			        this.Create_by_name = Convert.ToString(AttributeValue);
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
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "X":
					return x_initialized;
				
				case "Y":
					return y_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "Create_by_name":
					return create_by_name_initialized;
				
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
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "X":
					x_initialized = ret;
					return true;
				
				case "Y":
					y_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "Create_by_name":
					create_by_name_initialized = ret;
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
                AttributeItem attr = TCity.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = TCity.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = TCity.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (x_initialized)
			{
                AttributeItem attr = TCity.Attribute.X;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X);
                }
			}
			
			if (y_initialized)
			{
                AttributeItem attr = TCity.Attribute.Y;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Y);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = TCity.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = TCity.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (create_by_name_initialized)
			{
                AttributeItem attr = TCity.Attribute.Create_by_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by_name);
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
        public class TCityJson
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public decimal X { get; set; }
            
            /// <summary>γ��:[CtrlTypeDic-{InputString}]</summary>
            public decimal Y { get; set; }
            
            /// <summary>�Ƿ�����:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by_name { get; set; }
        }
        #endregion
    }
}