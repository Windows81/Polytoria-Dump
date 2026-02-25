namespace Unity.Profiling;

[IsReadOnly]
[Token(Token = "0x200001E")]
[UsedByNativeCode]
public struct ProfilerCategory
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000034")]
	private readonly ushort m_CategoryId; //Field offset: 0x0

	[Token(Token = "0x17000007")]
	public string Name
	{
		[Address(RVA = "0x19396D0", Offset = "0x19388D0", Length = "0x12C")]
		[CalledBy(Type = typeof(ProfilerCategory), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000058")]
		 get { } //Length: 300
	}

	[Token(Token = "0x17000008")]
	public static ProfilerCategory Scripts
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x124EAA0", Offset = "0x124DCA0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	internal ProfilerCategory(ushort category) { }

	[Address(RVA = "0x19396D0", Offset = "0x19388D0", Length = "0x12C")]
	[CalledBy(Type = typeof(ProfilerCategory), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000058")]
	public string get_Name() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	public static ProfilerCategory get_Scripts() { }

	[Address(RVA = "0x1939800", Offset = "0x1938A00", Length = "0x6")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600005B")]
	public static ushort op_Implicit(ProfilerCategory category) { }

	[Address(RVA = "0x19396C0", Offset = "0x19388C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerCategory), Member = "get_Name", ReturnType = typeof(string))]
	[Token(Token = "0x6000059")]
	public virtual string ToString() { }

}

