namespace Unity.Burst;

[Token(Token = "0x200000C")]
public sealed class BurstCompilerOptions
{
	[Token(Token = "0x4000018")]
	internal static readonly bool ForceDisableBurstCompilation; //Field offset: 0x0
	[Token(Token = "0x4000019")]
	private static readonly bool ForceBurstCompilationSynchronously; //Field offset: 0x1
	[Token(Token = "0x400001A")]
	internal static readonly bool IsSecondaryUnityProcess; //Field offset: 0x2
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	private bool _enableBurstCompilation; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400001C")]
	private bool _enableBurstSafetyChecks; //Field offset: 0x11
	[CompilerGenerated]
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x400001D")]
	private readonly bool <IsGlobal>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001E")]
	private Action <OptionsChanged>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000008")]
	public bool EnableBurstCompilation
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		 get { } //Length: 5
		[Address(RVA = "0x1819320", Offset = "0x1818520", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000020")]
		 set { } //Length: 232
	}

	[Token(Token = "0x17000009")]
	public bool EnableBurstSafetyChecks
	{
		[Address(RVA = "0x1819410", Offset = "0x1818610", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000021")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000007")]
	private bool IsGlobal
	{
		[Address(RVA = "0x5E9D30", Offset = "0x5E8F30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700000A")]
	internal Action OptionsChanged
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x18190A0", Offset = "0x18182A0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000028")]
	private static BurstCompilerOptions() { }

	[Address(RVA = "0x1819200", Offset = "0x1818400", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001D")]
	internal BurstCompilerOptions(bool isGlobal) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	private static bool CheckIsSecondaryUnityProcess() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public bool get_EnableBurstCompilation() { }

	[Address(RVA = "0x5E9D30", Offset = "0x5E8F30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	private bool get_IsGlobal() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000022")]
	internal Action get_OptionsChanged() { }

	[Address(RVA = "0x1818B00", Offset = "0x1817D00", Length = "0x3AF")]
	[CalledBy(Type = typeof(BurstCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "TryGetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BurstCompileAttribute&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "HasBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180739630")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(BurstCompileAttribute), Member = "set_CompileSynchronously", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000024")]
	private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) { }

	[Address(RVA = "0x1818EB0", Offset = "0x18180B0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000025")]
	internal static bool HasBurstCompileAttribute(MemberInfo member) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000027")]
	private void MaybeTriggerRecompilation() { }

	[Address(RVA = "0x1818FE0", Offset = "0x18181E0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000026")]
	private void OnOptionsChanged() { }

	[Address(RVA = "0x1819320", Offset = "0x1818520", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JobsUtility), Member = "set_JobCompilerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000020")]
	public void set_EnableBurstCompilation(bool value) { }

	[Address(RVA = "0x1819410", Offset = "0x1818610", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public void set_EnableBurstSafetyChecks(bool value) { }

	[Address(RVA = "0x1819000", Offset = "0x1818200", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[Token(Token = "0x6000023")]
	private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) { }

}

