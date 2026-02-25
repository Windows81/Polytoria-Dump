namespace System.Collections.Specialized;

[Token(Token = "0x20001AE")]
internal class CompatibleComparer : IEqualityComparer
{
	[Token(Token = "0x4000697")]
	private static IComparer defaultComparer; //Field offset: 0x0
	[Token(Token = "0x4000699")]
	private static IHashCodeProvider defaultHashProvider; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000696")]
	private IComparer _comparer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000698")]
	private IHashCodeProvider _hcp; //Field offset: 0x18

	[Token(Token = "0x170001F3")]
	public IComparer Comparer
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A66")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001F5")]
	public static IComparer DefaultComparer
	{
		[Address(RVA = "0x17B3220", Offset = "0x17B2420", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CaseInsensitiveComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000A68")]
		 get { } //Length: 229
	}

	[Token(Token = "0x170001F6")]
	public static IHashCodeProvider DefaultHashCodeProvider
	{
		[Address(RVA = "0x17B3310", Offset = "0x17B2510", Length = "0xEC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000A69")]
		 get { } //Length: 236
	}

	[Token(Token = "0x170001F4")]
	public IHashCodeProvider HashCodeProvider
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A67")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A63")]
	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	[Address(RVA = "0x17B2FD0", Offset = "0x17B21D0", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A64")]
	public override bool Equals(object a, object b) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A66")]
	public IComparer get_Comparer() { }

	[Address(RVA = "0x17B3220", Offset = "0x17B2420", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CaseInsensitiveComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000A68")]
	public static IComparer get_DefaultComparer() { }

	[Address(RVA = "0x17B3310", Offset = "0x17B2510", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000A69")]
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A67")]
	public IHashCodeProvider get_HashCodeProvider() { }

	[Address(RVA = "0x17B3150", Offset = "0x17B2350", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A65")]
	public override int GetHashCode(object obj) { }

}

