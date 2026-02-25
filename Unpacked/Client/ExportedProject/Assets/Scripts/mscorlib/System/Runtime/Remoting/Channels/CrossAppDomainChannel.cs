namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000374")]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
{
	[Token(Token = "0x4000E5F")]
	private static object s_lock; //Field offset: 0x0

	[Token(Token = "0x17000301")]
	public override object ChannelData
	{
		[Address(RVA = "0x1365770", Offset = "0x1364970", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001B3E")]
		 get { } //Length: 89
	}

	[Token(Token = "0x170002FF")]
	public override string ChannelName
	{
		[Address(RVA = "0x13657D0", Offset = "0x13649D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B3C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000300")]
	public override int ChannelPriority
	{
		[Address(RVA = "0x5B6570", Offset = "0x5B5770", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B3D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x13656F0", Offset = "0x13648F0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B42")]
	private static CrossAppDomainChannel() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B41")]
	public CrossAppDomainChannel() { }

	[Address(RVA = "0x1365430", Offset = "0x1364630", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
	[Calls(Type = typeof(CrossAppDomainSink), Member = "GetSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CrossAppDomainSink))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B40")]
	public override IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	[Address(RVA = "0x1365770", Offset = "0x1364970", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001B3E")]
	public override object get_ChannelData() { }

	[Address(RVA = "0x13657D0", Offset = "0x13649D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001B3C")]
	public override string get_ChannelName() { }

	[Address(RVA = "0x5B6570", Offset = "0x5B5770", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B3D")]
	public override int get_ChannelPriority() { }

	[Address(RVA = "0x13655B0", Offset = "0x13647B0", Length = "0x13A")]
	[CalledBy(Type = typeof(RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingServices), Member = "RegisterInternalChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannel), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B3B")]
	internal static void RegisterCrossAppDomainChannel() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B3F")]
	public override void StartListening(object data) { }

}

