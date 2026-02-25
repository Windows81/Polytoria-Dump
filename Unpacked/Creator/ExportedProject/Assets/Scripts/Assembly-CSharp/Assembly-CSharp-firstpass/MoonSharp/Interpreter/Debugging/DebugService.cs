namespace MoonSharp.Interpreter.Debugging;

[Token(Token = "0x2000162")]
public sealed class DebugService : IScriptPrivateResource
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005AB")]
	private Processor m_Processor; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005AC")]
	private Script <OwnerScript>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001B4")]
	public private override Script OwnerScript
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF8")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF9")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x378250", Offset = "0x377450", Length = "0x4E")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF7")]
	internal DebugService(Script script, Processor processor) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF8")]
	public override Script get_OwnerScript() { }

	[Address(RVA = "0x378230", Offset = "0x377430", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Processor), Member = "ResetBreakPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceCode), typeof(System.Collections.Generic.HashSet`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFA")]
	public HashSet<Int32> ResetBreakPoints(SourceCode src, HashSet<Int32> lines) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF9")]
	private void set_OwnerScript(Script value) { }

}

