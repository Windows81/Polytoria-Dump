namespace System.Reflection;

[Token(Token = "0x20004E1")]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
{
	[Token(Token = "0x4001379")]
	public static readonly TypeFilter FilterTypeName; //Field offset: 0x0
	[Token(Token = "0x400137B")]
	private const BindingFlags DefaultLookup = 28; //Field offset: 0x0
	[Token(Token = "0x400137A")]
	public static readonly TypeFilter FilterTypeNameIgnoreCase; //Field offset: 0x8

	[Token(Token = "0x1700044E")]
	public override Assembly Assembly
	{
		[Address(RVA = "0x13BEF00", Offset = "0x13BE100", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021E4")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700044F")]
	public override Guid ModuleVersionId
	{
		[Address(RVA = "0x13BEF30", Offset = "0x13BE130", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021E5")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000450")]
	public override string ScopeName
	{
		[Address(RVA = "0x13BEF60", Offset = "0x13BE160", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021E6")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x13BEE10", Offset = "0x13BE010", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60021F2")]
	private static Module() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E3")]
	protected Module() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EB")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x13BEA00", Offset = "0x13BDC00", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60021F0")]
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	[Address(RVA = "0x13BEBA0", Offset = "0x13BDDA0", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60021EF")]
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	[Address(RVA = "0x13BEF00", Offset = "0x13BE100", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021E4")]
	public override Assembly get_Assembly() { }

	[Address(RVA = "0x13BEF30", Offset = "0x13BE130", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021E5")]
	public override Guid get_ModuleVersionId() { }

	[Address(RVA = "0x13BEF60", Offset = "0x13BE160", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021E6")]
	public override string get_ScopeName() { }

	[Address(RVA = "0x13BECF0", Offset = "0x13BDEF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021E9")]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13BED20", Offset = "0x13BDF20", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021F1")]
	internal override Guid GetModuleVersionId() { }

	[Address(RVA = "0x13BED60", Offset = "0x13BDF60", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021EA")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13BED90", Offset = "0x13BDF90", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021E8")]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13BEDC0", Offset = "0x13BDFC0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021E7")]
	public override bool IsResource() { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021ED")]
	public static bool op_Equality(Module left, Module right) { }

	[Address(RVA = "0x13BEDF0", Offset = "0x13BDFF0", Length = "0x14")]
	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EE")]
	public virtual string ToString() { }

}

