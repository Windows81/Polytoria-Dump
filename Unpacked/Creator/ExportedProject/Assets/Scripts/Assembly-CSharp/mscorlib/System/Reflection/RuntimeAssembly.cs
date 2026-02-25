namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
[Token(Token = "0x2000507")]
internal class RuntimeAssembly : Assembly
{
	[Token(Token = "0x2000508")]
	public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4001467")]
		private Module module; //Field offset: 0x68

		[Address(RVA = "0x13ED920", Offset = "0x13ECB20", Length = "0x1D0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6002398")]
		public UnmanagedMemoryStreamForModule(Byte* pointer, long length, Module module) { }

		[Address(RVA = "0x13ED8D0", Offset = "0x13ECAD0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnmanagedMemoryStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002399")]
		protected virtual void Dispose(bool disposing) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400145D")]
	internal IntPtr _mono_assembly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400145E")]
	private object _evidence; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400145F")]
	internal ResolveEventHolder resolve_event_holder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001460")]
	private object _minimum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001461")]
	private object _optional; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001462")]
	private object _refuse; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001463")]
	private object _granted; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001464")]
	private object _denied; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001465")]
	internal bool fromByteArray; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001466")]
	internal string assemblyName; //Field offset: 0x58

	[Token(Token = "0x170004C8")]
	public virtual string CodeBase
	{
		[Address(RVA = "0x13E59F0", Offset = "0x13E4BF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210100")]
		[Token(Token = "0x6002389")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004C9")]
	public virtual string FullName
	{
		[Address(RVA = "0x13E5A00", Offset = "0x13E4C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210300")]
		[DeduplicatedMethod]
		[Token(Token = "0x600238A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004CB")]
	public virtual string Location
	{
		[Address(RVA = "0x13E5A10", Offset = "0x13E4C10", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x600238C")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170004CA")]
	internal virtual IntPtr MonoAssembly
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600238B")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x13E5980", Offset = "0x13E4B80", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600237B")]
	protected RuntimeAssembly() { }

	[Address(RVA = "0x13E4B40", Offset = "0x13E3D40", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002396")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x13E4C50", Offset = "0x13E3E50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210100")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002384")]
	private static string get_code_base(Assembly a, bool escaped) { }

	[Address(RVA = "0x13E59F0", Offset = "0x13E4BF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210100")]
	[Token(Token = "0x6002389")]
	public virtual string get_CodeBase() { }

	[Address(RVA = "0x13E5A00", Offset = "0x13E4C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210300")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002386")]
	internal static string get_fullname(Assembly a) { }

	[Address(RVA = "0x13E5A00", Offset = "0x13E4C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210300")]
	[DeduplicatedMethod]
	[Token(Token = "0x600238A")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x13E5A30", Offset = "0x13E4C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210390")]
	[Token(Token = "0x6002385")]
	private string get_location() { }

	[Address(RVA = "0x13E5A10", Offset = "0x13E4C10", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600238C")]
	public virtual string get_Location() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600238B")]
	internal virtual IntPtr get_MonoAssembly() { }

	[Address(RVA = "0x13E4C00", Offset = "0x13E3E00", Length = "0x4F")]
	[CalledBy(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[Token(Token = "0x6002383")]
	internal static Byte[] GetAotId() { }

	[Address(RVA = "0x12F3760", Offset = "0x12F2960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002387")]
	internal static bool GetAotIdInternal(Byte[] aotid) { }

	[Address(RVA = "0x13E4C50", Offset = "0x13E3E50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210100")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002388")]
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	[Address(RVA = "0x13E4C60", Offset = "0x13E3E60", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x6002393")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002395")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13E4CE0", Offset = "0x13E3EE0", Length = "0x128")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600238E")]
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	[Address(RVA = "0x13E4CD0", Offset = "0x13E3ED0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F080")]
	[Token(Token = "0x600238D")]
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	[Address(RVA = "0x13E4E10", Offset = "0x13E4010", Length = "0x5")]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F1D0")]
	[Token(Token = "0x6002390")]
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	[Address(RVA = "0x13E4E20", Offset = "0x13E4020", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F420")]
	[Token(Token = "0x600238F")]
	public virtual String[] GetManifestResourceNames() { }

	[Address(RVA = "0x13E4E30", Offset = "0x13E4030", Length = "0x3D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(AppDomain), Member = "DoResourceResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F1D0")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6002391")]
	public virtual Stream GetManifestResourceStream(string name) { }

	[Address(RVA = "0x13E5210", Offset = "0x13E4410", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002381")]
	public virtual Module GetModule(string name) { }

	[Address(RVA = "0x13E5390", Offset = "0x13E4590", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002382")]
	public virtual Module[] GetModules(bool getResourceModules) { }

	[Address(RVA = "0x13E5380", Offset = "0x13E4580", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F530")]
	[Token(Token = "0x6002394")]
	internal virtual Module[] GetModulesInternal() { }

	[Address(RVA = "0x13E54D0", Offset = "0x13E46D0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020F590")]
	[Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600237F")]
	public virtual AssemblyName GetName(bool copiedName) { }

	[Address(RVA = "0x13E55A0", Offset = "0x13E47A0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int), typeof(string), typeof(RuntimeAssembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600237C")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13E5640", Offset = "0x13E4840", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DBB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002380")]
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x13E5710", Offset = "0x13E4910", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002392")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E5870", Offset = "0x13E4A70", Length = "0xBE")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020EA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600237D")]
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x13E5780", Offset = "0x13E4980", Length = "0xE1")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020EA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600237E")]
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x13E5930", Offset = "0x13E4B30", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002397")]
	public virtual string ToString() { }

}

