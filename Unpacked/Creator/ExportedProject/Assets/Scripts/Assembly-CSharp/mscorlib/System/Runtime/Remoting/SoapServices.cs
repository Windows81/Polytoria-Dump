namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200034D")]
public class SoapServices
{
	[Token(Token = "0x200034E")]
	private class TypeInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E0B")]
		public Hashtable Attributes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E0C")]
		public Hashtable Elements; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A83")]
		public TypeInfo() { }

	}

	[Token(Token = "0x4000E06")]
	private static Hashtable _xmlTypes; //Field offset: 0x0
	[Token(Token = "0x4000E07")]
	private static Hashtable _xmlElements; //Field offset: 0x8
	[Token(Token = "0x4000E08")]
	private static Hashtable _soapActions; //Field offset: 0x10
	[Token(Token = "0x4000E09")]
	private static Hashtable _soapActionsMethods; //Field offset: 0x18
	[Token(Token = "0x4000E0A")]
	private static Hashtable _typeInfos; //Field offset: 0x20

	[Token(Token = "0x170002D6")]
	public static string XmlNsForClrTypeWithAssembly
	{
		[Address(RVA = "0x1376090", Offset = "0x1375290", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001A73")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170002D7")]
	public static string XmlNsForClrTypeWithNs
	{
		[Address(RVA = "0x13760F0", Offset = "0x13752F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001A74")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170002D8")]
	public static string XmlNsForClrTypeWithNsAndAssembly
	{
		[Address(RVA = "0x13760C0", Offset = "0x13752C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001A75")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1375F00", Offset = "0x1375100", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001A82")]
	private static SoapServices() { }

	[Address(RVA = "0x1374D60", Offset = "0x1373F60", Length = "0x180")]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SoapTypeAttribute), Member = "SetReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001A76")]
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	[Address(RVA = "0x1374EE0", Offset = "0x13740E0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A81")]
	private static string EncodeNs(string ns) { }

	[Address(RVA = "0x1376090", Offset = "0x1375290", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001A73")]
	public static string get_XmlNsForClrTypeWithAssembly() { }

	[Address(RVA = "0x13760F0", Offset = "0x13752F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001A74")]
	public static string get_XmlNsForClrTypeWithNs() { }

	[Address(RVA = "0x13760C0", Offset = "0x13752C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001A75")]
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	[Address(RVA = "0x1374FB0", Offset = "0x13741B0", Length = "0x132")]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001A78")]
	private static string GetAssemblyName(MethodBase mb) { }

	[Address(RVA = "0x13750F0", Offset = "0x13742F0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001A77")]
	private static string GetNameKey(string name, string namspace) { }

	[Address(RVA = "0x1375150", Offset = "0x1374350", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SoapAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A79")]
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	[Address(RVA = "0x1375260", Offset = "0x1374460", Length = "0xA0")]
	[CalledBy(Type = typeof(SoapMethodAttribute), Member = "SetReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoapServices), Member = "GetAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A7A")]
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	[Address(RVA = "0x1375310", Offset = "0x1374510", Length = "0xA0")]
	[CalledBy(Type = typeof(SoapMethodAttribute), Member = "SetReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoapServices), Member = "GetAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A7B")]
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	[Address(RVA = "0x13753C0", Offset = "0x13745C0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SoapAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001A7C")]
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	[Address(RVA = "0x1375B30", Offset = "0x1374D30", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A7D")]
	public static void PreLoad(Assembly assembly) { }

	[Address(RVA = "0x13754B0", Offset = "0x13746B0", Length = "0x678")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SoapAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6001A7E")]
	public static void PreLoad(Type type) { }

	[Address(RVA = "0x1375BF0", Offset = "0x1374DF0", Length = "0x180")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A7F")]
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	[Address(RVA = "0x1375D80", Offset = "0x1374F80", Length = "0x17E")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A80")]
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

}

