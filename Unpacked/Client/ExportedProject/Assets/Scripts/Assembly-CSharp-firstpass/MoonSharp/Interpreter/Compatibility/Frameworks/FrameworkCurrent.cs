namespace MoonSharp.Interpreter.Compatibility.Frameworks;

[Token(Token = "0x200019A")]
internal class FrameworkCurrent : FrameworkClrBase
{

	[Address(RVA = "0x396410", Offset = "0x395610", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F30")]
	public FrameworkCurrent() { }

	[Address(RVA = "0x396430", Offset = "0x395630", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F2F")]
	public virtual Type GetInterface(Type type, string name) { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F2C")]
	public virtual Type GetTypeInfoFromType(Type t) { }

	[Address(RVA = "0x396460", Offset = "0x395660", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "IsDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000F2D")]
	public virtual bool IsDbNull(object o) { }

	[Address(RVA = "0x3964C0", Offset = "0x3956C0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F2E")]
	public virtual bool StringContainsChar(string str, char chr) { }

}

