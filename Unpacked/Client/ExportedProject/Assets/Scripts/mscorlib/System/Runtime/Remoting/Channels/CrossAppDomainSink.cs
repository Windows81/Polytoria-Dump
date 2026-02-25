namespace System.Runtime.Remoting.Channels;

[MonoTODO("Handle domain unloading?")]
[Token(Token = "0x2000375")]
internal class CrossAppDomainSink : IMessageSink
{
	[Token(Token = "0x2000376")]
	private struct ProcessMessageRes
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E63")]
		public Byte[] arrResponse; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000E64")]
		public CADMethodReturnMessage cadMrm; //Field offset: 0x8

	}

	[Token(Token = "0x4000E60")]
	private static Hashtable s_sinks; //Field offset: 0x0
	[Token(Token = "0x4000E61")]
	private static MethodInfo processMessageMethod; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E62")]
	private int _domainID; //Field offset: 0x10

	[Token(Token = "0x17000302")]
	internal int TargetDomainId
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B45")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x1366240", Offset = "0x1365440", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B4A")]
	private static CrossAppDomainSink() { }

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B43")]
	internal CrossAppDomainSink(int domainID) { }

	[Address(RVA = "0x1366180", Offset = "0x1365380", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6001B4B")]
	private void <AsyncProcessMessage>b__10_0(object data) { }

	[Address(RVA = "0x13658A0", Offset = "0x1364AA0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001B48")]
	public override IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B45")]
	internal int get_TargetDomainId() { }

	[Address(RVA = "0x1365980", Offset = "0x1364B80", Length = "0x2BC")]
	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001B44")]
	internal static CrossAppDomainSink GetSink(int domainID) { }

	[Address(RVA = "0x1365C40", Offset = "0x1364E40", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ErrorMessage), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B46")]
	private static ProcessMessageRes ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	[Address(RVA = "0x1365D40", Offset = "0x1364F40", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B49")]
	public void SendAsyncMessage(object data) { }

	[Address(RVA = "0x1365E00", Offset = "0x1365000", Length = "0x376")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodCallMessage), typeof(CADMethodReturnMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(AppDomain), Member = "InvokeInDomainByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(CADMethodCallMessage), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(CADMethodCallMessage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "DeserializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream), typeof(IMethodCallMessage)}, ReturnType = typeof(IMessage))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B47")]
	public override IMessage SyncProcessMessage(IMessage msgRequest) { }

}

