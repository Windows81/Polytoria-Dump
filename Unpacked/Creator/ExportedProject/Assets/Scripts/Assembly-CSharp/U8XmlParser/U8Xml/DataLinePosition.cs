namespace U8Xml;

[DebuggerDisplay("{DebugView,nq}")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000007")]
public struct DataLinePosition : IEquatable<DataLinePosition>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000003")]
	public readonly int Line; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000004")]
	public readonly int Position; //Field offset: 0x4

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x17000001")]
	internal string DebugView
	{
		[Address(RVA = "0x1807000", Offset = "0x1806200", Length = "0x7B")]
		[CalledBy(Type = typeof(DataLinePosition), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000006")]
		internal get { } //Length: 123
	}

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public DataLinePosition(int line, int position) { }

	[Address(RVA = "0x1806E50", Offset = "0x1806050", Length = "0xB")]
	[CallerCount(Count = 0)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x6000008")]
	public void Deconstruct(out int line, out int position) { }

	[Address(RVA = "0x1806E60", Offset = "0x1806060", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	[Token(Token = "0x6000009")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1806EF0", Offset = "0x18060F0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public override bool Equals(DataLinePosition other) { }

	[Address(RVA = "0x1807000", Offset = "0x1806200", Length = "0x7B")]
	[CalledBy(Type = typeof(DataLinePosition), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000006")]
	internal string get_DebugView() { }

	[Address(RVA = "0x1806F10", Offset = "0x1806110", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XXHash32), Member = "ComputeHashShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x600000B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1806FF0", Offset = "0x18061F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataLinePosition), Member = "get_DebugView", ReturnType = typeof(string))]
	[Token(Token = "0x600000C")]
	public virtual string ToString() { }

}

