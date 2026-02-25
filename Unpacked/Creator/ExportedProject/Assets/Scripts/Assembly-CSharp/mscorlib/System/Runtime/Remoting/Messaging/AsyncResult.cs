namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x2000397")]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E92")]
	private object async_state; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E93")]
	private WaitHandle handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E94")]
	private object async_delegate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E95")]
	private IntPtr data; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E96")]
	private object object_data; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E97")]
	private bool sync_completed; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000E98")]
	private bool completed; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000E99")]
	private bool endinvoke_called; //Field offset: 0x3A
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E9A")]
	private object async_callback; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E9B")]
	private ExecutionContext current; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E9C")]
	private ExecutionContext original; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E9D")]
	private long add_time; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E9E")]
	private MonoMethodMessage call_message; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E9F")]
	private IMessageCtrl message_ctrl; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000EA0")]
	private IMessage reply_message; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000EA1")]
	private WaitCallback orig_cb; //Field offset: 0x78

	[Token(Token = "0x17000332")]
	public override object AsyncDelegate
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032D")]
	public override object AsyncState
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032E")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x1378A20", Offset = "0x1377C20", Length = "0xEB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6001BB3")]
		 get { } //Length: 235
	}

	[Token(Token = "0x17000334")]
	internal MonoMethodMessage CallMessage
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BC0")]
		internal get { } //Length: 5
		[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BC1")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700032F")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000331")]
	public bool EndInvokeCalled
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB6")]
		 get { } //Length: 5
		[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000330")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000333")]
	public override IMessageSink NextSink
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB9")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB1")]
	internal AsyncResult() { }

	[Address(RVA = "0x1378760", Offset = "0x1377960", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001BBA")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x13787A0", Offset = "0x13779A0", Length = "0xE4")]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001BBE")]
	internal IMessage EndInvoke() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB8")]
	public override object get_AsyncDelegate() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB2")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x1378A20", Offset = "0x1377C20", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001BB3")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC0")]
	internal MonoMethodMessage get_CallMessage() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB4")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB6")]
	public bool get_EndInvokeCalled() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB5")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB9")]
	public override IMessageSink get_NextSink() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BBB")]
	public override IMessage GetReplyMessage() { }

	[Address(RVA = "0x1378890", Offset = "0x1377A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C7B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC4")]
	internal object Invoke() { }

	[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC1")]
	internal void set_CallMessage(MonoMethodMessage value) { }

	[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB7")]
	public void set_EndInvokeCalled(bool value) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BBD")]
	internal void SetCompletedSynchronously(bool completed) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BBC")]
	public override void SetMessageCtrl(IMessageCtrl mc) { }

	[Address(RVA = "0x13788A0", Offset = "0x1377AA0", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001BBF")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

	[Address(RVA = "0x1378890", Offset = "0x1377A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C7B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC2")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC3")]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

