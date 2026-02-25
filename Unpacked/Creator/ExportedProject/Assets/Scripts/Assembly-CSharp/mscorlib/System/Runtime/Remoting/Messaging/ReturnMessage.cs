namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003BA")]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EFB")]
	private Object[] _outArgs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EFC")]
	private Object[] _args; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EFD")]
	private LogicalCallContext _callCtx; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EFE")]
	private object _returnValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EFF")]
	private string _uri; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F00")]
	private Exception _exception; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F01")]
	private MethodBase _methodBase; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F02")]
	private string _methodName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F03")]
	private Type[] _methodSignature; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F04")]
	private string _typeName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F05")]
	private MethodReturnDictionary _properties; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F06")]
	private Identity _targetIdentity; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000F07")]
	private ArgInfo _inArgInfo; //Field offset: 0x70

	[Token(Token = "0x1700038C")]
	public override int ArgCount
	{
		[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C9C")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700038D")]
	public override Object[] Args
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C9D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000396")]
	public override Exception Exception
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700038E")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x13916A0", Offset = "0x13908A0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C9E")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700038F")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C9F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000390")]
	public override string MethodName
	{
		[Address(RVA = "0x1391710", Offset = "0x1390910", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CA0")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000391")]
	public override object MethodSignature
	{
		[Address(RVA = "0x1391770", Offset = "0x1390970", Length = "0x16B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001CA1")]
		 get { } //Length: 363
	}

	[Token(Token = "0x17000397")]
	public override Object[] OutArgs
	{
		[Address(RVA = "0x13918E0", Offset = "0x1390AE0", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ArgInfo), Member = "GetInOutArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CAA")]
		 get { } //Length: 182
	}

	[Token(Token = "0x17000392")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x13919A0", Offset = "0x1390BA0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MethodReturnDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001CA2")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000398")]
	public override object ReturnValue
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000399")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAC")]
		private get { } //Length: 5
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAD")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000395")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA6")]
		private get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000393")]
	public override string TypeName
	{
		[Address(RVA = "0x1391A10", Offset = "0x1390C10", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001CA3")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000394")]
	public override string Uri
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA4")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA5")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1391590", Offset = "0x1390790", Length = "0x110")]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C9A")]
	public ReturnMessage(object ret, Object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	[Address(RVA = "0x13914B0", Offset = "0x13906B0", Length = "0xD4")]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel+ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ChannelServices), Member = "CheckIncomingMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(ReturnMessage))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ActivationServices), Member = "RemoteActivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C9B")]
	public ReturnMessage(Exception e, IMethodCallMessage mcm) { }

	[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C9C")]
	public override int get_ArgCount() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C9D")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA9")]
	public override Exception get_Exception() { }

	[Address(RVA = "0x13916A0", Offset = "0x13908A0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C9E")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C9F")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x1391710", Offset = "0x1390910", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CA0")]
	public override string get_MethodName() { }

	[Address(RVA = "0x1391770", Offset = "0x1390970", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001CA1")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x13918E0", Offset = "0x1390AE0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgInfo), Member = "GetInOutArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CAA")]
	public override Object[] get_OutArgs() { }

	[Address(RVA = "0x13919A0", Offset = "0x1390BA0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MethodReturnDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001CA2")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CAB")]
	public override object get_ReturnValue() { }

	[Address(RVA = "0x1391A10", Offset = "0x1390C10", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001CA3")]
	public override string get_TypeName() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA4")]
	public override string get_Uri() { }

	[Address(RVA = "0x1391480", Offset = "0x1390680", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA8")]
	public override object GetArg(int argNum) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA5")]
	public void set_Uri(string value) { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CAC")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA6")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CAD")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA7")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

