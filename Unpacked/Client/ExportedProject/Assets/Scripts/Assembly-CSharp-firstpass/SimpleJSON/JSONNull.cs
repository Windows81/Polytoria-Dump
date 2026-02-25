namespace SimpleJSON;

[Token(Token = "0x2000037")]
public class JSONNull : JSONNode
{
	[Token(Token = "0x400018B")]
	private static JSONNull m_StaticInstance; //Field offset: 0x0
	[Token(Token = "0x400018C")]
	public static bool reuseSameInstance; //Field offset: 0x8

	[Token(Token = "0x17000073")]
	public virtual bool AsBool
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044A")]
		 get { } //Length: 3
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044B")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000071")]
	public virtual bool IsNull
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000446")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000070")]
	public virtual JSONNodeType Tag
	{
		[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000445")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000072")]
	public virtual string Value
	{
		[Address(RVA = "0x2FF960", Offset = "0x2FEB60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000448")]
		 get { } //Length: 44
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000449")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x2FF8C0", Offset = "0x2FEAC0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600044F")]
	private static JSONNull() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000444")]
	private JSONNull() { }

	[Address(RVA = "0x2FF740", Offset = "0x2FE940", Length = "0x91")]
	[CalledBy(Type = typeof(JSONArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONArray), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONObject), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000443")]
	public static JSONNull CreateOrGet() { }

	[Address(RVA = "0x2FF7E0", Offset = "0x2FE9E0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600044C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044A")]
	public virtual bool get_AsBool() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000446")]
	public virtual bool get_IsNull() { }

	[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000445")]
	public virtual JSONNodeType get_Tag() { }

	[Address(RVA = "0x2FF960", Offset = "0x2FEB60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000448")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2FE7A0", Offset = "0x2FD9A0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000447")]
	public virtual Enumerator GetEnumerator() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044B")]
	public virtual void set_AsBool(bool value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000449")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2FF870", Offset = "0x2FEA70", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044E")]
	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

