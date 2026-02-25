namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x200039D")]
internal class CADMethodReturnMessage : CADMessageBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EB1")]
	private object _returnValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EB2")]
	private CADArgHolder _exception; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EB3")]
	private Type[] _sig; //Field offset: 0x48

	[Token(Token = "0x17000337")]
	internal int PropertiesCount
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BE2")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x137BB10", Offset = "0x137AD10", Length = "0x287")]
	[CalledBy(Type = typeof(CADMethodReturnMessage), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(CADMethodReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CADMessageBase), Member = "SaveLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage), typeof(ArrayList&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CADMessageBase), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(CADMessageBase), Member = "GetMethod", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CADMessageBase), Member = "MarshalArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(ArrayList&)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001BDD")]
	internal CADMethodReturnMessage(IMethodReturnMessage retMsg) { }

	[Address(RVA = "0x137B880", Offset = "0x137AA80", Length = "0x82")]
	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001BDC")]
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BE2")]
	internal int get_PropertiesCount() { }

	[Address(RVA = "0x137AAE0", Offset = "0x1379CE0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(ArrayList)}, ReturnType = typeof(Object[]))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BDF")]
	internal Object[] GetArgs(ArrayList args) { }

	[Address(RVA = "0x137B910", Offset = "0x137AB10", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001BDE")]
	internal ArrayList GetArguments() { }

	[Address(RVA = "0x137BA50", Offset = "0x137AC50", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001BE1")]
	internal Exception GetException(ArrayList args) { }

	[Address(RVA = "0x137BB00", Offset = "0x137AD00", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList)}, ReturnType = typeof(object))]
	[Token(Token = "0x6001BE0")]
	internal object GetReturnValue(ArrayList args) { }

}

