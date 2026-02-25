namespace MoonSharp.Interpreter.Interop.LuaStateInterop;

[Token(Token = "0x2000123")]
public class LuaBase
{
	[Token(Token = "0x4000478")]
	protected const int LUA_TNONE = -1; //Field offset: 0x0
	[Token(Token = "0x4000479")]
	protected const int LUA_TNIL = 0; //Field offset: 0x0
	[Token(Token = "0x400047A")]
	protected const int LUA_TBOOLEAN = 1; //Field offset: 0x0
	[Token(Token = "0x400047B")]
	protected const int LUA_TLIGHTUSERDATA = 2; //Field offset: 0x0
	[Token(Token = "0x400047C")]
	protected const int LUA_TNUMBER = 3; //Field offset: 0x0
	[Token(Token = "0x400047D")]
	protected const int LUA_TSTRING = 4; //Field offset: 0x0
	[Token(Token = "0x400047E")]
	protected const int LUA_TTABLE = 5; //Field offset: 0x0
	[Token(Token = "0x400047F")]
	protected const int LUA_TFUNCTION = 6; //Field offset: 0x0
	[Token(Token = "0x4000480")]
	protected const int LUA_TUSERDATA = 7; //Field offset: 0x0
	[Token(Token = "0x4000481")]
	protected const int LUA_TTHREAD = 8; //Field offset: 0x0
	[Token(Token = "0x4000482")]
	protected const int LUA_MULTRET = -1; //Field offset: 0x0
	[Token(Token = "0x4000483")]
	protected const string LUA_INTFRMLEN = "l"; //Field offset: 0x0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2A")]
	public LuaBase() { }

	[Address(RVA = "0x3583F0", Offset = "0x3575F0", Length = "0x6F")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE6")]
	protected static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = false) { }

	[Address(RVA = "0x358460", Offset = "0x357660", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE5")]
	protected static DynValue GetArgument(LuaState L, int pos) { }

	[Address(RVA = "0x3593D0", Offset = "0x3585D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B1F")]
	protected static bool isalnum(int c) { }

	[Address(RVA = "0x3593A0", Offset = "0x3585A0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B15")]
	protected static bool isalnum(char c) { }

	[Address(RVA = "0x359400", Offset = "0x358600", Length = "0x2D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B0E")]
	protected static bool isalpha(char c) { }

	[Address(RVA = "0x359430", Offset = "0x358630", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B18")]
	protected static bool isalpha(int c) { }

	[Address(RVA = "0x359490", Offset = "0x358690", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B19")]
	protected static bool iscntrl(int c) { }

	[Address(RVA = "0x359460", Offset = "0x358660", Length = "0x2D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B0F")]
	protected static bool iscntrl(char c) { }

	[Address(RVA = "0x3594C0", Offset = "0x3586C0", Length = "0x2D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B10")]
	protected static bool isdigit(char c) { }

	[Address(RVA = "0x3594F0", Offset = "0x3586F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B1A")]
	protected static bool isdigit(int c) { }

	[Address(RVA = "0x359520", Offset = "0x358720", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B20")]
	protected static bool isgraph(int c) { }

	[Address(RVA = "0x359580", Offset = "0x358780", Length = "0x5B")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B17")]
	protected static bool isgraph(char c) { }

	[Address(RVA = "0x359610", Offset = "0x358810", Length = "0x2D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B11")]
	protected static bool islower(char c) { }

	[Address(RVA = "0x3595E0", Offset = "0x3587E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B1B")]
	protected static bool islower(int c) { }

	[Address(RVA = "0x359640", Offset = "0x358840", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B1C")]
	protected static bool ispunct(int c) { }

	[Address(RVA = "0x359680", Offset = "0x358880", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B12")]
	protected static bool ispunct(char c) { }

	[Address(RVA = "0x3596B0", Offset = "0x3588B0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B13")]
	protected static bool isspace(char c) { }

	[Address(RVA = "0x3596B0", Offset = "0x3588B0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1D")]
	protected static bool isspace(int c) { }

	[Address(RVA = "0x359700", Offset = "0x358900", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B14")]
	protected static bool isupper(char c) { }

	[Address(RVA = "0x3596D0", Offset = "0x3588D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B1E")]
	protected static bool isupper(int c) { }

	[Address(RVA = "0x359730", Offset = "0x358930", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B16")]
	protected static bool isxdigit(char c) { }

	[Address(RVA = "0x358480", Offset = "0x357680", Length = "0x3F")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "classend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gfind_nodef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000AFC")]
	protected static string LUA_QL(string p) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFE")]
	protected static void LuaAssert(bool p) { }

	[Address(RVA = "0x3584C0", Offset = "0x3576C0", Length = "0x26D")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LuaState), Member = "GetTopArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LuaState), Member = "Pop", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B09")]
	protected static void LuaCall(LuaState L, int nargs, int nresults = -1) { }

	[Address(RVA = "0x358730", Offset = "0x357930", Length = "0xB3")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "Pop", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B02")]
	protected static void LuaGetTable(LuaState L, int p) { }

	[Address(RVA = "0x3587F0", Offset = "0x3579F0", Length = "0x41")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF4")]
	protected static int LuaGetTop(LuaState L) { }

	[Address(RVA = "0x358840", Offset = "0x357A40", Length = "0x3C")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B00")]
	protected static int LuaIsString(LuaState L, int p) { }

	[Address(RVA = "0x358880", Offset = "0x357A80", Length = "0x23")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addquoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(LuaLBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF6")]
	protected static void LuaLAddChar(LuaLBuffer b, char p) { }

	[Address(RVA = "0x3588B0", Offset = "0x357AB0", Length = "0x45")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addquoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(LuaLBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CharPtr), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEE")]
	protected static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p) { }

	[Address(RVA = "0x358900", Offset = "0x357B00", Length = "0x4A")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addquoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(LuaLBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AEF")]
	protected static void LuaLAddString(LuaLBuffer b, string s) { }

	[Address(RVA = "0x358950", Offset = "0x357B50", Length = "0x4B")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LuaState), Member = "Pop", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "ToPrintString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AED")]
	protected static void LuaLAddValue(LuaLBuffer b) { }

	[Address(RVA = "0x3589A0", Offset = "0x357BA0", Length = "0x21")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaBase), Member = "LuaLArgError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AF2")]
	protected static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message) { }

	[Address(RVA = "0x3589D0", Offset = "0x357BD0", Length = "0x5F")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLArgCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(bool), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "BadArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B06")]
	protected static void LuaLArgError(LuaState L, int arg, string p) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF7")]
	protected static void LuaLBuffInit(LuaState L, LuaLBuffer b) { }

	[Address(RVA = "0x358A30", Offset = "0x357C30", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF3")]
	protected static int LuaLCheckInt(LuaState L, int argNum) { }

	[Address(RVA = "0x358A30", Offset = "0x357C30", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF1")]
	protected static int LuaLCheckInteger(LuaState L, int pos) { }

	[Address(RVA = "0x358AA0", Offset = "0x357CA0", Length = "0x7E")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE8")]
	protected static string LuaLCheckLString(LuaState L, int argNum, out uint l) { }

	[Address(RVA = "0x358B20", Offset = "0x357D20", Length = "0x62")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B07")]
	protected static double LuaLCheckNumber(LuaState L, int pos) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFB")]
	protected static void LuaLCheckStack(LuaState L, int n, string message) { }

	[Address(RVA = "0x358C00", Offset = "0x357E00", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CharPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B04")]
	protected static CharPtr LuaLCheckString(LuaState L, int p) { }

	[Address(RVA = "0x358B90", Offset = "0x357D90", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B05")]
	protected static string LuaLCheckStringStr(LuaState L, int p) { }

	[Address(RVA = "0x358CC0", Offset = "0x357EC0", Length = "0x54")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "push_onecapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gfind_nodef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "start_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "matchbalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "classend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "capture_to_close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "check_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "end_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AF5")]
	protected static int LuaLError(LuaState luaState, string message, Object[] args) { }

	[Address(RVA = "0x358D20", Offset = "0x357F20", Length = "0x82")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B03")]
	protected static int LuaLOptInt(LuaState L, int pos, int def) { }

	[Address(RVA = "0x358DB0", Offset = "0x357FB0", Length = "0x92")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF0")]
	protected static int LuaLOptInteger(LuaState L, int pos, int def) { }

	[Address(RVA = "0x358E50", Offset = "0x358050", Length = "0x94")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF9")]
	protected static void LuaLPushResult(LuaLBuffer b) { }

	[Address(RVA = "0x358EF0", Offset = "0x3580F0", Length = "0x29")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaTypeExtensions), Member = "ToErrorTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFF")]
	protected static string LuaLTypeName(LuaState L, int p) { }

	[Address(RVA = "0x358F20", Offset = "0x358120", Length = "0xDB")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B01")]
	protected static void LuaPop(LuaState L, int p) { }

	[Address(RVA = "0x359000", Offset = "0x358200", Length = "0x71")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "push_onecapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AE9")]
	protected static void LuaPushInteger(LuaState L, int val) { }

	[Address(RVA = "0x359110", Offset = "0x358310", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF8")]
	protected static void LuaPushLiteral(LuaState L, string literalString) { }

	[Address(RVA = "0x359080", Offset = "0x358280", Length = "0x8F")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "push_onecapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(int), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CharPtr), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFA")]
	protected static void LuaPushLString(LuaState L, CharPtr s, uint len) { }

	[Address(RVA = "0x359180", Offset = "0x358380", Length = "0x97")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFD")]
	protected static void LuaPushNil(LuaState L) { }

	[Address(RVA = "0x359220", Offset = "0x358420", Length = "0x2E")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B08")]
	protected static void LuaPushValue(LuaState L, int arg) { }

	[Address(RVA = "0x359250", Offset = "0x358450", Length = "0x33")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CastToBool", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AEA")]
	protected static int LuaToBoolean(LuaState L, int p) { }

	[Address(RVA = "0x358AA0", Offset = "0x357CA0", Length = "0x7E")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEB")]
	protected static string LuaToLString(LuaState luaState, int p, out uint l) { }

	[Address(RVA = "0x358B90", Offset = "0x357D90", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEC")]
	protected static string LuaToString(LuaState luaState, int p) { }

	[Address(RVA = "0x359290", Offset = "0x358490", Length = "0xD8")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "add_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(LuaLBuffer), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LuaState), Member = "At", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE7")]
	protected static int LuaType(LuaState L, int p) { }

	[Address(RVA = "0x359780", Offset = "0x358980", Length = "0xE2")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B0C")]
	protected static CharPtr memchr(CharPtr ptr, char c, uint count) { }

	[Address(RVA = "0x359950", Offset = "0x358B50", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B0B")]
	protected static int memcmp(CharPtr ptr1, CharPtr ptr2, int size) { }

	[Address(RVA = "0x359870", Offset = "0x358A70", Length = "0xD6")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchState), typeof(CharPtr), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "lmemfind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr), typeof(uint), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B0A")]
	protected static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size) { }

	[Address(RVA = "0x359A30", Offset = "0x358C30", Length = "0x173")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Tools), Member = "sprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CharPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B29")]
	public static void sprintf(CharPtr buffer, CharPtr str, Object[] argv) { }

	[Address(RVA = "0x359BB0", Offset = "0x358DB0", Length = "0xD8")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B25")]
	protected static CharPtr strchr(CharPtr str, char c) { }

	[Address(RVA = "0x359C90", Offset = "0x358E90", Length = "0xC4")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B26")]
	protected static CharPtr strcpy(CharPtr dst, CharPtr src) { }

	[Address(RVA = "0x359D60", Offset = "0x358F60", Length = "0x4C")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "addintlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B28")]
	protected static int strlen(CharPtr str) { }

	[Address(RVA = "0x359DB0", Offset = "0x358FB0", Length = "0xE7")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "scanformat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(CharPtr)}, ReturnType = typeof(CharPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B27")]
	protected static CharPtr strncpy(CharPtr dst, CharPtr src, int length) { }

	[Address(RVA = "0x359EA0", Offset = "0x3590A0", Length = "0x14B")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_find_aux", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B0D")]
	protected static CharPtr strpbrk(CharPtr str, CharPtr charset) { }

	[Address(RVA = "0x359FF0", Offset = "0x3591F0", Length = "0x75")]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "match_class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CultureInfo)}, ReturnType = typeof(char))]
	[Token(Token = "0x6000B21")]
	protected static char tolower(char c) { }

	[Address(RVA = "0x35A070", Offset = "0x359270", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CultureInfo)}, ReturnType = typeof(char))]
	[Token(Token = "0x6000B23")]
	protected static char tolower(int c) { }

	[Address(RVA = "0x35A0F0", Offset = "0x3592F0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CultureInfo)}, ReturnType = typeof(char))]
	[Token(Token = "0x6000B22")]
	protected static char toupper(char c) { }

	[Address(RVA = "0x35A170", Offset = "0x359370", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CultureInfo)}, ReturnType = typeof(char))]
	[Token(Token = "0x6000B24")]
	protected static char toupper(int c) { }

}

