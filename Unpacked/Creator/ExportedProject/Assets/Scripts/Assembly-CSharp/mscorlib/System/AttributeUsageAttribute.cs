namespace System;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
[Token(Token = "0x20000BF")]
public sealed class AttributeUsageAttribute : Attribute
{
	[Token(Token = "0x40002C5")]
	internal static AttributeUsageAttribute Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C2")]
	private AttributeTargets _attributeTarget; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002C3")]
	private bool _allowMultiple; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40002C4")]
	private bool _inherited; //Field offset: 0x15

	[Token(Token = "0x1700005E")]
	public bool AllowMultiple
	{
		[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600043F")]
		 get { } //Length: 5
		[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000440")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005F")]
	public bool Inherited
	{
		[Address(RVA = "0x59AFF0", Offset = "0x59A1F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000441")]
		 get { } //Length: 5
		[Address(RVA = "0x59B010", Offset = "0x59A210", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000442")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x140B130", Offset = "0x140A330", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000443")]
	private static AttributeUsageAttribute() { }

	[Address(RVA = "0x140B1B0", Offset = "0x140A3B0", Length = "0x2F")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600043E")]
	public AttributeUsageAttribute(AttributeTargets validOn) { }

	[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043F")]
	public bool get_AllowMultiple() { }

	[Address(RVA = "0x59AFF0", Offset = "0x59A1F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000441")]
	public bool get_Inherited() { }

	[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000440")]
	public void set_AllowMultiple(bool value) { }

	[Address(RVA = "0x59B010", Offset = "0x59A210", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000442")]
	public void set_Inherited(bool value) { }

}

