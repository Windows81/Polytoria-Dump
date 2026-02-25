namespace UnityEngine;

[Token(Token = "0x2000170")]
public class WaitForSecondsRealtime : CustomYieldInstruction
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A1")]
	private float <waitTime>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005A2")]
	private float m_WaitUntilTime; //Field offset: 0x14

	[Token(Token = "0x170001A1")]
	public virtual bool keepWaiting
	{
		[Address(RVA = "0x1979910", Offset = "0x1978B10", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A70")]
		 get { } //Length: 153
	}

	[Token(Token = "0x170001A0")]
	public float waitTime
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A6E")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A6F")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x19798E0", Offset = "0x1978AE0", Length = "0x2F")]
	[CalledBy(Type = "TMPro.TMP_Dropdown+<DelayedDestroyDropdownList>d__90", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField+<MouseDragOutsideRect>d__314", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown+<DelayedDestroyDropdownList>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Authenticators.TimeoutAuthenticator+<BeginAuthentication>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A71")]
	public WaitForSecondsRealtime(float time) { }

	[Address(RVA = "0x1979910", Offset = "0x1978B10", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A70")]
	public virtual bool get_keepWaiting() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A6E")]
	public float get_waitTime() { }

	[Address(RVA = "0x19798D0", Offset = "0x1978AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A72")]
	public virtual void Reset() { }

	[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A6F")]
	public void set_waitTime(float value) { }

}

