namespace UnityEngine;

[Token(Token = "0x2000172")]
public sealed class WaitUntil : CustomYieldInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A6")]
	private readonly Func<Boolean> m_Predicate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A7")]
	private readonly Action m_TimeoutCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A8")]
	private readonly WaitTimeoutMode m_TimeoutMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005A9")]
	private readonly double m_MaxExecutionTime; //Field offset: 0x28

	[Token(Token = "0x170001A2")]
	public virtual bool keepWaiting
	{
		[Address(RVA = "0x1979A80", Offset = "0x1978C80", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A73")]
		 get { } //Length: 181
	}

	[Address(RVA = "0x1979A40", Offset = "0x1978C40", Length = "0x3F")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<GetAudioClip>d__39", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A74")]
	public WaitUntil(Func<Boolean> predicate) { }

	[Address(RVA = "0x1979A80", Offset = "0x1978C80", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A73")]
	public virtual bool get_keepWaiting() { }

	[Address(RVA = "0x19799E0", Offset = "0x1978BE0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A75")]
	private double GetTime() { }

}

