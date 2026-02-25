namespace MoonSharp.Interpreter.REPL;

[Token(Token = "0x20000B2")]
public class ReplHistoryInterpreter : ReplInterpreter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000363")]
	private String[] m_History; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000364")]
	private int m_Last; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000365")]
	private int m_Navi; //Field offset: 0x34

	[Address(RVA = "0x328AC0", Offset = "0x327CC0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007C9")]
	public ReplHistoryInterpreter(Script script, int historySize) { }

	[Address(RVA = "0x328980", Offset = "0x327B80", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReplInterpreter), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CA")]
	public virtual DynValue Evaluate(string input) { }

	[Address(RVA = "0x328A00", Offset = "0x327C00", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CC")]
	public string HistoryNext() { }

	[Address(RVA = "0x328A60", Offset = "0x327C60", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CB")]
	public string HistoryPrev() { }

}

