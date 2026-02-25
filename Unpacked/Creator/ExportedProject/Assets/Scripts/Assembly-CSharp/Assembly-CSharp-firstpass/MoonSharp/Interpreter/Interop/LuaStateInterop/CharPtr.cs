namespace MoonSharp.Interpreter.Interop.LuaStateInterop;

[DefaultMember("Item")]
[Token(Token = "0x2000122")]
public class CharPtr
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000476")]
	public Char[] chars; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000477")]
	public int index; //Field offset: 0x18

	[Token(Token = "0x17000172")]
	public char Item
	{
		[Address(RVA = "0x351F20", Offset = "0x351120", Length = "0x31")]
		[CallerCount(Count = 63)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABA")]
		 get { } //Length: 49
		[Address(RVA = "0x3528B0", Offset = "0x351AB0", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABB")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000173")]
	public char Item
	{
		[Address(RVA = "0x351EC0", Offset = "0x3510C0", Length = "0x5D")]
		[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ABC")]
		 get { } //Length: 93
		[Address(RVA = "0x3528F0", Offset = "0x351AF0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ABD")]
		 set { } //Length: 107
	}

	[Token(Token = "0x17000174")]
	public char Item
	{
		[Address(RVA = "0x351F20", Offset = "0x351120", Length = "0x31")]
		[CallerCount(Count = 63)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABE")]
		 get { } //Length: 49
		[Address(RVA = "0x3528B0", Offset = "0x351AB0", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABF")]
		 set { } //Length: 49
	}

	[Address(RVA = "0x351BC0", Offset = "0x350DC0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ACA")]
	public CharPtr(IntPtr ptr) { }

	[Address(RVA = "0x351CA0", Offset = "0x350EA0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC9")]
	public CharPtr(Byte[] bytes) { }

	[Address(RVA = "0x351C70", Offset = "0x350E70", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC3")]
	public CharPtr() { }

	[Address(RVA = "0x351DA0", Offset = "0x350FA0", Length = "0x7E")]
	[CalledBy(Type = typeof(CharPtr), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(LuaBase), Member = "sprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(CharPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC4")]
	public CharPtr(string str) { }

	[Address(RVA = "0x351B20", Offset = "0x350D20", Length = "0x43")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "classend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC5")]
	public CharPtr(CharPtr ptr) { }

	[Address(RVA = "0x351C20", Offset = "0x350E20", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC6")]
	public CharPtr(CharPtr ptr, int index) { }

	[Address(RVA = "0x351D60", Offset = "0x350F60", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC7")]
	public CharPtr(Char[] chars) { }

	[Address(RVA = "0x351B70", Offset = "0x350D70", Length = "0x42")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC8")]
	public CharPtr(Char[] chars, int index) { }

	[Address(RVA = "0x351E20", Offset = "0x351020", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AD3")]
	public CharPtr add(int ofs) { }

	[Address(RVA = "0x351EB0", Offset = "0x3510B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AD0")]
	public void dec() { }

	[Address(RVA = "0x351880", Offset = "0x350A80", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AE1")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x351F20", Offset = "0x351120", Length = "0x31")]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABA")]
	public char get_Item(int offset) { }

	[Address(RVA = "0x351EC0", Offset = "0x3510C0", Length = "0x5D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ABC")]
	public char get_Item(uint offset) { }

	[Address(RVA = "0x351F20", Offset = "0x351120", Length = "0x31")]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABE")]
	public char get_Item(long offset) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x351F60", Offset = "0x351160", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACF")]
	public void inc() { }

	[Address(RVA = "0x351F70", Offset = "0x351170", Length = "0x77")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+GMatchAuxData"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addquoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(LuaLBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "min_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbracketclass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "classend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AD1")]
	public CharPtr next() { }

	[Address(RVA = "0x351FF0", Offset = "0x3511F0", Length = "0x8D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "classend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbracketclass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "max_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "min_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ACB")]
	public static CharPtr op_Addition(CharPtr ptr, int offset) { }

	[Address(RVA = "0x352080", Offset = "0x351280", Length = "0x8D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+GMatchAuxData"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ACD")]
	public static CharPtr op_Addition(CharPtr ptr, uint offset) { }

	[Address(RVA = "0x352110", Offset = "0x351310", Length = "0x1F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000AD9")]
	public static CharPtr op_Addition(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x352350", Offset = "0x351550", Length = "0x29")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "start_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "end_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+GMatchAuxData"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ADF")]
	public static bool op_Equality(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x352380", Offset = "0x351580", Length = "0x35")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbracketclass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AD5")]
	public static bool op_Equality(CharPtr ptr, char ch) { }

	[Address(RVA = "0x352310", Offset = "0x351510", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AD6")]
	public static bool op_Equality(char ch, CharPtr ptr) { }

	[Address(RVA = "0x3523F0", Offset = "0x3515F0", Length = "0x21")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ADD")]
	public static bool op_GreaterThan(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x3523C0", Offset = "0x3515C0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ADE")]
	public static bool op_GreaterThanOrEqual(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x352500", Offset = "0x351700", Length = "0x67")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC1")]
	public static CharPtr op_Implicit(Char[] chars) { }

	[Address(RVA = "0x352570", Offset = "0x351770", Length = "0x54")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addquoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(LuaLBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CharPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AC0")]
	public static CharPtr op_Implicit(string str) { }

	[Address(RVA = "0x352420", Offset = "0x351620", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC2")]
	public static CharPtr op_Implicit(Byte[] bytes) { }

	[Address(RVA = "0x352650", Offset = "0x351850", Length = "0x37")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "max_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "min_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "push_captures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+GMatchAuxData"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AE0")]
	public static bool op_Inequality(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x352610", Offset = "0x351810", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AD8")]
	public static bool op_Inequality(char ch, CharPtr ptr) { }

	[Address(RVA = "0x3525D0", Offset = "0x3517D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AD7")]
	public static bool op_Inequality(CharPtr ptr, char ch) { }

	[Address(RVA = "0x3526C0", Offset = "0x3518C0", Length = "0x21")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbracketclass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "max_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "min_expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ADB")]
	public static bool op_LessThan(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x352690", Offset = "0x351890", Length = "0x21")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+GMatchAuxData"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ADC")]
	public static bool op_LessThanOrEqual(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x352810", Offset = "0x351A10", Length = "0x1E")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "end_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "push_onecapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+GMatchAuxData"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ADA")]
	public static int op_Subtraction(CharPtr ptr1, CharPtr ptr2) { }

	[Address(RVA = "0x3526F0", Offset = "0x3518F0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ACE")]
	public static CharPtr op_Subtraction(CharPtr ptr, uint offset) { }

	[Address(RVA = "0x352780", Offset = "0x351980", Length = "0x8C")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "singlematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ACC")]
	public static CharPtr op_Subtraction(CharPtr ptr, int offset) { }

	[Address(RVA = "0x352830", Offset = "0x351A30", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AD2")]
	public CharPtr prev() { }

	[Address(RVA = "0x3528B0", Offset = "0x351AB0", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABF")]
	public void set_Item(long offset, char value) { }

	[Address(RVA = "0x3528F0", Offset = "0x351AF0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ABD")]
	public void set_Item(uint offset, char value) { }

	[Address(RVA = "0x3528B0", Offset = "0x351AB0", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABB")]
	public void set_Item(int offset, char value) { }

	[Address(RVA = "0x352960", Offset = "0x351B60", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AD4")]
	public CharPtr sub(int ofs) { }

	[Address(RVA = "0x351A40", Offset = "0x350C40", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE3")]
	public virtual string ToString() { }

	[Address(RVA = "0x351940", Offset = "0x350B40", Length = "0xF4")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLAddLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaLBuffer), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE4")]
	public string ToString(int length) { }

}

