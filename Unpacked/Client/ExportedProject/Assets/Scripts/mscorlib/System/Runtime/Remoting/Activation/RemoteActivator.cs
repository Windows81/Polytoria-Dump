namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000389")]
internal class RemoteActivator : MarshalByRefObject, IActivator
{

	[Token(Token = "0x17000315")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0x1390FF0", Offset = "0x13901F0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B7A")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1390C60", Offset = "0x138FE60", Length = "0x38D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject)}, ReturnType = typeof(ObjRef))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "IsActivationAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001B79")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[Address(RVA = "0x1390FF0", Offset = "0x13901F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001B7A")]
	public override IActivator get_NextActivator() { }

}

