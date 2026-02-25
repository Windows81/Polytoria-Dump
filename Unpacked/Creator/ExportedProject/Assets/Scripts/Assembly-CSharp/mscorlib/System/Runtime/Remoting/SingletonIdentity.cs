namespace System.Runtime.Remoting;

[Token(Token = "0x200034A")]
internal class SingletonIdentity : ServerIdentity
{

	[Address(RVA = "0x13746C0", Offset = "0x13738C0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A69")]
	public SingletonIdentity(string objectUri, Context context, Type objectType) { }

	[Address(RVA = "0x1374A50", Offset = "0x1373C50", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A6C")]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1374B00", Offset = "0x1373D00", Length = "0x11D")]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Context)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A6A")]
	public MarshalByRefObject GetServerObject() { }

	[Address(RVA = "0x1374C20", Offset = "0x1373E20", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A6B")]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

