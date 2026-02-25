namespace System.ComponentModel;

[ClassInterface(ClassInterfaceType::AutoDispatch (1))]
[ComVisible(True)]
[DesignerCategory("Component")]
[Token(Token = "0x2000182")]
public class Component : MarshalByRefObject, IComponent, IDisposable
{
	[Token(Token = "0x4000623")]
	private static readonly object EventDisposed; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000624")]
	private ISite site; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000625")]
	private EventHandlerList events; //Field offset: 0x20

	[Token(Token = "0x170001BD")]
	protected override bool CanRaiseEvents
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000945")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001BE")]
	internal bool CanRaiseEventsInternal
	{
		[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000946")]
		internal get { } //Length: 20
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x170001C0")]
	protected bool DesignMode
	{
		[Address(RVA = "0x1794890", Offset = "0x1793A90", Length = "0x4C")]
		[CalledBy(Type = typeof(Process), Member = "get_SynchronizingObject", ReturnType = typeof(ISynchronizeInvoke))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x600094B")]
		 get { } //Length: 76
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x170001BF")]
	public override ISite Site
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000947")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1794810", Offset = "0x1793A10", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600094E")]
	private static Component() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094D")]
	public Component() { }

	[Address(RVA = "0x1794450", Offset = "0x1793650", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000948")]
	public override void Dispose() { }

	[Address(RVA = "0x17944C0", Offset = "0x17936C0", Length = "0x1EF")]
	[CalledBy(Type = typeof(Process), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemWatcher), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventHandlerList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000949")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1309C30", Offset = "0x1308E30", Length = "0x65")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000944")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000945")]
	protected override bool get_CanRaiseEvents() { }

	[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000946")]
	internal bool get_CanRaiseEventsInternal() { }

	[Address(RVA = "0x1794890", Offset = "0x1793A90", Length = "0x4C")]
	[CalledBy(Type = typeof(Process), Member = "get_SynchronizingObject", ReturnType = typeof(ISynchronizeInvoke))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x600094B")]
	protected bool get_DesignMode() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000947")]
	public override ISite get_Site() { }

	[Address(RVA = "0x17946C0", Offset = "0x17938C0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x600094A")]
	protected override object GetService(Type service) { }

	[Address(RVA = "0x1794720", Offset = "0x1793920", Length = "0xEB")]
	[CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600094C")]
	public virtual string ToString() { }

}

