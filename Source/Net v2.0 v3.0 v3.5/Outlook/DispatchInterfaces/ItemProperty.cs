//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface ItemProperty SupportByLibrary OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL10","OL11","OL12","OL14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ItemProperty : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperty(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperty(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperty(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperty()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string Formula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Formula", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Formula", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlUserPropertyType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlUserPropertyType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string ValidationFormula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationFormula", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ValidationFormula", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string ValidationText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ValidationText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public bool IsUserProperty
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsUserProperty", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}