namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200033E")]
public class InternalRemotingServices
{
	[Token(Token = "0x4000DCA")]
	private static Hashtable _soapAttributes; //Field offset: 0x0

	[Address(RVA = "0x1367D10", Offset = "0x1366F10", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60019E1")]
	private static InternalRemotingServices() { }

	[Address(RVA = "0x13677B0", Offset = "0x13669B0", Length = "0x553")]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlElementForInteropType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlTypeForInteropType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60019E0")]
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

}

