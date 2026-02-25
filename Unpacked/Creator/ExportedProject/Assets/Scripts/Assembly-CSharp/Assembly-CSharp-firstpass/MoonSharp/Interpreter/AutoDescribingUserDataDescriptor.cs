namespace MoonSharp.Interpreter;

[Token(Token = "0x200006A")]
public class AutoDescribingUserDataDescriptor : IUserDataDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000230")]
	private string m_FriendlyName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000231")]
	private Type m_Type; //Field offset: 0x18

	[Token(Token = "0x170000D3")]
	public override string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000646")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D4")]
	public override Type Type
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000647")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F6040", Offset = "0x2F5240", Length = "0x4E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000645")]
	public AutoDescribingUserDataDescriptor(Type type, string friendlyName) { }

	[Address(RVA = "0x2F5C70", Offset = "0x2F4E70", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600064A")]
	public override string AsString(object obj) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000646")]
	public override string get_Name() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000647")]
	public override Type get_Type() { }

	[Address(RVA = "0x2F5CA0", Offset = "0x2F4EA0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000648")]
	public override DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	[Address(RVA = "0x2F5D90", Offset = "0x2F4F90", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600064C")]
	public override bool IsTypeCompatible(Type type, object obj) { }

	[Address(RVA = "0x2F5E50", Offset = "0x2F5050", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600064B")]
	public override DynValue MetaIndex(Script script, object obj, string metaname) { }

	[Address(RVA = "0x2F5F40", Offset = "0x2F5140", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000649")]
	public override bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

}

