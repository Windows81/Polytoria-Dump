namespace SimpleJSON;

[Token(Token = "0x2000035")]
public class JSONNumber : JSONNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000189")]
	private double m_Data; //Field offset: 0x10

	[Token(Token = "0x1700006B")]
	public virtual double AsDouble
	{
		[Address(RVA = "0x2FFDD0", Offset = "0x2FEFD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042F")]
		 get { } //Length: 6
		[Address(RVA = "0x2FFE00", Offset = "0x2FF000", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000430")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000069")]
	public virtual bool IsNumber
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000068")]
	public virtual JSONNodeType Tag
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700006A")]
	public virtual string Value
	{
		[Address(RVA = "0x2FFDF0", Offset = "0x2FEFF0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[Token(Token = "0x600042D")]
		 get { } //Length: 11
		[Address(RVA = "0x2FFE10", Offset = "0x2FF010", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600042E")]
		 set { } //Length: 58
	}

	[Address(RVA = "0x2FFDA0", Offset = "0x2FEFA0", Length = "0x28")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService+<DoWriteToServer>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000431")]
	public JSONNumber(double aData) { }

	[Address(RVA = "0x2FE890", Offset = "0x2FDA90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000432")]
	public JSONNumber(string aData) { }

	[Address(RVA = "0x2FF990", Offset = "0x2FEB90", Length = "0x245")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000435")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FFDD0", Offset = "0x2FEFD0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042F")]
	public virtual double get_AsDouble() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042B")]
	public virtual bool get_IsNumber() { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042A")]
	public virtual JSONNodeType get_Tag() { }

	[Address(RVA = "0x2FFDF0", Offset = "0x2FEFF0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x600042D")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2FE7A0", Offset = "0x2FD9A0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042C")]
	public virtual Enumerator GetEnumerator() { }

	[Address(RVA = "0x2FFBE0", Offset = "0x2FEDE0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000436")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FFC20", Offset = "0x2FEE20", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000434")]
	private static bool IsNumeric(object value) { }

	[Address(RVA = "0x2FFE00", Offset = "0x2FF000", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000430")]
	public virtual void set_AsDouble(double value) { }

	[Address(RVA = "0x2FFE10", Offset = "0x2FF010", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600042E")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2FFD70", Offset = "0x2FEF70", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000433")]
	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

