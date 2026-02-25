namespace System;

[Token(Token = "0x200010B")]
internal static class Marvin
{
	[CompilerGenerated]
	[Token(Token = "0x400042F")]
	private static readonly ulong <DefaultSeed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700008F")]
	public static ulong DefaultSeed
	{
		[Address(RVA = "0x14A2640", Offset = "0x14A1840", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000835")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x10BD150", Offset = "0x10BC350", Length = "0x19")]
	[CallerCount(Count = 115)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000834")]
	private static uint _rotl(uint value, int shift) { }

	[Address(RVA = "0x14A2600", Offset = "0x14A1800", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000837")]
	private static Marvin() { }

	[Address(RVA = "0x14A1FE0", Offset = "0x14A11E0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000833")]
	private static void Block(ref uint rp0, ref uint rp1) { }

	[Address(RVA = "0x14A2080", Offset = "0x14A1280", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000831")]
	public static int ComputeHash32(ReadOnlySpan<Byte> data, ulong seed) { }

	[Address(RVA = "0x14A2120", Offset = "0x14A1320", Length = "0x184")]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000832")]
	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	[Address(RVA = "0x14A25F0", Offset = "0x14A17F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000836")]
	private static ulong GenerateSeed() { }

	[Address(RVA = "0x14A2640", Offset = "0x14A1840", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000835")]
	public static ulong get_DefaultSeed() { }

}

