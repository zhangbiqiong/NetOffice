//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Modules SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Modules : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Modules(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Modules(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Modules(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Modules()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public COMObject get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.HPageBreaks HPageBreaks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HPageBreaks", paramsArray);
				NetOffice.ExcelApi.HPageBreaks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.HPageBreaks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.VPageBreaks VPageBreaks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VPageBreaks", paramsArray);
				NetOffice.ExcelApi.VPageBreaks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.VPageBreaks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
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
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("IndexerItem")]
		public COMObject this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Before">optional object Before</param>
		/// <param name="After">optional object After</param>
		/// <param name="Count">optional object Count</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Module Add(object before, object after, object count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after, count);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Module newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Module;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Module Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Module newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Module;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Before">optional object Before</param>
		/// <param name="After">optional object After</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Copy(object before, object after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after);
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void _Dummy7()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_Dummy7", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Before">optional object Before</param>
		/// <param name="After">optional object After</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Move(object before, object after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Move()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 
		/// </summary>
		/// <param name="From">optional object From</param>
		/// <param name="To">optional object To</param>
		/// <param name="Copies">optional object Copies</param>
		/// <param name="Preview">optional object Preview</param>
		/// <param name="ActivePrinter">optional object ActivePrinter</param>
		/// <param name="PrintToFile">optional object PrintToFile</param>
		/// <param name="Collate">optional object Collate</param>
		[SupportByLibrary("XL09","XL10","XL11")]
		public void _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="From">optional object From</param>
		/// <param name="To">optional object To</param>
		/// <param name="Copies">optional object Copies</param>
		/// <param name="Preview">optional object Preview</param>
		/// <param name="ActivePrinter">optional object ActivePrinter</param>
		/// <param name="PrintToFile">optional object PrintToFile</param>
		/// <param name="Collate">optional object Collate</param>
		/// <param name="PrToFileName">optional object PrToFileName</param>
		[SupportByLibrary("XL12","XL14")]
		public void _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate, object prToFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate, prToFileName);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void _PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void _Dummy12()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_Dummy12", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Replace">optional object Replace</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Select(object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(replace);
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 
		/// </summary>
		/// <param name="From">optional object From</param>
		/// <param name="To">optional object To</param>
		/// <param name="Copies">optional object Copies</param>
		/// <param name="Preview">optional object Preview</param>
		/// <param name="ActivePrinter">optional object ActivePrinter</param>
		/// <param name="PrintToFile">optional object PrintToFile</param>
		/// <param name="Collate">optional object Collate</param>
		/// <param name="PrToFileName">optional object PrToFileName</param>
		[SupportByLibrary("XL09","XL10","XL11")]
		public void PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate, object prToFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate, prToFileName);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="From">optional object From</param>
		/// <param name="To">optional object To</param>
		/// <param name="Copies">optional object Copies</param>
		/// <param name="Preview">optional object Preview</param>
		/// <param name="ActivePrinter">optional object ActivePrinter</param>
		/// <param name="PrintToFile">optional object PrintToFile</param>
		/// <param name="Collate">optional object Collate</param>
		/// <param name="PrToFileName">optional object PrToFileName</param>
		/// <param name="IgnorePrintAreas">optional object IgnorePrintAreas</param>
		[SupportByLibrary("XL12","XL14")]
		public void PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate, object prToFileName, object ignorePrintAreas)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate, prToFileName, ignorePrintAreas);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="From">optional object From</param>
		/// <param name="To">optional object To</param>
		/// <param name="Copies">optional object Copies</param>
		/// <param name="Preview">optional object Preview</param>
		/// <param name="ActivePrinter">optional object ActivePrinter</param>
		/// <param name="PrintToFile">optional object PrintToFile</param>
		/// <param name="Collate">optional object Collate</param>
		[SupportByLibrary("XL12","XL14")]
		public void __PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public void __PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}