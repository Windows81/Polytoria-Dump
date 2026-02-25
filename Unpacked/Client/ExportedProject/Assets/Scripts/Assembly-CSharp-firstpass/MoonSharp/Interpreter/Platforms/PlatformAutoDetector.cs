namespace MoonSharp.Interpreter.Platforms;

[Token(Token = "0x20000B9")]
public static class PlatformAutoDetector
{
	[CompilerGenerated]
	[Token(Token = "0x20000BA")]
	private sealed class <>c
	{
		[Token(Token = "0x4000372")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000373")]
		public static Func<Assembly, IEnumerable`1<Type>> <>9__28_0; //Field offset: 0x8
		[Token(Token = "0x4000374")]
		public static Func<Type, Boolean> <>9__28_1; //Field offset: 0x10

		[Address(RVA = "0x32E920", Offset = "0x32DB20", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000816")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000817")]
		public <>c() { }

		[Address(RVA = "0x32E540", Offset = "0x32D740", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DescriptorHelpers), Member = "SafeGetTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(Type[]))]
		[Token(Token = "0x6000818")]
		internal IEnumerable<Type> <AutoDetectPlatformFlags>b__28_0(Assembly a) { }

		[Address(RVA = "0x32E550", Offset = "0x32D750", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000819")]
		internal bool <AutoDetectPlatformFlags>b__28_1(Type t) { }

	}

	[Token(Token = "0x400036A")]
	private static Nullable<Boolean> m_IsRunningOnAOT; //Field offset: 0x0
	[Token(Token = "0x400036B")]
	private static bool m_AutoDetectionsDone; //Field offset: 0x2
	[CompilerGenerated]
	[Token(Token = "0x400036C")]
	private static bool <IsRunningOnMono>k__BackingField; //Field offset: 0x3
	[CompilerGenerated]
	[Token(Token = "0x400036D")]
	private static bool <IsRunningOnClr4>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[Token(Token = "0x400036E")]
	private static bool <IsRunningOnUnity>k__BackingField; //Field offset: 0x5
	[CompilerGenerated]
	[Token(Token = "0x400036F")]
	private static bool <IsPortableFramework>k__BackingField; //Field offset: 0x6
	[CompilerGenerated]
	[Token(Token = "0x4000370")]
	private static bool <IsUnityNative>k__BackingField; //Field offset: 0x7
	[CompilerGenerated]
	[Token(Token = "0x4000371")]
	private static bool <IsUnityIL2CPP>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000109")]
	public private static bool IsPortableFramework
	{
		[Address(RVA = "0x328070", Offset = "0x327270", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600080C")]
		 get { } //Length: 55
		[Address(RVA = "0x3281F0", Offset = "0x3273F0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600080D")]
		private set { } //Length: 60
	}

	[Token(Token = "0x1700010C")]
	public static bool IsRunningOnAOT
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000812")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000107")]
	public private static bool IsRunningOnClr4
	{
		[Address(RVA = "0x3280B0", Offset = "0x3272B0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000808")]
		 get { } //Length: 55
		[Address(RVA = "0x328230", Offset = "0x327430", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000809")]
		private set { } //Length: 60
	}

	[Token(Token = "0x17000106")]
	public private static bool IsRunningOnMono
	{
		[Address(RVA = "0x3280F0", Offset = "0x3272F0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000806")]
		 get { } //Length: 55
		[Address(RVA = "0x328270", Offset = "0x327470", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000807")]
		private set { } //Length: 60
	}

	[Token(Token = "0x17000108")]
	public private static bool IsRunningOnUnity
	{
		[Address(RVA = "0x328130", Offset = "0x327330", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600080A")]
		 get { } //Length: 55
		[Address(RVA = "0x3282B0", Offset = "0x3274B0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600080B")]
		private set { } //Length: 60
	}

	[Token(Token = "0x1700010B")]
	public private static bool IsUnityIL2CPP
	{
		[Address(RVA = "0x328170", Offset = "0x327370", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000810")]
		 get { } //Length: 55
		[Address(RVA = "0x3282F0", Offset = "0x3274F0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000811")]
		private set { } //Length: 60
	}

	[Token(Token = "0x1700010A")]
	public private static bool IsUnityNative
	{
		[Address(RVA = "0x3281B0", Offset = "0x3273B0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600080E")]
		 get { } //Length: 55
		[Address(RVA = "0x328330", Offset = "0x327530", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600080F")]
		private set { } //Length: 60
	}

	[Address(RVA = "0x327B10", Offset = "0x326D10", Length = "0x371")]
	[CalledBy(Type = typeof(PlatformAutoDetector), Member = "GetDefaultPlatform", ReturnType = typeof(IPlatformAccessor))]
	[CalledBy(Type = typeof(PlatformAutoDetector), Member = "GetDefaultScriptLoader", ReturnType = typeof(IScriptLoader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "SelectMany", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Collections.Generic.IEnumerable`1<System.Object>>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000813")]
	private static void AutoDetectPlatformFlags() { }

	[Address(RVA = "0x328070", Offset = "0x327270", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600080C")]
	public static bool get_IsPortableFramework() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000812")]
	public static bool get_IsRunningOnAOT() { }

	[Address(RVA = "0x3280B0", Offset = "0x3272B0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000808")]
	public static bool get_IsRunningOnClr4() { }

	[Address(RVA = "0x3280F0", Offset = "0x3272F0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000806")]
	public static bool get_IsRunningOnMono() { }

	[Address(RVA = "0x328130", Offset = "0x327330", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600080A")]
	public static bool get_IsRunningOnUnity() { }

	[Address(RVA = "0x328170", Offset = "0x327370", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000810")]
	public static bool get_IsUnityIL2CPP() { }

	[Address(RVA = "0x3281B0", Offset = "0x3273B0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600080E")]
	public static bool get_IsUnityNative() { }

	[Address(RVA = "0x327E90", Offset = "0x327090", Length = "0x95")]
	[CalledBy(Type = typeof(Script), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptGlobalOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlatformAutoDetector), Member = "AutoDetectPlatformFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000814")]
	internal static IPlatformAccessor GetDefaultPlatform() { }

	[Address(RVA = "0x327F30", Offset = "0x327130", Length = "0x132")]
	[CalledBy(Type = typeof(Script), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlatformAutoDetector), Member = "AutoDetectPlatformFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityAssetsScriptLoader), Member = "LoadResourcesWithReflection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000815")]
	internal static IScriptLoader GetDefaultScriptLoader() { }

	[Address(RVA = "0x3281F0", Offset = "0x3273F0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600080D")]
	private static void set_IsPortableFramework(bool value) { }

	[Address(RVA = "0x328230", Offset = "0x327430", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000809")]
	private static void set_IsRunningOnClr4(bool value) { }

	[Address(RVA = "0x328270", Offset = "0x327470", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000807")]
	private static void set_IsRunningOnMono(bool value) { }

	[Address(RVA = "0x3282B0", Offset = "0x3274B0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600080B")]
	private static void set_IsRunningOnUnity(bool value) { }

	[Address(RVA = "0x3282F0", Offset = "0x3274F0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000811")]
	private static void set_IsUnityIL2CPP(bool value) { }

	[Address(RVA = "0x328330", Offset = "0x327530", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600080F")]
	private static void set_IsUnityNative(bool value) { }

}

