namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
[Token(Token = "0x2000500")]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	[Token(Token = "0x2000501")]
	public class ResolveEventHolder
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600234A")]
		public ResolveEventHolder() { }

	}


	[Token(Token = "0x170004B8")]
	public override string CodeBase
	{
		[Address(RVA = "0x13D1210", Offset = "0x13D0410", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002323")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004B9")]
	public override string FullName
	{
		[Address(RVA = "0x13D1250", Offset = "0x13D0450", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002324")]
		 get { } //Length: 62
	}

	[MonoTODO]
	[Token(Token = "0x170004BC")]
	public bool IsFullyTrusted
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002343")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004BB")]
	public override string Location
	{
		[Address(RVA = "0x13D1290", Offset = "0x13D0490", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002326")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004BA")]
	internal override IntPtr MonoAssembly
	{
		[Address(RVA = "0x13D12D0", Offset = "0x13D04D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002325")]
		internal get { } //Length: 62
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002349")]
	public Assembly() { }

	[Address(RVA = "0x13D0BD0", Offset = "0x13CFDD0", Length = "0x58")]
	[CalledBy(Type = typeof(Assembly), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Assembly), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(Assembly), Member = "GetModules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Module[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002342")]
	private static Exception CreateNIE() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002341")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x13D1210", Offset = "0x13D0410", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002323")]
	public override string get_CodeBase() { }

	[Address(RVA = "0x13D1250", Offset = "0x13D0450", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002324")]
	public override string get_FullName() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002343")]
	public bool get_IsFullyTrusted() { }

	[Address(RVA = "0x13D1290", Offset = "0x13D0490", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002326")]
	public override string get_Location() { }

	[Address(RVA = "0x13D12D0", Offset = "0x13D04D0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002325")]
	internal override IntPtr get_MonoAssembly() { }

	[Address(RVA = "0x13D0C30", Offset = "0x13CFE30", Length = "0x9E")]
	[CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(Converter), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002332")]
	public static Assembly GetAssembly(Type type) { }

	[Address(RVA = "0x13D0CD0", Offset = "0x13CFED0", Length = "0x5")]
	[CalledBy(Type = typeof(ResourceManager), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.UserData", Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Loaders.EmbeddedResourcesScriptLoader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D850")]
	[Token(Token = "0x600233D")]
	public static Assembly GetCallingAssembly() { }

	[Address(RVA = "0x13D0CE0", Offset = "0x13CFEE0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002329")]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13D0D20", Offset = "0x13CFF20", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE440")]
	[Token(Token = "0x600233C")]
	public static Assembly GetExecutingAssembly() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002340")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13D0D50", Offset = "0x13CFF50", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600233F")]
	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	[Address(RVA = "0x13D0D90", Offset = "0x13CFF90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600233E")]
	public override String[] GetManifestResourceNames() { }

	[Address(RVA = "0x13D0DD0", Offset = "0x13CFFD0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600232A")]
	public override Stream GetManifestResourceStream(string name) { }

	[Address(RVA = "0x13D0E10", Offset = "0x13D0010", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002345")]
	public override Module GetModule(string name) { }

	[Address(RVA = "0x13D0E80", Offset = "0x13D0080", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002346")]
	public override Module[] GetModules(bool getResourceModules) { }

	[Address(RVA = "0x13D0E40", Offset = "0x13D0040", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600233B")]
	internal override Module[] GetModulesInternal() { }

	[Address(RVA = "0x13D0EF0", Offset = "0x13D00F0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002330")]
	public override AssemblyName GetName() { }

	[Address(RVA = "0x13D0EB0", Offset = "0x13D00B0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600232F")]
	public override AssemblyName GetName(bool copiedName) { }

	[Address(RVA = "0x13D0F10", Offset = "0x13D0110", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002327")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13D0F80", Offset = "0x13D0180", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002344")]
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x13D0F50", Offset = "0x13D0150", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600232D")]
	public override Type GetType(string name) { }

	[Address(RVA = "0x13D0FC0", Offset = "0x13D01C0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600232C")]
	public override Type[] GetTypes() { }

	[Address(RVA = "0x13D0FB0", Offset = "0x13D01B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DBA0")]
	[Token(Token = "0x600232B")]
	internal override Type[] GetTypes(bool exportedOnly) { }

	[Address(RVA = "0x13D0FE0", Offset = "0x13D01E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DBB0")]
	[Token(Token = "0x600232E")]
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x13D0FF0", Offset = "0x13D01F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002328")]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13D1180", Offset = "0x13D0380", Length = "0x2D")]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MenuCreator", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002336")]
	public static Assembly Load(AssemblyName assemblyRef) { }

	[Address(RVA = "0x13D1150", Offset = "0x13D0350", Length = "0x2D")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceWellKnown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(FormatterServices), Member = "LoadAssemblyFromStringNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(FormatterServices), Member = "LoadAssemblyFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(WellKnownServiceTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(WellKnownObjectMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WellKnownClientTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientWellKnown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActivatedServiceTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActivatedClientTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncodingHelper), Member = "InvokeI18N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CalledBy(Type = "System.DelegateSerializationHolder+DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002335")]
	public static Assembly Load(string assemblyString) { }

	[Address(RVA = "0x13D1310", Offset = "0x13D0510", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020EA40")]
	[Token(Token = "0x6002338")]
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Address(RVA = "0x13D1040", Offset = "0x13D0240", Length = "0x1D")]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E1D0")]
	[Obsolete]
	[Token(Token = "0x6002334")]
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	[Address(RVA = "0x13D1030", Offset = "0x13D0230", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E1D0")]
	[Token(Token = "0x6002333")]
	private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x13D10F0", Offset = "0x13D02F0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020EA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x6002339")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	[Address(RVA = "0x13D1060", Offset = "0x13D0260", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020EA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600233A")]
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	[Address(RVA = "0x13D1320", Offset = "0x13D0520", Length = "0x51")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002347")]
	public static bool op_Equality(Assembly left, Assembly right) { }

	[Address(RVA = "0x13D1380", Offset = "0x13D0580", Length = "0x56")]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "DoAssemblyResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly), typeof(bool)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "DoTypeResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "DoResourceResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002348")]
	public static bool op_Inequality(Assembly left, Assembly right) { }

	[Address(RVA = "0x13D11B0", Offset = "0x13D03B0", Length = "0x4C")]
	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002337")]
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Address(RVA = "0x13D1200", Offset = "0x13D0400", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6002331")]
	public virtual string ToString() { }

}

