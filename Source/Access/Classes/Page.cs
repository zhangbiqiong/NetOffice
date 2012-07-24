using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Page_ClickEventHandler();
	public delegate void Page_DblClickEventHandler(ref Int16 Cancel);
	public delegate void Page_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Page_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Page_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Page 
	/// SupportByVersion Access, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Page : _Page,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_PageEvents_SinkHelper __PageEvents_SinkHelper;
		DispPageEvents_SinkHelper _dispPageEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Page);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Page(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Page(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Page(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Page 
        /// </summary>		
		public Page():base("Access.Page")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Page
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Page(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15
		/// </summary>
		private event Page_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15)]
		public event Page_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15
		/// </summary>
		private event Page_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15)]
		public event Page_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15
		/// </summary>
		private event Page_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15)]
		public event Page_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15
		/// </summary>
		private event Page_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15)]
		public event Page_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15
		/// </summary>
		private event Page_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15)]
		public event Page_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _PageEvents_SinkHelper.Id,DispPageEvents_SinkHelper.Id);


			if(_PageEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__PageEvents_SinkHelper = new _PageEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispPageEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispPageEvents_SinkHelper = new DispPageEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != __PageEvents_SinkHelper)
			{
				__PageEvents_SinkHelper.Dispose();
				__PageEvents_SinkHelper = null;
			}
			if( null != _dispPageEvents_SinkHelper)
			{
				_dispPageEvents_SinkHelper.Dispose();
				_dispPageEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}