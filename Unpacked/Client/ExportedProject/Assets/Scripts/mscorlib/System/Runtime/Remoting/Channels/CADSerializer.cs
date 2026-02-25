namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000377")]
internal class CADSerializer
{

	[Address(RVA = "0x1358E90", Offset = "0x1358090", Length = "0x3E")]
	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001B4C")]
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	[Address(RVA = "0x1358FE0", Offset = "0x13581E0", Length = "0x94")]
	[CalledBy(Type = typeof(CADMethodCallMessage), Member = "GetArguments", ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(CADMethodReturnMessage), Member = "GetArguments", ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CADMethodCallMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodCallMessage), typeof(CADMethodReturnMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B50")]
	internal static object DeserializeObject(MemoryStream mem) { }

	[Address(RVA = "0x1358ED0", Offset = "0x13580D0", Length = "0x107")]
	[CalledBy(Type = typeof(CADMessageBase), Member = "GetMethod", ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B4E")]
	internal static object DeserializeObjectSafe(Byte[] mem) { }

	[Address(RVA = "0x1359080", Offset = "0x1358280", Length = "0xF6")]
	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B4D")]
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	[Address(RVA = "0x1359180", Offset = "0x1358380", Length = "0xF6")]
	[CalledBy(Type = typeof(AppDomain), Member = "GetMarshalledDomainObjRef", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B4F")]
	internal static MemoryStream SerializeObject(object obj) { }

}

