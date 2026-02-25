namespace SimpleJSON;

[Token(Token = "0x2000036")]
public class JSONBool : JSONNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400018A")]
	private bool m_Data; //Field offset: 0x10

	[Token(Token = "0x1700006F")]
	public virtual bool AsBool
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600043C")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600043D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700006D")]
	public virtual bool IsBoolean
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000438")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700006C")]
	public virtual JSONNodeType Tag
	{
		[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000437")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700006E")]
	public virtual string Value
	{
		[Address(RVA = "0x2FE8F0", Offset = "0x2FDAF0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[Token(Token = "0x600043A")]
		 get { } //Length: 46
		[Address(RVA = "0x2FE930", Offset = "0x2FDB30", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600043B")]
		 set { } //Length: 81
	}

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043E")]
	public JSONBool(bool aData) { }

	[Address(RVA = "0x2FE890", Offset = "0x2FDA90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043F")]
	public JSONBool(string aData) { }

	[Address(RVA = "0x2FE740", Offset = "0x2FD940", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000441")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043C")]
	public virtual bool get_AsBool() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000438")]
	public virtual bool get_IsBoolean() { }

	[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000437")]
	public virtual JSONNodeType get_Tag() { }

	[Address(RVA = "0x2FE8F0", Offset = "0x2FDAF0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x600043A")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2FE7A0", Offset = "0x2FD9A0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000439")]
	public virtual Enumerator GetEnumerator() { }

	[Address(RVA = "0x2FE7C0", Offset = "0x2FD9C0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000442")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043D")]
	public virtual void set_AsBool(bool value) { }

	[Address(RVA = "0x2FE930", Offset = "0x2FDB30", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600043B")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2FE7F0", Offset = "0x2FD9F0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000440")]
	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

