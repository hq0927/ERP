﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace AmbleClient.BomOffer
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class BomOfferEntities : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“BomOfferEntities”部分中的连接字符串初始化新 BomOfferEntities 对象。
        /// </summary>
        public BomOfferEntities() : base("name=BomOfferEntities", "BomOfferEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 BomOfferEntities 对象。
        /// </summary>
        public BomOfferEntities(string connectionString) : base(connectionString, "BomOfferEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 BomOfferEntities 对象。
        /// </summary>
        public BomOfferEntities(EntityConnection connection) : base(connection, "BomOfferEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<account> account
        {
            get
            {
                if ((_account == null))
                {
                    _account = base.CreateObjectSet<account>("account");
                }
                return _account;
            }
        }
        private ObjectSet<account> _account;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<publicbomoffer> publicbomoffer
        {
            get
            {
                if ((_publicbomoffer == null))
                {
                    _publicbomoffer = base.CreateObjectSet<publicbomoffer>("publicbomoffer");
                }
                return _publicbomoffer;
            }
        }
        private ObjectSet<publicbomoffer> _publicbomoffer;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<publiccustven> publiccustven
        {
            get
            {
                if ((_publiccustven == null))
                {
                    _publiccustven = base.CreateObjectSet<publiccustven>("publiccustven");
                }
                return _publiccustven;
            }
        }
        private ObjectSet<publiccustven> _publiccustven;

        #endregion
        #region AddTo 方法
    
        /// <summary>
        /// 用于向 account EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToaccount(account account)
        {
            base.AddObject("account", account);
        }
    
        /// <summary>
        /// 用于向 publicbomoffer EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTopublicbomoffer(publicbomoffer publicbomoffer)
        {
            base.AddObject("publicbomoffer", publicbomoffer);
        }
    
        /// <summary>
        /// 用于向 publiccustven EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTopubliccustven(publiccustven publiccustven)
        {
            base.AddObject("publiccustven", publiccustven);
        }

        #endregion
    }
    

    #endregion
    
    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="shenzhenerpModel", Name="account")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class account : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 account 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        public static account Createaccount(global::System.Int16 id)
        {
            account account = new account();
            account.id = id;
            return account;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int16 _id;
        partial void OnidChanging(global::System.Int16 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String accountName
        {
            get
            {
                return _accountName;
            }
            set
            {
                OnaccountNameChanging(value);
                ReportPropertyChanging("accountName");
                _accountName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("accountName");
                OnaccountNameChanged();
            }
        }
        private global::System.String _accountName;
        partial void OnaccountNameChanging(global::System.String value);
        partial void OnaccountNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String accountPassword
        {
            get
            {
                return _accountPassword;
            }
            set
            {
                OnaccountPasswordChanging(value);
                ReportPropertyChanging("accountPassword");
                _accountPassword = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("accountPassword");
                OnaccountPasswordChanged();
            }
        }
        private global::System.String _accountPassword;
        partial void OnaccountPasswordChanging(global::System.String value);
        partial void OnaccountPasswordChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.SByte> job
        {
            get
            {
                return _job;
            }
            set
            {
                OnjobChanging(value);
                ReportPropertyChanging("job");
                _job = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("job");
                OnjobChanged();
            }
        }
        private Nullable<global::System.SByte> _job;
        partial void OnjobChanging(Nullable<global::System.SByte> value);
        partial void OnjobChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> superviser
        {
            get
            {
                return _superviser;
            }
            set
            {
                OnsuperviserChanging(value);
                ReportPropertyChanging("superviser");
                _superviser = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("superviser");
                OnsuperviserChanged();
            }
        }
        private Nullable<global::System.Int16> _superviser;
        partial void OnsuperviserChanging(Nullable<global::System.Int16> value);
        partial void OnsuperviserChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="shenzhenerpModel", Name="publicbomoffer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class publicbomoffer : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 publicbomoffer 对象。
        /// </summary>
        /// <param name="bomOfferId">bomOfferId 属性的初始值。</param>
        /// <param name="bomCustVendId">BomCustVendId 属性的初始值。</param>
        /// <param name="userID">userID 属性的初始值。</param>
        public static publicbomoffer Createpublicbomoffer(global::System.Int32 bomOfferId, global::System.Int32 bomCustVendId, global::System.Int16 userID)
        {
            publicbomoffer publicbomoffer = new publicbomoffer();
            publicbomoffer.bomOfferId = bomOfferId;
            publicbomoffer.BomCustVendId = bomCustVendId;
            publicbomoffer.userID = userID;
            return publicbomoffer;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 bomOfferId
        {
            get
            {
                return _bomOfferId;
            }
            set
            {
                if (_bomOfferId != value)
                {
                    OnbomOfferIdChanging(value);
                    ReportPropertyChanging("bomOfferId");
                    _bomOfferId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("bomOfferId");
                    OnbomOfferIdChanged();
                }
            }
        }
        private global::System.Int32 _bomOfferId;
        partial void OnbomOfferIdChanging(global::System.Int32 value);
        partial void OnbomOfferIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BomCustVendId
        {
            get
            {
                return _BomCustVendId;
            }
            set
            {
                OnBomCustVendIdChanging(value);
                ReportPropertyChanging("BomCustVendId");
                _BomCustVendId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BomCustVendId");
                OnBomCustVendIdChanged();
            }
        }
        private global::System.Int32 _BomCustVendId;
        partial void OnBomCustVendIdChanging(global::System.Int32 value);
        partial void OnBomCustVendIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String mfg
        {
            get
            {
                return _mfg;
            }
            set
            {
                OnmfgChanging(value);
                ReportPropertyChanging("mfg");
                _mfg = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("mfg");
                OnmfgChanged();
            }
        }
        private global::System.String _mfg;
        partial void OnmfgChanging(global::System.String value);
        partial void OnmfgChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String mpn
        {
            get
            {
                return _mpn;
            }
            set
            {
                OnmpnChanging(value);
                ReportPropertyChanging("mpn");
                _mpn = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("mpn");
                OnmpnChanged();
            }
        }
        private global::System.String _mpn;
        partial void OnmpnChanging(global::System.String value);
        partial void OnmpnChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> qty
        {
            get
            {
                return _qty;
            }
            set
            {
                OnqtyChanging(value);
                ReportPropertyChanging("qty");
                _qty = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("qty");
                OnqtyChanged();
            }
        }
        private Nullable<global::System.Int32> _qty;
        partial void OnqtyChanging(Nullable<global::System.Int32> value);
        partial void OnqtyChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private Nullable<global::System.Int32> _price;
        partial void OnpriceChanging(Nullable<global::System.Int32> value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cpn
        {
            get
            {
                return _cpn;
            }
            set
            {
                OncpnChanging(value);
                ReportPropertyChanging("cpn");
                _cpn = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cpn");
                OncpnChanged();
            }
        }
        private global::System.String _cpn;
        partial void OncpnChanging(global::System.String value);
        partial void OncpnChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 userID
        {
            get
            {
                return _userID;
            }
            set
            {
                OnuserIDChanging(value);
                ReportPropertyChanging("userID");
                _userID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("userID");
                OnuserIDChanged();
            }
        }
        private global::System.Int16 _userID;
        partial void OnuserIDChanging(global::System.Int16 value);
        partial void OnuserIDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> enerDay
        {
            get
            {
                return _enerDay;
            }
            set
            {
                OnenerDayChanging(value);
                ReportPropertyChanging("enerDay");
                _enerDay = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("enerDay");
                OnenerDayChanged();
            }
        }
        private Nullable<global::System.DateTime> _enerDay;
        partial void OnenerDayChanging(Nullable<global::System.DateTime> value);
        partial void OnenerDayChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="shenzhenerpModel", Name="publiccustven")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class publiccustven : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 publiccustven 对象。
        /// </summary>
        /// <param name="custVenId">custVenId 属性的初始值。</param>
        /// <param name="custVenName">custVenName 属性的初始值。</param>
        /// <param name="userID">userID 属性的初始值。</param>
        public static publiccustven Createpubliccustven(global::System.Int32 custVenId, global::System.String custVenName, global::System.Int16 userID)
        {
            publiccustven publiccustven = new publiccustven();
            publiccustven.custVenId = custVenId;
            publiccustven.custVenName = custVenName;
            publiccustven.userID = userID;
            return publiccustven;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 custVenId
        {
            get
            {
                return _custVenId;
            }
            set
            {
                if (_custVenId != value)
                {
                    OncustVenIdChanging(value);
                    ReportPropertyChanging("custVenId");
                    _custVenId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("custVenId");
                    OncustVenIdChanged();
                }
            }
        }
        private global::System.Int32 _custVenId;
        partial void OncustVenIdChanging(global::System.Int32 value);
        partial void OncustVenIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.SByte> custVendorType
        {
            get
            {
                return _custVendorType;
            }
            set
            {
                OncustVendorTypeChanging(value);
                ReportPropertyChanging("custVendorType");
                _custVendorType = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("custVendorType");
                OncustVendorTypeChanged();
            }
        }
        private Nullable<global::System.SByte> _custVendorType;
        partial void OncustVendorTypeChanging(Nullable<global::System.SByte> value);
        partial void OncustVendorTypeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String custVenName
        {
            get
            {
                return _custVenName;
            }
            set
            {
                OncustVenNameChanging(value);
                ReportPropertyChanging("custVenName");
                _custVenName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("custVenName");
                OncustVenNameChanged();
            }
        }
        private global::System.String _custVenName;
        partial void OncustVenNameChanging(global::System.String value);
        partial void OncustVenNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String contact
        {
            get
            {
                return _contact;
            }
            set
            {
                OncontactChanging(value);
                ReportPropertyChanging("contact");
                _contact = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("contact");
                OncontactChanged();
            }
        }
        private global::System.String _contact;
        partial void OncontactChanging(global::System.String value);
        partial void OncontactChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String tel
        {
            get
            {
                return _tel;
            }
            set
            {
                OntelChanging(value);
                ReportPropertyChanging("tel");
                _tel = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("tel");
                OntelChanged();
            }
        }
        private global::System.String _tel;
        partial void OntelChanging(global::System.String value);
        partial void OntelChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 userID
        {
            get
            {
                return _userID;
            }
            set
            {
                OnuserIDChanging(value);
                ReportPropertyChanging("userID");
                _userID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("userID");
                OnuserIDChanged();
            }
        }
        private global::System.Int16 _userID;
        partial void OnuserIDChanging(global::System.Int16 value);
        partial void OnuserIDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> enterDay
        {
            get
            {
                return _enterDay;
            }
            set
            {
                OnenterDayChanging(value);
                ReportPropertyChanging("enterDay");
                _enterDay = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("enterDay");
                OnenterDayChanged();
            }
        }
        private Nullable<global::System.DateTime> _enterDay;
        partial void OnenterDayChanging(Nullable<global::System.DateTime> value);
        partial void OnenterDayChanged();

        #endregion
    
    }

    #endregion
    
}
